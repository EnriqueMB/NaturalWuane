namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmAgregarComentarios
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
            this.Comentario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardarComentario = new CIDFares.Library.Controls.Btn.Btn();
            this.btnCancelarComentario = new CIDFares.Library.Controls.Btn.Btn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 30);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "COMENTARIO";
            // 
            // Comentario
            // 
            this.Comentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comentario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comentario.Location = new System.Drawing.Point(16, 68);
            this.Comentario.Multiline = true;
            this.Comentario.Name = "Comentario";
            this.Comentario.Size = new System.Drawing.Size(397, 94);
            this.Comentario.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 58);
            this.panel1.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.BackColor = System.Drawing.Color.White;
            this.btnGuardarComentario.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnGuardarComentario.FlatAppearance.BorderSize = 0;
            this.btnGuardarComentario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardarComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComentario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarComentario.IsBackStageButton = false;
            this.btnGuardarComentario.Location = new System.Drawing.Point(187, 13);
            this.btnGuardarComentario.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardarComentario.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarComentario.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(110, 29);
            this.btnGuardarComentario.TabIndex = 19;
            this.btnGuardarComentario.Text = "GUARDAR";
            this.btnGuardarComentario.Click += new System.EventHandler(this.BtnGuardarComentario_Click);
            // 
            // btnCancelarComentario
            // 
            this.btnCancelarComentario.BackColor = System.Drawing.Color.White;
            this.btnCancelarComentario.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancelarComentario.FlatAppearance.BorderSize = 0;
            this.btnCancelarComentario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelarComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarComentario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarComentario.IsBackStageButton = false;
            this.btnCancelarComentario.Location = new System.Drawing.Point(303, 13);
            this.btnCancelarComentario.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnCancelarComentario.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnCancelarComentario.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnCancelarComentario.Name = "btnCancelarComentario";
            this.btnCancelarComentario.Size = new System.Drawing.Size(110, 29);
            this.btnCancelarComentario.TabIndex = 19;
            this.btnCancelarComentario.Text = "CANCELAR";
            this.btnCancelarComentario.Click += new System.EventHandler(this.BtnCancelarComentario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.btnGuardarComentario);
            this.panel2.Controls.Add(this.btnCancelarComentario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 54);
            this.panel2.TabIndex = 20;
            // 
            // FrmAgregarComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 233);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Comentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(436, 240);
            this.Name = "FrmAgregarComentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarComentarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox Comentario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Library.Controls.Btn.Btn btnGuardarComentario;
        private Library.Controls.Btn.Btn btnCancelarComentario;
        private System.Windows.Forms.Panel panel2;
    }
}