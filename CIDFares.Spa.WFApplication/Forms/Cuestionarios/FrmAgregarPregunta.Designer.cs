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
            this.lblPregunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.PreguntaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreguntaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaControl.Location = new System.Drawing.Point(16, 40);
            this.PreguntaControl.Multiline = true;
            this.PreguntaControl.Name = "PreguntaControl";
            this.PreguntaControl.Size = new System.Drawing.Size(539, 119);
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
            this.btnGuardarPregunta.Location = new System.Drawing.Point(428, 165);
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
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.Black;
            this.lblPregunta.Location = new System.Drawing.Point(114, 13);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(106, 16);
            this.lblPregunta.TabIndex = 17;
            this.lblPregunta.Text = "HACER PREGUNTA";
            // 
            // FrmAgregarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 205);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnGuardarPregunta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PreguntaControl);
            this.Name = "FrmAgregarPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPregunta";
            this.Load += new System.EventHandler(this.FrmAgregarPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox PreguntaControl;
        private System.Windows.Forms.Button btnGuardarPregunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPregunta;
    }
}