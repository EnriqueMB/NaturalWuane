using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.Compras;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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
                FrmProveedorACompra producto = new FrmProveedorACompra();
                producto.ShowDialog();
                //var x = await Model.Proveedor(Model.IdProveedorTemp);
                this.Np.Text = producto.Model.NombreProveedor;
                this.lblRepresentante.Text = producto.Model.Representante;
                this.lblTelefono.Text = producto.Model.Telefono;
                this.lblDireccion.Text = producto.Model.Direccion;

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ bntnAgregarProvedor_Click(object sender, EventArgs e)");
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
                    var x = ModelCompra.ListaCompra.Where(p => p.IdCompra == Producto.IdProducto).Select(u => {
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
                            IdCompra = Producto.IdProducto,
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
    }
}
