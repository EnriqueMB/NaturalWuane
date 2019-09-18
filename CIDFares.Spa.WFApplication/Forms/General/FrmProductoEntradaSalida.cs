using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmProductoEntradaSalida : Form
    {
        public EntradaSalidaAlmacenViewModel Model { get; set; }
        public Producto producto { get; set; }
        public FrmProductoEntradaSalida()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EntradaSalidaAlmacenViewModel>();
            producto = new Producto();
        }
        #region Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsp, int wparam, int lparam);
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmOutMessageChild) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmProductoEntradaSalida_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosAsync();
                IniciarBinding();
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoEntradaSalida_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                Close();
            }
        }
        #region Metodos
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

        public void IniciarBinding()
        {
            this.sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataBindings.Add("DataSource", Model, "ListaProducto", true, DataSourceUpdateMode.OnPropertyChanged);

            BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Producto ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (Producto)sfDataGrid1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetBusqueda();
                    //sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                     errorProvider1.SetError(BusquedaControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 200 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProductoEntradaSalida ~ pictureBox1_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void sfDataGrid1_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    producto = item;
                    this.Close();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorACompra ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
