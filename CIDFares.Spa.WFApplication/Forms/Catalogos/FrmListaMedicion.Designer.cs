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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.PnlHead = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sfDataGridListaMedicion = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorControl = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGuarda = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BtnAgregar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnQuitar = new CIDFares.Library.Controls.Btn.Btn();
            this.PnlHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridListaMedicion)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.PnlHead.Controls.Add(this.label4);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.ForeColor = System.Drawing.Color.White;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(348, 58);
            this.PnlHead.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 68);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 450);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DescripcionControl.Location = new System.Drawing.Point(7, 44);
            this.DescripcionControl.MaxLength = 300;
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripcionControl.Size = new System.Drawing.Size(305, 63);
            this.DescripcionControl.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnQuitar);
            this.panel5.Controls.Add(this.sfDataGridListaMedicion);
            this.panel5.Location = new System.Drawing.Point(3, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 121);
            this.panel5.TabIndex = 8;
            // 
            // sfDataGridListaMedicion
            // 
            this.sfDataGridListaMedicion.AccessibleName = "Table";
            this.sfDataGridListaMedicion.AllowEditing = false;
            this.sfDataGridListaMedicion.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Valor";
            gridTextColumn1.MappingName = "Valor";
            this.sfDataGridListaMedicion.Columns.Add(gridTextColumn1);
            this.sfDataGridListaMedicion.Location = new System.Drawing.Point(7, 1);
            this.sfDataGridListaMedicion.Name = "sfDataGridListaMedicion";
            this.sfDataGridListaMedicion.Size = new System.Drawing.Size(257, 117);
            this.sfDataGridListaMedicion.TabIndex = 9;
            this.sfDataGridListaMedicion.Text = "sfDataGrid1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnAgregar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.ValorControl);
            this.panel4.Location = new System.Drawing.Point(3, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 83);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // ValorControl
            // 
            this.ValorControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ValorControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValorControl.Location = new System.Drawing.Point(7, 44);
            this.ValorControl.MaxLength = 50;
            this.ValorControl.Name = "ValorControl";
            this.ValorControl.Size = new System.Drawing.Size(257, 29);
            this.ValorControl.TabIndex = 5;
            this.ValorControl.TextChanged += new System.EventHandler(this.ValorControl_TextChanged);
            this.ValorControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValorControl_KeyDown);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // NombreControl
            // 
            this.NombreControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NombreControl.Location = new System.Drawing.Point(7, 41);
            this.NombreControl.MaxLength = 50;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(305, 29);
            this.NombreControl.TabIndex = 5;
            this.NombreControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            this.NombreControl.Leave += new System.EventHandler(this.NombreControl_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 183;
            this.label4.Text = "Lista medición";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuarda);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 68);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(172, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuarda.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnGuarda.FlatAppearance.BorderSize = 0;
            this.btnGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuarda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuarda.ForeColor = System.Drawing.Color.White;
            this.btnGuarda.IsBackStageButton = false;
            this.btnGuarda.Location = new System.Drawing.Point(43, 18);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(123, 29);
            this.btnGuarda.TabIndex = 18;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.BeforeTouchSize = new System.Drawing.Size(32, 28);
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.IsBackStageButton = false;
            this.BtnAgregar.Location = new System.Drawing.Point(280, 45);
            this.BtnAgregar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnAgregar.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnAgregar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(32, 28);
            this.BtnAgregar.TabIndex = 63;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.BeforeTouchSize = new System.Drawing.Size(32, 28);
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.IsBackStageButton = false;
            this.btnQuitar.Location = new System.Drawing.Point(280, 54);
            this.btnQuitar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnQuitar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnQuitar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(32, 28);
            this.btnQuitar.TabIndex = 64;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // FrmListaMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaMedicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaMedicion";
            this.Load += new System.EventHandler(this.FrmListaMedicion_Load);
            this.Shown += new System.EventHandler(this.FrmListaMedicion_Shown);
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
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridListaMedicion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnGuarda;
        private Library.Controls.Btn.Btn BtnAgregar;
        private Library.Controls.Btn.Btn btnQuitar;
    }
}