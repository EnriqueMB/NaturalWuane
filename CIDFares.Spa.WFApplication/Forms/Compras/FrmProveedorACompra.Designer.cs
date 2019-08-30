namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    partial class FrmProveedorACompra
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulos.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
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
            this.pnlTitulos.Size = new System.Drawing.Size(818, 70);
            this.pnlTitulos.TabIndex = 3;
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
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(676, 29);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(130, 28);
            this.btnLimpiarBusqueda.TabIndex = 183;
            this.btnLimpiarBusqueda.Text = "ELIMINAR FILTROS";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusquedaControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaControl.Location = new System.Drawing.Point(178, 32);
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(319, 19);
            this.BusquedaControl.TabIndex = 182;
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
            this.btnBusqueda.Location = new System.Drawing.Point(526, 29);
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
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 25);
            this.lblTitulo.TabIndex = 180;
            this.lblTitulo.Text = "PROVEEDORES";
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.BtnSeleccionar);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 361);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(818, 74);
            this.FlpBotones.TabIndex = 4;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(665, 23);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(130, 28);
            this.BtnSeleccionar.TabIndex = 13;
            this.BtnSeleccionar.Text = "SELECCIONAR";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 291);
            this.panel1.TabIndex = 5;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.AutoExpandGroups = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "IdProveedor";
            gridTextColumn1.MappingName = "IdProveedor";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Nombre Comercial";
            gridTextColumn3.MappingName = "NombreComercial";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Razon Social";
            gridTextColumn4.MappingName = "RazonSocial";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.HeaderText = "Representante";
            gridTextColumn5.MappingName = "Representante";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.HeaderText = "Direccion";
            gridTextColumn6.MappingName = "Direccion";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.HeaderText = "Telefono";
            gridTextColumn7.MappingName = "Telefono";
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "Correo Electronico";
            gridTextColumn8.MappingName = "CorreoElectronico";
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.HeaderText = "Pais";
            gridTextColumn9.MappingName = "Pais";
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "Estado";
            gridTextColumn10.MappingName = "Estado";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Municipio";
            gridTextColumn11.MappingName = "Municipio";
            this.sfDataGrid1.Columns.Add(gridTextColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn2);
            this.sfDataGrid1.Columns.Add(gridTextColumn3);
            this.sfDataGrid1.Columns.Add(gridTextColumn4);
            this.sfDataGrid1.Columns.Add(gridTextColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn6);
            this.sfDataGrid1.Columns.Add(gridTextColumn7);
            this.sfDataGrid1.Columns.Add(gridTextColumn8);
            this.sfDataGrid1.Columns.Add(gridTextColumn9);
            this.sfDataGrid1.Columns.Add(gridTextColumn10);
            this.sfDataGrid1.Columns.Add(gridTextColumn11);
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(818, 291);
            this.sfDataGrid1.TabIndex = 2;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProveedorACompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.pnlTitulos);
            this.MinimumSize = new System.Drawing.Size(826, 333);
            this.Name = "FrmProveedorACompra";
            this.Text = "FrmProveedorACompra";
            this.Load += new System.EventHandler(this.FrmProveedorACompra_Load);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulos;
        public System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox BusquedaControl;
        public System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}