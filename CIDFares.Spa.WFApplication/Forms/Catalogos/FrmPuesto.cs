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
    public partial class FrmPuesto : Form
    {
        #region Porpiedades Públicas
        public PuestoViewModels model { get; set; }
        #endregion

        #region Constructor
        public FrmPuesto()
        {
            InitializeComponent();
            model = ServiceLocator.Instance.Resolve<PuestoViewModels>();
            groupBoxPuesto.Enabled = false;
            IniciarBinding();
        }
        #endregion

        #region Metodos Generales

        /// <summary>
        /// Inicializa el binding de cada una de las propiedades que se utilizan en el formulario.
        /// </summary>
        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

                this.sfDataGridPuesto.AutoGenerateColumns = false;
                sfDataGridPuesto.DataBindings.Add("DataSource", model, "ListaPuesto", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para obtener el tipo de error.
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -2:
                        ErrorMessage = "El nombre del puesto ya se encuentra en los registros";
                        break;
                    default:
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

        /// <summary>
        /// Limpiamos las propiedades.
        /// </summary>
        public void LimpiarPropiedades()
        {
            try
            {
                model.IdPuesto = 0;
                model.Nombre = string.Empty;
                model.Descripcion = string.Empty;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Obtenermos la información de la fila seleccionada.
        /// </summary>
        /// <returns></returns>
        private Puesto ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridPuesto.SelectedItems.Count == 1)
                {
                    return (Puesto)sfDataGridPuesto.SelectedItem;
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

        /// <summary>
        /// Método para agregar un nuevo puesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPuesto.Enabled = true;
                LimpiarPropiedades();
                model.State = EntityState.Create;
                this.CleanErrors(errorProvider , typeof(PuestoViewModels));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Método asíncrono para guardar un nuervo puesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider, typeof(PuestoViewModels));
                var validationResults = model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    Puesto Resultado = await model.ACPuesto(CurrentSession.IdCuentaUsuario);
                    if (Resultado.IdPuesto > 0 )
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        groupBoxPuesto.Enabled = false;
                        LimpiarPropiedades();
                        sfDataGridPuesto.Refresh();
                        await model.GetAllAsync();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, ObtenerMensajeError(Resultado.IdPuesto),  TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider, typeof(PuestoViewModels), validationResults);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPuesto ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }

            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        /// <summary>
        /// Método para cancelar el guardado o actualización de un puesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPuesto.Enabled = false;
                LimpiarPropiedades();
                this.CleanErrors(errorProvider, typeof(Puesto));
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
                var itemPuesto = ObtenerSeleccionado();
                if (itemPuesto != null)
                {
                    this.CleanErrors(errorProvider, typeof(PuestoViewModels));
                    model.IdPuesto = itemPuesto.IdPuesto;
                    model.Nombre = itemPuesto.Nombre;
                    model.Descripcion = itemPuesto.Descripcion.Trim();
                    groupBoxPuesto.Enabled = true;
                    model.State = EntityState.Update;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPuesto ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var itemPuesto = ObtenerSeleccionado();
                if (itemPuesto != null)
                {

                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        model.IdPuesto = itemPuesto.IdPuesto;
                        groupBoxPuesto.Enabled = false;
                        var result = await model.DeletePuesto(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LimpiarPropiedades();
                            this.CleanErrors(errorProvider, typeof(PuestoViewModels));
                            await model.GetAllAsync();
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPuesto ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion
    }
}
