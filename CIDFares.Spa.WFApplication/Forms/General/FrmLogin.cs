using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmLogin : MetroForm
    {
        public LoginViewModel Model { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<LoginViewModel>();
        }

        #region Metodos
        private void AbrirFormHome()
        {
            try
            {
                this.Visible = false;
                var HomeForm = new Form1();
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
                    case -5:
                        ErrorMessage = "La cuenta de usuario no existe.";
                        break;
                    case -7:
                        ErrorMessage = "La contraseña es incorrecta.";
                        break;
                    case -6:
                        ErrorMessage = "La cuenta fue bloqueada por número de intentos.";
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
                var x = await Model.Login();
                if(x == 1)
                {
                    AbrirFormHome();
                    this.UserAccountControl.Text = string.Empty;
                    this.UserPasswordControl.Text = string.Empty;
                }
                else
                {
                    LblError.Visible = true;
                    LblError.Text = ObtenerMensajeError(x);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
