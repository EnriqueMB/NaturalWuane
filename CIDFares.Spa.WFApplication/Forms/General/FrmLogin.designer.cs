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
            this.LblError = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserPasswordControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.UserAccountControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.LblVersionSistema = new System.Windows.Forms.Label();
            this.LblDerechoReservado = new System.Windows.Forms.Label();
            this.BtnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelImagenMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPasswordControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccountControl)).BeginInit();
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
            this.PanelImagenMovimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelImagenMovimiento.BackColor = System.Drawing.Color.White;
            this.PanelImagenMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelImagenMovimiento.Controls.Add(this.LblError);
            this.PanelImagenMovimiento.Controls.Add(this.panel1);
            this.PanelImagenMovimiento.Controls.Add(this.UserPasswordControl);
            this.PanelImagenMovimiento.Controls.Add(this.UserAccountControl);
            this.PanelImagenMovimiento.Controls.Add(this.LblCerrar);
            this.PanelImagenMovimiento.Controls.Add(this.LblVersionSistema);
            this.PanelImagenMovimiento.Controls.Add(this.LblDerechoReservado);
            this.PanelImagenMovimiento.Controls.Add(this.BtnLogin);
            this.PanelImagenMovimiento.Controls.Add(this.pictureBox1);
            this.PanelImagenMovimiento.Location = new System.Drawing.Point(-4, -16);
            this.PanelImagenMovimiento.Name = "PanelImagenMovimiento";
            this.PanelImagenMovimiento.Size = new System.Drawing.Size(388, 661);
            this.PanelImagenMovimiento.TabIndex = 11;
            this.PanelImagenMovimiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelImagenMovimiento_MouseDown);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.LinkColor = System.Drawing.Color.Silver;
            this.LblError.Location = new System.Drawing.Point(135, 518);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(115, 13);
            this.LblError.TabIndex = 37;
            this.LblError.TabStop = true;
            this.LblError.Text = "Olvide mi contraseña";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 10);
            this.panel1.TabIndex = 34;
            // 
            // UserPasswordControl
            // 
            this.UserPasswordControl.BeforeTouchSize = new System.Drawing.Size(269, 27);
            this.UserPasswordControl.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.UserPasswordControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPasswordControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UserPasswordControl.Location = new System.Drawing.Point(63, 380);
            this.UserPasswordControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.UserPasswordControl.Name = "UserPasswordControl";
            this.UserPasswordControl.PasswordChar = '*';
            this.UserPasswordControl.Size = new System.Drawing.Size(269, 27);
            this.UserPasswordControl.TabIndex = 33;
            // 
            // UserAccountControl
            // 
            this.UserAccountControl.BeforeTouchSize = new System.Drawing.Size(269, 27);
            this.UserAccountControl.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.UserAccountControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserAccountControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UserAccountControl.Location = new System.Drawing.Point(63, 307);
            this.UserAccountControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.UserAccountControl.Name = "UserAccountControl";
            this.UserAccountControl.Size = new System.Drawing.Size(269, 27);
            this.UserAccountControl.TabIndex = 32;
            // 
            // LblCerrar
            // 
            this.LblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCerrar.BackColor = System.Drawing.Color.Silver;
            this.LblCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.LblCerrar.Location = new System.Drawing.Point(151, 566);
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
            this.LblVersionSistema.BackColor = System.Drawing.Color.White;
            this.LblVersionSistema.ForeColor = System.Drawing.Color.Black;
            this.LblVersionSistema.Location = new System.Drawing.Point(184, 637);
            this.LblVersionSistema.Name = "LblVersionSistema";
            this.LblVersionSistema.Size = new System.Drawing.Size(0, 13);
            this.LblVersionSistema.TabIndex = 30;
            // 
            // LblDerechoReservado
            // 
            this.LblDerechoReservado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDerechoReservado.AutoSize = true;
            this.LblDerechoReservado.BackColor = System.Drawing.Color.White;
            this.LblDerechoReservado.ForeColor = System.Drawing.Color.Black;
            this.LblDerechoReservado.Location = new System.Drawing.Point(38, 619);
            this.LblDerechoReservado.Name = "LblDerechoReservado";
            this.LblDerechoReservado.Size = new System.Drawing.Size(309, 13);
            this.LblDerechoReservado.TabIndex = 25;
            this.LblDerechoReservado.Text = "Impulsado por CID Fares® - Todos los derechos reservados";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(99)))));
            this.BtnLogin.BeforeTouchSize = new System.Drawing.Size(154, 33);
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.IsBackStageButton = false;
            this.BtnLogin.Location = new System.Drawing.Point(116, 454);
            this.BtnLogin.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(154, 33);
            this.BtnLogin.TabIndex = 26;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.ThemeName = "Metro";
            this.BtnLogin.UseVisualStyle = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.Recurso_10_3x;
            this.pictureBox1.Location = new System.Drawing.Point(101, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 630);
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
        private Syncfusion.Windows.Forms.ButtonAdv BtnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LblError;
    }
}