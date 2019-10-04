using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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
    public partial class Apruebas : Form
    {
        public InventarioFisicoViewModel Model { get; set; }

        private static string Nombre = "Producto";
        private static string PathAr = Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\Excel\Producto.xlsx");
        public Apruebas()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<InventarioFisicoViewModel>();
        }

        private async void EXPORTTAR_Click(object sender, EventArgs e)
        {
            try
            { 
                
                await Model.GetProducto(CurrentSession.IdSucursal, PathAr, Nombre);
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "Apruebas ~ EXPORTTAR_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
//--------------------------------------------------IMPORTAR EXCEL ---------------------------------------------
        private  void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                 Model.Importar(CurrentSession.IdSucursal,Nombre);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
    }
}

