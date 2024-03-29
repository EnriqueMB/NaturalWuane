﻿using CIDFares.Library.Code.Helpers;
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

            BtnNuevo.Visible = CurrentSession.PermisoUsuario("10");
            btnModificar.Visible = CurrentSession.PermisoUsuario("11");
            btnEliminar.Visible = CurrentSession.PermisoUsuario("12");
        }
        #endregion

        #region Botones
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                BtnNuevo.Enabled = false;
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
            finally
            {
                BtnNuevo.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                btnModificar.Enabled = false;
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
            finally
            {
                btnModificar.Enabled = true;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                btnEliminar.Enabled = false;
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnEliminar.Enabled = true;
            }
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            this.dataGridMain1.AutoGenerateColumns = false;
            dataGridMain1.DataBindings.Add("DataSource", Model, "ListaProducto", true, DataSourceUpdateMode.OnPropertyChanged);

            BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);
          
        }

        private  void CargarDatosAsync()
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.CargarDatos();
                    await Task.Delay(2000);
                }, "Espere");
               
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

        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                Buscar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoGrid ~ btnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            BusquedaControl.Text = String.Empty;
            CargarDatosAsync();
        }

        private async void Buscar()
        {
            try
            {
                errorProvider1.SetError(BusquedaControl, string.Empty);
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetBusqueda();
                    if (Model.ListaProducto.Count == 0)
                        CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                }
                else
                {
                    errorProvider1.SetError(BusquedaControl, "INGRESE EL CAMPO BUSQUEDA.");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleadoGrid ~ btnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void BusquedaControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleadoGrid ~ BusquedaControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }
    }
}
