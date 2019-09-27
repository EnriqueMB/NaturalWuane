namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmNuevaConsultaControl
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEncuestas = new System.Windows.Forms.ComboBox();
            this.TipoConsultaControl = new System.Windows.Forms.ComboBox();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.ptbNuevoCliente = new System.Windows.Forms.PictureBox();
            this.ptbCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPreguntas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(816, 45);
            this.pnlTitulo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "NUEVA CONSULTA";
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnCancelarConsulta);
            this.FlpBotones.Controls.Add(this.btnNuevaConsulta);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 627);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(816, 74);
            this.FlpBotones.TabIndex = 10;
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarConsulta.BackColor = System.Drawing.Color.White;
            this.btnCancelarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnCancelarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarConsulta.Location = new System.Drawing.Point(663, 23);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(130, 28);
            this.btnCancelarConsulta.TabIndex = 15;
            this.btnCancelarConsulta.Text = "CANCELAR";
            this.btnCancelarConsulta.UseVisualStyleBackColor = false;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.BtnCancelarConsulta_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaConsulta.BackColor = System.Drawing.Color.White;
            this.btnNuevaConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaConsulta.Location = new System.Drawing.Point(527, 23);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(130, 28);
            this.btnNuevaConsulta.TabIndex = 15;
            this.btnNuevaConsulta.Text = "GUARDAR";
            this.btnNuevaConsulta.UseVisualStyleBackColor = false;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.BtnNuevaConsulta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEncuestas);
            this.panel1.Controls.Add(this.TipoConsultaControl);
            this.panel1.Controls.Add(this.btnOpciones);
            this.panel1.Controls.Add(this.ptbNuevoCliente);
            this.panel1.Controls.Add(this.ptbCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NombreCompleto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 100);
            this.panel1.TabIndex = 47;
            // 
            // cmbEncuestas
            // 
            this.cmbEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEncuestas.FormattingEnabled = true;
            this.cmbEncuestas.Location = new System.Drawing.Point(623, 33);
            this.cmbEncuestas.Name = "cmbEncuestas";
            this.cmbEncuestas.Size = new System.Drawing.Size(180, 26);
            this.cmbEncuestas.TabIndex = 54;
            this.cmbEncuestas.SelectedIndexChanged += new System.EventHandler(this.CmbEncuestas_SelectedIndexChanged);
            // 
            // TipoConsultaControl
            // 
            this.TipoConsultaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoConsultaControl.FormattingEnabled = true;
            this.TipoConsultaControl.Location = new System.Drawing.Point(314, 33);
            this.TipoConsultaControl.Name = "TipoConsultaControl";
            this.TipoConsultaControl.Size = new System.Drawing.Size(234, 26);
            this.TipoConsultaControl.TabIndex = 55;
            this.TipoConsultaControl.Visible = false;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpciones.BackColor = System.Drawing.Color.White;
            this.btnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.Black;
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.Location = new System.Drawing.Point(556, 33);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(27, 26);
            this.btnOpciones.TabIndex = 47;
            this.btnOpciones.Text = "+";
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Visible = false;
            this.btnOpciones.Click += new System.EventHandler(this.BtnOpciones_Click);
            // 
            // ptbNuevoCliente
            // 
            this.ptbNuevoCliente.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.plus35pxBlack;
            this.ptbNuevoCliente.Location = new System.Drawing.Point(235, 62);
            this.ptbNuevoCliente.Name = "ptbNuevoCliente";
            this.ptbNuevoCliente.Size = new System.Drawing.Size(35, 26);
            this.ptbNuevoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNuevoCliente.TabIndex = 52;
            this.ptbNuevoCliente.TabStop = false;
            this.ptbNuevoCliente.Visible = false;
            // 
            // ptbCliente
            // 
            this.ptbCliente.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.search35px;
            this.ptbCliente.Location = new System.Drawing.Point(197, 62);
            this.ptbCliente.Name = "ptbCliente";
            this.ptbCliente.Size = new System.Drawing.Size(35, 26);
            this.ptbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCliente.TabIndex = 53;
            this.ptbCliente.TabStop = false;
            this.ptbCliente.Visible = false;
            this.ptbCliente.Click += new System.EventHandler(this.PtbCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(620, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "ENCUESTAS A CONTESTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(311, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "TIPO DE CONSULTA";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "CLIENTE";
            this.label1.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompleto.Location = new System.Drawing.Point(17, 33);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Size = new System.Drawing.Size(253, 26);
            this.NombreCompleto.TabIndex = 48;
            this.NombreCompleto.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(762, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelPreguntas);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 482);
            this.panel2.TabIndex = 48;
            // 
            // PanelPreguntas
            // 
            this.PanelPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPreguntas.Location = new System.Drawing.Point(0, 0);
            this.PanelPreguntas.Name = "PanelPreguntas";
            this.PanelPreguntas.Size = new System.Drawing.Size(816, 443);
            this.PanelPreguntas.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 39);
            this.panel3.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(43, 14);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "label4";
            this.lblError.Visible = false;
            // 
            // FrmNuevaConsultaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "FrmNuevaConsultaControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaConsulta";
            this.Load += new System.EventHandler(this.FrmNuevaConsultaControl_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEncuestas;
        private System.Windows.Forms.ComboBox TipoConsultaControl;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.PictureBox ptbNuevoCliente;
        private System.Windows.Forms.PictureBox ptbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCompleto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPreguntas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
    }
}