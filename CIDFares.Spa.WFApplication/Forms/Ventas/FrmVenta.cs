using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmVenta : Form
    {
        #region propiedades públicas
        public VentasViewModel Model { get; set; }
        #endregion

        #region propiedades privadas
        private Cliente cliente = new Cliente();
        #endregion

        #region Constructor
        public FrmVenta()
        {
            try
            {
                InitializeComponent();
                Model = ServiceLocator.Instance.Resolve<VentasViewModel>();
                IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos
        private void IniciarBinding()
        {
            try
            {
                FolioClienteControl.DataBindings.Add("Text", Model, "FolioCliente", true, DataSourceUpdateMode.OnPropertyChanged);

                TotalControl.DataBindings.Add("Text", Model, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
                IvaControl.DataBindings.Add("Text", Model, "Iva", true, DataSourceUpdateMode.OnPropertyChanged);
                SubtotalControl.DataBindings.Add("Text", Model, "Subtotal", true, DataSourceUpdateMode.OnPropertyChanged);
                FolioVentaControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);

                this.sfDataGridVenta.AutoGenerateColumns = false;
                sfDataGridVenta.DataBindings.Add("DataSource", Model, "Listaventa", true, DataSourceUpdateMode.OnPropertyChanged);
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
                if (sfDataGridVenta.SelectedItems.Count == 1)
                {
                    return (object)sfDataGridVenta.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void LlenarCliente(Cliente cliente)
        {
            try
            {
                Model.IdCliente = cliente.IdCliente;
                NombreControl.Text = cliente.NombreCompleto;
                TelefonoControl.Text = cliente.Telefono;
                DireccionControl.Text = cliente.Direccion;
                FolioClienteControl.Text = cliente.Clave;
                await Model.ModelCliente.GetFoto(cliente.IdCliente);
                if (!string.IsNullOrEmpty(Model.ModelCliente.FotoBase64))
                {
                    FotoControl.Image = ComprimirImagenExtensions.ImageBase64ToImage(Model.ModelCliente.FotoBase64);
                }
                else
                    FotoControl.Image = Properties.Resources.imagen_subir;
                Model.ModelCliente.FotoBase64 = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarCliente cliente = new FrmBuscarCliente();
                cliente.ShowDialog();
                if (cliente.cliente.IdCliente != Guid.Empty)
                    LlenarCliente(cliente.cliente);
            }
            catch(Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private DataTable ObtenerTablaProducto(BindingList<Venta> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdProducto", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.IdTipo == 1)
                {
                    Tabla.Rows.Add(new object[] { item.IdGenerico, item.Cantidad, item.Total });
                }
            }
            return Tabla;
        }

        private DataTable ObtenerTablaServicio(BindingList<Venta> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdServicio", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.IdTipo == 2)
                {
                    Tabla.Rows.Add(new object[] { item.IdGenerico, item.Cantidad, item.Total });
                }
            }
            return Tabla;
        }

        #endregion

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            FechaControl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            BindingList<Venta> ListaProductos = (BindingList<Venta>)sfDataGridVenta.DataSource;
            this.CleanErrors(errorProvider1, typeof(VentasViewModel));
            var validationResults = Model.Validate();
            validationResults.ToString();

            if (validationResults.IsValid)
            {
                if (ListaProductos.Count > 0)
                {
                    Model.TablaProducto = ObtenerTablaProducto(ListaProductos);
                    Model.TablaServicio = ObtenerTablaServicio(ListaProductos);
                    FrmSeleccionarPago pago = new FrmSeleccionarPago(Model);
                    pago.ShowDialog();
                    if (pago.resultado)
                        LimpiarPropiedades();
                }
                else
                    errorProvider1.SetError(FolioVentaControl, "Seleccione al menos un articulo.");
            }
            else
                    this.ShowErrors(errorProvider1, typeof(VentasViewModel), validationResults);
    }

        private void LimpiarPropiedades()
        {
            try
            {
                Model.IdCliente = Guid.Empty;
                Model.Iva = 0;
                Model.SubTotal = 0;
                Model.Total = 0;
                Model.TablaFormaPago = new DataTable();
                Model.TablaProducto = new DataTable();
                Model.TablaServicio = new DataTable();
                Model.Listaventa.Clear();
                Model.Efectivo = 0;
                Model.GetFolio();
                NombreControl.Text = "";
                TelefonoControl.Text = "";
                DireccionControl.Text = "";
                FolioClienteControl.Text = "";
                FechaControl.Text = DateTime.Now.ToString("dd/MM/yyyy");
                FotoControl.Image = Properties.Resources.imagen_subir;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBusquedaProducto Producto = new FrmBusquedaProducto();
                Producto.ShowDialog();
                if (Producto.producto.IdProducto != 0)
                    LLenarGrid(Producto.producto);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        public void LLenarGrid(BusqueProducto Producto)
        {
            try
            {
                if (Model.Listaventa.Count == 0)
                {
                    Model.Listaventa.Add(new Venta { IdGenerico = Producto.IdProducto,
                                                    IdTipo = Producto.IdTipo,
                                                    Cantidad = Producto.CantidaProducto,
                                                    Nombre = Producto.Nombre,
                                                    Precio = Producto.PrecioPublico-(Producto.PrecioPublico*(Producto.ProcentajeIva/100)),
                                                    PorcentajeIva = (Producto.PrecioPublico * (Producto.ProcentajeIva / 100)),
                                                    Total = Producto.CantidaProducto * Producto.PrecioPublico,
                                                    SubTotal = Producto.CantidaProducto * Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.ProcentajeIva / 100))
                    });
                    TotalVenta();
                }
                else
                {
                    var x = Model.Listaventa.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u => {
                        u.Cantidad += Producto.CantidaProducto;
                        u.Precio = Producto.PrecioPublico-(Producto.PrecioPublico*(Producto.ProcentajeIva/100));
                        u.PorcentajeIva += (Producto.PrecioPublico * (Producto.ProcentajeIva / 100));
                        u.Total = u.Cantidad * Producto.PrecioPublico ;
                        u.SubTotal = u.Cantidad * u.Precio; return u; }).ToList();
                    if (x.Count == 1)
                    {
                        this.sfDataGridVenta.Refresh();
                        TotalVenta();
                    }
                    else
                    {
                        Model.Listaventa.Add(new Venta {
                            IdGenerico = Producto.IdProducto,
                            IdTipo = Producto.IdTipo,
                            Cantidad = Producto.CantidaProducto,
                            Nombre = Producto.Nombre,
                            Precio = Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.ProcentajeIva / 100)),
                            PorcentajeIva = (Producto.PrecioPublico * (Producto.ProcentajeIva / 100)),
                            Total = Producto.CantidaProducto * Producto.PrecioPublico,
                            SubTotal = Producto.CantidaProducto * Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.ProcentajeIva / 100))
                        });
                        TotalVenta();
                    }
                    //Venta product = Model.Listaventa.SingleOrDefault(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo);
                    //if (product != null)
                    //{
                    //    foreach (var item in Model.Listaventa)
                    //    {
                    //        if (item.IdGenerico == Producto.IdProducto && item.IdTipo == Producto.IdTipo)
                    //        {
                    //            item.Cantidad = item.Cantidad + Producto.CantidaProducto;
                    //            item.Total = item.Precio * item.Cantidad;
                    //            this.sfDataGridVenta.Refresh();
                    //            TotalVenta();
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    Model.Listaventa.Add(new Venta { IdGenerico = Producto.IdProducto, IdTipo = Producto.IdTipo, Cantidad = Producto.CantidaProducto, Nombre = Producto.Nombre, Precio = Producto.PrecioPublico, Total = Producto.CantidaProducto * Producto.PrecioPublico });
                    //    TotalVenta();
                    //}
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta item = (Venta)ObtenerSeleccionado();
                if (item != null)
                {
                   Model.Listaventa.Remove(item);
                   TotalVenta();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TotalVenta()
        {
            try
            {
                decimal total = Model.Listaventa.Sum(x => x.Total);
                decimal SubTotal = Model.Listaventa.Sum(x => x.SubTotal);
                decimal Iva = Model.Listaventa.Sum(x => x.PorcentajeIva);
                TotalControl.Text = total.ToString("C2");
                SubtotalControl.Text = SubTotal.ToString("C2");
                IvaControl.Text = Iva.ToString("C2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //CALCULO DE EL IEPS
        //public decimal DesglosaIeps(out decimal PrecioSinIvaSinIeps)
        //{
        //    decimal PrecioSinIva = Precio / (1 + PorcentajeIva / 100);
        //    decimal MontoIeps = 0m;
        //    PrecioSinIvaSinIeps = 0m;
        //    if (EsMontoIeps)
        //    {
        //        MontoIeps = Ieps;
        //        PrecioSinIvaSinIeps = Math.Round(PrecioSinIva - MontoIeps, 2);
        //    }
        //    else
        //    {
        //        PrecioSinIvaSinIeps = Math.Round(PrecioSinIva / (1 + Ieps / 100), 2);
        //        MontoIeps = Math.Round(PrecioSinIvaSinIeps * Ieps / 100, 2);
        //    }
        //    return MontoIeps;
        //}
        //FIN DEL METODO DE IEPS
    }
}
