namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmProveedorGrid
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BuscarControl = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridProveedor = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorGridProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.BuscarControl);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Clave o nombre comercial:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(1104, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 29);
            this.btnBuscar.TabIndex = 183;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarControl
            // 
            this.BuscarControl.Location = new System.Drawing.Point(896, 27);
            this.BuscarControl.Name = "BuscarControl";
            this.BuscarControl.Size = new System.Drawing.Size(193, 20);
            this.BuscarControl.TabIndex = 182;
            this.BuscarControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarControl_KeyPress);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(12, 42);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(123, 25);
            this.lblProveedor.TabIndex = 181;
            this.lblProveedor.Text = "PROVEEDOR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 67);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(368, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 51);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataGridProveedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 341);
            this.panel3.TabIndex = 2;
            // 
            // DataGridProveedor
            // 
            this.DataGridProveedor.AccessibleName = "Table";
            this.DataGridProveedor.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdProveedor";
            gridTextColumn1.Visible = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.HeaderText = "Nombre comercial";
            gridTextColumn3.MappingName = "NombreComercial";
            gridTextColumn4.HeaderText = "Razon social";
            gridTextColumn4.MappingName = "RazonSocial";
            gridTextColumn5.HeaderText = "Representante";
            gridTextColumn5.MappingName = "Representante";
            gridTextColumn6.HeaderText = "RFC";
            gridTextColumn6.MappingName = "RFC";
            gridTextColumn7.HeaderText = "Dirección";
            gridTextColumn7.MappingName = "Direccion";
            gridTextColumn8.HeaderText = "Telefono";
            gridTextColumn8.MappingName = "Telefono";
            gridTextColumn9.HeaderText = "Correo electronico";
            gridTextColumn9.MappingName = "CorreoElectronico";
            gridTextColumn10.HeaderText = "Código postal";
            gridTextColumn10.MappingName = "CodigoPostal";
            gridTextColumn11.HeaderText = "IdPais";
            gridTextColumn11.MappingName = "IdPais";
            gridTextColumn11.Visible = false;
            gridTextColumn12.HeaderText = "País";
            gridTextColumn12.MappingName = "Pais";
            gridTextColumn13.HeaderText = "Column15";
            gridTextColumn13.MappingName = "IdEstado";
            gridTextColumn13.Visible = false;
            gridTextColumn14.HeaderText = "Estado";
            gridTextColumn14.MappingName = "Estado";
            gridTextColumn15.HeaderText = "Column17";
            gridTextColumn15.MappingName = "IdMunicipio";
            gridTextColumn15.Visible = false;
            gridTextColumn16.HeaderText = "Municipio";
            gridTextColumn16.MappingName = "Municipio";
            this.DataGridProveedor.Columns.Add(gridTextColumn1);
            this.DataGridProveedor.Columns.Add(gridTextColumn2);
            this.DataGridProveedor.Columns.Add(gridTextColumn3);
            this.DataGridProveedor.Columns.Add(gridTextColumn4);
            this.DataGridProveedor.Columns.Add(gridTextColumn5);
            this.DataGridProveedor.Columns.Add(gridTextColumn6);
            this.DataGridProveedor.Columns.Add(gridTextColumn7);
            this.DataGridProveedor.Columns.Add(gridTextColumn8);
            this.DataGridProveedor.Columns.Add(gridTextColumn9);
            this.DataGridProveedor.Columns.Add(gridTextColumn10);
            this.DataGridProveedor.Columns.Add(gridTextColumn11);
            this.DataGridProveedor.Columns.Add(gridTextColumn12);
            this.DataGridProveedor.Columns.Add(gridTextColumn13);
            this.DataGridProveedor.Columns.Add(gridTextColumn14);
            this.DataGridProveedor.Columns.Add(gridTextColumn15);
            this.DataGridProveedor.Columns.Add(gridTextColumn16);
            this.DataGridProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridProveedor.Location = new System.Drawing.Point(0, 0);
            this.DataGridProveedor.Name = "DataGridProveedor";
            this.DataGridProveedor.Size = new System.Drawing.Size(1239, 341);
            this.DataGridProveedor.TabIndex = 0;
            this.DataGridProveedor.Text = "sfDataGrid1";
            // 
            // errorGridProveedor
            // 
            this.errorGridProveedor.ContainerControl = this;
            // 
            // FrmProveedorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProveedorGrid";
            this.Text = "FrmProveedorGrid";
            this.Shown += new System.EventHandler(this.FrmProveedorGrid_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGridProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGridProveedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox BuscarControl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorGridProveedor;
        private System.Windows.Forms.Label label1;
    }
}