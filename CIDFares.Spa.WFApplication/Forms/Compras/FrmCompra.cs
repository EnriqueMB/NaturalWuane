using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
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
    public partial class FrmCompra : Form
    {

        public ProveedorACompraViewModel Model { get; set; }
        public FrmCompra()
        {
            InitializeComponent();
        }

        private  void bntnAgregarProvedor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProveedorACompra producto = new FrmProveedorACompra();
                producto.ShowDialog();
                //var x = await Model.Proveedor(Model.IdProveedorTemp);
                this.Np.Text = producto.Model.NombreProveedor;

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCompra ~ bntnAgregarProvedor_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
