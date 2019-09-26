using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Catalogos;
using CIDFares.Spa.WFApplication.Forms.Compras;
using CIDFares.Spa.WFApplication.Forms.Cuestionarios;
using CIDFares.Spa.WFApplication.Forms.Usuarios;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmHomePage : Form
    {
        #region Variables Globales
        int X, Y;
        #endregion
        public FrmHomePage()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Pnl_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmOutMessage) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            try
            {
                Maximizar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                Maximizar();
                BotonesPerfil();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnBarNav_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnl_MenuVertical.Width == 214)
                {
                    pnl_MenuVertical.Width = 57;
                    pb_img.Size = new Size(52, 34);
                    pb_img.Location = new Point(3, 40);
                    pnl_opciones.Visible = false;
                    pb_DotNavegacion.Visible = true;
                }
                else
                {
                    pnl_MenuVertical.Width = 214;
                    pb_img.Size = new Size(168, 77);
                    pb_img.Location = new Point(23, 40);
                    pnl_opciones.Visible = true;
                    pb_DotNavegacion.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PbMenu_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = "MENÚ";
                pbMenu.Visible = false;
                SlidePanelNomina.Visible = false;
                SlidePanelgenerales.Visible = false;
                pnlMenuPrincipal.BringToFront();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnEstructura_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = "CATALOGO";
                pbMenu.Visible = true;
                pnlCatalogo.BringToFront();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnGenerales_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = "GENERALES";
                pbMenu.Visible = true;
                pnlGenerales.BringToFront();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Pb_img_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel_MenuEmpleado.Visible = true;
                for (int i = 1; i < pnl_Contenedor.Controls.Count; i++)
                {
                    pnl_Contenedor.Controls.RemoveAt(i);

                    lblTitulo.Text = "MENÚ";
                    pbMenu.Visible = false;
                    SlidePanelNomina.Visible = false;
                    SlidePanelgenerales.Visible = false;
                    pnlMenuPrincipal.BringToFront();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Click de Catalogos
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnCliente);
            GetPanel(new FrmCliente());
        }
        private void BtnServicio_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnServicio);
            GetPanel(new FrmServicio());
        }

        private void BtnFormaPago_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnFormaPago);
            GetPanel(new FrmFormaPago());
        }

        private void BtnSucursal_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnSucursal);
            GetPanel(new FrmSucursalesGrid());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnProveedor);
            GetPanel(new FrmProveedorGrid());
        }
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnCategoria);
            GetPanel(new FrmCategoriaProducto());
        }
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnProducto);
            GetPanel(new FrmProductoGrid());
        }

        private void BtnPaquete_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnPaquete);
            GetPanel(new FrmPaquete());
        }
        #endregion

        #region Eventos click de Generales
        private void BtnVenta_Click(object sender, EventArgs e)
        {
            SlideGenerales(btnVenta);
            GetPanel(new FrmVenta());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            SlideGenerales(btnCompras);
            GetPanel(new FrmCompra());
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            SlideGenerales(btnUsuario);
            GetPanel(new FrmUsuario());
        }

        private void BtnCuestionario_Click(object sender, EventArgs e)
        {
            SlideGenerales(btnCuestionario);
            GetPanel(new FrmEncuesta());
        }
        private void BtnMonedero_Click(object sender, EventArgs e)
        {
            SlideGenerales(btnMonedero);
            GetPanel(new FrmProductosMonedero());
        }
        #endregion

        #endregion

        #region Metodos

        #region Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsp, int wparam, int lparam);
        #endregion

        #region metodo para abrir formularios dentro del panel principal
        private void GetPanel(object Formhijo)
        {
            try
            {
                if (this.pnl_Contenedor.Controls.Count > 0)
                {
                    //this.pnl_Contenedor.Controls.RemoveAt(0);
                    this.Panel_MenuEmpleado.Visible = false;
                    for (int i = 1; i < pnl_Contenedor.Controls.Count; i++)
                    {
                        pnl_Contenedor.Controls.RemoveAt(i);
                    }
                }
                Form Fchild = Formhijo as Form;
                Fchild.TopLevel = false;
                Fchild.Dock = DockStyle.Fill;
                this.pnl_Contenedor.Controls.Add(Fchild);
                this.pnl_Contenedor.Tag = Fchild;
                Fchild.Dock = DockStyle.Fill;
                Fchild.Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Botones para permisos de usuario
        private void BotonesPerfil()
        {
            EnabledButton(btnCategoria, CurrentSession.PermisoUsuario("1,2,3"));
            EnabledButton(btnCliente, CurrentSession.PermisoUsuario("4,5,6"));
            EnabledButton(btnFormaPago, CurrentSession.PermisoUsuario("7,8,9"));
            EnabledButton(btnProducto, CurrentSession.PermisoUsuario("10,11,12"));
            EnabledButton(btnProveedor, CurrentSession.PermisoUsuario("13,14,15"));
            EnabledButton(btnServicio, CurrentSession.PermisoUsuario("16,17,18"));
            EnabledButton(btnSucursal, CurrentSession.PermisoUsuario("19,20,21"));
            EnabledButton(btnUsuario, CurrentSession.PermisoUsuario("22,23,24"));
            EnabledButton(btnVenta, CurrentSession.PermisoUsuario("25"));
            EnabledButton(btnCompras, CurrentSession.PermisoUsuario("26"));
            EnabledButton(btnPermiso, CurrentSession.PermisoUsuario("27"));
        }

        private void EnabledButton(Button boton, bool permiso)
        {
            boton.Enabled = permiso;
        }
        #endregion

        public void Maximizar()
        {
            try
            {
                X = Location.X;
                Y = Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.btnMaximizar.Visible = false;
                this.btnRestaurar.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      

        public void Restaurar()
        {
            try
            {
                Size = new Size(1280, 720);        
                this.CenterToScreen();
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SlideCatalogo(Button button)
        {
            slidePanelCatalogo.Visible = true;
            slidePanelCatalogo.Height = button.Height;
            slidePanelCatalogo.Top = button.Top;
        }

        private void SlideUsuarios(Button button)
        {
            slidePanelUsuarios.Visible = true;
            slidePanelUsuarios.Height = button.Height;
            slidePanelUsuarios.Top = button.Top;
        }
        private void BtnPermiso_Click(object sender, EventArgs e)
        {
            SlideUsuarios(btnPermiso);
            GetPanel(new FrmReglasPerfil());
            BotonesPerfil();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = "USUARIOS";
                pbMenu.Visible = true;
                pnlUsuarios.BringToFront();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            SlideCatalogo(btnEmpleado);
            GetPanel(new FrmEmpleadoGrid());
        }

        private void btnEntradaSalida_Click(object sender, EventArgs e)
        {
            try
            {
                SlideCatalogo(btnEntradaSalida);
                FrmRegistroEntradaSalida registro = new FrmRegistroEntradaSalida();
                registro.ShowDialog();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        private void SlideGenerales(Button button)
        {
            SlidePanelgenerales.Visible = true;
            SlidePanelgenerales.Height = button.Height;
            SlidePanelgenerales.Top = button.Top;
        }
        #endregion
    }
}
