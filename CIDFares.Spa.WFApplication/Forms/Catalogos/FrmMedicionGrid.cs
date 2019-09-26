using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmMedicionGrid : Form
    {
        #region Propiedades Publicas
        public MedicionViewModel Model { get; set; }
        #endregion
        public FrmMedicionGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<MedicionViewModel>();
        }

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                EsAbiertaControl.DataBindings.Add("Checked", Model, "EsAbierta", true, DataSourceUpdateMode.OnPropertyChanged);
                sfDataGridMedicion.AutoGenerateColumns = false;
                sfDataGridMedicion.DataBindings.Add("DataSource", Model, "ListaMedicion", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(1);
                IdUnidaMedidaControl.DataBindings.Add("DataSource", Model, "ListaUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
                IdUnidaMedidaControl.DataBindings.Add("SelectedValue", Model, "IdUnidaMedida", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(2);
                IdListaMedicionControl.DataBindings.Add("DataSource", Model, "ListaValoresMedicion", true, DataSourceUpdateMode.OnPropertyChanged);
                IdListaMedicionControl.DataBindings.Add("SelectedValue", Model, "IdListaMedicion", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        private void IniciarCombos(int combo)
        {
            try
            {
                if (combo == 1)
                {
                    IdUnidaMedidaControl.DisplayMember = "Nombre";
                    IdUnidaMedidaControl.ValueMember = "IdUnidadMedida";
                }
                else if(combo == 2)
                {
                    IdListaMedicionControl.DisplayMember = "Nombre";
                    IdListaMedicionControl.ValueMember = "IdListaMedicion";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimpiarPropiedades()
        {
            try
            {
                Model.IdMedicion = 0;
                Model.IdUnidaMedida = 0;
                Model.IdListaMedicion = 0;
                Model.EsAbierta = false;
                Model.Nombre = string.Empty;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Medicion ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridMedicion.SelectedItems.Count == 1)
                {
                    return (Medicion)sfDataGridMedicion.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void FrmMedicionGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.GetAll();
                    var ListaMedicion = await Model.GetListaMedicionsAsync();
                    Model.LlenarListaMedicion(ListaMedicion);
                    var ListaUnidad = await Model.GetListaUnidadMedida();
                    Model.LlenarListaUnidadMedida(ListaUnidad);
                }, "Espere");
                IniciarBinding();
                Model.EsAbierta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Model.State = EntityState.Create;
                GroupMedicion.Enabled = true;
                pnlBotonesDatos.Enabled = true;
                LimpiarPropiedades();
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
                    GroupMedicion.Enabled = true;
                    pnlBotonesDatos.Enabled = true;
                    Model.State = EntityState.Update;
                    Model.IdMedicion = item.IdMedicion;
                    Model.IdUnidaMedida = item.IdUnidaMedida;
                    Model.IdListaMedicion = item.IdListaMedicion;
                    Model.Nombre = item.Nombre;
                    Model.EsAbierta = item.EsAbierta;
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                    GroupMedicion.Enabled = false;
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
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if(CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdMedicion = item.IdMedicion;
                        GroupMedicion.Enabled = false;
                        int result = 0;
                        result = await Model.Delete(CurrentSession.IdCuentaUsuario);
                        if(result > 0)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
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
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Model.IdListaMedicion = 0;
            IdListaMedicionControl.Enabled = (EsAbiertaControl.Checked) ? false : true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                GroupMedicion.Enabled = false;
                pnlBotonesDatos.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //btnGuardar.Enabled = false;
                pnlBotonesDatos.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(MedicionViewModel));
                var validation = Model.Validate();
                if (validation.IsValid)
                {
                    var resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (resul.IdMedicion > 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        GroupMedicion.Enabled = false;
                        await Model.GetAll();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(MedicionViewModel), validation);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                pnlBotonesDatos.Enabled = true;
            }
        }

        private async void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListaMedicion frmListaMedicion = new FrmListaMedicion(0);
                frmListaMedicion.ShowDialog();
                var ListaMedicion = await Model.GetListaMedicionsAsync();
                Model.LlenarListaMedicion(ListaMedicion);
                IdListaMedicionControl.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnEditarLista_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(IdListaMedicionControl, string.Empty);
                if (Model.IdListaMedicion > 0)
                {
                    FrmListaMedicion frmListaMedicion = new FrmListaMedicion(Model.IdListaMedicion);
                    frmListaMedicion.ShowDialog();
                    var ListaMedicion = await Model.GetListaMedicionsAsync();
                    Model.LlenarListaMedicion(ListaMedicion);
                    //LimpiarPropiedades();
                    IdListaMedicionControl.SelectedValue = 0;
                }
                else
                    errorProvider1.SetError(IdListaMedicionControl, "Debe seleccionar un valor de la lista");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void NombreControl_Leave(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(NombreControl, string.Empty);
                var result = await Model.ValidarNombre();
                if(result > 0)
                {
                    if (Model.IdMedicion > 0)
                    {
                        if(result != Model.IdMedicion)
                            errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                    }
                    else
                        errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            NombreControl.Text = NombreControl.Text.Replace("  ", " ");
            NombreControl.Select(NombreControl.Text.Length, 0);
        }

        private async void btnElimiarLista_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(IdListaMedicionControl, string.Empty);
                if (Model.IdListaMedicion > 0)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        var result = await Model.DeleteListaMedicion(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
                            var ListaMedicion = await Model.GetListaMedicionsAsync();
                            Model.LlenarListaMedicion(ListaMedicion);
                            IdListaMedicionControl.SelectedValue = 0;
                            LimpiarPropiedades();
                            await Model.GetAll();
                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                    }
                }
                else
                    errorProvider1.SetError(IdListaMedicionControl, "Debe seleccionar un valor de la lista");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
