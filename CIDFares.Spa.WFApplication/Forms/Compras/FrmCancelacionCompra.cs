using CIDFares.Library.Controls.CIDMessageBox.Code;
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
    public partial class FrmCancelacionCompra : Form
    {
        public string Motivo { get; set; }
        public FrmCancelacionCompra()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.MotivoControl.Text))
                {
                    Motivo = this.MotivoControl.Text;
                    this.Close();
                }
                else
                    errorProvider1.SetError(MotivoControl, "INGRESE EL MOTIVO DE LA CANCELACIÓN");
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, "ESTA SEGURO DESEA CERRAR EL FORMULARIO DE CANCELACIÓN.") == DialogResult.OK)
                    this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
