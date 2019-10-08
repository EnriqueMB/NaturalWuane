using System;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.WFApplication.Constants;
using System.Windows.Forms;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Session;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurnoPrincipal : Form
    {
        public TurnoPrincipalViewModel Model { get; set; }

        public FrmTurnoPrincipal()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<TurnoPrincipalViewModel>();
        }
        private void IniciarBinding()
        {
            try
            {
                GridNombresTurnos.AutoGenerateColumns = false;
                GridNombresTurnos.DataBindings.Add("DataSource", Model, "ListaTurno", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void FrmTurnoPrincipal_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () => {
                    await Model.GetListaTurno();
                }, "Espere");
                
                IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTurno Turno = new FrmTurno(0);
                Turno.ShowDialog();
                GetDataAsync();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleadoGrid ~ BtnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Turno item = ObtenerSeleccionado();
                if (item != null)
                {
                    FrmTurno frmTurno = new FrmTurno(item.IdTurno);
                    frmTurno.ShowDialog();
                    frmTurno.Dispose();
                    GetDataAsync();
                }
                else
                    CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetDataAsync()
        {
            try
            {
                CIDWait.Show(async () => {
                    await Model.GetListaTurno();
                }, "Espere");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                Model.IdTurno = item.IdTurno;
                if (item != null)
                {
                    if (Model.IdTurno == 1 || Model.IdTurno == 2 || Model.IdTurno == 3)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.NoEliminarTurno, TypeMessage.error);
                    }
                    else
                    {
                        if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                        {
                            //Model.IdTurno = item.IdTurno;
                            int result = 0;
                            result = await Model.Delete(CurrentSession.IdCuentaUsuario);
                            if (result > 0)
                            {
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
                                await Model.GetListaTurno();
                                //await Model.GetAllAsync();
                            }
                            else
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                        }
                    }
                    //NoEliminarTurno
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
            }
        }

        private Turno ObtenerSeleccionado()
        {
            try
            {
                if (GridNombresTurnos.SelectedItems.Count == 1)
                {
                    return (Turno)GridNombresTurnos.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
