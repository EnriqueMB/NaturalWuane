using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
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
    public partial class FrmAlimentoNuevo : Form
    {
        #region Propiedades Públicas
        public AlimentoViewModels Model { get; set; }
        #endregion

        /// <summary>
        /// Constructor que resive como parametro un id
        /// en el cual si el id es mayor a cero es porque
        /// es una modificación
        /// </summary>
        /// <param name="IdAlimento"></param>
        public FrmAlimentoNuevo(int IdAlimento)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<AlimentoViewModels>();
            if(IdAlimento > 0)
            {
                Model.IdAlimento = IdAlimento;
                Model.State = EntityState.Update;
            }
            else
            {
                Model.State = EntityState.Create;
            }
        }
        
        /// <summary>
        /// Inicia los Bindig de los campos del formulario
        /// </summary>
        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text",Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                
                IniciarCombo();
                IdTipoAlimentoControl.DataBindings.Add("DataSource", Model, "ListaTipoAlimentos", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoAlimentoControl.DataBindings.Add("SelectedValue", Model, "IdTipoAlimento", true, DataSourceUpdateMode.OnPropertyChanged);

                CaloriasControl.DataBindings.Add("Text", Model, "Calorias", true, DataSourceUpdateMode.OnPropertyChanged);
                HidratosControl.DataBindings.Add("Text", Model, "HidratosCarbono", true, DataSourceUpdateMode.OnPropertyChanged);
                ProteinasControl.DataBindings.Add("Text", Model, "Proteina",true, DataSourceUpdateMode.OnPropertyChanged);
                GrasasControl.DataBindings.Add("Text", Model, "Grasa", true, DataSourceUpdateMode.OnPropertyChanged);
                FibrasControl.DataBindings.Add("Text", Model, "Fibra", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para asignarle las propiedades del comboTipoAlimento
        /// las propiedades del model bindeados.
        /// </summary>
        private void IniciarCombo()
        {
            try
            {
                IdTipoAlimentoControl.DisplayMember = "Nombre";
                IdTipoAlimentoControl.ValueMember = "IdTipoAlimento";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Se carga los campos y el combo segun si es
        /// modificar o un nuevo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FrmAlimentoNuevo_Shown(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();

                if (Model.State == EntityState.Update)
                {
                    
                    CIDWait.Show(async () =>
                    {
                        await Model.GetAllAsyncXId(Model.IdAlimento);
                        lblTitulo.Text = "Modificar Alimento";
                    }, "Cargando registro");
                }
                else
                {
                    lblTitulo.Text = "Agregar Alimento";
                }
               CIDWait.Show(async () =>
                {
                    var lista = await Model.GetListaTipo();
                    Model.LlenarTipoAlimento(lista);

                }, "Espere");
                IniciarBinding();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Limpia las propiedades para deshacerse de cualquier dato ingresado.
        /// </summary>
        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = string.Empty;
                Model.Calorias = 0;
                Model.HidratosCarbono = 0;
                Model.Proteina = 0;
                Model.Grasa = 0;
                Model.Fibra = 0;
                Model.IdTipoAlimento = 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Guarda los cambios que se hayan modificado en el formulario o los nuevos que
        /// se agregaron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(error, typeof(AlimentoViewModels));
                var a = CaloriasControl.Text;
                var b = HidratosControl.Text;
                var ValidationsResult = Model.Validate();
                if(ValidationsResult.IsValid)
                {
                    var result = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (result.IdAlimento > 0)
                    {
                        CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.SuccessMessage, TypeMessage.correcto);
                        Close();
                    }
                    else
                        CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(error, typeof(AlimentoViewModels), ValidationsResult);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoNuevo ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        /// <summary>
        /// Cierra el formulario sin guardar ningún cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Constants.Messages.SystemName, Constants.Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoNuevo ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorAlCancelarFrm, TypeMessage.error);
            }
        }
    }
}
