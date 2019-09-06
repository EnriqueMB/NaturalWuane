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
    public partial class FrmServicio : Form
    {
        #region Propiedades Públicas
        public ServicioViewModel Model { get; set; }
        #endregion

        #region Constuctor
        public FrmServicio()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ServicioViewModel>();
            //IniciarBinding();
        }
        #endregion

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                //NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                //DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dgServicio.AutoGenerateColumns = false;
                dgServicio.DataBindings.Add("DataSource", Model, "ListaServicio", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -1:
                        ErrorMessage = "El nombre de la forma de pago ya se encuentra en los registros";
                        break;
                    case -2:
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

        private Servicio ObtenerSeleccionado()
        {
            try
            {
                if (dgServicio.SelectedItems.Count == 1)
                {
                    return (Servicio)dgServicio.SelectedItem;
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
                FrmServicioNuevo f = new FrmServicioNuevo();
                f.ShowDialog();
                Model.State = EntityState.Create;
                Model.GetAllAsync();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicio ~ btnNuevo_Click(object sender, EventArgs e)");                
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }                    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.State = EntityState.Update;
                    FrmServicioNuevo frn = new FrmServicioNuevo(ObtenerSeleccionado());
                    frn.ShowDialog();                    
                    Model.GetAllAsync();                                        
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicio ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
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
                        Model.IdServicio = item.IdServicio;
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            await Model.GetAllAsync();
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicio ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }       
        #endregion

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            Model.GetAllAsync();
        }
    }
}
