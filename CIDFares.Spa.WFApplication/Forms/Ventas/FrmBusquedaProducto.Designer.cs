namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmBusquedaProducto
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenedoGridGuardar = new System.Windows.Forms.Panel();
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.sfDataGridBuquedaProducto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BusqueNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BuquedaClaveCodigoControl = new System.Windows.Forms.TextBox();
            this.BusClaveBarraControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelContenedoGridGuardar.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelContenedoGridGuardar);
            this.panelContenedor.Controls.Add(this.panelBuscador);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(916, 482);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelContenedoGridGuardar
            // 
            this.panelContenedoGridGuardar.Controls.Add(this.panelGuardar);
            this.panelContenedoGridGuardar.Controls.Add(this.panelGrid);
            this.panelContenedoGridGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedoGridGuardar.Location = new System.Drawing.Point(0, 62);
            this.panelContenedoGridGuardar.Name = "panelContenedoGridGuardar";
            this.panelContenedoGridGuardar.Size = new System.Drawing.Size(916, 420);
            this.panelContenedoGridGuardar.TabIndex = 1;
            // 
            // panelGuardar
            // 
            this.panelGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuardar.Location = new System.Drawing.Point(755, 0);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(161, 420);
            this.panelGuardar.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridBuquedaProducto);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(755, 420);
            this.panelGrid.TabIndex = 0;
            // 
            // sfDataGridBuquedaProducto
            // 
            this.sfDataGridBuquedaProducto.AccessibleName = "Table";
            this.sfDataGridBuquedaProducto.AllowEditing = false;
            this.sfDataGridBuquedaProducto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "IdProducto";
            gridTextColumn1.MappingName = "IdProducto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Nombre";
            gridTextColumn3.MappingName = "Nombre";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Categoria";
            gridTextColumn4.MappingName = "NombreCategoria";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.HeaderText = "UnidadMedida";
            gridTextColumn5.MappingName = "UnidadMedida";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.HeaderText = "Precio Publico";
            gridTextColumn6.MappingName = "PrecioPublico";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.HeaderText = "Precio Mayoreo";
            gridTextColumn7.MappingName = "PrecioMayoreo";
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "Precio Menudeo";
            gridTextColumn8.MappingName = "PrecioMenudeo";
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn1);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn2);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn3);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn4);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn5);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn6);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn7);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn8);
            this.sfDataGridBuquedaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBuquedaProducto.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridBuquedaProducto.Name = "sfDataGridBuquedaProducto";
            this.sfDataGridBuquedaProducto.Size = new System.Drawing.Size(755, 420);
            this.sfDataGridBuquedaProducto.TabIndex = 2;
            this.sfDataGridBuquedaProducto.Text = "sfDataGrid1";
            // 
            // panelBuscador
            // 
            this.panelBuscador.Controls.Add(this.tableLayoutPanel1);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(916, 62);
            this.panelBuscador.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NombreControl);
            this.panel1.Controls.Add(this.BusqueNombreControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 49);
            this.panel1.TabIndex = 0;
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreControl.Location = new System.Drawing.Point(9, 26);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(226, 20);
            this.NombreControl.TabIndex = 6;
            // 
            // BusqueNombreControl
            // 
            this.BusqueNombreControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BusqueNombreControl.BeforeTouchSize = new System.Drawing.Size(155, 21);
            this.BusqueNombreControl.Location = new System.Drawing.Point(45, 1);
            this.BusqueNombreControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusqueNombreControl.Name = "BusqueNombreControl";
            this.BusqueNombreControl.Size = new System.Drawing.Size(155, 21);
            this.BusqueNombreControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusqueNombreControl.TabIndex = 7;
            this.BusqueNombreControl.Text = "Buscar por nombre producto";
            this.BusqueNombreControl.ThemeName = "Metro";
            this.BusqueNombreControl.ThemesEnabled = false;
            this.BusqueNombreControl.CheckedChanged += new System.EventHandler(this.BusqueNombreControl_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BuquedaClaveCodigoControl);
            this.panel2.Controls.Add(this.BusClaveBarraControl);
            this.panel2.Location = new System.Drawing.Point(280, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 49);
            this.panel2.TabIndex = 1;
            // 
            // BuquedaClaveCodigoControl
            // 
            this.BuquedaClaveCodigoControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BuquedaClaveCodigoControl.Location = new System.Drawing.Point(51, 26);
            this.BuquedaClaveCodigoControl.MaxLength = 200;
            this.BuquedaClaveCodigoControl.Name = "BuquedaClaveCodigoControl";
            this.BuquedaClaveCodigoControl.Size = new System.Drawing.Size(238, 20);
            this.BuquedaClaveCodigoControl.TabIndex = 8;
            // 
            // BusClaveBarraControl
            // 
            this.BusClaveBarraControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BusClaveBarraControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Location = new System.Drawing.Point(61, 2);
            this.BusClaveBarraControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusClaveBarraControl.Name = "BusClaveBarraControl";
            this.BusClaveBarraControl.Size = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusClaveBarraControl.TabIndex = 9;
            this.BusClaveBarraControl.Text = "Buscar por clave o codigo de barra";
            this.BusClaveBarraControl.ThemeName = "Metro";
            this.BusClaveBarraControl.ThemesEnabled = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.BtnBusqueda);
            this.panel3.Location = new System.Drawing.Point(618, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 49);
            this.panel3.TabIndex = 2;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(71, 7);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(111, 29);
            this.BtnBusqueda.TabIndex = 10;
            this.BtnBusqueda.Text = "Busqueda";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 482);
            this.Controls.Add(this.panelContenedor);
            this.MaximumSize = new System.Drawing.Size(932, 521);
            this.MinimumSize = new System.Drawing.Size(932, 521);
            this.Name = "FrmBusquedaProducto";
            this.Text = "BusquedaProducto";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedoGridGuardar.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelContenedoGridGuardar;
        private System.Windows.Forms.Panel panelGuardar;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Button BtnBusqueda;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBuquedaProducto;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusClaveBarraControl;
        private System.Windows.Forms.TextBox BuquedaClaveCodigoControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusqueNombreControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}