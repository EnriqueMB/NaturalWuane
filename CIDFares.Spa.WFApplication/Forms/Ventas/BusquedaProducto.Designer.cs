namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class BusquedaProducto
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.panelContenedoGridGuardar = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BusqueNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BuqClaveOCodBarraControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BuquedaClaveCodigoControl = new System.Windows.Forms.TextBox();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.sfDataGridBuquedaProducto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelContenedor.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelContenedoGridGuardar.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuqClaveOCodBarraControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).BeginInit();
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
            // panelBuscador
            // 
            this.panelBuscador.Controls.Add(this.BtnBusqueda);
            this.panelBuscador.Controls.Add(this.BuqClaveOCodBarraControl);
            this.panelBuscador.Controls.Add(this.BuquedaClaveCodigoControl);
            this.panelBuscador.Controls.Add(this.BusqueNombreControl);
            this.panelBuscador.Controls.Add(this.NombreControl);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(916, 64);
            this.panelBuscador.TabIndex = 0;
            // 
            // panelContenedoGridGuardar
            // 
            this.panelContenedoGridGuardar.Controls.Add(this.panelGuardar);
            this.panelContenedoGridGuardar.Controls.Add(this.panelGrid);
            this.panelContenedoGridGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedoGridGuardar.Location = new System.Drawing.Point(0, 64);
            this.panelContenedoGridGuardar.Name = "panelContenedoGridGuardar";
            this.panelContenedoGridGuardar.Size = new System.Drawing.Size(916, 418);
            this.panelContenedoGridGuardar.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridBuquedaProducto);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(755, 418);
            this.panelGrid.TabIndex = 0;
            // 
            // panelGuardar
            // 
            this.panelGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuardar.Location = new System.Drawing.Point(755, 0);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(161, 418);
            this.panelGuardar.TabIndex = 1;
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(23, 31);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(238, 20);
            this.NombreControl.TabIndex = 6;
            // 
            // BusqueNombreControl
            // 
            this.BusqueNombreControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BusqueNombreControl.Location = new System.Drawing.Point(23, 4);
            this.BusqueNombreControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusqueNombreControl.Name = "BusqueNombreControl";
            this.BusqueNombreControl.Size = new System.Drawing.Size(238, 21);
            this.BusqueNombreControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusqueNombreControl.TabIndex = 7;
            this.BusqueNombreControl.Text = "Buscar por nombre producto";
            this.BusqueNombreControl.ThemeName = "Metro";
            this.BusqueNombreControl.ThemesEnabled = false;
            // 
            // BuqClaveOCodBarraControl
            // 
            this.BuqClaveOCodBarraControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BuqClaveOCodBarraControl.Location = new System.Drawing.Point(280, 4);
            this.BuqClaveOCodBarraControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BuqClaveOCodBarraControl.Name = "BuqClaveOCodBarraControl";
            this.BuqClaveOCodBarraControl.Size = new System.Drawing.Size(238, 21);
            this.BuqClaveOCodBarraControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BuqClaveOCodBarraControl.TabIndex = 9;
            this.BuqClaveOCodBarraControl.Text = "Buscar por clave o codigo de barra";
            this.BuqClaveOCodBarraControl.ThemeName = "Metro";
            this.BuqClaveOCodBarraControl.ThemesEnabled = false;
            // 
            // BuquedaClaveCodigoControl
            // 
            this.BuquedaClaveCodigoControl.Location = new System.Drawing.Point(280, 31);
            this.BuquedaClaveCodigoControl.MaxLength = 200;
            this.BuquedaClaveCodigoControl.Name = "BuquedaClaveCodigoControl";
            this.BuquedaClaveCodigoControl.Size = new System.Drawing.Size(238, 20);
            this.BuquedaClaveCodigoControl.TabIndex = 8;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(585, 18);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(123, 29);
            this.BtnBusqueda.TabIndex = 10;
            this.BtnBusqueda.Text = "Busqueda";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // sfDataGridBuquedaProducto
            // 
            this.sfDataGridBuquedaProducto.AccessibleName = "Table";
            this.sfDataGridBuquedaProducto.AllowEditing = false;
            this.sfDataGridBuquedaProducto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "IdProducto";
            gridTextColumn8.MappingName = "IdProducto";
            gridTextColumn8.Visible = false;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.HeaderText = "Clave";
            gridTextColumn9.MappingName = "Clave";
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "Nombre";
            gridTextColumn10.MappingName = "Nombre";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Categoria";
            gridTextColumn11.MappingName = "NombreCategoria";
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.HeaderText = "Precio Publico";
            gridTextColumn12.MappingName = "PrecioPublico";
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.HeaderText = "Precio Mayoreo";
            gridTextColumn13.MappingName = "PrecioMayoreo";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.HeaderText = "Precio Menudeo";
            gridTextColumn14.MappingName = "PrecioMenudeo";
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn8);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn9);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn10);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn11);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn12);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn13);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn14);
            this.sfDataGridBuquedaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBuquedaProducto.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridBuquedaProducto.Name = "sfDataGridBuquedaProducto";
            this.sfDataGridBuquedaProducto.Size = new System.Drawing.Size(755, 418);
            this.sfDataGridBuquedaProducto.TabIndex = 2;
            this.sfDataGridBuquedaProducto.Text = "sfDataGrid1";
            // 
            // BusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 482);
            this.Controls.Add(this.panelContenedor);
            this.Name = "BusquedaProducto";
            this.Text = "BusquedaProducto";
            this.panelContenedor.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelContenedoGridGuardar.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuqClaveOCodBarraControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelContenedoGridGuardar;
        private System.Windows.Forms.Panel panelGuardar;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelBuscador;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusqueNombreControl;
        private System.Windows.Forms.TextBox NombreControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BuqClaveOCodBarraControl;
        private System.Windows.Forms.TextBox BuquedaClaveCodigoControl;
        private System.Windows.Forms.Button BtnBusqueda;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBuquedaProducto;
    }
}