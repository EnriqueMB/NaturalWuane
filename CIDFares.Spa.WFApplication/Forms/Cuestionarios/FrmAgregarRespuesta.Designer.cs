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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarRespuesta
            // 
            this.btnGuardarRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarRespuesta.BackColor = System.Drawing.Color.White;
            this.btnGuardarRespuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGuardarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRespuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRespuesta.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarRespuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRespuesta.Location = new System.Drawing.Point(421, 222);
            this.btnGuardarRespuesta.Name = "btnGuardarRespuesta";
            this.btnGuardarRespuesta.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarRespuesta.TabIndex = 3;
            this.btnGuardarRespuesta.Text = "GUARDAR";
            this.btnGuardarRespuesta.UseVisualStyleBackColor = false;
            this.btnGuardarRespuesta.Click += new System.EventHandler(this.BtnGuardarRespuesta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESPUESTA A:";
            // 
            // RespuestaControl
            // 
            this.RespuestaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RespuestaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespuestaControl.Location = new System.Drawing.Point(12, 78);
            this.RespuestaControl.Multiline = true;
            this.RespuestaControl.Name = "RespuestaControl";
            this.RespuestaControl.Size = new System.Drawing.Size(539, 121);
            this.RespuestaControl.TabIndex = 2;
            this.RespuestaControl.TextChanged += new System.EventHandler(this.RespuestaControl_TextChanged);
            this.RespuestaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RespuestaControl_KeyPress);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(157, 23);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(141, 21);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "HACER PREGUNTA";
            this.lblPregunta.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblPregunta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 64);
            this.panel1.TabIndex = 23;
            // 
            // FrmAgregarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarRespuesta);
            this.Controls.Add(this.RespuestaControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(586, 282);
            this.Name = "FrmAgregarRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarRespuesta";
            this.Load += new System.EventHandler(this.FrmAgregarRespuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarRespuesta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox RespuestaControl;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}