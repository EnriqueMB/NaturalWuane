using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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
                FormaPago Resultado = await Model.GuardarCambios();
                if (Resultado.Resultado == 1)
                {
                    //CIDMessageBox.ShowAlert(Constants.SystemName, Constants.SuccessMessage, TypeMessage.correcto);
                    grpBoxFormaPago.Enabled = false;
                    LimpiarPropiedades();
                    GridFromaPago.Refresh();
                    await Model.GetAllAsync();
                }
                else
                    //CIDMessageBox.ShowAlert(Constants.ErrorMessage, ObtenerMensajeError(Resultado), TypeMessage.error);
                    MessageBox.Show("ERROR");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    //this.CleanErrors(errorProviderNacionalidad, typeof(Nacionalidad));
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

                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                //if (item != null)
                //{

                //    if (CIDMessageBox.ShowAlertRequest(Constants.SystemName, Constants.ConfirmDeleteMessage) == DialogResult.OK)
                //    {
                //        Model.Datos.idNacionalidad = item.IdNacionalidad;
                //        grpBoxNacionalidad.Enabled = false;
                //        var result = await Model.Remove();
                //        if (result == 1)
                //        {
                //            CIDMessageBox.ShowAlert(Constants.SystemName, Constants.SuccessDeleteMessage, TypeMessage.informacion);
                //            LimpiarPropiedades();
                //            await Model.GetAllBinding();
                //        }
                //        else
                //            CIDMessageBox.ShowAlert(Constants.SystemName, Constants.ErrorDeleteMessage, TypeMessage.informacion);
                //    }
                //}
                //else
                //    CIDMessageBox.ShowAlert(Constants.SystemName, Constants.GridSelectMessage, TypeMessage.informacion);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
