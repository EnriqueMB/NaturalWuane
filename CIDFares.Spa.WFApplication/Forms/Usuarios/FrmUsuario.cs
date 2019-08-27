using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDMessageBox.Forms;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                this.DataGridUsuario.AutoGenerateColumns = false;
                DataGridUsuario.DataBindings.Add("DataSource", Model, "ListaUsuario", true, DataSourceUpdateMode.OnPropertyChanged);

                CuentaControl.DataBindings.Add("Text", Model, "Cuenta", true, DataSourceUpdateMode.OnPropertyChanged);
                ContraseniaControl.DataBindings.Add("Text", Model, "Contrasenia", true, DataSourceUpdateMode.OnPropertyChanged);
                ContraseniaDosControl.DataBindings.Add("Text", Model, "ContraseniaDos", true, DataSourceUpdateMode.OnPropertyChanged);


                IdRolControl.DataBindings.Add("SelectedValue", Model, "IdRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IdRolControl.DataBindings.Add("DataSource", Model, "ListaRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboRol();

                IdEmpleadoControl.DataBindings.Add("SelectedValue", Model, "IdEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);
                IdEmpleadoControl.DataBindings.Add("DataSource", Model, "ListaEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboEmpleado();
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
                IdEmpleadoControl.ValueMember =   "IdEmpleado";

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
            Model.Contrasenia = string.Empty;
            Model.ContraseniaDos = string.Empty;
            Model.IdRol = 0;
            Model.IdEmpleado = Guid.Empty;
            
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
                CIDMessageBox.ShowAlert(Messages.SystemName, "Error al cargar la informacion.", TypeMessage.error);
                this.Close();
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupUsuario.Enabled = true;
            flowLayoutPanel1.Enabled = true;
            LimpiarPropiedades();
            Model.State = EntityState.Create;
            IdRolControl.SelectedValue = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {

                    Model.IdCuentaUsuario = item.IdCuentaUsuario;
                    Model.Cuenta = item.Cuenta;
                    Model.Contrasenia = item.PasswordHash;
                    groupUsuario.Enabled = true;
                    flowLayoutPanel1.Enabled = true;
                    Model.State = EntityState.Update;
                }
               // else
               //   CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

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

                   // if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                   // {
                        Model.IdCuentaUsuario= item.IdCuentaUsuario;
                        groupUsuario.Enabled = false;
                        var result = await Model.Remove();


                        if (result == 1)
                        {
                            //CIDMessageBox.ShowAlert(Constants.SystemName, Constants.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            await Model.GetAll();
                        }
                //        else
                //            CIDMessageBox.ShowAlert(Constants.SystemName, Constants.ErrorDeleteMessage, TypeMessage.informacion);
                //    }
                }
                //else
                  //  CIDMessageBox.ShowAlert(Constants.SystemName, Constants.GridSelectMessage, TypeMessage.informacion);

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
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProviderUsuario, typeof(Usuario));
                //var validationResults = Model.Datos.Validate();
                //validationResults.ToString();

                //if (validationResults.IsValid)
                //{
                    var Resultado = await Model.GuardarCambios();
                   //if (Resultado)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        groupUsuario.Enabled = false;
                        LimpiarPropiedades();
                        DataGridUsuario.Refresh();
                        await Model.GetAll();
                   }
                   // else
                   //     CIDMessageBox.ShowAlert(Messages.ErrorMessage, ObtenerMensajeError(Resultado), TypeMessage.error);
                //}
                //else
                  //  this.ShowErrors(errorProviderNacionalidad, typeof(Usuario), validationResults);

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
                groupUsuario.Enabled = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
