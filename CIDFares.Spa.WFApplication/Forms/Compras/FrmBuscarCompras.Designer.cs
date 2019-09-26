namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    partial class FrmBuscarCompras
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
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridBuscarCompras = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBusquedaFecha = new System.Windows.Forms.RadioButton();
            this.rbBusquedaClave = new System.Windows.Forms.RadioButton();
            this.dtpFechaFinControl = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioControl = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ClaveControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlGeneral.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.panel3);
            this.pnlGeneral.Controls.Add(this.panel2);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(907, 518);
            this.pnlGeneral.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridBuscarCompras);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 460);
            this.panel3.TabIndex = 3;
            // 
            // dataGridBuscarCompras
            // 
            this.dataGridBuscarCompras.AccessibleName = "Table";
            this.dataGridBuscarCompras.AllowDraggingColumns = true;
            this.dataGridBuscarCompras.AllowEditing = false;
            this.dataGridBuscarCompras.AllowFiltering = true;
            this.dataGridBuscarCompras.AutoExpandGroups = true;
            this.dataGridBuscarCompras.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dataGridBuscarCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdCompra";
            gridTextColumn1.MappingName = "IdCompra";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Folio";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.Format = "dd-MM-yyyy";
            gridTextColumn3.HeaderText = "Fecha";
            gridTextColumn3.MappingName = "FechaCompra";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Proveedor";
            gridTextColumn4.MappingName = "ProveedorCompra.NombreComercial";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "SubTotal";
            gridTextColumn5.MappingName = "SubTotal";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Iva";
            gridTextColumn6.MappingName = "Iva";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.Format = "C2";
            gridTextColumn7.HeaderText = "Total";
            gridTextColumn7.MappingName = "Total";
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Clave";
            gridTextColumn8.MappingName = "ProveedorCompra.Clave";
            gridTextColumn8.Visible = false;
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn1);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn2);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn3);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn4);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn5);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn6);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn7);
            this.dataGridBuscarCompras.Columns.Add(gridTextColumn8);
            this.dataGridBuscarCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBuscarCompras.Location = new System.Drawing.Point(0, 0);
            this.dataGridBuscarCompras.Name = "dataGridBuscarCompras";
            this.dataGridBuscarCompras.RowHeight = 21;
            this.dataGridBuscarCompras.ShowGroupDropArea = true;
            this.dataGridBuscarCompras.Size = new System.Drawing.Size(907, 419);
            this.dataGridBuscarCompras.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridBuscarCompras.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridBuscarCompras.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridBuscarCompras.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridBuscarCompras.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridBuscarCompras.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridBuscarCompras.Style.HeaderStyle.Font.Bold = false;
            this.dataGridBuscarCompras.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridBuscarCompras.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridBuscarCompras.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridBuscarCompras.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridBuscarCompras.TabIndex = 1;
            this.dataGridBuscarCompras.Text = "dataGridsf1";
            this.dataGridBuscarCompras.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.DataGridBuscarCompras_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 41);
            this.panel1.TabIndex = 6;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(712, 6);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(123, 29);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.rbBusquedaFecha);
            this.panel2.Controls.Add(this.rbBusquedaClave);
            this.panel2.Controls.Add(this.dtpFechaFinControl);
            this.panel2.Controls.Add(this.dtpFechaInicioControl);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.ClaveControl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 58);
            this.panel2.TabIndex = 2;
            // 
            // rbBusquedaFecha
            // 
            this.rbBusquedaFecha.AutoSize = true;
            this.rbBusquedaFecha.Location = new System.Drawing.Point(458, 5);
            this.rbBusquedaFecha.Name = "rbBusquedaFecha";
            this.rbBusquedaFecha.Size = new System.Drawing.Size(209, 17);
            this.rbBusquedaFecha.TabIndex = 9;
            this.rbBusquedaFecha.TabStop = true;
            this.rbBusquedaFecha.Text = "BUSQUEDA POR RANGO DE FECHA";
            this.rbBusquedaFecha.UseVisualStyleBackColor = true;
            // 
            // rbBusquedaClave
            // 
            this.rbBusquedaClave.AutoSize = true;
            this.rbBusquedaClave.Location = new System.Drawing.Point(181, 5);
            this.rbBusquedaClave.Name = "rbBusquedaClave";
            this.rbBusquedaClave.Size = new System.Drawing.Size(148, 17);
            this.rbBusquedaClave.TabIndex = 8;
            this.rbBusquedaClave.TabStop = true;
            this.rbBusquedaClave.Text = "BUSQUEDA POR CLAVE";
            this.rbBusquedaClave.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFinControl
            // 
            this.dtpFechaFinControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpFechaFinControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinControl.Location = new System.Drawing.Point(585, 28);
            this.dtpFechaFinControl.Name = "dtpFechaFinControl";
            this.dtpFechaFinControl.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaFinControl.TabIndex = 4;
            // 
            // dtpFechaInicioControl
            // 
            this.dtpFechaInicioControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpFechaInicioControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioControl.Location = new System.Drawing.Point(415, 29);
            this.dtpFechaInicioControl.Name = "dtpFechaInicioControl";
            this.dtpFechaInicioControl.Size = new System.Drawing.Size(146, 20);
            this.dtpFechaInicioControl.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(786, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ClaveControl
            // 
            this.ClaveControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClaveControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveControl.Location = new System.Drawing.Point(181, 28);
            this.ClaveControl.MaxLength = 20;
            this.ClaveControl.Name = "ClaveControl";
            this.ClaveControl.Size = new System.Drawing.Size(174, 19);
            this.ClaveControl.TabIndex = 1;
            this.ClaveControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClaveControl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Compras";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 518);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "FrmBuscarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarCompras";
            this.Load += new System.EventHandler(this.FrmBuscarCompras_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox ClaveControl;
        private System.Windows.Forms.Label label1;
        private Library.Controls.CIDDataGridsf.DataGridsf dataGridBuscarCompras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinControl;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioControl;
        private System.Windows.Forms.RadioButton rbBusquedaFecha;
        private System.Windows.Forms.RadioButton rbBusquedaClave;
    }
}