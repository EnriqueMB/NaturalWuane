using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
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

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmInventarioTest : Form
    {
        #region Propiedades privadas
        public InventarioFisicoViewModel Model { get; set; }
        #endregion
        #region Propiedades publicas

        #endregion
        public FrmInventarioTest()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<InventarioFisicoViewModel>();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ValidarExcel())
                //{
                    this.ExportarExcel();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void ExportarExcel()
        {
            try
            {
                this.btnExportar.Enabled = false;
                await Model.GetProducto(CurrentSession.IdSucursal);
         
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
