namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmPaquetesCliente
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo2 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridPaquete = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombrePaqueteControl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.FolioClienteControl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPaquete)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelGrid);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(617, 373);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.tableLayoutPanel1);
            this.panelGrid.Controls.Add(this.FolioClienteControl);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(617, 373);
            this.panelGrid.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.73938F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69688F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 371);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridPaquete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 218);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // GridPaquete
            // 
            this.GridPaquete.AccessibleName = "Table";
            this.GridPaquete.AutoExpandGroups = true;
            this.GridPaquete.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn4.HeaderText = "Clave";
            gridTextColumn4.MappingName = "Clave";
            gridTextColumn4.Width = 100D;
            gridTextColumn5.CellStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            gridTextColumn5.HeaderText = "Nombre";
            gridTextColumn5.MappingName = "Nombre";
            gridTextColumn6.HeaderText = "Monto";
            gridTextColumn6.MappingName = "MontoPaquete";
            this.GridPaquete.Columns.Add(gridTextColumn4);
            this.GridPaquete.Columns.Add(gridTextColumn5);
            this.GridPaquete.Columns.Add(gridTextColumn6);
            this.GridPaquete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPaquete.Location = new System.Drawing.Point(3, 19);
            this.GridPaquete.Name = "GridPaquete";
            this.GridPaquete.SerializationController = null;
            this.GridPaquete.Size = new System.Drawing.Size(583, 196);
            gridBordersInfo2.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Standard, System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))));
            this.GridPaquete.Style.AddNewRowStyle.Borders = gridBordersInfo2;
            this.GridPaquete.Style.CellStyle.Font.Facename = "Century Gothic";
            this.GridPaquete.Style.CellStyle.Font.Size = 11F;
            this.GridPaquete.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.White;
            this.GridPaquete.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.White;
            this.GridPaquete.Style.CheckBoxStyle.CheckedTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridPaquete.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.GridPaquete.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.GridPaquete.Style.HeaderStyle.Font.Facename = "Century Gothic";
            this.GridPaquete.Style.HeaderStyle.Font.Size = 10F;
            this.GridPaquete.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 54);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NombrePaqueteControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 32);
            this.panel1.TabIndex = 0;
            // 
            // NombrePaqueteControl
            // 
            this.NombrePaqueteControl.AutoEllipsis = true;
            this.NombrePaqueteControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombrePaqueteControl.Location = new System.Drawing.Point(0, 0);
            this.NombrePaqueteControl.Name = "NombrePaqueteControl";
            this.NombrePaqueteControl.Size = new System.Drawing.Size(583, 32);
            this.NombrePaqueteControl.TabIndex = 16;
            this.NombrePaqueteControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnAbonar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(13, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 61);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.White;
            this.btnAbonar.FlatAppearance.BorderSize = 0;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.ForeColor = System.Drawing.Color.Red;
            this.btnAbonar.Location = new System.Drawing.Point(299, 17);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(167, 33);
            this.btnAbonar.TabIndex = 15;
            this.btnAbonar.Text = "Cerrar";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // FolioClienteControl
            // 
            this.FolioClienteControl.AutoSize = true;
            this.FolioClienteControl.Location = new System.Drawing.Point(386, 69);
            this.FolioClienteControl.Name = "FolioClienteControl";
            this.FolioClienteControl.Size = new System.Drawing.Size(0, 17);
            this.FolioClienteControl.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.button1.Location = new System.Drawing.Point(126, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar a venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPaquetesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 373);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaquetesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbonarPaquete";
            this.panelPrincipal.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPaquete)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label FolioClienteControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridPaquete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label NombrePaqueteControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}