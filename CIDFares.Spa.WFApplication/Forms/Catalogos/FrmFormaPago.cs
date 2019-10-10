using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmFormaPago : Form
    {
        #region Propiedades Públicas
        public FormaPagoViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmFormaPago()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<FormaPagoViewModel>();
            grpBoxFormaPago.Enabled = false;
            IniciarBinding();

            btnNuevo.Visible = CurrentSession.PermisoUsuario("7");
            btnModificar.Visible = CurrentSession.PermisoUsuario("8");
            btnEliminar.Visible = CurrentSession.PermisoUsuario("9");

            pnlDatos.Visible = CurrentSession.PermisoUsuario("7,8");

        }
        #endregion
        
        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

                this.GridFromaPago.AutoGenerateColumns = false;
                GridFromaPago.DataBindings.Add("DataSource", Model, "ListaFormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LimpiarPropiedades()
        {
            Model.IdFormaPago = 0;
            Model.Nombre = string.Empty;
            Model.Descripcion = string.Empty;
        }

        private FormaPago ObtenerSeleccionado()
        {
            try
            {
                if (GridFromaPago.SelectedItems.Count == 1)
                {
                    return (FormaPago)GridFromaPago.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                grpBoxFormaPago.Enabled = true;
                LimpiarPropiedades();
                Model.State = EntityState.Create;
                this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
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
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                FormaPago Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                if (Resultado.Resultado == 1)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                    grpBoxFormaPago.Enabled = false;
                    LimpiarPropiedades();
                    GridFromaPago.Refresh();
                    await Model.GetAllAsync();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.ErrorMessage, ObtenerMensajeError(Resultado.Resultado), TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(FormaPagoViewModel), validationResults);

        }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }

            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
                    Model.IdFormaPago = item.IdFormaPago;
                    Model.Nombre = item.Nombre;
                    Model.Descripcion = item.Descripcion;
                    grpBoxFormaPago.Enabled = true;
                    Model.State = EntityState.Update;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {

                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdFormaPago = item.IdFormaPago;
                        grpBoxFormaPago.Enabled = false;
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
                            await Model.GetAllAsync();
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Constants.Messages.SystemName, Constants.Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    grpBoxFormaPago.Enabled = false;
                    LimpiarPropiedades();
                    this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorAlCancelarFrm, TypeMessage.error);
            }
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            var x = this.NombreControl.SelectionStart;
            this.NombreControl.Text = this.NombreControl.Text.Replace("  ", " ");
            //this.NombreControl.Select(this.NombreControl.Text.Length, 0);
            this.NombreControl.SelectionStart = x;
            //this.NombreControl.Text = this.NombreControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "");
            //this.NombreControl.Text = this.NombreControl.Text.ToUpper();
            //this.DescripcionControl.Text.Length;
        }

        private void DescripcionControl_TextChanged(object sender, EventArgs e)
        {
            var x = this.DescripcionControl.SelectionStart;
            this.DescripcionControl.Text = this.DescripcionControl.Text.Replace("  ", " ");
            this.DescripcionControl.Select(this.DescripcionControl.Text.Length, 0);
            this.DescripcionControl.SelectionStart = x;
        }

        //private void DrawToolTip(object sender, DrawToolTipEventArgs e)
        //{
        //    e.DrawBackground();
        //    e.DrawBorder();
        //    e.DrawText();
        //    e.Graphics.DrawLine(Pens.Transparent, 0, e.Bounds.Height - 4, e.Bounds.Width, e.Bounds.Height - 4);
        //}
        #endregion
        
    }
}
