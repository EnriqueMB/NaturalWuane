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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPreguntas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 76);
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
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 506);
            this.panel2.TabIndex = 48;
            // 
            // PanelPreguntas
            // 
            this.PanelPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPreguntas.Location = new System.Drawing.Point(0, 0);
            this.PanelPreguntas.Name = "PanelPreguntas";
            this.PanelPreguntas.Size = new System.Drawing.Size(816, 467);
            this.PanelPreguntas.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
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
            this.MaximumSize = new System.Drawing.Size(832, 740);
            this.MinimumSize = new System.Drawing.Size(832, 740);
            this.Name = "FrmNuevaConsultaControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaConsulta";
            this.Load += new System.EventHandler(this.FrmNuevaConsultaControl_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPreguntas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
    }
}