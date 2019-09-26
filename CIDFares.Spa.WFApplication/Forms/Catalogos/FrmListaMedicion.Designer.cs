namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmListaMedicion
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.PnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.sfDataGridListaMedicion = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorControl = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridListaMedicion)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.Controls.Add(this.lblTitulo);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(348, 74);
            this.PnlHead.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 25);
            this.lblTitulo.TabIndex = 182;
            this.lblTitulo.Text = "LISTA MEDICIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuarda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(206, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuarda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGuarda.FlatAppearance.BorderSize = 0;
            this.btnGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuarda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuarda.ForeColor = System.Drawing.Color.White;
            this.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuarda.Location = new System.Drawing.Point(70, 26);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(130, 28);
            this.btnGuarda.TabIndex = 17;
            this.btnGuarda.Text = "GUARDAR";
            this.btnGuarda.UseVisualStyleBackColor = false;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 427);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.DescripcionControl);
            this.panel6.Location = new System.Drawing.Point(3, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 121);
            this.panel6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DescripcionControl.Location = new System.Drawing.Point(7, 44);
            this.DescripcionControl.MaxLength = 300;
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.Size = new System.Drawing.Size(283, 63);
            this.DescripcionControl.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnQuitar);
            this.panel5.Controls.Add(this.sfDataGridListaMedicion);
            this.panel5.Location = new System.Drawing.Point(3, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 117);
            this.panel5.TabIndex = 8;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(289, 46);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(32, 28);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // sfDataGridListaMedicion
            // 
            this.sfDataGridListaMedicion.AccessibleName = "Table";
            this.sfDataGridListaMedicion.AllowEditing = false;
            this.sfDataGridListaMedicion.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Valor";
            gridTextColumn2.MappingName = "Valor";
            this.sfDataGridListaMedicion.Columns.Add(gridTextColumn2);
            this.sfDataGridListaMedicion.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridListaMedicion.Name = "sfDataGridListaMedicion";
            this.sfDataGridListaMedicion.Size = new System.Drawing.Size(264, 117);
            this.sfDataGridListaMedicion.TabIndex = 9;
            this.sfDataGridListaMedicion.Text = "sfDataGrid1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.ValorControl);
            this.panel4.Controls.Add(this.BtnAgregar);
            this.panel4.Location = new System.Drawing.Point(3, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 83);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // ValorControl
            // 
            this.ValorControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ValorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ValorControl.Location = new System.Drawing.Point(7, 44);
            this.ValorControl.MaxLength = 50;
            this.ValorControl.Name = "ValorControl";
            this.ValorControl.Size = new System.Drawing.Size(175, 24);
            this.ValorControl.TabIndex = 5;
            this.ValorControl.TextChanged += new System.EventHandler(this.ValorControl_TextChanged);
            this.ValorControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValorControl_KeyDown);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(232, 43);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(32, 28);
            this.BtnAgregar.TabIndex = 57;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NombreControl);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 83);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // NombreControl
            // 
            this.NombreControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NombreControl.Location = new System.Drawing.Point(7, 44);
            this.NombreControl.MaxLength = 50;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(283, 24);
            this.NombreControl.TabIndex = 5;
            this.NombreControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            this.NombreControl.Leave += new System.EventHandler(this.NombreControl_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmListaMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaMedicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaMedicion";
            this.Load += new System.EventHandler(this.FrmListaMedicion_Load);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridListaMedicion)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValorControl;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridListaMedicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}