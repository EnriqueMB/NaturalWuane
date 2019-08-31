namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmSeleccionarPago
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.GridFormaPago = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EfectivoControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCambio = new System.Windows.Forms.Panel();
            this.btnAceeptar = new System.Windows.Forms.Button();
            this.CambioControl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPago)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoControl)).BeginInit();
            this.pnlCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.panel4);
            this.PanelPrincipal.Controls.Add(this.GridFormaPago);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(442, 536);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // GridFormaPago
            // 
            this.GridFormaPago.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdFormaPago";
            gridTextColumn1.Visible = false;
            gridCheckBoxColumn1.AllowCheckBoxOnHeader = true;
            gridCheckBoxColumn1.HeaderText = "Seleccionar";
            gridCheckBoxColumn1.MappingName = "Seleccionar";
            gridCheckBoxColumn1.Width = 30D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.HeaderText = "Formas de pago";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn2.Width = 250D;
            gridTextColumn3.Format = "C2";
            gridTextColumn3.HeaderText = "Monto";
            gridTextColumn3.MappingName = "Cantidad";
            gridTextColumn3.Width = 80D;
            this.GridFormaPago.Columns.Add(gridTextColumn1);
            this.GridFormaPago.Columns.Add(gridCheckBoxColumn1);
            this.GridFormaPago.Columns.Add(gridTextColumn2);
            this.GridFormaPago.Columns.Add(gridTextColumn3);
            this.GridFormaPago.Location = new System.Drawing.Point(35, 157);
            this.GridFormaPago.Name = "GridFormaPago";
            this.GridFormaPago.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.GridFormaPago.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.GridFormaPago.Size = new System.Drawing.Size(364, 207);
            gridBordersInfo1.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Standard, System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))));
            this.GridFormaPago.Style.AddNewRowStyle.Borders = gridBordersInfo1;
            this.GridFormaPago.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFormaPago.Style.CellStyle.Font.Facename = "Century Gothic";
            this.GridFormaPago.Style.CellStyle.Font.Size = 11F;
            this.GridFormaPago.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.White;
            this.GridFormaPago.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.White;
            this.GridFormaPago.Style.CheckBoxStyle.CheckedTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridFormaPago.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridFormaPago.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.White;
            this.GridFormaPago.Style.HeaderStyle.Font.Facename = "Century Gothic";
            this.GridFormaPago.Style.HeaderStyle.Font.Size = 10F;
            this.GridFormaPago.TabIndex = 7;
            this.GridFormaPago.Text = "sfDataGrid1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnCobrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 81);
            this.panel3.TabIndex = 6;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(63, 16);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(312, 53);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cobrar ";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TotalControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 151);
            this.panel1.TabIndex = 4;
            // 
            // TotalControl
            // 
            this.TotalControl.AutoSize = true;
            this.TotalControl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.TotalControl.Location = new System.Drawing.Point(150, 66);
            this.TotalControl.Name = "TotalControl";
            this.TotalControl.Size = new System.Drawing.Size(132, 56);
            this.TotalControl.TabIndex = 4;
            this.TotalControl.Text = "$300";
            this.TotalControl.Click += new System.EventHandler(this.TotalControl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una forma de pago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EfectivoControl);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 82);
            this.panel4.TabIndex = 11;
            // 
            // EfectivoControl
            // 
            this.EfectivoControl.BackGroundColor = System.Drawing.Color.White;
            this.EfectivoControl.BeforeTouchSize = new System.Drawing.Size(222, 34);
            this.EfectivoControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EfectivoControl.CornerRadius = 2;
            this.EfectivoControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EfectivoControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.EfectivoControl.FocusBorderColor = System.Drawing.Color.Transparent;
            this.EfectivoControl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EfectivoControl.ForeColor = System.Drawing.Color.Silver;
            this.EfectivoControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EfectivoControl.Location = new System.Drawing.Point(102, 34);
            this.EfectivoControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.EfectivoControl.MinimumSize = new System.Drawing.Size(8, 4);
            this.EfectivoControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EfectivoControl.Name = "EfectivoControl";
            this.EfectivoControl.NullString = "";
            this.EfectivoControl.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.EfectivoControl.SelectAllOnFocus = false;
            this.EfectivoControl.Size = new System.Drawing.Size(222, 34);
            this.EfectivoControl.TabIndex = 11;
            this.EfectivoControl.Text = "$0.00";
            this.EfectivoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EfectivoControl.ThemeStyle.FocusBorderColor = System.Drawing.Color.Gray;
            this.EfectivoControl.ThemeStyle.HoverBorderColor = System.Drawing.Color.White;
            this.EfectivoControl.ZeroColor = System.Drawing.Color.Silver;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(102, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 3);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Efectivo";
            // 
            // pnlCambio
            // 
            this.pnlCambio.BackColor = System.Drawing.Color.White;
            this.pnlCambio.Controls.Add(this.label5);
            this.pnlCambio.Controls.Add(this.btnAceeptar);
            this.pnlCambio.Controls.Add(this.CambioControl);
            this.pnlCambio.Controls.Add(this.label4);
            this.pnlCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCambio.Location = new System.Drawing.Point(0, 0);
            this.pnlCambio.Name = "pnlCambio";
            this.pnlCambio.Size = new System.Drawing.Size(441, 548);
            this.pnlCambio.TabIndex = 1;
            this.pnlCambio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCambio_Paint);
            // 
            // btnAceeptar
            // 
            this.btnAceeptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.btnAceeptar.FlatAppearance.BorderSize = 0;
            this.btnAceeptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceeptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceeptar.ForeColor = System.Drawing.Color.White;
            this.btnAceeptar.Location = new System.Drawing.Point(72, 391);
            this.btnAceeptar.Name = "btnAceeptar";
            this.btnAceeptar.Size = new System.Drawing.Size(312, 53);
            this.btnAceeptar.TabIndex = 5;
            this.btnAceeptar.Text = "Aceptar";
            this.btnAceeptar.UseVisualStyleBackColor = false;
            // 
            // CambioControl
            // 
            this.CambioControl.AutoSize = true;
            this.CambioControl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambioControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.CambioControl.Location = new System.Drawing.Point(150, 243);
            this.CambioControl.Name = "CambioControl";
            this.CambioControl.Size = new System.Drawing.Size(132, 56);
            this.CambioControl.TabIndex = 7;
            this.CambioControl.Text = "$300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(79, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Venta realizada exitosamente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(175, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cambio";
            // 
            // FrmSeleccionarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 548);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.pnlCambio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSeleccionarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSeleccionarPago_Load);
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPago)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoControl)).EndInit();
            this.pnlCambio.ResumeLayout(false);
            this.pnlCambio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridFormaPago;
        private System.Windows.Forms.Label TotalControl;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox EfectivoControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCambio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceeptar;
        private System.Windows.Forms.Label CambioControl;
        private System.Windows.Forms.Label label4;
    }
}