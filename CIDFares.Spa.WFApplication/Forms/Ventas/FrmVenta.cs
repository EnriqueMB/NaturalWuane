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
using CIDFares.Spa.WFApplication.Session;

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

                //TotalControl.DataBindings.Add("Text", Model, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
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
                Model.NombreCompleto = cliente.NombreCompleto;
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
        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Model.ListaPaqueteCliente.Clear();
                FrmBuscarCliente cliente = new FrmBuscarCliente();
                cliente.ShowDialog();
                if (cliente.cliente.IdCliente != Guid.Empty)
                {
                    btnVerProducto.Visible = false;
                    LlenarCliente(cliente.cliente);
                    await Model.GetAllPaqueteAsync(CurrentSession.IdSucursal);
                    if(Model.ListaPaqueteCliente.Count > 0)
                    {
                        AgregarPaquetesCliente();
                       
                    }
                    
                }

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

        //private DataTable ObtenerTablaPaquete(BindingList<Venta> Lista)
        //{
        //    Model.ListaPaquete.Clear();
        //    Paquetes paquete;
        //    DataTable Tabla = new DataTable();
        //    Tabla.Columns.Add("IdPaquete", typeof(int));
        //    Tabla.Columns.Add("Cantidad", typeof(decimal));
        //    Tabla.Columns.Add("Total", typeof(decimal));
        //    foreach (var item in Lista)
        //    {
        //        if (item.IdTipo == 3)
        //        {
           
        //            paquete = new Paquetes();
        //            paquete.PorcentajePago = 50;
        //            paquete.IdPaquete = item.IdGenerico;
        //            paquete.Nombre = item.Nombre;
        //            paquete.MontoPaquete = item.Total;
        //            paquete.CantidadServicio = (int)item.Cantidad;
        //            paquete.Seleccionar = true;
        //            paquete.PagoMinimo = paquete.MontoPaquete - (paquete.MontoPaquete * (paquete.PorcentajePago / 100));
        //            paquete.Abono = paquete.MontoPaquete;
        //            Model.ListaPaquete.Add(paquete);
        //            Tabla.Rows.Add(new object[] { item.IdGenerico, item.Cantidad, item.Total });
        //        }
        //    }
        //    return Tabla;
        //}

        private void ObtenerLista(BindingList<Venta> Lista)
        {
            Model.ListaPaquete.Clear();
            Paquetes paquete;
            foreach (var item in Lista)
            {
                if (item.IdTipo == 3)
                {

                    paquete = new Paquetes();
                    paquete.PorcentajePago = 50;
                    paquete.IdPaquete = item.IdGenerico;
                    paquete.Nombre = item.Nombre;
                    paquete.MontoPaquete = item.Total;
                    paquete.CantidadServicio = (int)item.Cantidad;
                    paquete.Seleccionar = true;
                    paquete.PagoMinimo = paquete.MontoPaquete - (paquete.MontoPaquete * (paquete.PorcentajePago / 100));
                    paquete.Abono = paquete.MontoPaquete;
                    paquete.PorPagar = paquete.MontoPaquete - paquete.Abono;
                    Model.ListaPaquete.Add(paquete);
                }
            }
            
        }

        #endregion

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            FechaControl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            rbtProducto.Checked = true;
            Model.IdTurno = CurrentSession.IdTurnoEmpleado;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            BindingList<Venta> Lista = (BindingList<Venta>)sfDataGridVenta.DataSource;
            this.CleanErrors(errorProvider1, typeof(VentasViewModel));
            var validationResults = Model.Validate();
            validationResults.ToString();

            if (validationResults.IsValid)
            {
                if (Lista.Count > 0)
                {
                    Model.TablaProducto = ObtenerTablaProducto(Lista);
                    Model.TablaServicio = ObtenerTablaServicio(Lista);
                    ObtenerLista(Lista);
                    if (Model.ListaPaquete.Count > 0)
                    {
                        FrmPaqueteVenta paquete = new FrmPaqueteVenta(Model);
                        paquete.ShowDialog();
                        if (paquete.resultado)
                            LimpiarPropiedades();
                    }
                    else
                    {
                        FrmSeleccionarPago pago = new FrmSeleccionarPago(Model);
                        pago.ShowDialog();
                        if (pago.resultado)
                            LimpiarPropiedades();
                    }
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
                BusquedaControl.Text = "";
                txtCantidad.Text= "";
                TotalControl.Text = "0";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBusquedaProducto Producto = new FrmBusquedaProducto();
                Producto.ShowDialog();
                if (Producto.producto.IdProducto != 0)
                {
                    var item = Producto.producto;
                    decimal cantidadAnterior = BuscarCantidad(item);
                    int cantidadActual = 0;
                    int cantidadBusqueda = 0;
                    cantidadActual = Convert.ToInt32(cantidadAnterior);
                    cantidadBusqueda = cantidadActual + Convert.ToInt32(item.CantidadProducto);
                    var result = await Model.CheckCantidadProducto(item.IdProducto, cantidadBusqueda, CurrentSession.IdSucursal);
                    if (result == -1)
                    {
                        var IdTipo = Producto.IDTipo;
                        LLenarGrid2(Producto.producto, IdTipo);
                    }
                    else if (result != -1)
                        CIDMessageBox.ShowAlert(Messages.SystemName, "No hay suficiente productos. La cantidad existente es: " + result.ToString(), TypeMessage.error);
                    //LLenarGrid(Producto.producto);
                }
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
                                                    Cantidad = Producto.CantidadProducto,
                                                    Nombre = Producto.Nombre,
                                                    Precio = Producto.PrecioPublico-(Producto.PrecioPublico*(Producto.PorcentajeIva / 100)),
                                                    PorcentajeIva = (Producto.PrecioPublico * (Producto.PorcentajeIva / 100)),
                                                    Total = Producto.CantidadProducto * Producto.PrecioPublico,
                                                    SubTotal = Producto.CantidadProducto * Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajeIva / 100))
                    });
                    TotalVenta();
                }
                else
                {
                    var x = Model.Listaventa.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u => {
                        u.Cantidad += Producto.CantidadProducto;
                        u.Precio = Producto.PrecioPublico-(Producto.PrecioPublico*(Producto.PorcentajeIva / 100));
                        u.PorcentajeIva += (Producto.PrecioPublico * (Producto.PorcentajeIva / 100));
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
                            Cantidad = Producto.CantidadProducto,
                            Nombre = Producto.Nombre,
                            Precio = Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajeIva / 100)),
                            PorcentajeIva = (Producto.PrecioPublico * (Producto.PorcentajeIva / 100)),
                            Total = Producto.CantidadProducto * Producto.PrecioPublico,
                            SubTotal = Producto.CantidadProducto * Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajeIva / 100))
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
                Paquetes p = new Paquetes();
                Venta item = (Venta)ObtenerSeleccionado();
                if (item != null)
                {
                   if(item.IdTipo == 4)
                    {
                        p.Nombre = item.Nombre;
                        p.MontoPaquete = item.Precio;
                        //p.Clave = item.clave;
                        Model.ListaPaqueteCliente.Add(p);
                        btnVerProducto.Visible = true;
                    }
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
                Model.Total = total;
                SubtotalControl.Text = SubTotal.ToString("C2");
                IvaControl.Text = Iva.ToString("C2");
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
                FrmBuscarServicio servicio = new FrmBuscarServicio();
                servicio.ShowDialog();
                if (servicio.servicio.IdServicio != 0)
                {
                    int Tipo = 0;
                    Tipo = servicio.IDTipo;
                    LLenarGrid2(servicio.servicio, Tipo);
                }
                    
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        public decimal BuscarCantidad(object objetoX)
        {
            try
            {
                decimal cantidad = 0;
                var Producto = (BusqueProducto)objetoX;
                var x = Model.Listaventa.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u =>
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
        public void LLenarGrid2(object objetoX, int IdTipo)
        {
            try
            {
                if (IdTipo == 1)
                {
                    var Producto = (BusqueProducto)objetoX;
                    if (Model.Listaventa.Count == 0)
                    {
                        Model.Listaventa.Add(new Venta
                        {
                            IdGenerico = Producto.IdProducto,
                            IdTipo = Producto.IdTipo,
                            Cantidad = Producto.CantidadProducto,
                            Nombre = Producto.Nombre,
                            Precio = Producto.Precio - (Producto.Precio * (Producto.PorcentajeIva / 100)),
                            PorcentajeIva = (Producto.Precio * (Producto.PorcentajeIva / 100)),
                            Total = Producto.CantidadProducto * Producto.Precio,
                            SubTotal = Producto.CantidadProducto * Producto.Precio - (Producto.Precio * (Producto.PorcentajeIva / 100))
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.Listaventa.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u => {
                            u.Cantidad += Producto.CantidadProducto;
                            u.Precio = Producto.Precio - (Producto.Precio * (Producto.PorcentajeIva / 100));
                            u.PorcentajeIva += (Producto.Precio * (Producto.PorcentajeIva / 100));
                            u.Total = u.Cantidad * Producto.Precio;
                            u.SubTotal = u.Cantidad * u.Precio; return u;
                        }).ToList();
                        if (x.Count == 1)
                        {
                            this.sfDataGridVenta.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.Listaventa.Add(new Venta
                            {
                                IdGenerico = Producto.IdProducto,
                                IdTipo = Producto.IdTipo,
                                Cantidad = Producto.CantidadProducto,
                                Nombre = Producto.Nombre,
                                Precio = Producto.Precio - (Producto.Precio * (Producto.PorcentajeIva / 100)),
                                PorcentajeIva = (Producto.Precio * (Producto.PorcentajeIva / 100)),
                                Total = Producto.CantidadProducto * Producto.Precio,
                                SubTotal = Producto.CantidadProducto * Producto.Precio - (Producto.Precio * (Producto.PorcentajeIva / 100))
                            });
                            TotalVenta();
                        }                       
                    }
                }
                else if (IdTipo == 2)
                {
                    var x = (Servicio)objetoX;
                    if (Model.Listaventa.Count == 0)
                    {
                        Model.Listaventa.Add(new Venta
                        {
                            IdGenerico = x.IdServicio,
                            IdTipo = x.IdTipoServicio,
                            Cantidad = x.CantidadServicio,
                            Nombre = x.Nombre,
                            Precio = x.Precio - (x.Precio * (x.Porcentaje / 100)),
                            PorcentajeIva = (x.Precio * (x.Porcentaje / 100)),
                            Total = x.CantidadServicio * x.Precio,
                            SubTotal = x.CantidadServicio * x.Precio - (x. Precio * (x.Porcentaje / 100))
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var Lista = Model.Listaventa.Where(p => p.IdGenerico == x.IdServicio && p.IdTipo == x.IdTipoServicio)
                            .Select(u => {
                            u.Cantidad += x.CantidadServicio;
                            u.Precio = x.Precio - (x.Precio * (x.Porcentaje / 100));
                            u.PorcentajeIva += (x.Precio * (x.Porcentaje / 100));
                            u.Total = u.Cantidad * x.Precio;
                            u.SubTotal = u.Cantidad * u.Precio; return u;
                        }).ToList();
                        if (Lista.Count == 1)
                        {
                            this.sfDataGridVenta.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.Listaventa.Add(new Venta
                            {
                                IdGenerico = x.IdServicio,
                                IdTipo = x.IdTipoServicio,
                                Cantidad = x.CantidadServicio,
                                Nombre = x.Nombre,
                                Precio = x.Precio - (x.Precio * (x.Porcentaje / 100)),
                                PorcentajeIva = (x.Precio * (x.Porcentaje / 100)),
                                Total = x.CantidadServicio * x.Precio,
                                SubTotal = x.CantidadServicio * x.Precio - (x.Precio * (x.Porcentaje / 100))
                            });
                            TotalVenta();
                        }
                    }
                }
                else
                if (IdTipo == 3)
                {
                    var paquetes = (Paquetes)objetoX;
                    if (Model.Listaventa.Count == 0)
                    {
                        Model.Listaventa.Add(new Venta
                        {
                            IdGenerico = paquetes.IdPaquete,
                            IdTipo = paquetes.IdTipo,
                            Cantidad = paquetes.CantidadServicio,
                            Nombre = paquetes.Nombre,
                            Precio = paquetes.MontoPaquete,
                            PorcentajeIva = 0,
                            Total = paquetes.CantidadServicio * paquetes.MontoPaquete,
                            SubTotal = paquetes.CantidadServicio * paquetes.MontoPaquete //- (paquetes.MontoPaquete * (paquetes. / 100))
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.Listaventa.Where(p => p.IdGenerico == paquetes.IdPaquete && p.IdTipo == paquetes.IdTipo).Select(u => {
                            u.Cantidad += paquetes.CantidadServicio;
                            u.Precio = paquetes.MontoPaquete; //- (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100));
                            u.PorcentajeIva = 0; //(paquetes. * (paquetes.ProcentajeIva / 100));
                            u.Total = u.Cantidad * paquetes.MontoPaquete;
                            u.SubTotal = u.Cantidad * u.Precio; return u;
                        }).ToList();
                        if (x.Count == 1)
                        {
                            this.sfDataGridVenta.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.Listaventa.Add(new Venta
                            {
                                IdGenerico = paquetes.IdPaquete,
                                IdTipo = paquetes.IdTipo,
                                Cantidad = paquetes.CantidadServicio,
                                Nombre = paquetes.Nombre,
                                Precio = paquetes.MontoPaquete, //- (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100)),
                                PorcentajeIva = 0,// (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100)),
                                Total = paquetes.CantidadServicio * paquetes.MontoPaquete,
                                SubTotal = paquetes.CantidadServicio * paquetes.MontoPaquete// - (paquetes.PrecioPublico * (paquetes.ProcentajeIva / 100))
                            });
                            TotalVenta();
                        }
                    }
                }
                else
                if (IdTipo == 4)
                {
                    var paquetes = (Paquetes)objetoX;
                    if (Model.Listaventa.Count == 0)
                    {
                        Model.Listaventa.Add(new Venta
                        {
                            IdGenerico = paquetes.IdPaquete,
                            IdTipo = paquetes.IdTipo,
                            Cantidad = paquetes.CantidadServicio,
                            Nombre = paquetes.Nombre,
                            Precio = paquetes.MontoPaquete,
                            PorcentajeIva = 0,
                            Total = paquetes.CantidadServicio * paquetes.MontoPaquete,
                            SubTotal = paquetes.CantidadServicio * paquetes.MontoPaquete //- (paquetes.MontoPaquete * (paquetes. / 100))
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.Listaventa.Where(p => p.IdGenerico == paquetes.IdPaquete && p.IdTipo == paquetes.IdTipo).Select(u => {
                            u.Cantidad += paquetes.CantidadServicio;
                            u.Precio = paquetes.MontoPaquete; //- (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100));
                            u.PorcentajeIva = 0; //(paquetes. * (paquetes.ProcentajeIva / 100));
                            u.Total = u.Cantidad * paquetes.MontoPaquete;
                            u.SubTotal = u.Cantidad * u.Precio; return u;
                        }).ToList();
                        if (x.Count == 1)
                        {
                            this.sfDataGridVenta.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.Listaventa.Add(new Venta
                            {
                                IdGenerico = paquetes.IdPaquete,
                                IdTipo = paquetes.IdTipo,
                                Cantidad = paquetes.CantidadServicio,
                                Nombre = paquetes.Nombre,
                                Precio = paquetes.MontoPaquete, //- (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100)),
                                PorcentajeIva = 0,// (paquetes.MontoPaquete * (paquetes.ProcentajeIva / 100)),
                                Total = paquetes.CantidadServicio * paquetes.MontoPaquete,
                                SubTotal = paquetes.CantidadServicio * paquetes.MontoPaquete// - (paquetes.PrecioPublico * (paquetes.ProcentajeIva / 100))
                            });
                            TotalVenta();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            
        }

        private async void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtCantidad, string.Empty);
                errorProvider1.SetError(BusquedaControl, string.Empty);
                int cantidad = 0;
                int.TryParse(txtCantidad.Text, out cantidad);
                if (BusquedaControl.Text != string.Empty)
                {
                    if (cantidad > 0)
                    {
                        if (rbtProducto.Checked == true)
                        {
                            await Model.GetBusquedaRapida(1, BusquedaControl.Text, CurrentSession.IdSucursal);
                            if (Model.ListaBusquedaProducto.Count == 1)
                            {
                                var item = Model.ListaBusquedaProducto.ElementAt(0);
                                item.IdTipo = 1;
                                decimal cantidadAnterior = BuscarCantidad(item);
                                int cantidadActual = 0;
                                int cantidadBusqueda = 0;
                                cantidadActual = Convert.ToInt32(cantidadAnterior);
                                cantidadBusqueda = cantidadActual + cantidad;
                                var result = await Model.CheckCantidadProducto(item.IdProducto, cantidadBusqueda, CurrentSession.IdSucursal);
                                if (result == -1)
                                {
                                    item.CantidadProducto = cantidad;
                                    LLenarGrid2(item, item.IdTipo);
                                }
                                else if(result != -1)
                                    CIDMessageBox.ShowAlert(Messages.SystemName, "No hay suficientes productos. La cantidad existente es: "+result.ToString(), TypeMessage.error);
                            }
                        }
                        else if (rbtServicio.Checked == true)
                        {
                            await Model.GetBusquedaRapida(2, BusquedaControl.Text, CurrentSession.IdSucursal);
                            if (Model.ListaServicio.Count == 1)
                            {
                                var item = Model.ListaServicio.ElementAt(0);
                                item.IdTipoServicio = 2;
                                item.CantidadServicio = 1;
                                LLenarGrid2(item, item.IdTipoServicio);
                            }
                        }
                        else if (rbtPaquete.Checked == true)
                        {
                            await Model.GetBusquedaRapida(3, BusquedaControl.Text, CurrentSession.IdSucursal);
                            if (Model.ListaPaquete.Count == 1)
                            {
                                var item = Model.ListaPaquete.ElementAt(0);
                                item.IdTipo = 3;
                                item.CantidadServicio = 1;
                                LLenarGrid2(item, item.IdTipo);
                            }
                        }
                    }
                    else
                        errorProvider1.SetError(txtCantidad, "Ingrese la cantidad deseada");
                }
                else
                    errorProvider1.SetError(BusquedaControl, "Ingrese la clave o el código de barras");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarPaquete paquete = new FrmBuscarPaquete();
                paquete.ShowDialog();
                if (paquete.paquetes.IdPaquete != 0)
                {
                    int Tipo = 3;
                    Tipo = paquete.IDTipo;
                    LLenarGrid2(paquete.paquetes, Tipo);
                }

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void AgregarPaquetesCliente()
        {
            try
            {
                FrmPaquetesCliente paquetesCliente = new FrmPaquetesCliente(Model.ListaPaqueteCliente, Model.ModelCliente.NombreCompleto);
                paquetesCliente.ShowDialog();
                if (paquetesCliente.paquetes.IdPaquete != 0)
                {
                    int Tipo = 4;
                    Model.ListaPaqueteCliente.Remove(paquetesCliente.paquetes);
                    LLenarGrid2(paquetesCliente.paquetes, Tipo);
                }
                if (Model.ListaPaqueteCliente.Count > 0)
                    btnVerProducto.Visible = true;
                else
                    btnVerProducto.Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPaquetesCliente();
            }
            catch (Exception)
            {

                throw;
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
