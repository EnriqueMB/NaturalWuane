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
                ClaveProveedorControl.DataBindings.Add("Text", ModelCompra, "ClaveProveedor", true, DataSourceUpdateMode.OnPropertyChanged);
                TotalControl.DataBindings.Add("Text", ModelCompra, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
                IvaControl.DataBindings.Add("Text", ModelCompra, "Iva", true, DataSourceUpdateMode.OnPropertyChanged);
                SubtotalControl.DataBindings.Add("Text", ModelCompra, "Subtotal", true, DataSourceUpdateMode.OnPropertyChanged);
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
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            FechaControl.Text = DateTime.Now.ToString("dd/mm/yyyy");
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
                        IdCompraProducto = Producto.IdProducto,
                        Cantidad = Producto.CantidaProducto,
                        Nombre = Producto.Nombre,
                        PrecioCosto = Producto.CostoProducto,
                        PorcentajeIva = (Producto.CostoProducto * (Producto.ProcentajeIva / 100)),
                        Total = Producto.CantidaProducto * Producto.CostoProducto,
                        SubTotal = Producto.CantidaProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.ProcentajeIva / 100))
                    });
                    TotalCompra();
                }
                else
                {
                    var x = ModelCompra.ListaCompra.Where(p => p.IdCompraProducto == Producto.IdProducto).Select(u => {
                        u.Cantidad += Producto.CantidaProducto;
                        u.PrecioCosto = Producto.CostoProducto;
                        u.PorcentajeIva += (Producto.CostoProducto * (Producto.ProcentajeIva / 100));
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
                            IdCompraProducto = Producto.IdProducto,
                            Cantidad = Producto.CantidaProducto,
                            Nombre = Producto.Nombre,
                            PrecioCosto = Producto.CostoProducto,
                            PorcentajeIva = (Producto.CostoProducto * (Producto.ProcentajeIva / 100)),
                            Total = Producto.CantidaProducto * Producto.CostoProducto,
                            SubTotal = Producto.CantidaProducto * Producto.CostoProducto - (Producto.CostoProducto * (Producto.ProcentajeIva / 100))
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
                    }
                }
                else
                    errorProvider1.SetError(FolioCompraControl, "Seleccione al menos un articulo.");
            }
            else
                this.ShowErrors(errorProvider1, typeof(ComprasViewModel), validationResults);
        }

        private DataTable ObtenerTablaProducto(BindingList<Compra> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                    Tabla.Rows.Add(new object[] {item.IdCompraProducto, item.Cantidad, item.Total });
 
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
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmOutMessage) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
