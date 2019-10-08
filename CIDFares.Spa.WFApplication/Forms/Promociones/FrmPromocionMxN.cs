using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Promociones;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Promociones
{
    public partial class FrmPromocionMxN : Form
    {
        public PromocionViewModel Model { get; set; }
        public bool EsSiguiente { get; set; }
        public FrmPromocionMxN(PromocionViewModel model)
        {
            InitializeComponent();
            Model = model;
            EsSiguiente = false;
            this.IniciarBinding();
            Model.EsPromocionMxN = true;
            Model.EsPromocionNxN = false;
            Model.EsDescuento = false;
        }

        private void IniciarBinding()
        {
            try
            {
                CantidadControl.DataBindings.Add("Text", Model, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreProductoControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                

                this.GridPS.AutoGenerateColumns = false;
                GridPS.DataBindings.Add("DataSource", Model, "ListaPromocionMxN", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPromocionMxN_Load(object sender, EventArgs e)
        {
            try
            {
                GridPS.Style.HeaderStyle.Borders.All = new GridBorder(GridBorderStyle.None);
                this.GridPS.Style.CellStyle.Borders.All = new GridBorder(GridBorderStyle.None);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocionMxN ~ FrmPromocionMxN_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                    FrmBusquedaProducto buscar = new FrmBusquedaProducto();
                    buscar.ShowDialog();
                if (buscar.producto.IdProducto != 0)
                    AgregarProducto(buscar.producto);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocionMxN ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void AgregarProducto(BusqueProducto producto)
        {
            try
            {
                PromocionMxN item = new PromocionMxN();
                item.Nombre = producto.Nombre;
                item.IDGenerico = producto.IdProducto;
                item.CantidadGratis = (int)producto.CantidadProducto;
                item.IdTipo = producto.IdTipo;

                var x = Model.ListaPromocionMxN.Where(p => p.IDGenerico == producto.IdProducto).Select(u => {
                    u.CantidadGratis += (int)producto.CantidadProducto; return u;
                }).ToList();
                if (x.Count == 1)
                {
                    this.GridPS.Refresh();
                }
                else
                    Model.ListaPromocionMxN.Add(item);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void AgregarServicio(Servicio servicio)
        {
            try
            {
                PromocionMxN item = new PromocionMxN();
                item.Nombre = servicio.Nombre;
                item.IDGenerico = servicio.IdServicio;
                item.CantidadGratis = (int)servicio.CantidadServicio;
                item.IdTipo = servicio.IdTipoServicio;

                var x = Model.ListaPromocionMxN.Where(p => p.IDGenerico == servicio.IdServicio).Select(u =>
                {
                    u.CantidadGratis += (int)servicio.CantidadServicio; return u;
                }).ToList();
                if (x.Count == 1)
                {
                    this.GridPS.Refresh();
                }
                else
                    Model.ListaPromocionMxN.Add(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarServicio buscar = new FrmBuscarServicio();
                buscar.ShowDialog();
                if(buscar.servicio.IdServicio != 0)
                AgregarServicio(buscar.servicio);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocionMxN ~ btnServicio_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private object ObtenerSeleccionado()
        {
            try
            {
                if (GridPS.SelectedItems.Count == 1)
                {
                    return (object)GridPS.SelectedItem;
                }
                return null;
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
                PromocionMxN item = (PromocionMxN)ObtenerSeleccionado();
                if (item != null)
                {
                    Model.ListaPromocionMxN.Remove(item);
                } 
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocionMxN ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = String.Empty;
                Model.IdGenerico = 0;
                Model.EsProducto = true;
                Model.Cantidad = 0;
                Model.CantidadGratis = 0;
                Model.ListaPromocionMxN.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private DataTable ObtenerTablaProducto(BindingList<PromocionMxN> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.IdTipo == 1)
                {
                    Tabla.Rows.Add(new object[] { item.IDGenerico, item.CantidadGratis, 0});
                }
            }
            return Tabla;
        }

        private DataTable ObtenerTablaServicio(BindingList<PromocionMxN> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdServicio", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.IdTipo == 2)
                {
                    Tabla.Rows.Add(new object[] { item.IDGenerico, item.CantidadGratis,0});
                }
            }
            return Tabla;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                this.CleanErrors(errorProvider1, typeof(PromocionViewModel));
                if (String.IsNullOrEmpty(Model.Nombre))
                    errorProvider1.SetError(btnAgregar, "Selecione un producto o servicio");
                else
                {
                    if (String.IsNullOrEmpty(Model.NombrePromocion))
                        errorProvider1.SetError(btnAgregar, "Ingrese un nombre de la promoción");
                    else
                    {
                        var validationResults = Model.Validate();
                        validationResults.ToString();
                        if (validationResults.IsValid)
                        {
                    BindingList<PromocionMxN> ListaPromocionMxN = (BindingList<PromocionMxN>)GridPS.DataSource;
                    if (ListaPromocionMxN.Count > 0)
                    {
                        Model.TablaProducto = ObtenerTablaProducto(ListaPromocionMxN);
                        Model.TablaServicio = ObtenerTablaServicio(ListaPromocionMxN);
                        FrmPromocionDias promocionDias = new FrmPromocionDias(Model);
                        promocionDias.ShowDialog();
                        if (promocionDias.Resultado == 1)
                        {
                            this.Close();
                            Model.Resultado = 1;
                            LimpiarPropiedades();
                        }
                    }
                    else
                        errorProvider1.SetError(btnAgregar, "Seleccione al menos un articulo.");
                        }
                        else
                            this.ShowErrors(errorProvider1, typeof(PromocionViewModel), validationResults);
                    }
                }

            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocionMxN ~ btnAgregar_Click_1(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
