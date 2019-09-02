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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenedoGridGuardar = new System.Windows.Forms.Panel();
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadProductoControl = new System.Windows.Forms.TextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.sfDataGridBuquedaProducto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.ErrorControl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BuquedaClaveCodigoControl = new System.Windows.Forms.TextBox();
            this.BusqueNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BusClaveBarraControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.panelContenedoGridGuardar.Location = new System.Drawing.Point(0, 62);
            this.panelContenedoGridGuardar.Name = "panelContenedoGridGuardar";
            this.panelContenedoGridGuardar.Size = new System.Drawing.Size(916, 420);
            this.panelContenedoGridGuardar.TabIndex = 1;
            // 
            // panelGuardar
            // 
            this.panelGuardar.Controls.Add(this.BtnAgregar);
            this.panelGuardar.Controls.Add(this.label1);
            this.panelGuardar.Controls.Add(this.CantidadProductoControl);
            this.panelGuardar.Location = new System.Drawing.Point(755, 0);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(161, 420);
            this.panelGuardar.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(22, 169);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 29);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar venta";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad a vender:";
            // 
            // CantidadProductoControl
            // 
            this.CantidadProductoControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CantidadProductoControl.Location = new System.Drawing.Point(20, 128);
            this.CantidadProductoControl.MaxLength = 200;
            this.CantidadProductoControl.Name = "CantidadProductoControl";
            this.CantidadProductoControl.Size = new System.Drawing.Size(113, 20);
            this.CantidadProductoControl.TabIndex = 7;
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
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.HeaderText = "IdProducto";
            gridTextColumn9.MappingName = "IdProducto";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "Clave";
            gridTextColumn10.MappingName = "Clave";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Nombre";
            gridTextColumn11.MappingName = "Nombre";
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.HeaderText = "Categoria";
            gridTextColumn12.MappingName = "NombreCategoria";
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.HeaderText = "UnidadMedida";
            gridTextColumn13.MappingName = "UnidadMedida";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.Format = "C2";
            gridTextColumn14.HeaderText = "Precio Publico";
            gridTextColumn14.MappingName = "PrecioPublico";
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.Format = "C2";
            gridTextColumn15.HeaderText = "Precio Mayoreo";
            gridTextColumn15.MappingName = "PrecioMayoreo";
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.Format = "C2";
            gridTextColumn16.HeaderText = "Precio Menudeo";
            gridTextColumn16.MappingName = "PrecioMenudeo";
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn9);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn10);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn11);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn12);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn13);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn14);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn15);
            this.sfDataGridBuquedaProducto.Columns.Add(gridTextColumn16);
            this.sfDataGridBuquedaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBuquedaProducto.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridBuquedaProducto.Name = "sfDataGridBuquedaProducto";
            this.sfDataGridBuquedaProducto.Size = new System.Drawing.Size(755, 420);
            this.sfDataGridBuquedaProducto.TabIndex = 2;
            this.sfDataGridBuquedaProducto.Text = "sfDataGrid1";
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panelBuscador.Controls.Add(this.ErrorControl);
            this.panelBuscador.Controls.Add(this.label2);
            this.panelBuscador.Controls.Add(this.BtnBusqueda);
            this.panelBuscador.Controls.Add(this.NombreControl);
            this.panelBuscador.Controls.Add(this.BuquedaClaveCodigoControl);
            this.panelBuscador.Controls.Add(this.BusqueNombreControl);
            this.panelBuscador.Controls.Add(this.BusClaveBarraControl);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(916, 62);
            this.panelBuscador.TabIndex = 0;
            // 
            // ErrorControl
            // 
            this.ErrorControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ErrorControl.AutoSize = true;
            this.ErrorControl.Location = new System.Drawing.Point(752, 30);
            this.ErrorControl.Name = "ErrorControl";
            this.ErrorControl.Size = new System.Drawing.Size(0, 13);
            this.ErrorControl.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar producto";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(795, 18);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(89, 26);
            this.BtnBusqueda.TabIndex = 11;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NombreControl.Location = new System.Drawing.Point(483, 31);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(226, 20);
            this.NombreControl.TabIndex = 6;
            this.NombreControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreControl_KeyPress);
            // 
            // BuquedaClaveCodigoControl
            // 
            this.BuquedaClaveCodigoControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuquedaClaveCodigoControl.Location = new System.Drawing.Point(201, 30);
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
            this.BusqueNombreControl.Location = new System.Drawing.Point(509, 6);
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
            this.BusClaveBarraControl.Location = new System.Drawing.Point(211, 6);
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
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorControl;
    }
}