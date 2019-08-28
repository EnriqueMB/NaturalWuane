using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDMessageBox.Forms;
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
    public partial class FrmProductoGrid : Form
    {
        #region Propiedades Publicas

        public ProductoViewModel Model { get; set; }

         public FrmMessageBox mensaje { get; set; }

        #endregion

        #region Constructor
        public FrmProductoGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
            //BtnNuevo.Enabled = CurrentSession.PermisoUsuario("30");
            //btnModificar.Enabled = CurrentSession.PermisoUsuario("31");
            //BtnAgregarUnidad.Enabled = CurrentSession.PermisoUsuario("32");
            //btnEliminar.Enabled = CurrentSession.PermisoUsuario("33");
        }
        #endregion

        #region Botones
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProducto producto = new FrmProducto();
                producto.ShowDialog();
                Model.State = EntityState.Create;
                CargarDatosAsync();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid ~ BtnNuevo_Click(object sender, EventArgs e)");
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

                    FrmProducto Producto = new FrmProducto(item.IdProducto);
                    Producto.ShowDialog();
                    Model.State = EntityState.Update;
                    CargarDatosAsync();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid ~ btnModificar_Click(object sender, EventArgs e)");
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

                        Model.IdProducto = item.IdProducto;
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);

                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            CargarDatosAsync();
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid ~ btnEliminar_Click_1(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            this.dataGridMain1.AutoGenerateColumns = false;
            dataGridMain1.DataBindings.Add("DataSource", Model, "ListaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void CargarDatosAsync()
        {
            try
            {
                //CIDWait.Show(async () =>
                //{
                //    await Model.CargarDatos();
                //    await Task.Delay(2000);
                //}, "Espere");
                await Model.CargarDatos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Producto ObtenerSeleccionado()
        {
            try
            {
                if (dataGridMain1.SelectedItems.Count == 1)
                {
                    return (Producto)dataGridMain1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void FrmProductoGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                CargarDatosAsync();
                IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid_Shown(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                Close();
            }
        }
    }
}
