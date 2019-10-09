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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenedoGridGuardar = new System.Windows.Forms.Panel();
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadProductoControl = new System.Windows.Forms.TextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.sfDataGridBuquedaProducto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.ErrorControl = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BuquedaClaveCodigoControl = new System.Windows.Forms.TextBox();
            this.BusqueNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BusClaveBarraControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelContenedoGridGuardar.SuspendLayout();
            this.panelGuardar.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).BeginInit();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).BeginInit();
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
            this.panelContenedoGridGuardar.Location = new System.Drawing.Point(0, 58);
            this.panelContenedoGridGuardar.Name = "panelContenedoGridGuardar";
            this.panelContenedoGridGuardar.Size = new System.Drawing.Size(916, 424);
            this.panelContenedoGridGuardar.TabIndex = 1;
            // 
            // panelGuardar
            // 
            this.panelGuardar.Controls.Add(this.BtnAgregar);
            this.panelGuardar.Controls.Add(this.label1);
            this.panelGuardar.Controls.Add(this.CantidadProductoControl);
            this.panelGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGuardar.Location = new System.Drawing.Point(755, 0);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(161, 420);
            this.panelGuardar.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(22, 169);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 29);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad:";
            // 
            // CantidadProductoControl
            // 
            this.CantidadProductoControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CantidadProductoControl.Location = new System.Drawing.Point(20, 128);
            this.CantidadProductoControl.MaxLength = 200;
            this.CantidadProductoControl.Name = "CantidadProductoControl";
            this.CantidadProductoControl.Size = new System.Drawing.Size(113, 29);
            this.CantidadProductoControl.TabIndex = 7;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridBuquedaProducto);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(755, 424);
            this.panelGrid.TabIndex = 0;
            // 
            // sfDataGridBuquedaProducto
            // 
            this.sfDataGridBuquedaProducto.AccessibleName = "Table";
            this.sfDataGridBuquedaProducto.AllowEditing = false;
            this.sfDataGridBuquedaProducto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "IdProducto";
            gridTextColumn10.MappingName = "IdProducto";
            gridTextColumn10.Visible = false;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Clave";
            gridTextColumn11.MappingName = "Clave";
            gridTextColumn11.MaximumWidth = 100D;
            gridTextColumn11.MinimumWidth = 90D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.HeaderText = "Nombre";
            gridTextColumn12.MappingName = "Nombre";
            gridTextColumn12.MaximumWidth = 200D;
            gridTextColumn12.MinimumWidth = 200D;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.HeaderText = "Existencia";
            gridTextColumn13.MappingName = "CantidadProducto";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.HeaderText = "Categoria";
            gridTextColumn14.MappingName = "NombreCategoria";
            gridTextColumn14.Visible = false;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.HeaderText = "UM";
            gridTextColumn15.MappingName = "UnidadMedida";
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.Format = "C2";
            gridTextColumn16.HeaderText = "P. Publico";
            gridTextColumn16.MappingName = "PrecioPublico";
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.HeaderText = "Porcentaje Paquete";
            gridTextColumn17.MappingName = "PorcentajePaquete";
            gridTextColumn17.Visible = false;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.Format = "C";
            gridTextColumn18.HeaderText = "Costo";
            gridTextColumn18.MappingName = "CostoProducto";
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn10);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn11);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn12);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn13);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn14);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn15);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn16);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn17);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn18);
            this.sfDataGridBuquedaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBuquedaProducto.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridBuquedaProducto.Name = "sfDataGridBuquedaProducto";
            this.sfDataGridBuquedaProducto.Size = new System.Drawing.Size(755, 424);
            this.sfDataGridBuquedaProducto.TabIndex = 2;
            this.sfDataGridBuquedaProducto.Text = "sfDataGrid1";
            this.sfDataGridBuquedaProducto.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.sfDataGridBuquedaProducto_CellDoubleClick);
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panelBuscador.Controls.Add(this.lblTitulo);
            this.panelBuscador.Controls.Add(this.BtnBusqueda);
            this.panelBuscador.Controls.Add(this.ErrorControl);
            this.panelBuscador.Controls.Add(this.NombreControl);
            this.panelBuscador.Controls.Add(this.BuquedaClaveCodigoControl);
            this.panelBuscador.Controls.Add(this.BusqueNombreControl);
            this.panelBuscador.Controls.Add(this.BusClaveBarraControl);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(916, 58);
            this.panelBuscador.TabIndex = 0;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnBusqueda.BackColor = System.Drawing.Color.White;
            this.BtnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(812, 16);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(89, 26);
            this.BtnBusqueda.TabIndex = 13;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // ErrorControl
            // 
            this.ErrorControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ErrorControl.AutoSize = true;
            this.ErrorControl.Location = new System.Drawing.Point(752, 23);
            this.ErrorControl.Name = "ErrorControl";
            this.ErrorControl.Size = new System.Drawing.Size(0, 13);
            this.ErrorControl.TabIndex = 11;
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NombreControl.Location = new System.Drawing.Point(507, 29);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(226, 20);
            this.NombreControl.TabIndex = 6;
            this.NombreControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreControl_KeyPress);
            // 
            // BuquedaClaveCodigoControl
            // 
            this.BuquedaClaveCodigoControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuquedaClaveCodigoControl.Location = new System.Drawing.Point(225, 28);
            this.BuquedaClaveCodigoControl.MaxLength = 200;
            this.BuquedaClaveCodigoControl.Name = "BuquedaClaveCodigoControl";
            this.BuquedaClaveCodigoControl.Size = new System.Drawing.Size(238, 20);
            this.BuquedaClaveCodigoControl.TabIndex = 8;
            this.BuquedaClaveCodigoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuquedaClaveCodigoControl_KeyPress);
            // 
            // BusqueNombreControl
            // 
            this.BusqueNombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusqueNombreControl.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.BusqueNombreControl.Location = new System.Drawing.Point(533, 4);
            this.BusqueNombreControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusqueNombreControl.Name = "BusqueNombreControl";
            this.BusqueNombreControl.Size = new System.Drawing.Size(175, 21);
            this.BusqueNombreControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusqueNombreControl.TabIndex = 7;
            this.BusqueNombreControl.Text = "Buscar por producto";
            this.BusqueNombreControl.ThemeName = "Metro";
            this.BusqueNombreControl.ThemesEnabled = false;
            this.BusqueNombreControl.CheckedChanged += new System.EventHandler(this.BusqueNombreControl_CheckedChanged);
            // 
            // BusClaveBarraControl
            // 
            this.BusClaveBarraControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusClaveBarraControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Location = new System.Drawing.Point(235, 4);
            this.BusClaveBarraControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusClaveBarraControl.Name = "BusClaveBarraControl";
            this.BusClaveBarraControl.Size = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusClaveBarraControl.TabIndex = 9;
            this.BusClaveBarraControl.Text = "Buscar por clave o codigo de barra";
            this.BusClaveBarraControl.ThemeName = "Metro";
            this.BusClaveBarraControl.ThemesEnabled = false;
            this.BusClaveBarraControl.CheckedChanged += new System.EventHandler(this.BusClaveBarraControl_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 30);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Buscar producto";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaProducto";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedoGridGuardar.ResumeLayout(false);
            this.panelGuardar.ResumeLayout(false);
            this.panelGuardar.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBuquedaProducto)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).EndInit();
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
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBuquedaProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusqueNombreControl;
        private System.Windows.Forms.TextBox BuquedaClaveCodigoControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusClaveBarraControl;
        private System.Windows.Forms.TextBox CantidadProductoControl;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorControl;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label lblTitulo;
    }
}