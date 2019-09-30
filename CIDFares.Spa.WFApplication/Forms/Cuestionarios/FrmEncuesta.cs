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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmEncuesta : Form
    {
        #region Propiedades
        public EncuestasViewModel Model  { get; set; }
        #endregion

        #region Constructor
        public FrmEncuesta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
        }
        #endregion

        #region Eventos
        private void FrmEncuesta_Load(object sender, EventArgs e)
        {
            try
            {               
                LlenarLista();
                iniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                Model.State = EntityState.Create;
                FrmNuevaEncuesta _NEncuesta = new FrmNuevaEncuesta();
                _NEncuesta.ShowDialog();
                _NEncuesta.Dispose();
                LlenarLista();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ BtnNuevaEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private async void BtnModificarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnModificarEncuesta.Enabled = false;
                Model.State = EntityState.Update;

                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.IdEncuesta = item.IdEncuesta;
                    var result =  await Model.ObtenerEncuestaXId();
                  
                    if (result != null)
                    {
                        FrmNuevaEncuesta _encuesta = new FrmNuevaEncuesta(result);
                        _encuesta.ShowDialog();
                        _encuesta.Dispose();

                        LlenarLista();
                    }                    
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                }

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ BtnModificarEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                this.btnModificarEncuesta.Enabled = true;
            }
        }
        private async void BtnEliminarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnEliminarEncuesta.Enabled = false;
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdUsuario = CurrentSession.IdCuentaUsuario;
                        Model.IdEncuesta = item.IdEncuesta;
                        var result = await Model.Remove();
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            LlenarLista();
                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ BtnEliminarEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                this.btnEliminarEncuesta.Enabled = true;
            }
        }
        #endregion

        #region Metodos
        public Cuestionario  ObtenerSeleccionado()
        {
            try
            {
                if (dtgEncuestas.SelectedItems.Count == 1)
                {
                    return (Cuestionario)dtgEncuestas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void iniciarBinding()
        {
            try
            {
                this.dtgEncuestas.AutoGenerateColumns = false;
                dtgEncuestas.DataBindings.Add("DataSource", Model, "_ListaEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ iniciarBinding()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        public void LlenarLista()
        {
            try
            {
                Model.LLenarListaEncuesta();
                this.dtgEncuestas.DataSource = Model._ListaEncuesta;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ LlenarLista()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        private  void FrmEncuesta_Shown(object sender, EventArgs e)
        {
            try
            {
                //CIDWait.Show(async () =>
                //{                   
                //    LlenarLista();
                //}, "Espere...");
                //iniciarBinding();
            }
            catch (Exception)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                this.Close();
            }
        }
    }
}
