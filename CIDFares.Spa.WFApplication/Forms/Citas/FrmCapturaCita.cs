using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Citas;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmCapturaCita : Form
    {
        #region Propiedades Públicas
        public CapturaCitaViewModel Model { get; set; }
        public CapturaCita cita { get; set; }
        public SpecialDate special { get; set; }
        #endregion

        #region Constructor
        public FrmCapturaCita()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            cita = new CapturaCita();
        }
        #endregion

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                FechaInicioControl.DataBindings.Add("Value", Model, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaFinalControl.DataBindings.Add("Value", Model, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LimpiarPropiedades()
        {
            mcCita2.SelectedDate = DateTime.Now;
            Model.IdAgendaCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
            //Model.FechaCita = DateTime.MinValue;
            Model.FechaInicio = DateTime.Now;
            Model.FechaFinal = new DateTime(2020, 05, 01, 06, 30, 05);            
        }
        

        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -1:
                        ErrorMessage = "El nombre de la forma de pago ya se encuentra en los registros";
                        break;
                    case -2:
                        ErrorMessage = "Desconocido";
                        break;
                }
                return ErrorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos        

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                Model.State = EntityState.Create;
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }                
        #endregion

        private void FrmCapturaCita_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                LimpiarPropiedades();                
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCita ~ FrmCapturaCita_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }            
        }
        
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<SpecialDate> listsd = new List<SpecialDate>();
                await Model.GetCitaXPeriodo(CurrentSession.IdSucursal);                
                Image newimage = Image.FromFile("c:\\holanw2.png");
                foreach (var item in Model.ListaCapturaCita)
                {
                    SpecialDate special = new SpecialDate();                    
                    special.IsDateVisible = false;
                    special.Value = item.FechaInicio;
                    special.Image = newimage;
                    special.ImageAlign = ContentAlignment.MiddleLeft;
                    listsd.Add(special);
                }
                this.mcCita2.SpecialDates = listsd;                
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCita ~ btnBuscar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }       

        private void mcCita_Click(object sender, EventArgs e)
        {                        
            Console.WriteLine("Hola");
        }

        private async void mcCita2_DoubleClick(object sender, EventArgs e)
        {                      
            try
            {
                int v = 0;
                DateTime? x = this.mcCita2.SelectedDate;
                if (x.Value.Date >= DateTime.Now.Date)
                {
                    foreach (var item in Model.ListaCapturaCita)
                    {
                        if (item.FechaInicio.Date == x.Value.Date)
                        {
                            v = 1;
                            Console.WriteLine("Detalle");
                            FrmCapturaCitaNuevo f = new FrmCapturaCitaNuevo(x);
                            f.ShowDialog();
                            Model.State = EntityState.Update;
                            break;
                        }
                    }
                    if (v != 1)
                    {
                        Console.WriteLine("Nuevo");
                        FrmCapturaCitaNuevo f = new FrmCapturaCitaNuevo(x);
                        f.ShowDialog();
                        Model.State = EntityState.Create;
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.FechaSelectMessage, TypeMessage.informacion);
                }                                
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCita ~ mcCita2_DoubleClick(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }        
    }
}