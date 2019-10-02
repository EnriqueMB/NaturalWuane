namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    partial class FrmCancelacionCompra
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.panelContenerdo2 = new System.Windows.Forms.Panel();
            this.lblPaquete = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.MotivoControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor1.SuspendLayout();
            this.panelbtn.SuspendLayout();
            this.panelContenerdo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelContenedor1);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(479, 250);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panelTitulo.Controls.Add(this.lblPaquete);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(479, 58);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.Controls.Add(this.panelContenerdo2);
            this.panelContenedor1.Controls.Add(this.panelbtn);
            this.panelContenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor1.Location = new System.Drawing.Point(0, 58);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(479, 192);
            this.panelContenedor1.TabIndex = 1;
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.btnGuardar);
            this.panelbtn.Controls.Add(this.btnCancelar);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtn.Location = new System.Drawing.Point(0, 147);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(479, 45);
            this.panelbtn.TabIndex = 0;
            // 
            // panelContenerdo2
            // 
            this.panelContenerdo2.Controls.Add(this.label1);
            this.panelContenerdo2.Controls.Add(this.MotivoControl);
            this.panelContenerdo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenerdo2.Location = new System.Drawing.Point(0, 0);
            this.panelContenerdo2.Name = "panelContenerdo2";
            this.panelContenerdo2.Size = new System.Drawing.Size(479, 147);
            this.panelContenerdo2.TabIndex = 1;
            // 
            // lblPaquete
            // 
            this.lblPaquete.AutoSize = true;
            this.lblPaquete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaquete.Location = new System.Drawing.Point(14, 16);
            this.lblPaquete.Name = "lblPaquete";
            this.lblPaquete.Size = new System.Drawing.Size(230, 25);
            this.lblPaquete.TabIndex = 184;
            this.lblPaquete.Text = "CANCELACIÓN COMPRA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(216, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(345, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // MotivoControl
            // 
            this.MotivoControl.Location = new System.Drawing.Point(40, 28);
            this.MotivoControl.MaxLength = 500;
            this.MotivoControl.Multiline = true;
            this.MotivoControl.Name = "MotivoControl";
            this.MotivoControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MotivoControl.Size = new System.Drawing.Size(389, 113);
            this.MotivoControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOTIVO DE CANCELACIÓN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCancelacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 250);
            this.Controls.Add(this.panelContenedor);
            this.MaximumSize = new System.Drawing.Size(495, 289);
            this.MinimumSize = new System.Drawing.Size(495, 289);
            this.Name = "FrmCancelacionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCancelacion";
            this.panelContenedor.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor1.ResumeLayout(false);
            this.panelbtn.ResumeLayout(false);
            this.panelContenerdo2.ResumeLayout(false);
            this.panelContenerdo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.Panel panelContenerdo2;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Label lblPaquete;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MotivoControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}