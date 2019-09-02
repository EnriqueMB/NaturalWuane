using CIDFares.Spa.WFApplication.Forms.Catalogos;
using CIDFares.Spa.WFApplication.Forms.Usuarios;
using CIDFares.Spa.WFApplication.Forms.Ventas;
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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
            frmCliente.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
            frmUsuario.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFormaPago frmFormaPago = new FrmFormaPago();
            frmFormaPago.ShowDialog();
            frmFormaPago.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSucursalesGrid frmSucursalesGrid = new FrmSucursalesGrid();
            frmSucursalesGrid.ShowDialog();
            frmSucursalesGrid.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
            frmVenta.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmProductoGrid frmProductoGrid = new FrmProductoGrid();
            frmProductoGrid.ShowDialog();
            frmProductoGrid.Dispose();
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmProveedorGrid frmProveedorGrid = new FrmProveedorGrid();
            frmProveedorGrid.ShowDialog();
            frmProveedorGrid.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmServicio frmServicio = new FrmServicio();
            frmServicio.ShowDialog();
            frmServicio.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmCategoriaProducto fcp = new FrmCategoriaProducto();
            fcp.ShowDialog();
            fcp.Dispose();
        }
    }
}
