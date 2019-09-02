namespace CIDFares.Spa.WFApplication.Forms.General
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bannerTextProvider = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelImagenMovimiento = new System.Windows.Forms.Panel();
            this.UserPasswordControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.UserAccountControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.LblVersionSistema = new System.Windows.Forms.Label();
            this.LblDerechoReservado = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblError = new System.Windows.Forms.Label();
            this.BtnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelImagenMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPasswordControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccountControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // PanelImagenMovimiento
            // 
            this.PanelImagenMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.PanelImagenMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelImagenMovimiento.Controls.Add(this.UserPasswordControl);
            this.PanelImagenMovimiento.Controls.Add(this.UserAccountControl);
            this.PanelImagenMovimiento.Controls.Add(this.LblCerrar);
            this.PanelImagenMovimiento.Controls.Add(this.LblVersionSistema);
            this.PanelImagenMovimiento.Controls.Add(this.LblDerechoReservado);
            this.PanelImagenMovimiento.Controls.Add(this.pictureBox3);
            this.PanelImagenMovimiento.Controls.Add(this.pictureBox2);
            this.PanelImagenMovimiento.Controls.Add(this.LblError);
            this.PanelImagenMovimiento.Controls.Add(this.BtnLogin);
            this.PanelImagenMovimiento.Controls.Add(this.pictureBox1);
            this.PanelImagenMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImagenMovimiento.Location = new System.Drawing.Point(0, 0);
            this.PanelImagenMovimiento.Name = "PanelImagenMovimiento";
            this.PanelImagenMovimiento.Size = new System.Drawing.Size(388, 538);
            this.PanelImagenMovimiento.TabIndex = 11;
            this.PanelImagenMovimiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelImagenMovimiento_MouseDown);
            // 
            // UserPasswordControl
            // 
            this.UserPasswordControl.BeforeTouchSize = new System.Drawing.Size(210, 22);
            this.UserPasswordControl.Location = new System.Drawing.Point(113, 302);
            this.UserPasswordControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.UserPasswordControl.Name = "UserPasswordControl";
            this.UserPasswordControl.PasswordChar = '*';
            this.UserPasswordControl.Size = new System.Drawing.Size(210, 22);
            this.UserPasswordControl.TabIndex = 33;
            // 
            // UserAccountControl
            // 
            this.UserAccountControl.BeforeTouchSize = new System.Drawing.Size(210, 22);
            this.UserAccountControl.Location = new System.Drawing.Point(113, 247);
            this.UserAccountControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.UserAccountControl.Name = "UserAccountControl";
            this.UserAccountControl.Size = new System.Drawing.Size(210, 22);
            this.UserAccountControl.TabIndex = 32;
            // 
            // LblCerrar
            // 
            this.LblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.LblCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.LblCerrar.Location = new System.Drawing.Point(156, 462);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(82, 22);
            this.LblCerrar.TabIndex = 31;
            this.LblCerrar.Text = "Cerrar";
            this.LblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // LblVersionSistema
            // 
            this.LblVersionSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblVersionSistema.AutoSize = true;
            this.LblVersionSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.LblVersionSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(143)))), ((int)(((byte)(101)))));
            this.LblVersionSistema.Location = new System.Drawing.Point(6, 520);
            this.LblVersionSistema.Name = "LblVersionSistema";
            this.LblVersionSistema.Size = new System.Drawing.Size(0, 13);
            this.LblVersionSistema.TabIndex = 30;
            // 
            // LblDerechoReservado
            // 
            this.LblDerechoReservado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDerechoReservado.AutoSize = true;
            this.LblDerechoReservado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.LblDerechoReservado.ForeColor = System.Drawing.Color.White;
            this.LblDerechoReservado.Location = new System.Drawing.Point(34, 499);
            this.LblDerechoReservado.Name = "LblDerechoReservado";
            this.LblDerechoReservado.Size = new System.Drawing.Size(310, 13);
            this.LblDerechoReservado.TabIndex = 25;
            this.LblDerechoReservado.Text = "Impulsado por CID Fares® - Todos los derechos reservados";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.pictureBox3.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.PasswordL2;
            this.pictureBox3.Location = new System.Drawing.Point(72, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.pictureBox2.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.UsuarioL2;
            this.pictureBox2.Location = new System.Drawing.Point(72, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // LblError
            // 
            this.LblError.BackColor = System.Drawing.Color.Transparent;
            this.LblError.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.LblError.Location = new System.Drawing.Point(105, 334);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(210, 38);
            this.LblError.TabIndex = 27;
            this.LblError.Text = "Recuperar contraseña";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblError.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(99)))));
            this.BtnLogin.BeforeTouchSize = new System.Drawing.Size(154, 33);
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.IsBackStageButton = false;
            this.BtnLogin.Location = new System.Drawing.Point(127, 390);
            this.BtnLogin.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(132)))), ((int)(((byte)(51)))));
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(154, 33);
            this.BtnLogin.TabIndex = 26;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.ThemeName = "Metro";
            this.BtnLogin.UseVisualStyle = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(88, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(33)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 538);
            this.ControlBox = false;
            this.Controls.Add(this.PanelImagenMovimiento);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PanelImagenMovimiento.ResumeLayout(false);
            this.PanelImagenMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPasswordControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccountControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel PanelImagenMovimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UserPasswordControl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UserAccountControl;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Label LblVersionSistema;
        private System.Windows.Forms.Label LblDerechoReservado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblError;
        private Syncfusion.Windows.Forms.ButtonAdv BtnLogin;
    }
}