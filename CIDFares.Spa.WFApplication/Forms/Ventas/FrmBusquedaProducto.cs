using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmBusquedaProducto : Form
    {
        #region Propiedades Públicas
        public BusquedaProductoViewModel Model { get; set; }
        #endregion

        public FrmBusquedaProducto()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<BusquedaProductoViewModel>();
            IniciarBinding();
        }

        private async void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.BuscaClaveCodigo == true || Model.BuscarNombre == true)
                {
                    await Model.GetAll();
                }

               
                if (!string.IsNullOrEmpty(Model.BusquedaNombre))
                {

                }
                else
                {
                    errorProvider1.SetError(NombreControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 200 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void IniciarBinding()
        {
            try
            {
                BusqueNombreControl.DataBindings.Add("Checked", Model, "BuscarNombre", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "BusquedaNombre", true, DataSourceUpdateMode.OnPropertyChanged);
                BuquedaClaveCodigoControl.DataBindings.Add("Text", Model, "BusquedaClaveCodigo", true, DataSourceUpdateMode.OnPropertyChanged);
                BusClaveBarraControl.DataBindings.Add("Checked", Model, "BuscaClaveCodigo", true, DataSourceUpdateMode.OnPropertyChanged);
                this.sfDataGridBuquedaProducto.AutoGenerateColumns = false;
                sfDataGridBuquedaProducto.DataBindings.Add("DataSource", Model, "ListaBusquedaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BusqueNombreControl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //if (Model.BuscarNombre == true)
                //{
                //    BusClaveBarraControl.Enabled = false;
                //    BuquedaClaveCodigoControl.Enabled = false;
                //}
                //else
                //{
                //    Model.BuscaClaveCodigo = true;
                //    BusClaveBarraControl.Enabled = true;
                //    BuquedaClaveCodigoControl.Enabled = true;
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
