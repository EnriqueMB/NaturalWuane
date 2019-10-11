using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.WinForms.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmMedicionGrid : Form
    {
        #region Propiedades Publicas
        public MedicionViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmMedicionGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<MedicionViewModel>();
            Model.Page = -1;
            Model.Opcion = 1;
            this.btnEditarLista.FlatAppearance.BorderSize = 1;
            this.btnElimiarLista.FlatAppearance.BorderSize = 1;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 1;
        }
        #endregion

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

        private void CargarGrid()
        {
            try
            {
                
                    if (Model.Opcion == 1)
                        Model.Page++;
                    CIDWait.Show(async () =>
                    {
                        await Model.GetAll();
                    }, "Espere");
                
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
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridMedicion.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged += X_ValueChanged;
                CargarGrid();
                CIDWait.Show(async () =>
                {
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ FrmMedicionGrid_Shown(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Evento que detecta cada movimiento del Scroll Vertical del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Syncfusion.WinForms.DataGrid.TableControl tableControl = sfDataGridMedicion.TableControl;
                if (tableControl.VerticalScroll.Value + tableControl.VerticalScroll.LargeChange == tableControl.VerticalScroll.Maximum)
                {
                    if (!Model.PaginaMaxima)
                    {
                        Model.Opcion = 1;
                        CargarGrid();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "No hay mas registros", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ X_ValueChanged(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridMedicion.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
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
                            Model.Opcion = 2;
                            CargarGrid();
                            x.ValueChanged += X_ValueChanged;
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnEliminar_Click(object sender, EventArgs e)");
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
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    LimpiarPropiedades();
                    GroupMedicion.Enabled = false;
                    pnlBotonesDatos.Enabled = false;
                }
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
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridMedicion.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
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
                        Model.Opcion = 2;
                        CargarGrid();
                        x.ValueChanged += X_ValueChanged;
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(MedicionViewModel), validation);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnGuardar_Click(object sender, EventArgs e)");
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnEditarLista_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private async void NombreControl_Leave(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = true;
                errorProvider1.SetError(NombreControl, string.Empty);
                var result = await Model.ValidarNombre();
                if(result > 0)
                {
                    if (Model.IdMedicion > 0)
                    {
                        if (result != Model.IdMedicion)
                        {
                            btnGuardar.Enabled = false;
                            errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                        }
                    }
                    else
                    {
                        btnGuardar.Enabled = false;
                        errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                    }
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
                errorProvider1.SetError(btnElimiarLista, string.Empty);
                if (Model.IdListaMedicion > 0)
                {
                    var ListaOcupada = Model.ListaMedicion.Where(m => m.IdListaMedicion == Model.IdListaMedicion).Select(u => u.IdListaMedicion).ToList();
                    if (ListaOcupada.Count == 0)
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
                        errorProvider1.SetError(btnElimiarLista, "No puede borrar la lista por que se esta usando");
                }
                else
                    errorProvider1.SetError(IdListaMedicionControl, "Debe seleccionar un valor de la lista");
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnEliminarLista_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        private void pnlBotonesDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
