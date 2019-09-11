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
    public partial class FrmClaveTarjeta : Form
    {

        public string ClaveTarjeta { get; set; }
        public FrmClaveTarjeta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(ClaveTarjetaControl, string.Empty);
                if (!string.IsNullOrWhiteSpace(ClaveTarjetaControl.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    ClaveTarjeta = ClaveTarjetaControl.Text;
                    this.Close();
                }
                else
                    errorProvider1.SetError(ClaveTarjetaControl, "Ingrese la clave de la tarjeta");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
