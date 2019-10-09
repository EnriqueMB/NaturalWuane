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
        DateTime f;
        private Paquetes Paquetes;
        #endregion
        public FrmCapturaCitaNuevo(DateTime? fecha)
        {
            InitializeComponent();            
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model.IdSucursal = CurrentSession.IdSucursal;
            f = Convert.ToDateTime(fecha);
            groupBoxCita.Enabled = false;
            Model.NombreCompleto = string.Empty;
            Model.IdPaquete = 0;
            Paquetes = new Paquetes();
        }

        //Agregar un paquete a la cita
        public FrmCapturaCitaNuevo(DateTime? fecha, Paquetes paquete, Cliente cliente)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model.IdSucursal = CurrentSession.IdSucursal;
            f = Convert.ToDateTime(fecha);
            Paquetes = paquete;
            Model.IdCliente = cliente.IdCliente;
            Model.NombreCompleto = cliente.NombreCompleto;
        }

        #region Métodos
        public void LimpiarPropiedades()
        {
            Model.IdAgendaCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
        }

        #endregion                    

        private void IniciarBinding()
        {
            try
            {
                NombreCompletoControl.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);                
                ServicioControl.DataBindings.Add("Text", Model, "Servicio", true, DataSourceUpdateMode.OnPropertyChanged);                

                this.dgmCita.AutoGenerateColumns = false;
                dgmCita.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalle", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombo();
                IdHoraControl.DataBindings.Add("SelectedValue", Model, "IdHora", true, DataSourceUpdateMode.OnPropertyChanged);
                IdHoraControl.DataBindings.Add("DataSource", Model, "ListaHoras", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarComboPaquete();
                IdServicioControl.DataBindings.Add("SelectedValue", Model, "IdServicio", true, DataSourceUpdateMode.OnPropertyChanged);
                IdServicioControl.DataBindings.Add("DataSource", Model, "ListaServicioPaquete", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarCombo()
        {
            try
            {
                IdHoraControl.DisplayMember = "Hora";
                IdHoraControl.ValueMember = "IdHora";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarComboPaquete()
        {
            try
            {
                IdServicioControl.DisplayMember = "Nombre";
                IdServicioControl.ValueMember = "IdServicio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void ServiciosPaquete(Guid IdOrdenPaquete)
        {
            try
            {
                var x = await Model.GetAllServicioPaquete(IdOrdenPaquete);
                Model.LlenarListaServicioPaquete(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private async void HorarioSucursal()
        {
            try
            {
                var x = await Model.HorarioSucursal(Model.Dias(f), CurrentSession.IdSucursal);
                Model.LlenarListaHoras(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        private async void FrmCapturaCitaNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                IniciarFormulario();
                if (Paquetes.IdPaquete != 0)
                    FormularioPaquete();
                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                HorarioSucursal();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCitaNuevo(DateTime? fecha) ~ FrmCapturaCitaNuevo_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void FormularioPaquete()
        {
            try
            {
                IdServicioControl.Visible = true;
                BtnBuscar.Enabled = false;
                ServicioControl.Visible = false;
                pictureBox1.Visible = false;
                pnlButtons.Visible = false;
                labelNombre.Text = Paquetes.Nombre;
                Model.IdPaquete = Paquetes.IdPaquete;
                Model.Nombre = Paquetes.Nombre;

                OrdenPaquete OP = await Model.AgendarPaquete(CurrentSession.IdSucursal, CurrentSession.IdCuentaUsuario);
                ServiciosPaquete(OP.IdOrdenPaquete);
                Model.IdOrdenPaquete = OP.IdOrdenPaquete;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void IniciarFormulario()
        {
            try
            {
                string fi = f.ToShortDateString() + " " + "09:00:00";
                Model.FechaInicio = Convert.ToDateTime(fi);
                FechaControl.Text = f.ToShortDateString();
                if (f == DateTime.Now)
                    btnAnterior.Visible = false;
                else
                    btnAnterior.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
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
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Model.State = EntityState.Create;            
            groupBoxCita.Enabled = true;
            BtnBuscar.Enabled = true;
            NombreCompletoControl.Text = string.Empty;
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FrmBuscarCliente cli = new FrmBuscarCliente();
            cli.ShowDialog();
            Model.IdCliente = cli.cliente.IdCliente;
            Model.NombreCompleto = cli.cliente.NombreCompleto;            
        }

        private void ObtenerDatos()
        {
            try
            {
                Model.FechaInicio = f.Date + Model.IdHora;
                Model.FechaFinal = (f.Date + Model.IdHora).AddHours(1);

                string vr = Model.FechaInicio.ToShortDateString() + " " + Model.IdHora;
                Model.FechaInicio = Convert.ToDateTime(vr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    BtnBuscar.Enabled = false;
                    groupBoxCita.Enabled = true;
                    NombreCompletoControl.ReadOnly = true;
                    NombreCompletoControl.Text = item.OrdenServicio.Cliente.NombreCompleto;
                    //Model.IdHora = (TimeSpan)item.FechaInicio;
                    Model.IdCliente = item.OrdenServicio.Cliente.IdCliente;
                    Model.IdAgendaCita = item.IdAgendaCita;
                    Model.IdOrdenServicio = item.OrdenServicio.IdOrdenServicio;
                    Model.IdServicio = item.OrdenServicio.Servicio.IdServicio;
                    Model.Servicio = item.OrdenServicio.Servicio.Nombre;
                    Model.State = EntityState.Update;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CitaSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {            
                throw ex;
            }
        }
        
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                btnEliminar.Enabled = false;
                var item = ObtenerSeleccionado();
                if (item != null)
                {

                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {     
                        var result = await Model.DeleteAsync(item.IdAgendaCita, CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                            this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));                            
                        }                        
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                btnEliminar.Enabled = true;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarCliente cli = new FrmBuscarCliente();
                cli.ShowDialog();
                Model.IdCliente = cli.cliente.IdCliente;
                Model.NombreCompleto = cli.cliente.NombreCompleto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                    FrmBuscarServicio bs = new FrmBuscarServicio(Paquetes);
                    bs.ShowDialog();
                    if (bs.servicio.IdServicio > 0)
                    {
                        Model.Servicio = bs.servicio.Nombre;
                        Model.IdServicio = bs.servicio.IdServicio;
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                errorProvider1.Clear();
                button1.Enabled = false;
                ObtenerDatos();
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid )
                {
                    int res = 0;
                        var Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                        res = Resul.Resultado;
                    if (res == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                        HorarioSucursal();
                        Model.Servicio = string.Empty;
                        ServiciosPaquete(Model.IdOrdenPaquete);
                        if (Model.State == EntityState.Update)
                        {
                            LimpiarPropiedades();
                            groupBoxCita.Enabled = false;
                        }
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, "Error", TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(CapturaCitaViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicioNuevo ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                groupBoxCita.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = Convert.ToDateTime(f.AddDays(1)).ToString("dddd, dd MMMM yyyy").ToUpper();
                f = Convert.ToDateTime(f.AddDays(1));
                IniciarFormulario();
                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if(f == DateTime.Now)
                {
                    btnAnterior.Visible = false;
                }
                lblTitle.Text = Convert.ToDateTime(f.AddDays(-1)).ToString("dddd, dd MMMM yyyy").ToUpper();
                f = Convert.ToDateTime(f.AddDays(-1));
                IniciarFormulario();
                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            FrmBuscarPaquete busPaquete = new FrmBuscarPaquete();
            busPaquete.ShowDialog();
        }

        private void btnCitasSinAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCitasSinAgendar csa = new FrmCitasSinAgendar();
                csa.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
