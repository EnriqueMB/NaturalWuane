using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmPaquete : Form
    {
        #region Propiedades Publicas
        public PaqueteViewModel Model { get; set; }
        #endregion

        #region Constructor

        public FrmPaquete()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Model.IdUsuarioL = CurrentSession.IdCuentaUsuario;
        }

        #endregion

        #region Metodos

        private void IniciarBinding()
        {
            try
            {
                this.sfDataGridPaquete.AutoGenerateColumns = false;
                sfDataGridPaquete.DataBindings.Add("DataSource", Model, "ListaPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Paquetes ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridPaquete.SelectedItems.Count == 1)
                {
                    return (Paquetes)sfDataGridPaquete.SelectedItem;
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
        private async void FrmPaquete_Load(object sender, EventArgs e)
        {
            try
            {
                await Model.GetAll();
                this.IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaquete ~ FrmPaquete_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
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
                        Model.IdPaquete = item.IdPaquete;
                        var result = await Model.DeleteAsync();
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
                            await Model.GetAll();
                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaquete ~  btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        #endregion

        private async void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPaqueteNuevo frmPaqueteNuevo = new FrmPaqueteNuevo();
                frmPaqueteNuevo.ShowDialog();
                await Model.GetAll();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaquete ~ BtnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    FrmPaqueteNuevo frmPaqueteNuevo = new FrmPaqueteNuevo(item);
                    frmPaqueteNuevo.ShowDialog();
                    await Model.GetAll();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaquete ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}
