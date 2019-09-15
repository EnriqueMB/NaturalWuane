using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
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

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmRegistroPasswordEmpleado : Form
    {
        #region propiedades publicas
        public RegistroEntradaSalidaViewModel Model { get; set; }
        #endregion

        public FrmRegistroPasswordEmpleado(Guid IdEmpleado, string Tipo)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<RegistroEntradaSalidaViewModel>();
            Model.Pass = true;
            //Model.Codigo = false;
            Model.IdEmpleado = IdEmpleado;
            Model.Tipo = Tipo;
        }

        #region metodos
        public void Iniciarbinding()
        {
            PasswordControl.DataBindings.Add("Text", Model, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }
        public void LimpiarPropiedades()
        {
            Model.Password = string.Empty;
           
        }
        #endregion
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(RegistroEntradaSalidaViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    //Model.IdEmpleado = Model.IdEmpleado;
                    var Resultado = await Model.Registrar();
                    if (Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        this.Close();

                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        LimpiarPropiedades();

                    }
                }
                else
                    this.ShowErrors(errorProvider1, typeof(RegistroEntradaSalidaViewModel), validationResults);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmRegistroEntradaSalida ~ btnRegistrar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistroPasswordEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                Model.Pass = false;
                Model.Codigo = true;
                Iniciarbinding();
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmRegistroPasswordEmpleado ~ FrmRegistroPasswordEmpleado_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}
