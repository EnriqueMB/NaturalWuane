using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
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
    public partial class FrmSucursalesGrid : Form
    {
        #region Propiedades
        public SucursalViewModel Model { get; set; }
        #endregion
        public FrmSucursalesGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<SucursalViewModel>();
        }

        #region Metodos
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

        private void IniciarBinding()
        {
            try
            {
                sfDataGrid1.AutoGenerateColumns = false;
                sfDataGrid1.DataBindings.Add("DataSource", Model, "ListaSucursales", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void FrmSucursalesGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                sfDataGrid1.ShowGroupDropArea = false;
                GetDataAsync();
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
                FrmSucursal frmSucursal = new FrmSucursal(0);
                frmSucursal.ShowDialog();
                frmSucursal.Dispose();
                GetDataAsync();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
