using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Ventas;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Citas
{
    public partial class FrmCapturaCitaNuevo : Form
    {
        #region Propiedades Públicas
        public CapturaCitaViewModel Model { get; set; }
        public CapturaCita cita { get; set; }
        #endregion
        public FrmCapturaCitaNuevo(DateTime? fecha)
        {
            InitializeComponent();
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            Model.GetCitaDetalle(fecha);
            Model.FechaCita = DateTime.Now;
        }

        public FrmCapturaCitaNuevo(Guid IdCuenta, DateTime? fech)
        {
            InitializeComponent();
            lblTitle.Text = Convert.ToDateTime(fech).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            Model.FechaCita = DateTime.Now;
        }

        #region Métodos
        public void LimpiarPropiedades()
        {
            Model.IdCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
            Model.FechaCita = DateTime.MinValue;            
        }

        #endregion                    

        private void IniciarBinding()
        {
            try
            {
                FechaCitaControl.DataBindings.Add("Value", Model, "Fechacita", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraCitaControl.DataBindings.Add("Value", Model, "Fechacita", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dgmCita.AutoGenerateColumns = false;
                dgmCita.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalle", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dgmServicio.AutoGenerateColumns = false;
                dgmServicio.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalleServicio", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void FrmCapturaCitaNuevo_Load(object sender, EventArgs e)
        {
            IniciarBinding();            

        }

        private CapturaCita ObtenerSeleccionado()
        {
            try
            {
                if (dgmCita.SelectedItems.Count == 1)
                {
                    return (CapturaCita)dgmCita.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CapturaCita ObtenerSeleccionadoServicio()
        {
            try
            {
                if (dgmServicio.SelectedItems.Count == 1)
                {
                    return (CapturaCita)dgmServicio.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerDatosTabla(BindingList<CapturaCita> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdServicio", typeof(int));
            Tabla.Columns.Add("FechaInicio", typeof(DateTime));
            Tabla.Columns.Add("FechaFinal", typeof(DateTime));
            foreach (var item in Lista)
            {
                Tabla.Rows.Add(new object[] { item.IdServicio, item.FechaIServicio, item.FechaFServicio });
            }
            return Tabla;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbCita.Enabled = true;
            btnBuscarCliente.Visible = true;
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FrmBuscarCliente f = new FrmBuscarCliente();
            f.ShowDialog();
            Model.IdCliente = f.cliente.IdCliente;
            ClienteControl.Text = f.cliente.NombreCompleto;
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                BindingList<CapturaCita> ListaServicio = (BindingList<CapturaCita>)dgmServicio.DataSource;
                Model.TablaGServicio = ObtenerDatosTabla(ListaServicio);
                //this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                //var validationResults = Model.Validate();
                //validationResults.ToString();

                //if (validationResults.IsValid)
                //{
                //var aux = Model.Duracion;
                //var otroAux = DuracionControl.Value;
                var Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                    //if (Resul.Resultado == 1)
                    //{
                    //    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                    //    LimpiarPropiedades();
                    //    //await Model.GetAllAsync();
                    //    this.Close();
                    //}
                    //else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, "Error", TypeMessage.error);
                //}
                //else
                //    this.ShowErrors(errorProvider1, typeof(ServicioViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicioNuevo ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnBuscarServicio_Click_1(object sender, EventArgs e)
        {
            FrmBuscarServicio bs = new FrmBuscarServicio();
            bs.ShowDialog();
            if (bs.servicio.IdServicio > 0)
            {
                agregarServicioLista(bs.servicio);
            }
            //Model.IdCliente = f.cliente.IdCliente;
            //tbCliente.Text = f.cliente.NombreCompleto;
        }

        private void agregarServicioLista(Servicio ex)
        {
            
            if (Model.ListaCapturaCitaDetalleServicio.Count == 0)
            {
                HoraCitaControl.Enabled = true;
                Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
                {
                    IdServicio = ex.IdServicio,
                    Servicio = ex.Nombre,
                    FechaIServicio = Model.FechaCita,
                    FechaFServicio = Model.FechaCita.AddHours(1)
                });

            }
            else
            {
                var UltimaFecha = DateTime.Now;

               List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.Skip(Math.Max(0, Model.ListaCapturaCitaDetalleServicio.Count - 4)).Select(x => { UltimaFecha = x.FechaFServicio; return x; }).ToList();

                    Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
                    {
                        IdServicio = ex.IdServicio,
                        Servicio = ex.Nombre,
                        FechaIServicio = UltimaFecha,
                        FechaFServicio = UltimaFecha.AddHours(1)
                    });
               
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    btnBuscarCliente.Visible = false;
                    Model.State = EntityState.Update;
                    gbCita.Enabled = true;                    
                    ClienteControl.Text = item.NombreCompleto;
                    Model.FechaCita = item.FechaCita;                                      
                    await Model.GetCitaDetalleServicio(item.IdCita);                    
                    int count = dgmServicio.RowCount-1;
                    DateTime c2 = Model.FechaCita.AddHours(count);
                    dtpFechafin.Value = c2;
                    //DateTime c = item.FechaCita.AddHours(Model.ListaCapturaCitaDetalleServicio.Count);
                    //Model.GetAllAsync(); Metodo que carga datos
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CitaSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {            
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbCita.Enabled = false;
            ClienteControl.Text = string.Empty;
            Model.ListaCapturaCitaDetalleServicio.Clear();
            Model.FechaCita = DateTime.Today;
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionadoServicio();
                if (item != null)
                {
                    Model.ListaCapturaCitaDetalleServicio.Remove(item);
                    //DateTime c = item.FechaCita.AddHours(Model.ListaCapturaCitaDetalleServicio.Count);
                    //Model.GetAllAsync(); Metodo que carga datos
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ServicioSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void btnGuardar_MouseHover(object sender, EventArgs e)
        //{
        //    if (btnGuardar.ForeColor == Color.White)
        //    {
        //        btnGuardar.FlatAppearance.BorderColor = Color.Black;
        //        btnGuardar.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        btnGuardar.FlatAppearance.BorderColor = Color.Transparent;
        //        btnGuardar.ForeColor = Color.White;
        //    }
        //}
    }
}
