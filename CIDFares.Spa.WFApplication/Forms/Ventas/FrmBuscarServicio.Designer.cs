namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmBuscarServicio
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.sfDataGridBusqServicio = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelcantidad = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadServicioControl = new System.Windows.Forms.TextBox();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.ErrorControl = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BuquedaClaveControl = new System.Windows.Forms.TextBox();
            this.BandClaveControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BandNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelContenedor1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBusqServicio)).BeginInit();
            this.panelcantidad.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandClaveControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandNombreControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelContenedor1);
            this.panelContenedor.Controls.Add(this.panelBuscador);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 450);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.Controls.Add(this.panelGrid);
            this.panelContenedor1.Controls.Add(this.panelcantidad);
            this.panelContenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor1.Location = new System.Drawing.Point(0, 55);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(800, 395);
            this.panelContenedor1.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridBusqServicio);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(600, 395);
            this.panelGrid.TabIndex = 1;
            // 
            // sfDataGridBusqServicio
            // 
            this.sfDataGridBusqServicio.AccessibleName = "Table";
            this.sfDataGridBusqServicio.AllowEditing = false;
            this.sfDataGridBusqServicio.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "IdServicio";
            gridTextColumn1.MappingName = "IdServicio";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Nombre";
            gridTextColumn3.MappingName = "Nombre";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Tipo Servicio";
            gridTextColumn4.MappingName = "TipoServicio";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.HeaderText = "Duracion";
            gridTextColumn5.MappingName = "Duracion";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.Format = "C2";
            gridTextColumn6.HeaderText = "Precio";
            gridTextColumn6.MappingName = "Precio";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.Format = "N2";
            gridTextColumn7.HeaderText = "Porcentaje";
            gridTextColumn7.MappingName = "Porcentaje";
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "AplicaIEPS";
            gridTextColumn8.MappingName = "AplicaIEPS";
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.HeaderText = "IEPSMonto";
            gridTextColumn9.MappingName = "IEPSMonto";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.Format = "C2";
            gridTextColumn10.HeaderText = "IEPS";
            gridTextColumn10.MappingName = "IEPS";
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn1);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn2);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn3);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn4);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn5);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn6);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn7);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn8);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn9);
            this.sfDataGridBusqServicio.Columns.Add(gridTextColumn10);
            this.sfDataGridBusqServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBusqServicio.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridBusqServicio.Name = "sfDataGridBusqServicio";
            this.sfDataGridBusqServicio.Size = new System.Drawing.Size(600, 395);
            this.sfDataGridBusqServicio.TabIndex = 3;
            this.sfDataGridBusqServicio.Text = "sfDataGrid1";
            // 
            // panelcantidad
            // 
            this.panelcantidad.Controls.Add(this.BtnAgregar);
            this.panelcantidad.Controls.Add(this.label2);
            this.panelcantidad.Controls.Add(this.CantidadServicioControl);
            this.panelcantidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcantidad.Location = new System.Drawing.Point(600, 0);
            this.panelcantidad.Name = "panelcantidad";
            this.panelcantidad.Size = new System.Drawing.Size(200, 395);
            this.panelcantidad.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(37, 210);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 29);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar venta";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad a vender:";
            // 
            // CantidadServicioControl
            // 
            this.CantidadServicioControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadServicioControl.Location = new System.Drawing.Point(35, 169);
            this.CantidadServicioControl.MaxLength = 200;
            this.CantidadServicioControl.Name = "CantidadServicioControl";
            this.CantidadServicioControl.Size = new System.Drawing.Size(113, 20);
            this.CantidadServicioControl.TabIndex = 12;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panelBuscador.Controls.Add(this.ErrorControl);
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.BuquedaClaveControl);
            this.panelBuscador.Controls.Add(this.BandClaveControl);
            this.panelBuscador.Controls.Add(this.NombreControl);
            this.panelBuscador.Controls.Add(this.BandNombreControl);
            this.panelBuscador.Controls.Add(this.label1);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(800, 55);
            this.panelBuscador.TabIndex = 0;
            // 
            // ErrorControl
            // 
            this.ErrorControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ErrorControl.AutoSize = true;
            this.ErrorControl.Location = new System.Drawing.Point(663, 22);
            this.ErrorControl.Name = "ErrorControl";
            this.ErrorControl.Size = new System.Drawing.Size(0, 13);
            this.ErrorControl.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(686, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 26);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuquedaClaveControl
            // 
            this.BuquedaClaveControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuquedaClaveControl.Location = new System.Drawing.Point(156, 29);
            this.BuquedaClaveControl.MaxLength = 200;
            this.BuquedaClaveControl.Name = "BuquedaClaveControl";
            this.BuquedaClaveControl.Size = new System.Drawing.Size(238, 20);
            this.BuquedaClaveControl.TabIndex = 2;
            this.BuquedaClaveControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuquedaClaveControl_KeyPress);
            // 
            // BandClaveControl
            // 
            this.BandClaveControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BandClaveControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BandClaveControl.Location = new System.Drawing.Point(166, 5);
            this.BandClaveControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BandClaveControl.Name = "BandClaveControl";
            this.BandClaveControl.Size = new System.Drawing.Size(238, 21);
            this.BandClaveControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BandClaveControl.TabIndex = 1;
            this.BandClaveControl.Text = "Buscar por clave o codigo de barra";
            this.BandClaveControl.ThemeName = "Metro";
            this.BandClaveControl.ThemesEnabled = false;
            this.BandClaveControl.CheckedChanged += new System.EventHandler(this.BandClaveControl_CheckedChanged);
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NombreControl.Location = new System.Drawing.Point(410, 29);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(226, 20);
            this.NombreControl.TabIndex = 4;
            this.NombreControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreControl_KeyPress);
            // 
            // BandNombreControl
            // 
            this.BandNombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BandNombreControl.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.BandNombreControl.Location = new System.Drawing.Point(436, 4);
            this.BandNombreControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BandNombreControl.Name = "BandNombreControl";
            this.BandNombreControl.Size = new System.Drawing.Size(175, 21);
            this.BandNombreControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BandNombreControl.TabIndex = 3;
            this.BandNombreControl.Text = "Buscar por servicio";
            this.BandNombreControl.ThemeName = "Metro";
            this.BandNombreControl.ThemesEnabled = false;
            this.BandNombreControl.CheckedChanged += new System.EventHandler(this.BandNombreControl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar servicio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FrmBuscarServicio";
            this.Text = "FrmBuscarServicio";
            this.Load += new System.EventHandler(this.FrmBuscarServicio_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBusqServicio)).EndInit();
            this.panelcantidad.ResumeLayout(false);
            this.panelcantidad.PerformLayout();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandClaveControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandNombreControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BandNombreControl;
        private System.Windows.Forms.TextBox BuquedaClaveControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BandClaveControl;
        private System.Windows.Forms.Button btnBuscar;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBusqServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ErrorControl;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadServicioControl;
    }
}