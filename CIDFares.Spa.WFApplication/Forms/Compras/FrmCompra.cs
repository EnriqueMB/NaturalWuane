using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.Compras;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    public partial class FrmCompra : Form
    {
        #region propiedades públicas
        public ComprasViewModel ModelCompra { get; set; }
        public int TipoF { get; set; }
        #endregion

        public FrmCompra()
        {
            try
            {
                InitializeComponent();
                ModelCompra = ServiceLocator.Instance.Resolve<ComprasViewModel>();
                IniciarBinding();              
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        private void IniciarBinding()
        {
            try
            {
                FechaControl.DataBindings.Add("Text", ModelCompra, "FechaCompra", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy");
                ClaveProveedorControl.DataBindings.Add("Text", ModelCompra, "ClaveProveedor", true, DataSourceUpdateMode.OnPropertyChanged);
                TotalControl.DataBindings.Add("Text", ModelCompra, "Total", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
                IvaControl.DataBindings.Add("Text", ModelCompra, "Iva", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
                SubtotalControl.DataBindings.Add("Text", ModelCompra, "Subtotal", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
                FolioCompraControl.DataBindings.Add("Text", ModelCompra, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);
                this.sfDataGrid1.AutoGenerateColumns = false;
                sfDataGrid1.DataBindings.Add("DataSource", ModelCompra, "ListaCompra", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        private  void bntnAgregarProvedor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProveedorACompra proveedor = new FrmProveedorACompra();
                proveedor.ShowDialog();
                if (proveedor.proveedor.IdProveedor != Guid.Empty)
                    LlenarProveedor(proveedor.proveedor);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private async void FrmCompra_Load(object sender, EventArgs e)
        {
            try
            {
                FechaControl.Text = DateTime.Now.ToString("dd/mm/yyyy");
                await ModelCompra.GetFolio();
                MetodosBtn();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ FrmCompra_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        public void MetodosBtn()
        {
            if (this.TipoF == 0) // Inicia el formulario
            {
                this.bntnAgregarProvedor.Visible = false;
                this.btnProducto.Visible = false;
                this.btnEliminar.Visible = false;
                this.BtnAgregar.Visible = false;
                this.btnNuevo.Visible = true;
                this.btnModificar.Visible = true;
                this.BtnCancelarCompra.Visible = true;
            }
            else if (this.TipoF == 1)// Seleccionar btn Nuevo
            {
                this.btnNuevo.Visible = false;
                this.btnModificar.Visible = false;
                this.BtnCancelarCompra.Visible = false;
                this.bntnAgregarProvedor.Visible = true;
                this.btnProducto.Visible = true;
                this.btnEliminar.Visible = true;
                this.BtnAgregar.Visible = true;
            }
            else if (this.TipoF == 2)// Seleccionar btn Modificar 
            {
                this.btnNuevo.Visible = false;
                this.btnModificar.Visible = false;
                this.BtnCancelarCompra.Visible = false;
                this.bntnAgregarProvedor.Visible = true;
                this.btnProducto.Visible = true;
                this.btnEliminar.Visible = true;
                this.BtnAgregar.Visible = true;
            }
            else if (this.TipoF == 3)// Seleccionar btn Cancelar Compra
            {
                this.btnNuevo.Visible = false;
                this.btnModificar.Visible = false;
                this.BtnCancelarCompra.Visible = false;
                this.bntnAgregarProvedor.Visible = false;
                this.btnProducto.Visible = false;
                this.btnEliminar.Visible = false;
                this.BtnAgregar.Visible = true;
            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProductoCompra Producto = new FrmProductoCompra();
                Producto.ShowDialog();
                if (Producto.producto.IdProducto != 0)
                {
                    LLenarGridCompra(Producto.producto);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void LlenarProveedor(ProveedorACompra proveedor)
        {
            try
            {
                ModelCompra.IdProveedor = proveedor.IdProveedor;
                this.ClaveProveedorControl.Text = proveedor.Clave;
                this.Np.Text = proveedor.NombreComercial;
                this.lblRepresentanteControl.Text = proveedor.Representante;
                this.lblTelefonoControl.Text = proveedor.Telefono;
                this.lblDireccionControl.Text = proveedor.Direccion;               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LLenarGridCompra(object objetoX)
        {
            try
            {                
               var Producto = (BusqueProducto)objetoX;
                if (ModelCompra.ListaCompra.Count == 0)
                {
                    ModelCompra.ListaCompra.Add(new Compra
                    {
                        IdProducto = Producto.IdProducto,
                        Cantidad = Producto.CantidadProducto,
                        Nombre = Producto.Nombre,
                        PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                        PorcentajeIva = (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                        Total = Producto.CantidadProducto * Producto.CostoProducto,
                        SubTotal = Producto.CantidadProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100))
                    });
                    TotalCompra();
                }
                else
                {
                    var x = ModelCompra.ListaCompra.Where(p => p.IdProducto == Producto.IdProducto).Select(u => {
                        u.Cantidad += Producto.CantidadProducto;
                       // u.PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100));
                        u.PorcentajeIva += (Producto.CostoProducto * (Producto.PorcentajeIva / 100));
                        u.Total = u.Cantidad * Producto.CostoProducto;
                        u.SubTotal = u.Cantidad * u.PrecioCosto; return u;
                    }).ToList();
                    if (x.Count == 1)
                    {
                        this.sfDataGrid1.Refresh();
                        TotalCompra();
                    }
                    else
                    {
                        ModelCompra.ListaCompra.Add(new Compra
                        {
                            IdProducto = Producto.IdProducto,
                            Cantidad = Producto.CantidadProducto,
                            Nombre = Producto.Nombre,
                            PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                            PorcentajeIva = (Producto.CostoProducto * (Producto.PorcentajeIva / 100)),
                            Total = Producto.CantidadProducto * Producto.CostoProducto,
                            SubTotal = Producto.CantidadProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100))
                        });
                        TotalCompra();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }            
        }
        public void TotalCompra()
        {
            try
            {
                decimal total = ModelCompra.ListaCompra.Sum(x => x.Total);
                decimal SubTotal = ModelCompra.ListaCompra.Sum(x => x.SubTotal);
                decimal Iva = ModelCompra.ListaCompra.Sum(x => x.PorcentajeIva);
                TotalControl.Text = total.ToString("C2");
                SubtotalControl.Text = SubTotal.ToString("C2");
                IvaControl.Text = Iva.ToString("C2");
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
                Compra item = (Compra)ObtenerSeleccionado();
                if (item != null)
                {
                    ModelCompra.ListaCompra.Remove(item);
                    TotalCompra();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (this.TipoF == 1) //Agregar una nueva compra
            {
                BindingList<Compra> ListaProductos = (BindingList<Compra>)sfDataGrid1.DataSource;
                this.CleanErrors(errorProvider1, typeof(ComprasViewModel));
                var validationResults = ModelCompra.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    if (ListaProductos.Count > 0)
                    {
                        ModelCompra.TablaProducto = ObtenerTablaProducto(ListaProductos);

                        Compra Resultado = await ModelCompra.GuardarVenta(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                        if (Resultado.Resultado == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                            this.TipoF = 0;
                            this.MetodosBtn();
                        }
                    }
                    else
                        errorProvider1.SetError(FolioCompraControl, "Seleccione al menos un articulo.");
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ComprasViewModel), validationResults);
            }
            else if (this.TipoF == 2) //Modificacion de compra 
            {

            }
            else if (this.TipoF == 3) //Cancelacion de compra
            {
                try
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, "ESTA SEGURO QUE DESEA CANCELAR LA COMPRA") == DialogResult.OK)
                    {
                        FrmCancelacionCompra frmCancelacionCompra = new FrmCancelacionCompra();
                        frmCancelacionCompra.ShowDialog();
                        if (!string.IsNullOrEmpty(frmCancelacionCompra.Motivo))
                        {
                            int Resultado = await ModelCompra.GuardaCancelacionCompra(frmCancelacionCompra.Motivo, CurrentSession.IdSucursal, CurrentSession.IdCuentaUsuario);
                            if (Resultado == 1)
                            {
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                                LimpiarPropiedades();
                                this.TipoF = 0;
                                this.MetodosBtn();
                            }
                            else
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                        }
                        else
                        {
                            LimpiarPropiedades();
                            this.TipoF = 0;
                            this.MetodosBtn();
                        }
                    }
                    else
                    {
                        LimpiarPropiedades();
                        this.TipoF = 0;
                        this.MetodosBtn();
                    }
                }
                catch (Exception ex)
                {
                    ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ btnCancelar_Click(object sender, EventArgs e)");
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
            }
        }
        private DataTable ObtenerTablaProducto(BindingList<Compra> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                Tabla.Rows.Add(new object[] {item.IdProducto, item.Cantidad, item.Total }); 
            }
            return Tabla;
        }
        private void LimpiarPropiedades()
        {
            try
            {
                ModelCompra.IdProveedor = Guid.Empty;
                ModelCompra.Iva = 0;
                ModelCompra.SubTotal = 0;
                ModelCompra.Total = 0;
                ModelCompra.TablaProducto = new DataTable();

                ModelCompra.ListaCompra.Clear();
                ModelCompra.GetFolio();
                ClaveProveedorControl.Text = "";
                Np.Text = "";
                lblRepresentanteControl.Text = "";
                lblTelefonoControl.Text = "";
                lblDireccionControl.Text = "";
                FechaControl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                this.TipoF = 3;
                this.BuscarCompra();                
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ BtnCancelarCompra_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void BuscarCompra()
        {
            FrmBuscarCompras frmBuscarCompras = new FrmBuscarCompras();
            frmBuscarCompras.ShowDialog();
            if (frmBuscarCompras.Model.IdCompra != Guid.Empty)
            {
                MetodosBtn();
                ModelCompra.IdCompra = frmBuscarCompras.Model.IdCompra;                
                ModelCompra.GetDetalle();
                ModelCompra.IdProveedor = ModelCompra.IdProveedor;
                this.ClaveProveedorControl.Text = ModelCompra.ModelProveedor.Clave;
                this.Np.Text = ModelCompra.ModelProveedor.NombreComercial;
                this.lblRepresentanteControl.Text = ModelCompra.ModelProveedor.Representante;
                this.lblTelefonoControl.Text = ModelCompra.ModelProveedor.Telefono;
                this.lblDireccionControl.Text = ModelCompra.ModelProveedor.Direccion;
                foreach (var item in ModelCompra.ListaCompra)
                {
                    BusqueProducto BP = new BusqueProducto();
                    BP.IdProducto = item.IdProducto;
                    BP.Nombre = item.Nombre;
                    BP.PorcentajeIva = item.PorcentajeIva;
                    BP.CostoProducto = item.PrecioCosto;
                    BP.CantidadProducto = item.Cantidad;
                    LlenarDatos(BP);
                }
            }
        }

        private void LlenarDatos(object Datos)
        {
            try
            {

            var Producto = (BusqueProducto)Datos;
                var x = ModelCompra.ListaCompra.Where(p => p.IdProducto == Producto.IdProducto).Select(u => {
                    //u.Cantidad += Producto.CantidadProducto;
                    //Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajeIva / 100));
                    u.PrecioCosto = Producto.CostoProducto - (Producto.CostoProducto * (Producto.PorcentajeIva / 100));
                    u.PorcentajeIva = (Producto.CostoProducto * (Producto.PorcentajeIva / 100));
                    u.Total = u.Cantidad * Producto.CostoProducto;
                    u.SubTotal = u.Cantidad * u.PrecioCosto; return u;
                }).ToList();
                if (x.Count == 1)
                {
                    this.sfDataGrid1.Refresh();
                    //TotalCompra();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ LlenarDatos(object Datos)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.TipoF = 1;
                MetodosBtn();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ BtnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.TipoF = 2;
                this.BuscarCompra();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ BtnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}
