namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmPaqueteVenta
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn2 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo2 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.GridPaquete = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPaquete)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.GridPaquete);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(591, 548);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // GridPaquete
            // 
            this.GridPaquete.AccessibleName = "Table";
            gridTextColumn8.HeaderText = "IdPaquete";
            gridTextColumn8.MappingName = "IdPaquete";
            gridTextColumn8.Visible = false;
            gridCheckBoxColumn2.AllowEditing = false;
            gridCheckBoxColumn2.HeaderText = "Seleccionar";
            gridCheckBoxColumn2.MappingName = "Seleccionar";
            gridCheckBoxColumn2.Width = 28D;
            gridTextColumn9.HeaderText = "Cantidad";
            gridTextColumn9.MappingName = "CantidadServicio";
            gridTextColumn9.Width = 30D;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowGrouping = false;
            gridTextColumn10.HeaderText = "Paquete";
            gridTextColumn10.MappingName = "Nombre";
            gridTextColumn10.Width = 150D;
            gridTextColumn11.Format = "C2";
            gridTextColumn11.HeaderText = "Total";
            gridTextColumn11.MappingName = "MontoPaquete";
            gridTextColumn11.Width = 80D;
            gridTextColumn12.Format = "C2";
            gridTextColumn12.HeaderText = "Pago minimo";
            gridTextColumn12.MappingName = "PagoMinimo";
            gridTextColumn13.CellStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            gridTextColumn13.Format = "C2";
            gridTextColumn13.HeaderText = "Abono";
            gridTextColumn13.MappingName = "Abono";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.CellStyle.TextColor = System.Drawing.Color.Red;
            gridTextColumn14.Format = "c2";
            gridTextColumn14.HeaderText = "Adeudo";
            gridTextColumn14.MappingName = "PorPagar";
            this.GridPaquete.Columns.Add(gridTextColumn8);
            this.GridPaquete.Columns.Add(gridCheckBoxColumn2);
            this.GridPaquete.Columns.Add(gridTextColumn9);
            this.GridPaquete.Columns.Add(gridTextColumn10);
            this.GridPaquete.Columns.Add(gridTextColumn11);
            this.GridPaquete.Columns.Add(gridTextColumn12);
            this.GridPaquete.Columns.Add(gridTextColumn13);
            this.GridPaquete.Columns.Add(gridTextColumn14);
            this.GridPaquete.Location = new System.Drawing.Point(12, 81);
            this.GridPaquete.Name = "GridPaquete";
            this.GridPaquete.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.GridPaquete.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.GridPaquete.Size = new System.Drawing.Size(579, 366);
            gridBordersInfo2.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Standard, System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))));
            this.GridPaquete.Style.AddNewRowStyle.Borders = gridBordersInfo2;
            this.GridPaquete.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPaquete.Style.CellStyle.Font.Facename = "Century Gothic";
            this.GridPaquete.Style.CellStyle.Font.Size = 11F;
            this.GridPaquete.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.White;
            this.GridPaquete.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.White;
            this.GridPaquete.Style.CheckBoxStyle.CheckedTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridPaquete.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridPaquete.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.White;
            this.GridPaquete.Style.HeaderStyle.Font.Facename = "Century Gothic";
            this.GridPaquete.Style.HeaderStyle.Font.Size = 10F;
            this.GridPaquete.TabIndex = 7;
            this.GridPaquete.Text = "sfDataGrid1";
            this.GridPaquete.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.GridPaquete_CurrentCellEndEdit);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnCobrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 81);
            this.panel3.TabIndex = 6;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(325, 16);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(189, 53);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Siguiente";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 75);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(568, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(152, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paquetes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(41, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPaqueteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 548);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaqueteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPaquete)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridPaquete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}