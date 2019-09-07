using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmEncuesta : Form
    {
        #region Constructor
        public FrmEncuesta()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void BtnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNuevaEncuesta _NEncuesta = new FrmNuevaEncuesta();
                _NEncuesta.ShowDialog();
                _NEncuesta.Dispose();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEncuesta ~ BtnNuevaEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        #endregion

        #region Metodos

        #endregion
    }
}
