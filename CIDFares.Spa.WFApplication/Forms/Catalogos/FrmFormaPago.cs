using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
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
        #endregion

        #region Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                grpBoxFormaPago.Enabled = true;
                LimpiarPropiedades();
                Model.State = EntityState.Create;
                //this.CleanErrors(errorProviderNacionalidad, typeof(Nacionalidad));
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
                //this.CleanErrors(errorProviderNacionalidad, typeof(Nacionalidad));
                //var validationResults = Model.Datos.Validate();
                //validationResults.ToString();

                //if (validationResults.IsValid)
                //{
                //    var Resultado = await Model.GuardarCambios();
                //if (Resultado == 1)
                //{
                //    //CIDMessageBox.ShowAlert(Constants.SystemName, Constants.SuccessMessage, TypeMessage.correcto);
                //    grpBoxFormaPago.Enabled = false;
                //    LimpiarPropiedades();
                //    GridFromaPago.Refresh();
                //    await Model.GetAllAsync();
                //}
                //else
                //    //CIDMessageBox.ShowAlert(Constants.ErrorMessage, ObtenerMensajeError(Resultado), TypeMessage.error);
                //    MessageBox.Show("ERROR");
                //}
                //else
                //    this.ShowErrors(errorProviderNacionalidad, typeof(Nacionalidad), validationResults);

            }
            catch (Exception ex)
            {
                //LogError.AddExcFileTxt(ex, "FrmNacionalidad ~ btnGuardar_Click(object sender, EventArgs e)");
                //CIDMessageBox.ShowAlert(Constants.SystemName, Constants.ErrorMessage, TypeMessage.error);
            }

            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        #endregion
    }
}
