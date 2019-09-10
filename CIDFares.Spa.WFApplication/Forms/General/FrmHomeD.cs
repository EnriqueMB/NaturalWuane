using CIDFares.Spa.WFApplication.Forms.Catalogos;
using CIDFares.Spa.WFApplication.Forms.Compras;
using CIDFares.Spa.WFApplication.Forms.Usuarios;
using CIDFares.Spa.WFApplication.Forms.Ventas;
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
    public partial class FrmHomeD : Form
    {
        public FrmHomeD()
        {
            InitializeComponent();
            BotonesPerfil();
        }

        private void BotonesPerfil()
        {
            //btnCategoria.Enabled = CurrentSession.PermisoUsuario("1,2,3");
            EnabledButton(btnCategoria, CurrentSession.PermisoUsuario("1,2,3"));
            EnabledButton(btnCliente, CurrentSession.PermisoUsuario("4,5,6"));
            EnabledButton(btnFormaPago, CurrentSession.PermisoUsuario("7,8,9"));
            EnabledButton(btnProducto, CurrentSession.PermisoUsuario("10,11,12"));
            EnabledButton(btnProveedor, CurrentSession.PermisoUsuario("13,14,15"));
            EnabledButton(btnServicio, CurrentSession.PermisoUsuario("16,17,18"));
            EnabledButton(btnSucursale, CurrentSession.PermisoUsuario("19,20,21"));
            EnabledButton(btnUsuario,CurrentSession.PermisoUsuario("22,23,24"));
            EnabledButton(btnVenta,CurrentSession.PermisoUsuario("25"));
            EnabledButton(btnCompras,CurrentSession.PermisoUsuario("26"));

            btnConfiguracion.Visible = CurrentSession.PermisoUsuario("27");
            EnabledButton(btnPermisos,CurrentSession.PermisoUsuario("27"));
        }

        private void EnabledButton(Button boton, bool permiso)
        {
            boton.BackColor = Color.White;
            boton.Enabled = permiso;
            if (permiso == false)
            {
                boton.BackColor = Color.WhiteSmoke;
            }
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompra = new FrmCompra();
            frmCompra.ShowDialog();
            frmCompra.Dispose();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if(panelConfiguracion.Visible)
            panelConfiguracion.Visible = false;
            else
                panelConfiguracion.Visible = true;
            
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            FrmReglasPerfil frmReglas = new FrmReglasPerfil();
            frmReglas.ShowDialog();
            frmReglas.Dispose();
            BotonesPerfil();
            panelConfiguracion.Visible = false;
        }
    }
}
