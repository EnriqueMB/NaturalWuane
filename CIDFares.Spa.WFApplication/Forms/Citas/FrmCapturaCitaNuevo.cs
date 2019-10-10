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
        public OrdenPaquete ordenPaquete { get; set; }
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
            ordenPaquete = new OrdenPaquete();
        }

        //Agregar un paquete a la cita
        public FrmCapturaCitaNuevo(DateTime? fecha, OrdenPaquete orden, Cliente cliente)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model.IdSucursal = CurrentSession.IdSucursal;
            f = Convert.ToDateTime(fecha);
            this.ordenPaquete = orden;
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
            Model.Servicio = string.Empty;
            Model.IdHora = Model.ListaHoras[0].IdHora;
            lblNombre.Text = "Nueva cita";
            btnAgregarPaquete.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnCitasSinAgendar.Enabled = true;
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
                if (ordenPaquete.Paquete.IdPaquete != 0)
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
                btnNuevo.Visible = false;
                btnModificar.Visible = false;
                btnAgregarPaquete.Visible = false;
                btnEliminar.Visible = false;

                labelNombre.Text =ordenPaquete.Paquete.Nombre;
                Model.IdPaquete = ordenPaquete.Paquete.IdPaquete;
                Model.Nombre = ordenPaquete.Paquete.NombreCompleto

                OrdenPaquete OP = await Model.AgendarPaquete(CurrentSession.IdSucursal, CurrentSession.IdCuentaUsuario);
                ServiciosPaquete(OP.IdOrdenPaquete);
                Model.IdOrdenPaquete = OP.IdOrdenPaquete;
                ordenPaquete.IdOrdenPaquete = OP.IdOrdenPaquete;
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
                if (f.Date <= DateTime.Now.Date)
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
                    btnAgregarPaquete.Enabled = false;
                    btnNuevo.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCitasSinAgendar.Enabled = false;
                    lblNombre.Text = item.OrdenServicio.Cliente.NombreCompleto;
                    if (item.OrdenServicio.OrdenPaquete.IdOrdenPaquete != Guid.Empty)
                    {
                        //btnAgregarPaquete.Enabled = true;
                        //btnNuevo.Enabled = true;
                        //btnEliminar.Enabled = true;
                        //btnCitasSinAgendar.Enabled = true;
                        lblNombre.Text = item.OrdenServicio.OrdenPaquete.Paquete.Nombre;
                    }
                    BtnBuscar.Enabled = false;
                    groupBoxCita.Enabled = true;
                    NombreCompletoControl.ReadOnly = true;                    
                    ServicioControl.Visible = true;
                    IdServicioControl.Visible = false;
                    NombreCompletoControl.Text = item.OrdenServicio.Cliente.NombreCompleto;                    
                    Model.IdHora = item.FechaInicio.TimeOfDay;
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
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CitaSelectMessage, TypeMessage.informacion);
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
                lblNombre.Text = cli.cliente.NombreCompleto;
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
                if(f.Date <= DateTime.Now.Date)
                {
                    btnAnterior.Visible = false;
                }
                else
                {
                    btnAnterior.Visible = true;
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

        private async void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupBoxCita.Enabled == true)
                {
                    if (this.NombreCompletoControl.Text != string.Empty)
                    {
                        FrmBuscarPaquete busPaquete = new FrmBuscarPaquete();
                        busPaquete.ShowDialog();
                        Model.IdPaquete = busPaquete.paquetes.IdPaquete;
                        if (Model.IdPaquete != 0)
                        {
                            var x = await Model.AgendarPaquete(CurrentSession.IdSucursal, CurrentSession.IdCuentaUsuario);
                            Model.IdOrdenPaquete = x.IdOrdenPaquete;
                            ServiciosPaquete(Model.IdOrdenPaquete);
                            IdServicioControl.Visible = true;
                            groupBoxCita.Enabled = true;
                            lblNombre.Text = busPaquete.paquetes.Nombre;
                            BtnBuscar.Enabled = false;
                            ServicioControl.Visible = false;
                            pictureBox1.Visible = false;
                        }
                        else
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.PaqueteSelectMessage, TypeMessage.informacion);
                        }                        
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ClienteSelectMessage, TypeMessage.informacion);
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CitaAddMessage, TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //labelNombre.Text = csa.capturaCita.OrdenServicio.OrdenPaquete.Paquete.Nombre;
            //Model.NombreCompleto = csa.capturaCita.OrdenServicio.Cliente.NombreCompleto;
            //Model.IdCliente = csa.capturaCita.OrdenServicio.Cliente.IdCliente;
        }

        private void btnCitasSinAgendar_Click(object sender, EventArgs e)
        {
            try
            {               
                FrmCitasSinAgendar csa = new FrmCitasSinAgendar();
                csa.ShowDialog();
                Model.IdOrdenPaquete = csa.capturaCita.OrdenServicio.OrdenPaquete.IdOrdenPaquete;
                ServiciosPaquete(Model.IdOrdenPaquete);
                IdServicioControl.Visible = true;
                lblNombre.Text = csa.capturaCita.OrdenServicio.Cliente.NombreCompleto;
                groupBoxCita.Enabled = true;
                BtnBuscar.Enabled = false;
                ServicioControl.Visible = false;
                pictureBox1.Visible = false;
                lblNombre.Text = csa.capturaCita.OrdenServicio.OrdenPaquete.Paquete.Nombre;
                Model.NombreCompleto = csa.capturaCita.OrdenServicio.Cliente.NombreCompleto;
                Model.IdCliente = csa.capturaCita.OrdenServicio.Cliente.IdCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private async void btnReservarCita_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                errorProvider1.Clear();
                btnReservarCita.Enabled = false;
                ObtenerDatos();
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
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
                btnReservarCita.Enabled = true;
            }
        }
    }
}
