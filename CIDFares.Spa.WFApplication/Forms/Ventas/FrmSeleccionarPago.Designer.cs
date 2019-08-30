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
            this.EfectivoControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GridFormaPago = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPago)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.EfectivoControl);
            this.PanelPrincipal.Controls.Add(this.panel2);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.GridFormaPago);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(441, 548);
            this.PanelPrincipal.TabIndex = 0;
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
            this.EfectivoControl.Location = new System.Drawing.Point(104, 414);
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
            this.EfectivoControl.TabIndex = 1;
            this.EfectivoControl.Text = "$0.00";
            this.EfectivoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EfectivoControl.ThemeStyle.FocusBorderColor = System.Drawing.Color.Gray;
            this.EfectivoControl.ThemeStyle.HoverBorderColor = System.Drawing.Color.White;
            this.EfectivoControl.ZeroColor = System.Drawing.Color.Silver;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(104, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 3);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(175, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Efectivo";
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
            this.GridFormaPago.Location = new System.Drawing.Point(42, 157);
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
            this.GridFormaPago.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.GridFormaPago_QueryCellStyle);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnCobrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 81);
            this.panel3.TabIndex = 6;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(63, 3);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(312, 53);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cobrar ";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TotalControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 151);
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
            // 
            // FrmSeleccionarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 548);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSeleccionarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSeleccionarPago_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFormaPago)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox EfectivoControl;
    }
}