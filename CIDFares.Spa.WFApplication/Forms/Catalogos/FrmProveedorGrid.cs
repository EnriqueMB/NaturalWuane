using CIDFares.Library.Code.Extensions;
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

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmProveedorGrid : Form
    {
        public ProveedorViewModel Model { get; set; }
        public Proveedor Datos { get; set; }
        public FrmProveedorGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProveedorViewModel>();

            btnNuevo.Visible = CurrentSession.PermisoUsuario("13");
            btnModificar.Visible = CurrentSession.PermisoUsuario("14");
            btnEliminar.Visible = CurrentSession.PermisoUsuario("15");
        }

        #region Metodos

        private void IniciarBinding()
        {
            try
            {
                this.DataGridProveedor.AutoGenerateColumns = false;
                DataGridProveedor.DataBindings.Add("DataSource", Model, "ListaBuscarProveedor", true, DataSourceUpdateMode.OnPropertyChanged);
                
                BuscarControl.DataBindings.Add("Text", Model, "Buscar", true, DataSourceUpdateMode.OnPropertyChanged);
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
                    await Model.GetAll();
                    await Task.Delay(1000);
                }, "Espere");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        private Proveedor ObtenerSeleccionado()
        {
            try
            {
                if (DataGridProveedor.SelectedItems.Count == 1)
                {
                    return (Proveedor)DataGridProveedor.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.Buscar))
                {
                    await Model.GetBusqueda();      
                }
                else
                {
                    errorGridProveedor.SetError(BuscarControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 200 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorGrid ~ btnBuscar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void FrmProveedorGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    DataGridProveedor.Refresh();
                    await Model.GetAll();
                    
                    await Task.Delay(100);
                }, "Espere");
                this.IniciarBinding();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProveedor proveedor = new FrmProveedor();
                proveedor.ShowDialog();
                //DataGridProveedor.Refresh();
                await Model.GetAll();
                Model.State = EntityState.Create;
                this.CleanErrors(errorGridProveedor, typeof(ProveedorViewModel));

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorGrid ~ BtnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void BuscarControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor item = ObtenerSeleccionado();
                if (item != null)
                {

                    FrmProveedor Proveedor = new FrmProveedor(item.IdProveedor);
                    Proveedor.ShowDialog();
                    Proveedor.Dispose();
                    GetDataAsync();

                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorGrid ~ btnModificar_Click(object sender, EventArgs e)");
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
                        Model.IdProveedor = item.IdProveedor;
                        var result = await Model.Remove(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            await Model.GetAll();
                    
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorGrid ~ btnEliminar_Click_1(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
