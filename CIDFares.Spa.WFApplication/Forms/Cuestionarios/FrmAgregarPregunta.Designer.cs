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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarPregunta = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGuardarPregunta = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 30);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Pregunta";
            // 
            // PreguntaControl
            // 
            this.PreguntaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreguntaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaControl.Location = new System.Drawing.Point(16, 70);
            this.PreguntaControl.Multiline = true;
            this.PreguntaControl.Name = "PreguntaControl";
            this.PreguntaControl.Size = new System.Drawing.Size(555, 121);
            this.PreguntaControl.TabIndex = 4;
            this.PreguntaControl.TextChanged += new System.EventHandler(this.TxtPreguntas_TextChanged);
            this.PreguntaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreguntaControl_KeyPress);
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
            this.groupBox1.Location = new System.Drawing.Point(32, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preguntas";
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Location = new System.Drawing.Point(394, 27);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(61, 17);
            this.rbMultiple.TabIndex = 2;
            this.rbMultiple.Text = "Multiple";
            this.rbMultiple.UseVisualStyleBackColor = true;
            this.rbMultiple.CheckedChanged += new System.EventHandler(this.CheckMultipleRespuesta_CheckedChanged);
            // 
            // rbSiNo
            // 
            this.rbSiNo.AutoSize = true;
            this.rbSiNo.Location = new System.Drawing.Point(234, 27);
            this.rbSiNo.Name = "rbSiNo";
            this.rbSiNo.Size = new System.Drawing.Size(53, 17);
            this.rbSiNo.TabIndex = 1;
            this.rbSiNo.Text = "Si/No";
            this.rbSiNo.UseVisualStyleBackColor = true;
            // 
            // checkMultipleRespuesta
            // 
            this.checkMultipleRespuesta.AutoSize = true;
            this.checkMultipleRespuesta.Location = new System.Drawing.Point(359, 50);
            this.checkMultipleRespuesta.Name = "checkMultipleRespuesta";
            this.checkMultipleRespuesta.Size = new System.Drawing.Size(137, 17);
            this.checkMultipleRespuesta.TabIndex = 3;
            this.checkMultipleRespuesta.Text = "¿Es multiple respuesta?";
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
            this.rbAbierta.Size = new System.Drawing.Size(58, 17);
            this.rbAbierta.TabIndex = 0;
            this.rbAbierta.TabStop = true;
            this.rbAbierta.Text = "Abierta";
            this.rbAbierta.UseVisualStyleBackColor = true;
            // 
            // checkDepende
            // 
            this.checkDepende.AutoSize = true;
            this.checkDepende.Location = new System.Drawing.Point(16, 286);
            this.checkDepende.Name = "checkDepende";
            this.checkDepende.Size = new System.Drawing.Size(201, 17);
            this.checkDepende.TabIndex = 6;
            this.checkDepende.Text = "Esta pregunta depende de la anterior";
            this.checkDepende.UseVisualStyleBackColor = true;
            this.checkDepende.CheckedChanged += new System.EventHandler(this.CheckDepende_CheckedChanged);
            // 
            // cmbPreguntas
            // 
            this.cmbPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreguntas.FormattingEnabled = true;
            this.cmbPreguntas.Location = new System.Drawing.Point(12, 372);
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(321, 26);
            this.cmbPreguntas.TabIndex = 7;
            this.cmbPreguntas.Visible = false;
            // 
            // lblcmb
            // 
            this.lblcmb.AutoSize = true;
            this.lblcmb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmb.Location = new System.Drawing.Point(13, 347);
            this.lblcmb.Name = "lblcmb";
            this.lblcmb.Size = new System.Drawing.Size(155, 13);
            this.lblcmb.TabIndex = 0;
            this.lblcmb.Text = "Pregunta de la cual depende";
            this.lblcmb.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtNo);
            this.groupBox2.Controls.Add(this.rbtSi);
            this.groupBox2.Location = new System.Drawing.Point(342, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 58);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preguntar cuando sea";
            this.groupBox2.Visible = false;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(126, 25);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Checked = true;
            this.rbtSi.Location = new System.Drawing.Point(37, 25);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(34, 17);
            this.rbtSi.TabIndex = 0;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "Si";
            this.rbtSi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.btnCancelarPregunta);
            this.panel2.Controls.Add(this.btnGuardarPregunta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 54);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 64);
            this.panel1.TabIndex = 22;
            // 
            // btnCancelarPregunta
            // 
            this.btnCancelarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnCancelarPregunta.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnCancelarPregunta.FlatAppearance.BorderSize = 0;
            this.btnCancelarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPregunta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarPregunta.IsBackStageButton = false;
            this.btnCancelarPregunta.Location = new System.Drawing.Point(444, 13);
            this.btnCancelarPregunta.Name = "btnCancelarPregunta";
            this.btnCancelarPregunta.Size = new System.Drawing.Size(123, 29);
            this.btnCancelarPregunta.TabIndex = 21;
            this.btnCancelarPregunta.Text = "Cancelar";
            this.btnCancelarPregunta.Click += new System.EventHandler(this.BtnCancelarPregunta_Click);
            // 
            // btnGuardarPregunta
            // 
            this.btnGuardarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardarPregunta.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnGuardarPregunta.FlatAppearance.BorderSize = 0;
            this.btnGuardarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPregunta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPregunta.IsBackStageButton = false;
            this.btnGuardarPregunta.Location = new System.Drawing.Point(315, 13);
            this.btnGuardarPregunta.Name = "btnGuardarPregunta";
            this.btnGuardarPregunta.Size = new System.Drawing.Size(123, 29);
            this.btnGuardarPregunta.TabIndex = 20;
            this.btnGuardarPregunta.Text = "Guardar";
            this.btnGuardarPregunta.Click += new System.EventHandler(this.BtnGuardarPregunta_Click);
            // 
            // FrmAgregarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbPreguntas);
            this.Controls.Add(this.lblcmb);
            this.Controls.Add(this.checkDepende);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PreguntaControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPregunta";
            this.Load += new System.EventHandler(this.FrmAgregarPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox PreguntaControl;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelarPregunta;
        private Syncfusion.Windows.Forms.ButtonAdv btnGuardarPregunta;
    }
}