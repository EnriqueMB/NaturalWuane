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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Model.IdCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
            Model.FechaCita = DateTime.MinValue;
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
                //grpBoxFormaPago.Enabled = true;
                LimpiarPropiedades();
                Model.State = EntityState.Create;
                this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //var item = ObtenerSeleccionado();
                //if (item != null)
                //{
                //    this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                //    //Model.IdFormaPago = item.IdFormaPago;
                //    //Model.Nombre = item.Nombre;
                //    //Model.Descripcion = item.Descripcion;
                //    //grpBoxFormaPago.Enabled = true;
                //    Model.State = EntityState.Update;
                //}
                //else
                //    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //var item = ObtenerSeleccionado();
                //if (item != null)
                //{

                //    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                //    {
                //        //Model.IdFormaPago = item.IdFormaPago;
                //        //grpBoxFormaPago.Enabled = false;
                //        var result = 1;//await Model.DeleteAsync(CurrentSession.IdCuentaUsuario, Guid IdUser);
                //        if (result == 1)
                //        {
                //            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                //            LimpiarPropiedades();
                //            this.CleanErrors(errorProvider1, typeof(CapturaCitaViewModel));
                //            //await Model.GetAllAsync();
                //        }
                //        else
                //            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                //    }
                //}
                //else
                //    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        private void FrmCapturaCita_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                LimpiarPropiedades();
                //mcCita2
                //mcCita2.SpecialDates = new DateTime[]
                //{
                //    new DateTime(2019,09,17),
                //    new DateTime(2019,09, 15)
                //};
                //var x = await Repository.GetCitaXPeriodo(this.FechaInicio, this.FechaFinal);
                //ListaCapturaCita.Clear();
                //foreach (var item in x)
                //{
                //    ListaCapturaCita.Add(item);
                //}
                //SpecialDate specialDate = new SpecialDate();
                //List<SpecialDate> list = new List<SpecialDate>();
                
                //DateTime[] array1 = new[] { DateTime.Now, DateTime.Now };
                //DateTime[] array2 = new[] { DateTime.Today, DateTime.UtcNow };
                //specialDate.Value = new DateTime(2019,09,11);
                //specialDate.BackColor = System.Drawing.Color.Red;
                //list.Add(specialDate);
                //this.mcCita2.SpecialDates = list;
                //mcCita2.SpecialDates.Add(list);
                ////list.Add(array2);
              // this.mcCita2.SpecialDates.Add(((Syncfusion.WinForms.Input.SpecialDate)(resources.GetObject("mcCita2.SpecialDates2"))));
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
                await Model.GetCitaXPeriodo();                
                Image newimage = Image.FromFile("c:\\holanw2.png");
                foreach (var item in Model.ListaCapturaCita)
                {
                    SpecialDate special = new SpecialDate();                    
                    special.IsDateVisible = false;
                    special.Value = item.FechaCita;
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

        private async void monthCalendarAdv1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    await Model.GetCitaXPeriodo();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}            
        }

        private void mcCita_Click(object sender, EventArgs e)
        {            
            //var x = this.mcCita.Value;
            Console.WriteLine("Hola");
        }

        private async void mcCita2_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                int v = 0;
                DateTime? x = this.mcCita2.SelectedDate;                                
                foreach (var item in Model.ListaCapturaCita)
                {
                    if (item.FechaCita.Date == x.Value.Date)
                    {
                        v = 1;
                        Console.WriteLine("Detalle");
                        await Model.GetCitaDetalle(x);
                        FrmCapturaCitaNuevo f = new FrmCapturaCitaNuevo();
                        f.ShowDialog();
                        Model.State = EntityState.Update;
                        break;
                    }                    
                }
                if (v != 1)
                {
                    Console.WriteLine("Nuevo");
                    FrmCapturaCitaNuevo f = new FrmCapturaCitaNuevo();
                    f.ShowDialog();
                    Model.State = EntityState.Create;
                }
                //Model.GetAllAsync();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaCita ~ mcCita2_DoubleClick(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void mcCita2_Click(object sender, EventArgs e)
        {

        }
    }
}