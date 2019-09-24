namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmBuscarVentas
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelgeneral1 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridsfBVentas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.panelgeneral1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsfBVentas)).BeginInit();
            this.panelbtn.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelgeneral1);
            this.panelGeneral.Controls.Add(this.panelTitulo);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 450);
            this.panelGeneral.TabIndex = 0;
            // 
            // panelgeneral1
            // 
            this.panelgeneral1.Controls.Add(this.panelGrid);
            this.panelgeneral1.Controls.Add(this.panelbtn);
            this.panelgeneral1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgeneral1.Location = new System.Drawing.Point(0, 61);
            this.panelgeneral1.Name = "panelgeneral1";
            this.panelgeneral1.Size = new System.Drawing.Size(800, 389);
            this.panelgeneral1.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridsfBVentas);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 344);
            this.panelGrid.TabIndex = 1;
            // 
            // dataGridsfBVentas
            // 
            this.dataGridsfBVentas.AccessibleName = "Table";
            this.dataGridsfBVentas.AllowDraggingColumns = true;
            this.dataGridsfBVentas.AllowEditing = false;
            this.dataGridsfBVentas.AllowFiltering = true;
            this.dataGridsfBVentas.AutoExpandGroups = true;
            this.dataGridsfBVentas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dataGridsfBVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdVenta";
            gridTextColumn1.MappingName = "IdVenta";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "LocalId";
            gridTextColumn2.MappingName = "LocalId";
            gridTextColumn2.Visible = false;
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Folio";
            gridTextColumn3.MappingName = "Folio";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.Format = "dd/MM/yyyy";
            gridTextColumn4.HeaderText = "Fecha";
            gridTextColumn4.MappingName = "FechaVenta";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Cliente";
            gridTextColumn5.MappingName = "ClienteVenta.NombreCompleto";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Sucursal";
            gridTextColumn6.MappingName = "SucursalDatos.Nombre";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.Format = "C2";
            gridTextColumn7.HeaderText = "SubTotal";
            gridTextColumn7.MappingName = "Subtotal";
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.Format = "C2";
            gridTextColumn8.HeaderText = "Iva";
            gridTextColumn8.MappingName = "PorcentajeIva";
            gridTextColumn9.AllowDragging = true;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.Format = "C2";
            gridTextColumn9.HeaderText = "Total";
            gridTextColumn9.MappingName = "Total";
            this.dataGridsfBVentas.Columns.Add(gridTextColumn1);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn2);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn3);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn4);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn5);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn6);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn7);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn8);
            this.dataGridsfBVentas.Columns.Add(gridTextColumn9);
            this.dataGridsfBVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridsfBVentas.Location = new System.Drawing.Point(0, 0);
            this.dataGridsfBVentas.Name = "dataGridsfBVentas";
            this.dataGridsfBVentas.RowHeight = 21;
            this.dataGridsfBVentas.ShowGroupDropArea = true;
            this.dataGridsfBVentas.Size = new System.Drawing.Size(800, 344);
            this.dataGridsfBVentas.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsfBVentas.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridsfBVentas.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsfBVentas.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsfBVentas.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsfBVentas.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsfBVentas.Style.HeaderStyle.Font.Bold = false;
            this.dataGridsfBVentas.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsfBVentas.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsfBVentas.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsfBVentas.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsfBVentas.TabIndex = 1;
            this.dataGridsfBVentas.Text = "dataGridsf1";
            this.dataGridsfBVentas.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.DataGridsfBVentas_CellDoubleClick);
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.btnSeleccionar);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtn.Location = new System.Drawing.Point(0, 344);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(800, 45);
            this.panelbtn.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(643, 6);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(123, 29);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 61);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas del dia de la sucursal";
            // 
            // FrmBuscarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGeneral);
            this.Name = "FrmBuscarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarVentas";
            this.Load += new System.EventHandler(this.FrmBuscarVentas_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelgeneral1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsfBVentas)).EndInit();
            this.panelbtn.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelgeneral1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private Library.Controls.CIDDataGridsf.DataGridsf dataGridsfBVentas;
    }
}