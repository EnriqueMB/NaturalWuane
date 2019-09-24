namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmAgregarRespuesta
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
            this.btnGuardarRespuesta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.RespuestaControl = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarRespuesta
            // 
            this.btnGuardarRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGuardarRespuesta.FlatAppearance.BorderSize = 0;
            this.btnGuardarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRespuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRespuesta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRespuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRespuesta.Location = new System.Drawing.Point(421, 198);
            this.btnGuardarRespuesta.Name = "btnGuardarRespuesta";
            this.btnGuardarRespuesta.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarRespuesta.TabIndex = 19;
            this.btnGuardarRespuesta.Text = "GUARDAR";
            this.btnGuardarRespuesta.UseVisualStyleBackColor = false;
            this.btnGuardarRespuesta.Click += new System.EventHandler(this.BtnGuardarRespuesta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 20);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "RESPUESTA A:";
            // 
            // RespuestaControl
            // 
            this.RespuestaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RespuestaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespuestaControl.Location = new System.Drawing.Point(12, 54);
            this.RespuestaControl.Multiline = true;
            this.RespuestaControl.Name = "RespuestaControl";
            this.RespuestaControl.Size = new System.Drawing.Size(539, 121);
            this.RespuestaControl.TabIndex = 17;
            this.RespuestaControl.TextChanged += new System.EventHandler(this.RespuestaControl_TextChanged);
            this.RespuestaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RespuestaControl_KeyPress);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.Black;
            this.lblPregunta.Location = new System.Drawing.Point(117, 24);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(106, 16);
            this.lblPregunta.TabIndex = 20;
            this.lblPregunta.Text = "HACER PREGUNTA";
            this.lblPregunta.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAgregarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 243);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnGuardarRespuesta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.RespuestaControl);
            this.Name = "FrmAgregarRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarRespuesta";
            this.Load += new System.EventHandler(this.FrmAgregarRespuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarRespuesta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox RespuestaControl;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}