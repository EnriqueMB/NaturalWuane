using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDMessageBox.Forms;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Usuarios
{
    public partial class FrmUsuario : Form
    {
        public UsuarioViewModel Model { get; set; }
        public FrmUsuario()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<UsuarioViewModel>();
        }

        #region Metodos

        private void IniciarBinding()
        {
            try
            {
                CuentaControl.DataBindings.Add("Text", Model, "Cuenta", true, DataSourceUpdateMode.OnPropertyChanged);
                PasswordControl.DataBindings.Add("Text", Model, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
                ContraseniaDosControl.DataBindings.Add("Text", Model, "ContraseniaDos", true, DataSourceUpdateMode.OnPropertyChanged);

                this.DataGridUsuario.AutoGenerateColumns = false;
                DataGridUsuario.DataBindings.Add("DataSource", Model, "ListaUsuario", true, DataSourceUpdateMode.OnPropertyChanged);

                


                IdRolControl.DataBindings.Add("SelectedValue", Model, "IdRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IdRolControl.DataBindings.Add("DataSource", Model, "ListaRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboRol();

                IdEmpleadoControl.DataBindings.Add("SelectedValue", Model, "IdEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);
                IdEmpleadoControl.DataBindings.Add("DataSource", Model, "ListaEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboEmpleado();

                checkBox1.DataBindings.Add("Checked", Model, "Modificar", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void IniciarComboRol()
        {
            try
            {
                IdRolControl.DisplayMember = "Nombre";
                IdRolControl.ValueMember = "IdRol";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarComboEmpleado()
        {
            try
            {
                IdEmpleadoControl.DisplayMember = "Nombres";
                IdEmpleadoControl.ValueMember = "IdEmpleado";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario ObtenerSeleccionado()
        {
            try
            {
                if (DataGridUsuario.SelectedItems.Count == 1)
                {
                    return (Usuario)DataGridUsuario.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LimpiarPropiedades()
        {
            Model.Cuenta = string.Empty;
            Model.Password = string.Empty;
            Model.ContraseniaDos = string.Empty;
            Model.IdRol = 0;
            Model.IdEmpleado = Guid.Empty;
            
        }

        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -1:
                        ErrorMessage = "LA CUENTA YA SE ENCUENTRA REGISTRADA";
                        break;
                    case -2:
                        ErrorMessage = "DESCONOCIDO";
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

        private void FrmUsuario_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    groupUsuario.Enabled = false;
                    await Model.LlenarListaRol();
                    await Model.LlenarListaEmpleado();
                    await Model.GetAll();
                    await Task.Delay(100);
                }, "Espere");
                this.IniciarBinding();

            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, "ERROR AL CARGAR LA INFORMACION.", TypeMessage.error);
                this.Close();
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Model.Modificar = true;
            checkBox1.Enabled = false;
            groupUsuario.Enabled = true;
            flowLayoutPanel1.Enabled = true;
            LimpiarPropiedades();
            Model.State = EntityState.Create;
            IdRolControl.SelectedValue = 0;
            this.CleanErrors(errorProviderUsuario, typeof(UsuarioViewModel));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordControl.Enabled = false;
                ContraseniaDosControl.Enabled = false;
                checkBox1.Enabled = true;
                Model.Modificar = false;
                this.CleanErrors(errorProviderUsuario, typeof(UsuarioViewModel));
                var item = ObtenerSeleccionado();
                if (item != null)
                {

                    Model.IdCuentaUsuario = item.IdCuentaUsuario;
                    Model.Cuenta = item.Cuenta;
                    //Model.Password = item.PasswordHash;
                    //Model.ContraseniaDos = item.ConstraseniaDos;
                    Model.IdRol = item.IdRol;
                    Model.IdEmpleado = item.IdEmpleado;
                    

                    groupUsuario.Enabled = true;
                    flowLayoutPanel1.Enabled = true;
                    Model.State = EntityState.Update;
                }
                else
                  CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

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

                   if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                   {
                        Model.IdCuentaUsuario= item.IdCuentaUsuario;
                        groupUsuario.Enabled = false;
                        var result = await Model.Remove(CurrentSession.IdCuentaUsuario);

                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            await Model.GetAll();
                        }
                     else
                           CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = true;
               
                this.CleanErrors(errorProviderUsuario, typeof(UsuarioViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                { 
                    Usuario Resultado = await Model.GuardarCambios();
                    
                   if (Resultado.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        groupUsuario.Enabled = false;
                        LimpiarPropiedades();
                        DataGridUsuario.Refresh();
                        await Model.GetAll();
                        btnGuardar.Enabled = false;
                    }
                   else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, ObtenerMensajeError(Resultado.Resultado), TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProviderUsuario, typeof(UsuarioViewModel), validationResults);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmUsuario ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);

            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                groupUsuario.Enabled = false;
                this.CleanErrors(errorProviderUsuario, typeof(UsuarioViewModel));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CuentaControl_TextChanged(object sender, EventArgs e)
        {
            var x = this.CuentaControl.SelectionStart;
            this.CuentaControl.Text = this.CuentaControl.Text.Replace("  ", " ");
            this.CuentaControl.SelectionStart = x;
        }

        private void PasswordControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
               
                PasswordControl.Enabled = true;
                ContraseniaDosControl.Enabled = true;
            }
            else if(checkBox1.Checked == false)
            {
             
                PasswordControl.Enabled = false;
                ContraseniaDosControl.Enabled = false;
                LimpiarPropiedades();
                
            }
        }
    }
}
