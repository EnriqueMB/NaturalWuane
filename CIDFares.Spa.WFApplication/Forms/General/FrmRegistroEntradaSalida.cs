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
    public partial class FrmRegistroEntradaSalida : Form
    {
        #region propiedades publicas
        public RegistroEntradaSalidaViewModel Model { get; set; }
        #endregion

        #region Tipp Combo

        private class Tipo
        {
            public string Nombre { get; set; }
            public String Id { get; set; }
            public Tipo(string N, string I)
            {
                Nombre = N;
                Id = I;
            }
        }
        #endregion
        #region constructor
        public FrmRegistroEntradaSalida()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<RegistroEntradaSalidaViewModel>();
            Model.Pass = true;
            //Model.Codigo = true;

        }
        #endregion
        #region metodos
        public void Iniciarbinding()
        {
            CodigoBarraControl.DataBindings.Add("Text", Model, "CodigoBarra", true, DataSourceUpdateMode.OnPropertyChanged);
            TipoControl.DataBindings.Add("SelectedValue", Model, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombo();
        }

        public void IniciarCombo()
        {
            try
            {
                List<Tipo> ListaTipo = new List<Tipo>();
                ListaTipo.Add(new Tipo("SELECCIONE", "S"));
                ListaTipo.Add(new Tipo("ENTRADA", "ENTRADA"));
                ListaTipo.Add(new Tipo("SALIDA", "SALIDA"));

                TipoControl.DataSource = ListaTipo;

                TipoControl.DisplayMember = "Nombre";
                TipoControl.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void LimpiarPropiedades()
        {
            Model.CodigoBarra = string.Empty;
            Model.Tipo ="S";
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistroEntradaSalida_Load(object sender, EventArgs e)
        {
            try
            {
              
                Iniciarbinding();
            }
            catch (Exception ex )
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmRegistroEntradaSalida ~ FrmRegistroEntradaSalida_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(RegistroEntradaSalidaViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    Guid Resultado = await Model.VerificarCodigoBarra();
                    if (Resultado != Guid.Empty)
                    {
                        
                        FrmRegistroPasswordEmpleado registro = new FrmRegistroPasswordEmpleado(Resultado,Model.Tipo);
                        registro.ShowDialog();
                        registro.Close();
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
        
    }
}
