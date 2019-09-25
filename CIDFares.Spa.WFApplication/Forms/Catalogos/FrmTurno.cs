using System;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.Business.ValueObjects;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurno : Form
    {
        public TurnoViewModel Model { get; set; }
        public FrmTurno()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<TurnoViewModel>();
            groupBoxTurno.Enabled = false;
            Model.IdUsuario = CurrentSession.IdCuentaUsuario;

            btnNuevoTurno.Visible = CurrentSession.PermisoUsuario("4");
            btnModificarTurno.Visible = CurrentSession.PermisoUsuario("5");
            btnEliminarTurno.Visible = CurrentSession.PermisoUsuario("6");

            PanelCapturaDatosTurno.Visible = CurrentSession.PermisoUsuario("4,5");
        }

        private void IniciarBinding()
        {
            try
            {
                NombreTurnoTextBox.DataBindings.Add("Text", Model, "NombreTurno", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraEntrada1TimePicker.DataBindings.Add("Value", Model, "HoraEntrada1", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraSalida1TimePicker.DataBindings.Add("Value", Model, "HoraSalida1", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraEntrada2TimePicker.DataBindings.Add("Value", Model, "HoraEntrada2", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraSalida2TimePicker.DataBindings.Add("Value", Model, "HoraSalida2", true, DataSourceUpdateMode.OnPropertyChanged);
                LunesCkeckBox.DataBindings.Add("Checked", Model, "Lunes", true, DataSourceUpdateMode.OnPropertyChanged);
                MartesCkeckBox.DataBindings.Add("Checked", Model, "Martes", true, DataSourceUpdateMode.OnPropertyChanged);
                MiercolesCkeckBox.DataBindings.Add("Checked", Model, "Miercoles", true, DataSourceUpdateMode.OnPropertyChanged);
                JuevesCkeckBox.DataBindings.Add("Checked", Model, "Jueves", true, DataSourceUpdateMode.OnPropertyChanged);
                ViernesCkeckBox.DataBindings.Add("Checked", Model, "Viernes", true, DataSourceUpdateMode.OnPropertyChanged);
                SabadoCkeckBox.DataBindings.Add("Checked", Model, "Sabado", true, DataSourceUpdateMode.OnPropertyChanged);
                DomingoCkeckBox.DataBindings.Add("Checked", Model, "Domingo", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void LimpiarPropiedades()
        {
            Model.IdTurno = 0;
            Model.HoraEntrada1 = DateTime.MinValue;
            Model.HoraSalida1 = DateTime.MinValue; ;
            Model.HoraEntrada2 = DateTime.MinValue;
            Model.HoraSalida2 = DateTime.MinValue;
            Model.Lunes = false;
            Model.Martes = false;
            Model.Miercoles = false;
            Model.Jueves = false;
            Model.Viernes = false;
            Model.Sabado = false;
            Model.Domingo = false;
        }

        public Turno ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridTurno.SelectedItems.Count == 1)
                {
                    return (Turno)sfDataGridTurno.SelectedItem;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private async void FrmTurno_Load(object sender, EventArgs e)
        {
            try
            {
                await Model.GetAll();
                IniciarBinding();
            }
            catch(Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Model.State = EntityState.Create;
                groupBoxTurno.Enabled = true;
                DosHorariosRadio.Checked = true;
                PanelHorarios.Enabled = true;
                LimpiarPropiedades();
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado();
            if(item != null)
            {
                groupBoxTurno.Enabled = true;
                Model.State = EntityState.Update;
                Model.IdTurno = item.IdTurno;
                Model.NombreTurno = item.NombreTurno;
                Model.HoraEntrada1 = item.HoraEntrada1;
                Model.HoraSalida1 = item.HoraSalida1;
                Model.HoraEntrada2 = item.HoraEntrada2;
                Model.HoraSalida2 = item.HoraSalida2;
                Model.Lunes = item.Lunes;
                Model.Martes = item.Martes;
                Model.Miercoles = item.Miercoles;
                Model.Jueves = item.Jueves;
                Model.Viernes = item.Viernes;
                Model.Sabado = item.Sabado;
                Model.Domingo = item.Domingo;
            }
            else
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                groupBoxTurno.Enabled = false;
            }
        }

        private async void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                /* var validationResult = Model.Validate();
                 validationResult.ToString();
                 if(validationResult.IsValid)
                 {*/
                if (DosHorariosRadio.Checked)
                {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, true);
                    if (Resultado.Resultado > 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        groupBoxTurno.Enabled = false;
                        await Model.GetAll();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        LimpiarPropiedades();
                        groupBoxTurno.Enabled = false;
                    }
                }
                else
                {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, false);
                    if (Resultado.Resultado > 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        groupBoxTurno.Enabled = false;
                        await Model.GetAll();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        LimpiarPropiedades();
                        groupBoxTurno.Enabled = false;
                    }
                }
                    
               // }
                /*else
                    this.ShowErrors*/
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdTurno = item.IdTurno;
                        groupBoxTurno.Enabled = false;
                        var result = await Model.DeleteAsync();
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                            await Model.GetAll();
                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    this.groupBoxTurno.Enabled = false;
                    this.LimpiarPropiedades();
                    //this.CleanErrors(errorProvider1, typeof(ClienteViewModel));
                }
            }
            catch(Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorAlCancelarFrm, TypeMessage.error);
            }
        }

        private void DosHorariosRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (DosHorariosRadio.Checked)
            {
                HoraEntrada2TimePicker.Enabled = false;
                HoraSalida2TimePicker.Enabled = false;
            }
            else
            {
                HoraEntrada2TimePicker.Enabled = true;
                HoraSalida2TimePicker.Enabled = true;
            }
        }
    }
}
