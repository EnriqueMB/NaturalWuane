namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmAgregarPregunta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PreguntaControl = new System.Windows.Forms.TextBox();
            this.btnGuardarPregunta = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultiple = new System.Windows.Forms.RadioButton();
            this.rbSiNo = new System.Windows.Forms.RadioButton();
            this.checkMultipleRespuesta = new System.Windows.Forms.CheckBox();
            this.rbAbierta = new System.Windows.Forms.RadioButton();
            this.checkDepende = new System.Windows.Forms.CheckBox();
            this.cmbPreguntas = new System.Windows.Forms.ComboBox();
            this.lblcmb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtSi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "PREGUNTA";
            // 
            // PreguntaControl
            // 
            this.PreguntaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreguntaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaControl.Location = new System.Drawing.Point(16, 40);
            this.PreguntaControl.Multiline = true;
            this.PreguntaControl.Name = "PreguntaControl";
            this.PreguntaControl.Size = new System.Drawing.Size(539, 121);
            this.PreguntaControl.TabIndex = 5;
            this.PreguntaControl.TextChanged += new System.EventHandler(this.TxtPreguntas_TextChanged);
            this.PreguntaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreguntaControl_KeyPress);
            // 
            // btnGuardarPregunta
            // 
            this.btnGuardarPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGuardarPregunta.FlatAppearance.BorderSize = 0;
            this.btnGuardarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPregunta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPregunta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPregunta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPregunta.Location = new System.Drawing.Point(428, 418);
            this.btnGuardarPregunta.Name = "btnGuardarPregunta";
            this.btnGuardarPregunta.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarPregunta.TabIndex = 16;
            this.btnGuardarPregunta.Text = "GUARDAR";
            this.btnGuardarPregunta.UseVisualStyleBackColor = false;
            this.btnGuardarPregunta.Click += new System.EventHandler(this.BtnGuardarPregunta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbMultiple);
            this.groupBox1.Controls.Add(this.rbSiNo);
            this.groupBox1.Controls.Add(this.checkMultipleRespuesta);
            this.groupBox1.Controls.Add(this.rbAbierta);
            this.groupBox1.Location = new System.Drawing.Point(16, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 87);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREGUNTAS";
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Location = new System.Drawing.Point(394, 27);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(78, 17);
            this.rbMultiple.TabIndex = 1;
            this.rbMultiple.Text = "MULTIPLE";
            this.rbMultiple.UseVisualStyleBackColor = true;
            this.rbMultiple.CheckedChanged += new System.EventHandler(this.CheckMultipleRespuesta_CheckedChanged);
            // 
            // rbSiNo
            // 
            this.rbSiNo.AutoSize = true;
            this.rbSiNo.Location = new System.Drawing.Point(234, 27);
            this.rbSiNo.Name = "rbSiNo";
            this.rbSiNo.Size = new System.Drawing.Size(56, 17);
            this.rbSiNo.TabIndex = 1;
            this.rbSiNo.Text = "SI/NO";
            this.rbSiNo.UseVisualStyleBackColor = true;
            // 
            // checkMultipleRespuesta
            // 
            this.checkMultipleRespuesta.AutoSize = true;
            this.checkMultipleRespuesta.Location = new System.Drawing.Point(394, 50);
            this.checkMultipleRespuesta.Name = "checkMultipleRespuesta";
            this.checkMultipleRespuesta.Size = new System.Drawing.Size(147, 17);
            this.checkMultipleRespuesta.TabIndex = 19;
            this.checkMultipleRespuesta.Text = "MULTIPLE RESPUESTA";
            this.checkMultipleRespuesta.UseVisualStyleBackColor = true;
            this.checkMultipleRespuesta.Visible = false;
            this.checkMultipleRespuesta.CheckedChanged += new System.EventHandler(this.CheckMultipleRespuesta_CheckedChanged);
            // 
            // rbAbierta
            // 
            this.rbAbierta.AutoSize = true;
            this.rbAbierta.Checked = true;
            this.rbAbierta.Location = new System.Drawing.Point(65, 27);
            this.rbAbierta.Name = "rbAbierta";
            this.rbAbierta.Size = new System.Drawing.Size(71, 17);
            this.rbAbierta.TabIndex = 1;
            this.rbAbierta.TabStop = true;
            this.rbAbierta.Text = "ABIERTA";
            this.rbAbierta.UseVisualStyleBackColor = true;
            // 
            // checkDepende
            // 
            this.checkDepende.AutoSize = true;
            this.checkDepende.Location = new System.Drawing.Point(16, 262);
            this.checkDepende.Name = "checkDepende";
            this.checkDepende.Size = new System.Drawing.Size(265, 17);
            this.checkDepende.TabIndex = 19;
            this.checkDepende.Text = "ESTA PREGUNTA DEPENDE DE LA ANTERIOR";
            this.checkDepende.UseVisualStyleBackColor = true;
            this.checkDepende.CheckedChanged += new System.EventHandler(this.CheckDepende_CheckedChanged);
            // 
            // cmbPreguntas
            // 
            this.cmbPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreguntas.FormattingEnabled = true;
            this.cmbPreguntas.Location = new System.Drawing.Point(12, 348);
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(321, 26);
            this.cmbPreguntas.TabIndex = 47;
            this.cmbPreguntas.Visible = false;
            // 
            // lblcmb
            // 
            this.lblcmb.AutoSize = true;
            this.lblcmb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmb.Location = new System.Drawing.Point(13, 323);
            this.lblcmb.Name = "lblcmb";
            this.lblcmb.Size = new System.Drawing.Size(175, 13);
            this.lblcmb.TabIndex = 48;
            this.lblcmb.Text = "PREGUNTA DE LA CUAL DEPENDE";
            this.lblcmb.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtNo);
            this.groupBox2.Controls.Add(this.rbtSi);
            this.groupBox2.Location = new System.Drawing.Point(342, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 58);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PREGUNATAR CUANDO SEA";
            this.groupBox2.Visible = false;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(126, 25);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(41, 17);
            this.rbtNo.TabIndex = 0;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "NO";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Checked = true;
            this.rbtSi.Location = new System.Drawing.Point(37, 25);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(35, 17);
            this.rbtSi.TabIndex = 0;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "SI";
            this.rbtSi.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbPreguntas);
            this.Controls.Add(this.lblcmb);
            this.Controls.Add(this.checkDepende);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarPregunta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PreguntaControl);
            this.Name = "FrmAgregarPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPregunta";
            this.Load += new System.EventHandler(this.FrmAgregarPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox PreguntaControl;
        private System.Windows.Forms.Button btnGuardarPregunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultiple;
        private System.Windows.Forms.RadioButton rbSiNo;
        private System.Windows.Forms.RadioButton rbAbierta;
        private System.Windows.Forms.CheckBox checkDepende;
        private System.Windows.Forms.ComboBox cmbPreguntas;
        private System.Windows.Forms.Label lblcmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtSi;
        private System.Windows.Forms.CheckBox checkMultipleRespuesta;
    }
}