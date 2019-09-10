using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDDataGridsf;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Session;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmPaqueteNuevo : Form
    {
        #region Propiedades publicas 
        public PaqueteViewModel Model { get; set; }
        private Servicio infoServicio { get; set; }
        private Producto InfoProducto { get; set; }
        #endregion

        #region Constructor

        public FrmPaqueteNuevo()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Model.State = EntityState.Create;
        }

        public FrmPaqueteNuevo(Paquetes paquete)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Model.IdPaquete = paquete.IdPaquete;
            Model.Clave = paquete.Clave;
            Model.Descripcion = paquete.Descripcion;
            Model.FechaVencimiento = paquete.FechaVencimiento;
            Model.NPersonal = paquete.NPersona;
            Model.NPago = paquete.NPago;
            Model.MontoPaquete = paquete.MontoPaquete;
            Model.Nombre = paquete.Nombre;
            Model.State = EntityState.Update;
            lblPaquete.Text = "MODIFICACIÓN DEL PAQUETE CON CLAVE: " + Model.Clave;
        }

        #endregion

        #region Eventos
        private async void FrmPaqueteNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                if (Model.IdPaquete != 0)
                {
                    await Model.ListaDetalle();
                    TotalVenta();
                }
                else
                {
                    LimpiarPropiedades();
                }               
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ FrmPaqueteNuevo_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBusquedaProducto Producto = new FrmBusquedaProducto();
                Producto.ShowDialog();
                if (Producto.producto.IdProducto != 0)
                {
                    var IdTipo = Producto.IDTipo;
                    //  LLenarGrid2(Producto.producto, IdTipo);
                    LLenarGrid(Producto.producto, IdTipo);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnAgregarProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarServicio frmBuscarServicio = new FrmBuscarServicio();
                frmBuscarServicio.ShowDialog();
                if (frmBuscarServicio.servicio.IdServicio != 0)
                {
                    var IdTipo = frmBuscarServicio.IDTipo;
                    LLenarGrid(frmBuscarServicio.servicio, IdTipo);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnAgregarServicio_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (PaqueteDetalle)ObtenerSeleccionado();
                if (item != null)
                {
                    Model.ListaDetallePaquete.Remove(item);
                    TotalVenta();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnEliminarRegistro_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(PaqueteViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    if (Model.ListaDetallePaquete.Count > 0)
                    {
                        this.ObtenerTablas(Model.ListaDetallePaquete);
                        Paquetes Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                        if (Resul.Result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                            this.Close();
                        }
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, "AL MENOS TIENE SELECCIONAR UN PRODUCTO O UN SERVICIO", TypeMessage.informacion);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ServicioViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        #region Metodo
        private void IniciarBinding()
        {
            try
            {
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaVencimientoControl.DataBindings.Add("Value", Model, "FechaVencimiento", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
                NPersonaControl.DataBindings.Add("Text", Model, "NPersonal", true, DataSourceUpdateMode.OnPropertyChanged);
                NPagoControl.DataBindings.Add("Text", Model, "NPago", true, DataSourceUpdateMode.OnPropertyChanged);
                MontoPaqueteControl.DataBindings.Add("Text", Model, "MontoPaquete", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dataGridsfPaqueteDetalle.AutoGenerateColumns = false;
                dataGridsfPaqueteDetalle.DataBindings.Add("DataSource", Model, "ListaDetallePaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LimpiarPropiedades()
        {
            Model.Clave = string.Empty;
            Model.FechaVencimiento = DateTime.Today;
            Model.Nombre = string.Empty;
            Model.Descripcion = string.Empty;
            Model.NPersonal = string.Empty;
            Model.NPago = string.Empty;
            Model.MontoPaquete = 0;
            Model.TablaProducto = new DataTable();
            Model.TablaServicio = new DataTable();
        }
        public void LLenarGrid(object objetoX, int IdTipo)
        {
            try
            {
                if (IdTipo == 1)
                {
                    var Producto = (BusqueProducto)objetoX;
                    if (Model.ListaDetallePaquete.Count == 0)
                    {
                        Model.ListaDetallePaquete.Add(new PaqueteDetalle
                        {
                            IdGenerico = Producto.IdProducto,
                            IdTipo = Producto.IdTipo,
                            Tipo = "Producto",
                            Cantidad = Producto.CantidaProducto,
                            Nombre = Producto.Nombre,
                            Precios = Producto.PrecioPublico,
                            PrecioSinDescuento = Producto.CantidaProducto * Producto.PrecioPublico,
                            PorcentajeDescuento = Producto.PorcentajePaquete,
                            PrecioDescuento = Producto.CantidaProducto * (Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajePaquete / 100)))
                        });
                        TotalVenta();
                    }
                    else
                    {
                        List<PaqueteDetalle> x = Model.ListaDetallePaquete.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u =>
                        {
                            u.Cantidad += Producto.CantidaProducto;
                            u.PrecioSinDescuento = u.Cantidad * Producto.PrecioPublico;
                            u.PrecioDescuento += Producto.PrecioPublico - (Producto.PrecioPublico * (u.PorcentajeDescuento / 100));
                            return u;
                        }).ToList();
                        if (x.Count == 1)
                        {
                            this.dataGridsfPaqueteDetalle.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.ListaDetallePaquete.Add(new PaqueteDetalle
                            {
                                IdGenerico = Producto.IdProducto,
                                IdTipo = Producto.IdTipo,
                                Tipo = "Producto",
                                Cantidad = Producto.CantidaProducto,
                                Nombre = Producto.Nombre,
                                Precios = Producto.PrecioPublico,
                                PrecioSinDescuento = Producto.CantidaProducto * Producto.PrecioPublico,
                                PorcentajeDescuento = Producto.PorcentajePaquete,
                                PrecioDescuento = Producto.CantidaProducto * (Producto.PrecioPublico - (Producto.PrecioPublico * (Producto.PorcentajePaquete / 100)))
                            });
                            TotalVenta();
                        }
                    }
                }
                else if (IdTipo == 2)
                {
                    var Servicio = (Servicio)objetoX;
                    if (Model.ListaDetallePaquete.Count == 0)
                    {
                        Model.ListaDetallePaquete.Add(new PaqueteDetalle
                        {
                            IdGenerico = Servicio.IdServicio,
                            IdTipo = Servicio.IdTipoServicio,
                            Tipo = "Servicio",
                            Cantidad = Servicio.CantidadServicio,
                            Nombre = Servicio.Nombre,
                            Precios = Servicio.Precio,
                            PrecioSinDescuento = Servicio.CantidadServicio * Servicio.Precio,
                            PorcentajeDescuento = Servicio.PorcentajePaquete,
                            PrecioDescuento = Servicio.CantidadServicio * (Servicio.Precio - (Servicio.Precio * (Servicio.PorcentajePaquete / 100))),
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.ListaDetallePaquete.Where(p => p.IdGenerico == Servicio.IdServicio && p.IdTipo == Servicio.IdTipoServicio).Select(u =>
                        {
                            u.Cantidad += Servicio.CantidadServicio;
                            u.PrecioSinDescuento = u.Cantidad * Servicio.Precio;
                            u.PrecioDescuento += Servicio.Precio - (Servicio.Precio * (u.PorcentajeDescuento / 100));
                            return u;
                        }).ToList();
                        if (x.Count == 1)
                        {
                            this.dataGridsfPaqueteDetalle.Refresh();
                            TotalVenta();
                        }
                        else
                        {
                            Model.ListaDetallePaquete.Add(new PaqueteDetalle
                            {
                                IdGenerico = Servicio.IdServicio,
                                IdTipo = Servicio.IdTipoServicio,
                                Tipo = "Servicio",
                                Cantidad = Servicio.CantidadServicio,
                                Nombre = Servicio.Nombre,
                                Precios = Servicio.Precio,
                                PrecioSinDescuento = Servicio.CantidadServicio * Servicio.Precio,
                                PorcentajeDescuento = Servicio.PorcentajePaquete,
                                PrecioDescuento = Servicio.CantidadServicio * (Servicio.Precio - (Servicio.Precio * (Servicio.PorcentajePaquete / 100))),
                            });
                            TotalVenta();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ btnProducto_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        public void TotalVenta()
        {
            try
            {
                decimal total = Model.ListaDetallePaquete.Sum(x => x.PrecioSinDescuento);
                TotalControl.Text = total.ToString("C2");
                Model.MontoPaquete = Model.ListaDetallePaquete.Sum(x => x.PrecioDescuento);
                MontoPaqueteControl.Text = Model.MontoPaquete.ToString("C2");
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
                if (dataGridsfPaqueteDetalle.SelectedItems.Count == 1)
                {
                    return (object)dataGridsfPaqueteDetalle.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerTablas(BindingList<PaqueteDetalle> Lista)
        {
            Model.TablaServicio = new DataTable();
            Model.TablaServicio.Columns.Add("IdPaqueteServicio", typeof(int));
            Model.TablaServicio.Columns.Add("IdServicio", typeof(int));
            Model.TablaServicio.Columns.Add("CantidadServicio", typeof(int));
            Model.TablaServicio.Columns.Add("PrecioServicio", typeof(decimal));
            Model.TablaProducto = new DataTable();
            Model.TablaProducto.Columns.Add("IdPaqueteProducto", typeof(int));
            Model.TablaProducto.Columns.Add("IdProducto", typeof(int));
            Model.TablaProducto.Columns.Add("CantidadProducto", typeof(int));
            Model.TablaProducto.Columns.Add("PrecioProducto", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.IdTipo == 1)
                    Model.TablaProducto.Rows.Add(new object[] { item.IdDetallePaquete, item.IdGenerico, item.Cantidad, item.PrecioDescuento });
                else
                    Model.TablaServicio.Rows.Add(new object[] { item.IdDetallePaquete, item.IdGenerico, item.Cantidad, item.PrecioDescuento });
            }
        }

        #endregion
    }
}
