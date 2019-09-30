using CIDFares.Library.Code.Extensions;
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
            dataGridsf1.ShowGroupDropArea = false;
        }
        #endregion

        #region Metodos


        private object ObtenerSeleccionado()
        {
            try
            {
                if (dataGridsf1.SelectedItems.Count == 1)
                {
                    return (object)dataGridsf1.SelectedItem;
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
                        Cantidad = Convert.ToInt32(Producto.CantidadProducto),
                        Nombre = Producto.Nombre,
                        PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                        PorcentajeIva = (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                        Total = Producto.CantidadProducto * Producto.CostoProducto,
                        SubTotal = Producto.CantidadProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100))
                    });
                    CantidadProducto();

                }
                else
                {
                    var x = Model.ListaProducto.Where(p => p.IdProducto == Producto.IdProducto).Select(u => {
                        u.Cantidad += Convert.ToInt32(Producto.CantidadProducto);
                        u.PorcentajeIva += (Producto.CostoProducto * (Producto.PorcentajeIva / 100));
                        u.Total = u.Cantidad * Producto.CostoProducto;
                        u.SubTotal = u.Cantidad * u.PrecioCosto;
                        return u;
                    }).ToList();
                    if (x.Count == 1)
                    {
                        this.dataGridsf1.Refresh();
                        CantidadProducto();

                    }
                    else
                    {
                        Model.ListaProducto.Add(new EntradaSalidaAlmacen
                        {
                            IdProducto = Producto.IdProducto,
                            Clave = Producto.Clave,
                            Cantidad = Convert.ToInt32(Producto.CantidadProducto),
                            Nombre = Producto.Nombre,
                            PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                            PorcentajeIva = (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                            Total = Producto.CantidadProducto * Producto.CostoProducto,
                            SubTotal = Producto.CantidadProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100))
                        });
                        CantidadProducto();

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
            Model.Cantidad = 0;
            Model.Iva = 0;
            Model.SubTotal = 0;
            Model.Total = 0;
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
            dataGridsf1.AutoGenerateColumns = false;
            TipoControl.DataBindings.Add("SelectedValue", Model, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            FechaControl.DataBindings.Add("Text", Model, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            dataGridsf1.DataBindings.Add("DataSource", Model, "ListaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            FolioProductoControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);
            MotivoControl.DataBindings.Add("Text", Model, "Motivo", true, DataSourceUpdateMode.OnPropertyChanged);
            CantidadControl.DataBindings.Add("Text", Model, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
            TotalControl.DataBindings.Add("Text", Model, "Total", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            IvaControl.DataBindings.Add("Text", Model, "Iva", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            SubtotalControl.DataBindings.Add("Text", Model, "Subtotal", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            IniciarCombos();
        }

        public void CantidadProducto()
        {
            try
            {
                int Cantidad = Model.ListaProducto.Sum(x => x.Cantidad);
                decimal total = Model.ListaProducto.Sum(x => x.Total);
                decimal SubTotal = Model.ListaProducto.Sum(x => x.SubTotal);
                decimal Iva = Model.ListaProducto.Sum(x => x.PorcentajeIva);
                TotalControl.Text = total.ToString("C2");
                SubtotalControl.Text = SubTotal.ToString("C2");
                IvaControl.Text = Iva.ToString("C2");
                CantidadControl.Text = Convert.ToString(Cantidad);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async void NuevoProducto()
        {
            try
            {
                errorProvider1.SetError(TipoControl, string.Empty);
                if(Model.Tipo != 2)
                { 
                    FrmBusquedaProducto FProducto = new FrmBusquedaProducto();
                    FProducto.ShowDialog();
                    if (FProducto.producto.IdProducto != 0)
                    {
                        var item = FProducto.producto;
                        if (Model.Tipo == 0)
                        {
                            LLenarGrid(FProducto.producto);
                        }
                        else if (Model.Tipo == 1)
                        {
                            decimal cantidadAnterior = BuscarCantidad(item);
                            int cantidadActual = 0;
                            int cantidadBusqueda = 0;
                            cantidadActual = Convert.ToInt32(cantidadAnterior);
                            cantidadBusqueda = cantidadActual + Convert.ToInt32(item.CantidadProducto);
                            var result = await Model.CheckCantidadProducto(item.IdProducto, cantidadBusqueda);
                            if (result == -1)
                            {
                                LLenarGrid(FProducto.producto);
                            }
                            else if (result != -1)
                                CIDMessageBox.ShowAlert(Messages.SystemName, "No hay suficiente productos. La cantidad existente es: " + result.ToString(), TypeMessage.error);
                        }
                    }
                    
                }
                else if (Model.Tipo == 2)
                {
                    errorProvider1.SetError(TipoControl, "Debe seleccionar un tipo");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEntradaSalidaAlmacen ~ pcMas_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        #endregion


        #region Eventos
        private  void btnNuevo_Click_1(object sender, EventArgs e)
        { 
            try
            {
                NuevoProducto();
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
                    CantidadProducto();
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
        private DataTable ObtenerEntradaSalidaProducto(BindingList<EntradaSalidaAlmacen> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(int));
            foreach (var item in Lista)
            {  
                    Tabla.Rows.Add(new object[] { item.IdProducto, item.Cantidad });     
            }
            return Tabla;
        }
    
        #endregion



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                BindingList<EntradaSalidaAlmacen> ListaProductos = (BindingList<EntradaSalidaAlmacen>)dataGridsf1.DataSource;
                this.CleanErrors(errorProvider1, typeof(EntradaSalidaAlmacenViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    if (ListaProductos.Count > 0)
                    {
                        Model.TablaEntradaAlmacen = ObtenerEntradaSalidaProducto(ListaProductos);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInventarioTest f = new FrmInventarioTest();
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void TipoControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var X = Model.Tipo;
            var Y = Model.Cantidad;
            if (X==1 && Y!=0)
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.HaveProduct) == DialogResult.OK )
                Model.ListaProducto.Clear();
                CantidadProducto();
            }
        }
    }
}
