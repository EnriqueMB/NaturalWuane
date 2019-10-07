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
            string fi = f.ToShortDateString() + " "+ "09:00:00";
            Model.FechaInicio = Convert.ToDateTime(fi);
            //string cf = fecha.Value.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();           
            //Model.HoraCita = Convert.ToDateTime(cf);
            Model.NombreCompleto = string.Empty;
            Model.ListaCapturaCita = new BindingList<CapturaCita>(new List<CapturaCita>());
            Model.ListaCapturaCitaDetalle = new BindingList<CapturaCita>(new List<CapturaCita>());
            Model.ListaCapturaCitaDetalleServicio = new BindingList<CapturaCita>(new List<CapturaCita>());
        }        

        #region Métodos
        public void LimpiarPropiedades()
        {
            Model.IdAgendaCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
            //Model.FechaCita = DateTime.MinValue;            
        }

        #endregion                    

        private void IniciarBinding()
        {
            try
            {
                ClienteControl.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);                

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
                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                IniciarBinding();
                //comboHoras();
                HorarioSucursal();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCitaNuevo(DateTime? fecha) ~ FrmCapturaCitaNuevo_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
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
                Tabla.Rows.Add(new object[] { item.OrdenServicio.Servicio.IdServicio, item.FechaInicio, item.FechaFinal });
            }
            return Tabla;
            //return new DataTable();
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
            FrmBuscarCliente cli = new FrmBuscarCliente();
            cli.ShowDialog();
            //cita.OrdenServicio.Cliente.IdCliente = cli.cliente.IdCliente;
            //cita.OrdenServicio.Cliente.NombreCompleto = cli.cliente.NombreCompleto;
            Model.IdCliente = cli.cliente.IdCliente;
            Model.NombreCompleto = cli.cliente.NombreCompleto;            
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                errorProvider1.Clear();
                btnGuardar.Enabled = false;
                BindingList<CapturaCita> ListaServicio = (BindingList<CapturaCita>)dgmServicio.DataSource;
                //Model.TablaGServicio = ObtenerDatosTabla(ListaServicio);
                ObtenerDatos(ListaServicio);
                int exists = await Model.BusyService(CurrentSession.IdSucursal);                                
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (exists != 1 && exists != 5)
                {
                    if (Model.ListaCapturaCitaDetalleServicio.Count > 0)
                    {
                        if (validationResults.IsValid)
                        {
                            var Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                            if (Resul.Resultado == 1)
                            {
                                
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);                                
                                await Model.GetCitaDetalle(f, CurrentSession.IdSucursal);
                                HorarioSucursal();
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
                }
                else
                {
                    if (exists == 5)
                    {
                        errorProvider1.SetError(lblCitaOcupadaControl, "NO PUEDES AGENDAR CITAS MENOR A LA HORA ACTUAL");
                    }
                    else
                    {
                        errorProvider1.SetError(lblCitaOcupadaControl, "HORARIO OCUPADO");
                    }
                    //this.ShowErrors(errorProvider1, typeof(CapturaCitaViewModel), validationResults);
                }
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

        private void ObtenerDatos(BindingList<CapturaCita> listaServicio)
        {
            try
            {
                foreach(var item in listaServicio)
                {
                    Model.IdServicio = item.OrdenServicio.Servicio.IdServicio;
                    Model.Servicio = item.OrdenServicio.Servicio.Nombre;
                    Model.FechaInicio = item.FechaInicio;
                    Model.FechaFinal = item.FechaFinal;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                //HoraCitaControl.Enabled = true;
                Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
                {                                           
                    FechaInicio = f.Date + Model.IdHora,
                    FechaFinal = (f.Date + Model.IdHora).AddHours(1),
                    OrdenServicio = new OrdenServicio
                    {                        
                        Servicio = new Servicio
                        {
                            IdServicio = ex.IdServicio,
                            Nombre = ex.Nombre
                        }
                    }
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

        private void agregarServicioListaUpd(Servicio ex, DateTime fInicio)
        {
            if (Model.ListaCapturaCitaDetalleServicio.Count == 0)
            {
                //HoraCitaControl.Enabled = true;

                Model.IdHora = TimeSpan.Parse(fInicio.ToString("HH:mm:ss"));
                Model.ListaCapturaCitaDetalleServicio.Add(new CapturaCita
                {
                     
                    FechaInicio = fInicio,
                    FechaFinal = fInicio.AddHours(1),
                    OrdenServicio = new OrdenServicio
                    {
                        Servicio = new Servicio
                        {
                            IdServicio = ex.IdServicio,
                            Nombre = ex.Nombre
                        }
                    }
                });
            }
            else if (Model.ListaCapturaCitaDetalleServicio.Count >= 1)
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Servicio ex;
                    btnBuscarCliente.Visible = false;
                    //Model.State = EntityState.Update;
                    gbCita.Enabled = true;
                    ClienteControl.Text = item.OrdenServicio.Cliente.NombreCompleto;
                    Model.IdCliente = item.OrdenServicio.Cliente.IdCliente;
                    Model.IdAgendaCita = item.IdAgendaCita;
                    Model.IdOrdenServicio = item.OrdenServicio.IdOrdenServicio;
                    //List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.ToList();
                    Model.ListaCapturaCitaDetalleServicio.Clear();
                    ex = new Servicio();
                    ex.IdServicio = item.OrdenServicio.Servicio.IdServicio;
                    ex.Nombre = item.OrdenServicio.Servicio.Nombre;
                    agregarServicioListaUpd(ex, item.FechaInicio);
                    Model.State = EntityState.Update;
                    //await Model.GetCitaDetalleServicio(item.IdAgendaCita);
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
            //Model.FechaCita = DateTime.Today;
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

        //private void HoraCitaControl_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Model.ListaCapturaCitaDetalleServicio.Count > 0)
        //        {
        //            Model.HoraCita = HoraCitaControl.Value;
        //            Servicio ex;
        //            List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.ToList();
        //            Model.ListaCapturaCitaDetalleServicio.Clear();
        //            foreach (var servicio in Data)
        //            {
        //                ex = new Servicio();
        //                ex.IdServicio = servicio.OrdenServicio.Servicio.IdServicio;
        //                ex.Nombre = servicio.OrdenServicio.Servicio.Nombre;
        //                agregarServicioLista(ex);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}       

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
                    //var x = Model.FechaInicio;
                    //Model.FechaInicio = HorasControl.ValueMember;
                    
                    //Model.HoraCita = HoraCitaControl.Value;
                    Servicio ex;
                    List<CapturaCita> Data = Model.ListaCapturaCitaDetalleServicio.ToList();
                    Model.ListaCapturaCitaDetalleServicio.Clear();
                    foreach (var servicio in Data)
                    {
                        ex = new Servicio();
                        ex.IdServicio = servicio.OrdenServicio.Servicio.IdServicio;
                        ex.Nombre = servicio.OrdenServicio.Servicio.Nombre;
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
                        //Model.IdCita = item.IdCita;                        
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
