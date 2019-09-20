﻿using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmEntradaSalidaAlmacen : Form
    {
        #region propidesades publicas
        public EntradaSalidaAlmacenViewModel Model { get; set; }
        public BusqueProducto producto { get; set; }
        #endregion

        #region combo Tipo

        private class Tipo
        {
            public string Nombre { get; set; }
            public int Id { get; set; }
            public Tipo(string N, int I)
            {
                Nombre = N;
                Id = I;
            }
        }
        #endregion

        #region constructor
        public FrmEntradaSalidaAlmacen()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EntradaSalidaAlmacenViewModel>();
            Model.GetFolio();
        }
        #endregion

        #region Metodos


        private object ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (object)sfDataGrid1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public decimal BuscarCantidad(object objetoX)
        {
            try
            {
                decimal cantidad = 0;
                var Producto = (BusqueProducto)objetoX;
                var x = Model.ListaProducto.Where(p => p.IdProducto == Producto.IdProducto).Select(u =>
                {
                    cantidad = u.Cantidad;
                    return u;
                }).ToList();

                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LLenarGrid(object objetoX)
        {
            try
            {
                var Producto = (BusqueProducto)objetoX;
                if (Model.ListaProducto.Count == 0)
                {
                    Model.ListaProducto.Add(new EntradaSalidaAlmacen
                    {
                        IdProducto = Producto.IdProducto,
                        Clave = Producto.Clave,
                        Cantidad = Convert.ToInt32(Producto.CantidaProducto),
                        Nombre = Producto.Nombre
                    });

                }
                else
                {
                    var x = Model.ListaProducto.Where(p => p.IdProducto == Producto.IdProducto).Select(u => {
                        u.Cantidad += Convert.ToInt32(Producto.CantidaProducto);
                        return u;
                    }).ToList();
                    if (x.Count == 1)
                    {
                        this.sfDataGrid1.Refresh();

                    }
                    else
                    {
                        Model.ListaProducto.Add(new EntradaSalidaAlmacen
                        {
                            IdProducto = Producto.IdProducto,
                            Clave = Producto.Clave,
                            Cantidad = Convert.ToInt32(Producto.CantidaProducto),
                            Nombre = Producto.Nombre
                        });


                    }
                }

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEntradaSalidaAlmacen ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        public void LimpiarPropiedades()
        {
            Model.ListaProducto.Clear();
            Model.Fecha = DateTime.Now;
            Model.Tipo = 2;
            Model.Motivo = string.Empty;
            Model.GetFolio();
        }
        public void IniciarCombos()
        {
            List<Tipo> ListaTipo = new List<Tipo>();
            ListaTipo.Add(new Tipo("SELECCIONE", 2));
            ListaTipo.Add(new Tipo("ENTRADA", 0));
            ListaTipo.Add(new Tipo("SALIDA", 1));

            TipoControl.DataSource = ListaTipo;

            TipoControl.DisplayMember = "Nombre";
            TipoControl.ValueMember = "Id";
        }

        public void IniciarBinding()
        {
            sfDataGrid1.AutoGenerateColumns = false;
            TipoControl.DataBindings.Add("SelectedValue", Model, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            FechaControl.DataBindings.Add("Text", Model, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            sfDataGrid1.DataBindings.Add("DataSource", Model, "ListaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            FolioProductoControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);
            MotivoControl.DataBindings.Add("Text", Model, "Motivo", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos();
        }
        #endregion


        #region Eventos
        private async void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmBusquedaProducto FProducto = new FrmBusquedaProducto();
                FProducto.ShowDialog();
                if (FProducto.producto.IdProducto != 0)
                {
                    var item = FProducto.producto;
                    decimal cantidadAnterior = BuscarCantidad(item);
                    int cantidadActual = 0;
                    int cantidadBusqueda = 0;
                    cantidadActual = Convert.ToInt32(cantidadAnterior);
                    cantidadBusqueda = cantidadActual + Convert.ToInt32(item.CantidaProducto);
                    var result = await Model.CheckCantidadProducto(item.IdProducto, cantidadBusqueda);
                    if (result == -1)
                    {
                        LLenarGrid(FProducto.producto);
                    }
                    else if (result != -1)
                        CIDMessageBox.ShowAlert(Messages.SystemName, "No hay suficiente productos. La cantidad existente es: " + result.ToString(), TypeMessage.error);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEntradaSalidaAlmacen ~ pcMas_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void FrmEntradaSalidaAlmacen_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                LimpiarPropiedades();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntradaSalidaAlmacen item = (EntradaSalidaAlmacen)ObtenerSeleccionado();
                if (item != null)
                {
                    Model.ListaProducto.Remove(item);
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Llenando tablas
        private DataTable ObtenerEntradaProducto(BindingList<EntradaSalidaAlmacen> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(int));
            foreach (var item in Lista)
            {
                if (Model.Tipo == 0)//Entrada
                {
                    Tabla.Rows.Add(new object[] { item.IdProducto, item.Cantidad });
                }
            }
            return Tabla;
        }
        private DataTable ObtenerSalidaProducto(BindingList<EntradaSalidaAlmacen> Lista)
        {
            DataTable Tabla = new DataTable();//Salida
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(int));
            foreach (var item in Lista)
            {
                if (Model.Tipo == 1)
                {
                    Tabla.Rows.Add(new object[] { item.IdProducto, item.Cantidad });
                }
            }
            return Tabla;
        }
        #endregion



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<EntradaSalidaAlmacen> ListaProductos = (BindingList<EntradaSalidaAlmacen>)sfDataGrid1.DataSource;
                this.CleanErrors(errorProvider1, typeof(EntradaSalidaAlmacenViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    if (ListaProductos.Count > 0)
                    {
                        Model.TablaEntradaAlmacen = ObtenerEntradaProducto(ListaProductos);
                        Model.TablaSalidaAlmacen = ObtenerSalidaProducto(ListaProductos);
                        EntradaSalidaAlmacen Resultado = await Model.GuardarEntradaSalida(CurrentSession.IdCuentaUsuario);
                        if (Resultado.Resultado == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                        }
                    }
                    else
                        errorProvider1.SetError(FolioProductoControl, "Seleccione al menos un articulo.");
                }
                else
                    this.ShowErrors(errorProvider1, typeof(EntradaSalidaAlmacenViewModel), validationResults);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




    }
}
