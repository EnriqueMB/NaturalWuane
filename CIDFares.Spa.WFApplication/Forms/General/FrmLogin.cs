using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using CIDFares.Library.Code.Extensions;

using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmLogin : MetroForm
    {
        #region Propiedades
        public LoginViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<LoginViewModel>();
        }
        #endregion

        #region Metodos
        private void GuardarSession()
        {
            try
            {
                CurrentSession.IdCuentaUsuario = Model.IdCuentaUsuario;
                CurrentSession.IdRol = Model.IdRol;
                CurrentSession.IdEmpleado = Model.IdEmpleado;
                CurrentSession.Nombres = Model.Nombres;
                CurrentSession.IdTurnoEmpleado = Model.IdTurnoEmpleado;
                CurrentSession.ReglasUsuario = Model.ReglaUsuario;
                CurrentSession.IdSucursal = Model.IdSucursal;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void AbrirFormHome()
        {
            try
            {
                this.Visible = false;
                var HomeForm = new FrmHomeD();
                HomeForm.ShowDialog();
                HomeForm.Dispose();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AbrirFormHome2()
        {
            try
            {
                this.Visible = false;
                var HomeForm = new FrmHomePage();
                HomeForm.ShowDialog();
                HomeForm.Dispose();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void IniciarPlaceholder()
        {
            try
            {
                BannerTextInfo placeholderUsuario = bannerTextProvider.GetBannerText(UserAccountControl);
                placeholderUsuario.Text = "Usuario";
                placeholderUsuario.Visible = true;
                placeholderUsuario.Mode = BannerTextMode.EditMode;

                BannerTextInfo placeholderPassword = bannerTextProvider.GetBannerText(UserPasswordControl);
                placeholderPassword.Text = "Contraseña";
                placeholderPassword.Visible = true;
                placeholderPassword.Mode = BannerTextMode.EditMode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void IniciarBinding()
        {
            try
            {
                UserAccountControl.DataBindings.Add("Text", Model, "UserAccount", true, DataSourceUpdateMode.OnPropertyChanged);
                UserPasswordControl.DataBindings.Add("Text", Model, "UserPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string ObtenerMensajeError(int? Error)
        {
            try
            {
                //string ErrorMessage = Constants.LoginErrorMessage;
                string ErrorMessage = "FAVOR DE VERIFICAR BIEN SUS CREDENCIALES";
                switch (Error)
                {
                    case 9:
                        ErrorMessage = "La cuenta de usuario no existe.";
                        break;
                    case 7:
                        ErrorMessage = "La contraseña es incorrecta.";
                        break;
                    case 8:
                        ErrorMessage = "La cuenta fue bloqueada por número de intentos.";
                        break;
                    case 10:
                        ErrorMessage = "La cuenta no esta asignada a un empleado";
                        break;
                }
                return ErrorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region MoverFrom
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelImagenMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Eventos
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            IniciarPlaceholder();
            IniciarBinding();
            this.LblVersionSistema.Text = "Version 1.0";
            this.LblDerechoReservado.Text = "Impulsado por CID Fares® - Todos los derechos reservados " + DateTime.Now.Year.ToString();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LblError.Visible = false;
                this.CleanErrors(errorProvider1, typeof(LoginViewModel));
                var validationResults = Model.Validate();
                if (validationResults.IsValid)
                {
                    BtnLogin.Enabled = false;
                    var x = await Model.Login();
                    if (x == 1)
                    {
                        GuardarSession();
                        if (CurrentSession.PermisoUsuario("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27"))
                        {
                            AbrirFormHome2();
                            this.UserAccountControl.Text = string.Empty;
                            this.UserPasswordControl.Text = string.Empty;
                        }
                        else
                        {
                            LblError.Visible = true;
                            LblError.Text = "EL USUARIO NO TIENE PERMISO PARA ACCEDER AL SISTEMA.";
                        }
                    }
                    else
                    {
                        LblError.Visible = true;
                        LblError.Text = ObtenerMensajeError(x);
                    }
                }else
                    this.ShowErrors(errorProvider1, typeof(LoginViewModel), validationResults);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BtnLogin.Enabled = true;
            }
        }
        #endregion

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserPasswordControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.Focus();
                BtnLogin_Click(sender, e);
            }
        }
    }
}
