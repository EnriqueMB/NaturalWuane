using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDDataGridsf;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmPaqueteNuevo : Form
    {
        #region Propiedades publicas 
        public PaqueteViewModel Model { get; set; }
        private Servicio infoServicio { get; set; }
        private Producto InfoProducto { get; set; }
        #endregion

        public FrmPaqueteNuevo()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
        }

        public FrmPaqueteNuevo(Paquetes paquete)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Model.IdPaquete = paquete.IdPaquete;
        }
        #region Eventos
        private void FrmPaqueteNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
            }
            catch (Exception ex)
            {

                throw;
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
        #endregion

        #region Metodo

        private void IniciarBinding()
        {
            try
            {
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);

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
                            Precios = Producto.PrecioPublico 
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.ListaDetallePaquete.Where(p => p.IdGenerico == Producto.IdProducto && p.IdTipo == Producto.IdTipo).Select(u =>
                        {
                            u.Cantidad += Producto.CantidaProducto;
                            u.Precios = u.Cantidad * Producto.PrecioPublico; return u;
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
                                Precios = Producto.PrecioPublico
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
                            Precios = Servicio.Precio
                        });
                        TotalVenta();
                    }
                    else
                    {
                        var x = Model.ListaDetallePaquete.Where(p => p.IdGenerico == Servicio.IdServicio && p.IdTipo == Servicio.IdTipoServicio).Select(u =>
                        {
                            u.Cantidad += Servicio.CantidadServicio;
                            u.Precios = u.Cantidad * Servicio.Precio; return u;
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
                                Precios = Servicio.Precio
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

        public void TotalVenta()
        {
            try
            {
                decimal total = Model.ListaDetallePaquete.Sum(x => x.Precios);
                MontoPaqueteControl.Text = total.ToString("C2");
                Model.MontoPaquete = total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
