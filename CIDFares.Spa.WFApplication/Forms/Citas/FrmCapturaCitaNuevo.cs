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
        #endregion
        public FrmCapturaCitaNuevo(DateTime? fecha)
        {
            InitializeComponent();            
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();            
            f = Convert.ToDateTime(fecha);            
            string cf = fecha.Value.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();           
            Model.HoraCita = Convert.ToDateTime(cf);
            Model.Cliente = string.Empty;
            Model.ListaCapturaCita = new BindingList<CapturaCita>(new List<CapturaCita>());
            Model.ListaCapturaCitaDetalle = new BindingList<CapturaCita>(new List<CapturaCita>());
            Model.ListaCapturaCitaDetalleServicio = new BindingList<CapturaCita>(new List<CapturaCita>());
            
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
                ClienteControl.DataBindings.Add("Text", Model, "Cliente", true, DataSourceUpdateMode.OnPropertyChanged);                

                this.dgmCita.AutoGenerateColumns = false;
                dgmCita.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalle", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dgmServicio.AutoGenerateColumns = false;
                dgmServicio.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalleServicio", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombo();
                HorasControl.DataBindings.Add("SelectedValue", Model, "IdHora", true, DataSourceUpdateMode.OnPropertyChanged);
                HorasControl.DataBindings.Add("DataSource", Model, "ListaHoras", true, DataSourceUpdateMode.OnPropertyChanged);
                
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
                HorasControl.DisplayMember = "Hora";
                HorasControl.ValueMember = "IdHora";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void comboHoras()
        {
            DateTime primeraHora = new DateTime(2019, 11, 05, 9, 0, 0);
            var z = await Model.GetListaHoras(f, primeraHora);
            Model.LlenarListaHoras(z);
        }

        private async void FrmCapturaCitaNuevo_Load(object sender, EventArgs e)
        {
            
            await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
            IniciarBinding();
            comboHoras();
                    
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
            //DataTable Tabla = new DataTable();
            //Tabla.Columns.Add("IdServicio", typeof(int));
            //Tabla.Columns.Add("FechaInicio", typeof(DateTime));
            //Tabla.Columns.Add("FechaFinal", typeof(DateTime));
            //foreach (var item in Lista)
            //{
            //    Tabla.Rows.Add(new object[] { item.IdServicio, item.FechaIServicio, item.FechaFServicio });
            //}
            //return Tabla;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Model.State = EntityState.Create;            
            gbCita.Enabled = true;
            //btnBuscarServicio.Enabled = false;
            btnBuscarCliente.Visible = true;
            ClienteControl.Text = string.Empty;
            Model.ListaCapturaCitaDetalleServicio.Clear();            
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FrmBuscarCliente f = new FrmBuscarCliente();
            f.ShowDialog();
            Model.IdCliente = f.cliente.IdCliente;
            Model.Cliente = f.cliente.NombreCompleto;            
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                errorProvider1.Clear();
                btnGuardar.Enabled = false;
                BindingList<CapturaCita> ListaServicio = (BindingList<CapturaCita>)dgmServicio.DataSource;
                Model.TablaGServicio = ObtenerDatosTabla(ListaServicio);
                //int exists = await Model.BusyService(CurrentSession.IdSucursal);                                
                var validationResults = Model.Validate();
                validationResults.ToString();
                //if (exists != 1 && exists != 5)
                //{                    
                    if (Model.ListaCapturaCitaDetalleServicio.Count > 0)
                    {
                        if (validationResults.IsValid)
                        {
                            var Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                            if (Resul.Resultado == 1)
                            {
                                
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);                                
                                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                                comboHoras();
                                ClienteControl.Text = string.Empty;
                                Model.ListaCapturaCitaDetalleServicio.Clear();
                                
                                gbCita.Enabled = false;
                            }
                            else
                                CIDMessageBox.ShowAlert(Messages.ErrorMessage, "Error", TypeMessage.error);
                        }
                        else
                            this.ShowErrors(errorProvider1, typeof(CapturaCitaViewModel), validationResults);
                    }
                    else
                    {
                        errorProvider1.SetError(lblErrorControl, "SELECCIONE EL SERVICIO");
                        //this.ShowErrors(errorProvider1, typeof(CapturaCitaViewModel), validationResults);
                    }
            //}
            //else
            //{
            //    if (exists == 5)
            //    {
            //        errorProvider1.SetError(lblCitaOcupadaControl, "NO PUEDES AGENDAR CITAS MENOR A LA HORA ACTUAL");
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(lblCitaOcupadaControl, "HORARIO OCUPADO");
            //    }                    
            //    //this.ShowErrors(errorProvider1, typeof(CapturaCitaViewModel), validationResults);
            //}
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
            try
            {                
                if (Model.ListaCapturaCitaDetalleServicio.Count < 1)
                {                    
                    FrmBuscarServicio bs = new FrmBuscarServicio();
                    bs.ShowDialog();
                    if (bs.servicio.IdServicio > 0)
                    {
                        agregarServicioLista(bs.servicio);
                        //btnBuscarServicio.Enabled = false;
                    }                                 
                }
                else
                {
                    //btnBuscarServicio.Enabled = false;
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.OneService, TypeMessage.informacion);
                }                       
            }
            catch (Exception ex)
            {
                throw ex;
            }            
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
                    FechaIServicio = f.Date + Model.IdHora,                   
                    FechaFServicio = (f.Date + Model.IdHora).AddHours(1)
                });
            }
            else if(Model.ListaCapturaCitaDetalleServicio.Count >= 1)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.OneService, TypeMessage.informacion);
                // var UltimaFecha = DateTime.Now;

                //List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.Skip(Math.Max(0, Model.ListaCapturaCitaDetalleServicio.Count - 4)).Select(x => { UltimaFecha = x.FechaFServicio; return x; }).ToList();
                // //var gg = Model.FechaCita;
                //     Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
                //     {
                //         IdServicio = ex.IdServicio,
                //         Servicio = ex.Nombre,
                //         FechaIServicio = UltimaFecha,
                //         FechaFServicio = UltimaFecha.AddHours(1)
                //     });

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
                    //ClienteControl.Text = item.NombreCompleto;
                    //Model.IdCliente = item.IdCliente;
                    Model.IdCita = item.IdCita;                    
                    Model.State = EntityState.Update;                                                       
                    await Model.GetCitaDetalleServicio(item.IdCita);                                        
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
            this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
            Model.FechaCita = DateTime.Today;
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                Model.ListaCapturaCitaDetalleServicio.Clear();
                //List<CapturaCita> Data;
                //Servicio ex;
                //var item = ObtenerSeleccionadoServicio();
                //if (item != null)
                //{
                //    Model.ListaCapturaCitaDetalleServicio.Remove(item);      
                //    Data = Model.ListaCapturaCitaDetalleServicio.ToList();
                //    Model.ListaCapturaCitaDetalleServicio.Clear();
                //    foreach (var servicio in Data)
                //    {
                //        ex = new Servicio();
                //        ex.IdServicio = servicio.IdServicio;
                //        ex.Nombre = servicio.Servicio;
                //        agregarServicioLista(ex);
                //    }
                //    btnBuscarServicio.Enabled = true;
                //}
                //else
                //    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ServicioSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HoraCitaControl_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Model.ListaCapturaCitaDetalleServicio.Count > 0)
                {
                    Model.HoraCita = HoraCitaControl.Value;
                    Servicio ex;
                    List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.ToList();
                    Model.ListaCapturaCitaDetalleServicio.Clear();
                    foreach (var servicio in Data)
                    {
                        ex = new Servicio();
                        ex.IdServicio = servicio.IdServicio;
                        ex.Nombre = servicio.Servicio;
                        agregarServicioLista(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HorasControl_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void HorasControl_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                //btnBuscarServicio.Enabled = true;
                if (HorasControl.DataBindings["SelectedValue"] != null)
                {
                    HorasControl.DataBindings["SelectedValue"].WriteValue();
                }
                if (Model.ListaCapturaCitaDetalleServicio.Count > 0)
                {
                    Model.HoraCita = HoraCitaControl.Value;
                    Servicio ex;
                    List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.ToList();
                    Model.ListaCapturaCitaDetalleServicio.Clear();
                    foreach (var servicio in Data)
                    {
                        ex = new Servicio();
                        ex.IdServicio = servicio.IdServicio;
                        ex.Nombre = servicio.Servicio;
                        agregarServicioLista(ex);
                    }
                }
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
                        Model.IdCita = item.IdCita;                        
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                            this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));                            
                        }
                        else if (result == 0)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CategoryIsOcuped, TypeMessage.informacion);
                            LimpiarPropiedades();
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

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {

        }

        //private void agregarServicioLista(List<CapturaCita> data)
        //{
        //    string cf = Model.FechaCita.ToShortDateString() + " " + Model.HoraCita.ToLongTimeString();
        //    Model.FechaCita = Convert.ToDateTime(cf);

        //    if (Model.ListaCapturaCitaDetalleServicio.Count == 0)
        //    {
        //        HoraCitaControl.Enabled = true;
        //        Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
        //        {
        //            IdServicio = ex.IdServicio,
        //            Servicio = ex.Nombre,
        //            FechaIServicio = Model.FechaCita,
        //            FechaFServicio = Model.FechaCita.AddHours(1)
        //        });

        //    }
        //    else
        //    {
        //        var UltimaFecha = DateTime.Now;

        //        List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.Skip(Math.Max(0, Model.ListaCapturaCitaDetalleServicio.Count - 4)).Select(x => { UltimaFecha = x.FechaFServicio; return x; }).ToList();

        //        Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
        //        {
        //            IdServicio = ex.IdServicio,
        //            Servicio = ex.Nombre,
        //            FechaIServicio = UltimaFecha,
        //            FechaFServicio = UltimaFecha.AddHours(1)
        //        });

        //    }
        //}        
    }
}
