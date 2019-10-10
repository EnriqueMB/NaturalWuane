using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static string PathAr = Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\Excel\Producto.xlsx");
        public static string Nombre = "Producto";
        #endregion
        #region Propiedades publicas

        #endregion
        public FrmInventarioTest()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<InventarioFisicoViewModel>();
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                //CIDWait.Show(async () =>
                //{
                    await Model.GetProducto(CurrentSession.IdSucursal, PathAr, Nombre);
                //    await Task.Delay(2000);
                //}, "Espere");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmInventarioTest ~ btnExportar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }


        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Importar(CurrentSession.IdSucursal, Nombre);
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmInventarioTest ~ btnImportar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}
