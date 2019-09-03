using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    public partial class FrmProveedorACompra : Form
    {

        #region Propiedades privadas
        public ProveedorACompraViewModel Model { get; set; }
        #endregion

        #region propiedades publicas

        #endregion

        #region eventos
        public FrmProveedorACompra()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProveedorACompraViewModel>();
        }

        private void FrmProveedorACompra_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosAsync();
                IniciarBinding();
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorACompra_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                Close();
            }
        }
        #endregion


        #region Metodos
        private void IniciarBinding()
        {
            this.sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataBindings.Add("DataSource", Model, "ListaProveedorACompra", true, DataSourceUpdateMode.OnPropertyChanged);

           BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);

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

        private ProveedorACompra ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (ProveedorACompra)sfDataGrid1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetBusqueda();
                    
                }
                else
                {
                    errorProvider1.SetError(BusquedaControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 100 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedorACompra ~ btnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            BusquedaControl.Text = string.Empty;
            CargarDatosAsync();
        }

        

        private void sfDataGrid1_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {


                    Model.IdProveedorTemp = item.IdProveedor;
                    Model.NombreProveedor = item.NombreComercial;

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
