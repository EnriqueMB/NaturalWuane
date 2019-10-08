namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmProductoGrid
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn21 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn22 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn23 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn24 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn25 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn26 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn27 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn28 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dataGridMain1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulos.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlTitulos.Controls.Add(this.BusquedaControl);
            this.pnlTitulos.Controls.Add(this.btnBusqueda);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1048, 58);
            this.pnlTitulos.TabIndex = 2;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(856, 16);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(130, 28);
            this.btnLimpiarBusqueda.TabIndex = 183;
            this.btnLimpiarBusqueda.Text = "ELIMINAR FILTROS";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusquedaControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaControl.Location = new System.Drawing.Point(329, 20);
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(355, 19);
            this.BusquedaControl.TabIndex = 182;
            this.BusquedaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusquedaControl_KeyPress);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(704, 16);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(130, 28);
            this.btnBusqueda.TabIndex = 181;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 25);
            this.lblTitulo.TabIndex = 180;
            this.lblTitulo.Text = "PRODUCTO";
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnEliminar);
            this.FlpBotones.Controls.Add(this.btnModificar);
            this.FlpBotones.Controls.Add(this.BtnNuevo);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 528);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(1048, 74);
            this.FlpBotones.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(895, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 28);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(132)))), ((int)(((byte)(51)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(759, 23);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 28);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(623, 23);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 28);
            this.BtnNuevo.TabIndex = 13;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dataGridMain1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 58);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1048, 470);
            this.pnlContainer.TabIndex = 4;
            // 
            // dataGridMain1
            // 
            this.dataGridMain1.AccessibleName = "Table";
            this.dataGridMain1.AllowEditing = false;
            this.dataGridMain1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.HeaderText = "Column1";
            gridTextColumn15.MappingName = "IdProducto";
            gridTextColumn15.Visible = false;
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.HeaderText = "Clave";
            gridTextColumn16.MappingName = "Clave";
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.HeaderText = "Producto";
            gridTextColumn17.MappingName = "Nombre";
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.HeaderText = "Categoria";
            gridTextColumn18.MappingName = "Categoria";
            gridTextColumn19.AllowEditing = false;
            gridTextColumn19.HeaderText = "Descripcion";
            gridTextColumn19.MappingName = "Descripcion";
            gridTextColumn20.AllowEditing = false;
            gridTextColumn20.HeaderText = "Stock";
            gridTextColumn20.MappingName = "StockStr";
            gridTextColumn21.AllowEditing = false;
            gridTextColumn21.HeaderText = "StockMax";
            gridTextColumn21.MappingName = "StockMax";
            gridTextColumn22.AllowEditing = false;
            gridTextColumn22.HeaderText = "StockMin";
            gridTextColumn22.MappingName = "StockMin";
            gridTextColumn23.AllowEditing = false;
            gridTextColumn23.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            gridTextColumn23.Format = "C";
            gridTextColumn23.HeaderText = "Precio publico";
            gridTextColumn23.MappingName = "PrecioPublico";
            gridTextColumn24.AllowEditing = false;
            gridTextColumn24.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            gridTextColumn24.Format = "C";
            gridTextColumn24.HeaderText = "Precio mayoreo";
            gridTextColumn24.MappingName = "PrecioMayoreo";
            gridTextColumn25.AllowEditing = false;
            gridTextColumn25.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            gridTextColumn25.Format = "C";
            gridTextColumn25.HeaderText = "Precio menudeo";
            gridTextColumn25.MappingName = "PrecioMenudeo";
            gridTextColumn26.AllowEditing = false;
            gridTextColumn26.HeaderText = "Unidad de medida";
            gridTextColumn26.MappingName = "UnidadMedida";
            gridTextColumn27.AllowEditing = false;
            gridTextColumn27.HeaderText = "Clave SAT";
            gridTextColumn27.MappingName = "ClaveSat";
            gridTextColumn27.Visible = false;
            gridTextColumn28.AllowEditing = false;
            gridTextColumn28.HeaderText = "Porcentaje Iva";
            gridTextColumn28.MappingName = "Porcentaje";
            this.dataGridMain1.Columns.Add(gridTextColumn15);
            this.dataGridMain1.Columns.Add(gridTextColumn16);
            this.dataGridMain1.Columns.Add(gridTextColumn17);
            this.dataGridMain1.Columns.Add(gridTextColumn18);
            this.dataGridMain1.Columns.Add(gridTextColumn19);
            this.dataGridMain1.Columns.Add(gridTextColumn20);
            this.dataGridMain1.Columns.Add(gridTextColumn21);
            this.dataGridMain1.Columns.Add(gridTextColumn22);
            this.dataGridMain1.Columns.Add(gridTextColumn23);
            this.dataGridMain1.Columns.Add(gridTextColumn24);
            this.dataGridMain1.Columns.Add(gridTextColumn25);
            this.dataGridMain1.Columns.Add(gridTextColumn26);
            this.dataGridMain1.Columns.Add(gridTextColumn27);
            this.dataGridMain1.Columns.Add(gridTextColumn28);
            this.dataGridMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMain1.Location = new System.Drawing.Point(0, 0);
            this.dataGridMain1.Name = "dataGridMain1";
            this.dataGridMain1.Size = new System.Drawing.Size(1048, 470);
            this.dataGridMain1.TabIndex = 0;
            this.dataGridMain1.Text = "sfDataGrid1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 602);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.pnlTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductoGrid";
            this.Text = "FrmProductoGrid";
            this.Shown += new System.EventHandler(this.FrmProductoGrid_Shown);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel pnlContainer;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dataGridMain1;
        public System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox BusquedaControl;
        public System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}