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
    public partial class FrmBaseBTN : Form
    {
        public FrmBaseBTN()
        {
            InitializeComponent();
        }

        private void btnBusqueda_MouseHover(object sender, EventArgs e)
        {
            this.btnBusqueda.FlatAppearance.BorderColor = Color.FromArgb(46, 166, 48);
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 166, 48);
        }

        private void btnBusqueda_MouseLeave(object sender, EventArgs e)
        {
            this.btnBusqueda.FlatAppearance.BorderColor = Color.Black;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(46, 166, 48);
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 166, 48);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.FlatAppearance.BorderColor = Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = Color.White;
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            this.btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 166, 48);
            this.btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            this.btnNuevo.FlatAppearance.MouseOverBackColor = Color.White;
            this.btnNuevo.ForeColor = Color.Black;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            this.btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 166, 48);
            this.btnModificar.ForeColor = Color.White;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.btnModificar.FlatAppearance.MouseOverBackColor = Color.White;
            this.btnModificar.ForeColor = Color.Black;
        }
    }
}
