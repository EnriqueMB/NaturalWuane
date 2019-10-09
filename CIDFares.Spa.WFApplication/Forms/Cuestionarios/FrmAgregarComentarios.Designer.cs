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
            this.btnGuardarComentario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 20);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "COMENTARIO";
            // 
            // Comentario
            // 
            this.Comentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comentario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comentario.Location = new System.Drawing.Point(16, 46);
            this.Comentario.Multiline = true;
            this.Comentario.Name = "Comentario";
            this.Comentario.Size = new System.Drawing.Size(381, 107);
            this.Comentario.TabIndex = 7;
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarComentario.BackColor = System.Drawing.Color.White;
            this.btnGuardarComentario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardarComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComentario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComentario.Location = new System.Drawing.Point(267, 159);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarComentario.TabIndex = 17;
            this.btnGuardarComentario.Text = "GUARDAR";
            this.btnGuardarComentario.UseVisualStyleBackColor = false;
            this.btnGuardarComentario.Click += new System.EventHandler(this.BtnGuardarComentario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 40);
            this.panel1.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAgregarComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarComentario);
            this.Controls.Add(this.Comentario);
            this.MaximumSize = new System.Drawing.Size(436, 240);
            this.MinimumSize = new System.Drawing.Size(436, 240);
            this.Name = "FrmAgregarComentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarComentarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox Comentario;
        private System.Windows.Forms.Button btnGuardarComentario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}