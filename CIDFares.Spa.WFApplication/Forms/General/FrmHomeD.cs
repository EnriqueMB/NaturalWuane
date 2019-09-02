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
    public partial class FrmHomeD : Form
    {
        public FrmHomeD()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
            frmCliente.Dispose();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductoGrid frmProductoGrid = new FrmProductoGrid();
            frmProductoGrid.ShowDialog();
            frmProductoGrid.Dispose();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedorGrid frmProveedorGrid = new FrmProveedorGrid();
            frmProveedorGrid.ShowDialog();
            frmProveedorGrid.Dispose();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriaProducto frmCategoriaProducto = new FrmCategoriaProducto();
            frmCategoriaProducto.ShowDialog();
            frmCategoriaProducto.Dispose();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            FrmServicio frmServicio = new FrmServicio();
            frmServicio.ShowDialog();
            frmServicio.Dispose();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
            frmUsuario.Dispose();
        }

        private void btnFormaPago_Click(object sender, EventArgs e)
        {
            FrmFormaPago frmFormaPago = new FrmFormaPago();
            frmFormaPago.ShowDialog();
            frmFormaPago.Dispose();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
            frmVenta.Dispose();
        }

        private void btnSucursale_Click(object sender, EventArgs e)
        {
            FrmSucursalesGrid frmSucursalesGrid = new FrmSucursalesGrid();
            frmSucursalesGrid.ShowDialog();
            frmSucursalesGrid.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
