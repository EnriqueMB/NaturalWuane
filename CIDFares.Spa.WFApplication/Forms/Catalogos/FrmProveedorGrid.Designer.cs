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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn29 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn30 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn31 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn32 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarControl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridProveedor = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorGridProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BuscarControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(1164, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 24);
            this.btnBuscar.TabIndex = 186;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(755, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 184;
            this.label1.Text = "Clave / Nombre:";
            // 
            // BuscarControl
            // 
            this.BuscarControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BuscarControl.Location = new System.Drawing.Point(881, 21);
            this.BuscarControl.MaxLength = 200;
            this.BuscarControl.Name = "BuscarControl";
            this.BuscarControl.Size = new System.Drawing.Size(263, 22);
            this.BuscarControl.TabIndex = 182;
            this.BuscarControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarControl_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 68);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataGridProveedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 352);
            this.panel3.TabIndex = 2;
            // 
            // DataGridProveedor
            // 
            this.DataGridProveedor.AccessibleName = "Table";
            this.DataGridProveedor.AllowEditing = false;
            this.DataGridProveedor.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.HeaderText = "Column1";
            gridTextColumn17.MappingName = "IdProveedor";
            gridTextColumn17.Visible = false;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.HeaderText = "Clave";
            gridTextColumn18.MappingName = "Clave";
            gridTextColumn19.AllowEditing = false;
            gridTextColumn19.HeaderText = "Nombre comercial";
            gridTextColumn19.MappingName = "NombreComercial";
            gridTextColumn20.AllowEditing = false;
            gridTextColumn20.HeaderText = "Razón social";
            gridTextColumn20.MappingName = "RazonSocial";
            gridTextColumn21.AllowEditing = false;
            gridTextColumn21.HeaderText = "Representante";
            gridTextColumn21.MappingName = "Representante";
            gridTextColumn22.AllowEditing = false;
            gridTextColumn22.HeaderText = "RFC";
            gridTextColumn22.MappingName = "RFC";
            gridTextColumn23.AllowEditing = false;
            gridTextColumn23.HeaderText = "Dirección";
            gridTextColumn23.MappingName = "Direccion";
            gridTextColumn24.AllowEditing = false;
            gridTextColumn24.HeaderText = "Telefono";
            gridTextColumn24.MappingName = "Telefono";
            gridTextColumn25.AllowEditing = false;
            gridTextColumn25.HeaderText = "Correo";
            gridTextColumn25.MappingName = "CorreoElectronico";
            gridTextColumn26.AllowEditing = false;
            gridTextColumn26.HeaderText = "Código postal";
            gridTextColumn26.MappingName = "CodigoPostal";
            gridTextColumn27.AllowEditing = false;
            gridTextColumn27.HeaderText = "IdPais";
            gridTextColumn27.MappingName = "IdPais";
            gridTextColumn27.Visible = false;
            gridTextColumn28.AllowEditing = false;
            gridTextColumn28.HeaderText = "País";
            gridTextColumn28.MappingName = "Pais";
            gridTextColumn29.AllowEditing = false;
            gridTextColumn29.HeaderText = "Column15";
            gridTextColumn29.MappingName = "IdEstado";
            gridTextColumn29.Visible = false;
            gridTextColumn30.AllowEditing = false;
            gridTextColumn30.HeaderText = "Estado";
            gridTextColumn30.MappingName = "Estado";
            gridTextColumn31.AllowEditing = false;
            gridTextColumn31.HeaderText = "Column17";
            gridTextColumn31.MappingName = "IdMunicipio";
            gridTextColumn31.Visible = false;
            gridTextColumn32.AllowEditing = false;
            gridTextColumn32.HeaderText = "Municipio";
            gridTextColumn32.MappingName = "Municipio";
            this.DataGridProveedor.Columns.Add(gridTextColumn17);
            this.DataGridProveedor.Columns.Add(gridTextColumn18);
            this.DataGridProveedor.Columns.Add(gridTextColumn19);
            this.DataGridProveedor.Columns.Add(gridTextColumn20);
            this.DataGridProveedor.Columns.Add(gridTextColumn21);
            this.DataGridProveedor.Columns.Add(gridTextColumn22);
            this.DataGridProveedor.Columns.Add(gridTextColumn23);
            this.DataGridProveedor.Columns.Add(gridTextColumn24);
            this.DataGridProveedor.Columns.Add(gridTextColumn25);
            this.DataGridProveedor.Columns.Add(gridTextColumn26);
            this.DataGridProveedor.Columns.Add(gridTextColumn27);
            this.DataGridProveedor.Columns.Add(gridTextColumn28);
            this.DataGridProveedor.Columns.Add(gridTextColumn29);
            this.DataGridProveedor.Columns.Add(gridTextColumn30);
            this.DataGridProveedor.Columns.Add(gridTextColumn31);
            this.DataGridProveedor.Columns.Add(gridTextColumn32);
            this.DataGridProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridProveedor.Location = new System.Drawing.Point(0, 0);
            this.DataGridProveedor.Name = "DataGridProveedor";
            this.DataGridProveedor.Size = new System.Drawing.Size(1239, 352);
            this.DataGridProveedor.TabIndex = 0;
            this.DataGridProveedor.Text = "sfDataGrid1";
            // 
            // errorGridProveedor
            // 
            this.errorGridProveedor.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 30);
            this.label3.TabIndex = 187;
            this.label3.Text = "Proveedor";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.IsBackStageButton = false;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.IsBackStageButton = false;
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IsBackStageButton = false;
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmProveedorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox BuscarControl;
        private System.Windows.Forms.ErrorProvider errorGridProveedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private Library.Controls.Btn.Btn btnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
    }
}