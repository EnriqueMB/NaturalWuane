namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmCancelacion
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GroupColumnDescription groupColumnDescription2 = new Syncfusion.WinForms.DataGrid.GroupColumnDescription();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelCantenedor1 = new System.Windows.Forms.Panel();
            this.panelContenedor2 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridsfDetalleVenta = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClaveControl = new System.Windows.Forms.TextBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.MotivoControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelCantenedor1.SuspendLayout();
            this.panelContenedor2.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsfDetalleVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelbtn.SuspendLayout();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelCantenedor1);
            this.panelContenedor.Controls.Add(this.paneltitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(971, 454);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelCantenedor1
            // 
            this.panelCantenedor1.Controls.Add(this.panelContenedor2);
            this.panelCantenedor1.Controls.Add(this.panelbtn);
            this.panelCantenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCantenedor1.Location = new System.Drawing.Point(0, 58);
            this.panelCantenedor1.Name = "panelCantenedor1";
            this.panelCantenedor1.Size = new System.Drawing.Size(971, 396);
            this.panelCantenedor1.TabIndex = 1;
            // 
            // panelContenedor2
            // 
            this.panelContenedor2.Controls.Add(this.panelGrid);
            this.panelContenedor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor2.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor2.Name = "panelContenedor2";
            this.panelContenedor2.Size = new System.Drawing.Size(971, 356);
            this.panelContenedor2.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.groupBox2);
            this.panelGrid.Controls.Add(this.groupBox1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(971, 356);
            this.panelGrid.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridsfDetalleVenta);
            this.groupBox2.Location = new System.Drawing.Point(423, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 326);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Venta";
            // 
            // dataGridsfDetalleVenta
            // 
            this.dataGridsfDetalleVenta.AccessibleName = "Table";
            this.dataGridsfDetalleVenta.AllowDraggingColumns = true;
            this.dataGridsfDetalleVenta.AllowEditing = false;
            this.dataGridsfDetalleVenta.AllowFiltering = true;
            this.dataGridsfDetalleVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridsfDetalleVenta.AutoExpandGroups = true;
            this.dataGridsfDetalleVenta.AutoFitGroupDropAreaItem = true;
            this.dataGridsfDetalleVenta.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dataGridsfDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "NOMBRE";
            gridTextColumn6.MappingName = "Nombre";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "IdTipo";
            gridTextColumn7.MappingName = "IdTipo";
            gridTextColumn7.Visible = false;
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "VENTA";
            gridTextColumn8.MappingName = "TipoVenta";
            gridTextColumn8.Visible = false;
            gridTextColumn9.AllowDragging = true;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.HeaderText = "CANTIDAD";
            gridTextColumn9.MappingName = "Cantidad";
            gridTextColumn10.AllowDragging = true;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.Format = "C2";
            gridTextColumn10.HeaderText = "TOTAL";
            gridTextColumn10.MappingName = "Total";
            this.dataGridsfDetalleVenta.Columns.Add(gridTextColumn6);
            this.dataGridsfDetalleVenta.Columns.Add(gridTextColumn7);
            this.dataGridsfDetalleVenta.Columns.Add(gridTextColumn8);
            this.dataGridsfDetalleVenta.Columns.Add(gridTextColumn9);
            this.dataGridsfDetalleVenta.Columns.Add(gridTextColumn10);
            groupColumnDescription2.ColumnName = "TipoVenta";
            this.dataGridsfDetalleVenta.GroupColumnDescriptions.Add(groupColumnDescription2);
            this.dataGridsfDetalleVenta.Location = new System.Drawing.Point(8, 27);
            this.dataGridsfDetalleVenta.Name = "dataGridsfDetalleVenta";
            this.dataGridsfDetalleVenta.RowHeight = 21;
            this.dataGridsfDetalleVenta.ShowGroupDropArea = true;
            this.dataGridsfDetalleVenta.Size = new System.Drawing.Size(511, 280);
            this.dataGridsfDetalleVenta.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsfDetalleVenta.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridsfDetalleVenta.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsfDetalleVenta.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsfDetalleVenta.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsfDetalleVenta.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsfDetalleVenta.Style.HeaderStyle.Font.Bold = false;
            this.dataGridsfDetalleVenta.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsfDetalleVenta.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsfDetalleVenta.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsfDetalleVenta.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsfDetalleVenta.TabIndex = 1;
            this.dataGridsfDetalleVenta.Text = "dataGridsf1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClaveControl);
            this.groupBox1.Controls.Add(this.btnVentas);
            this.groupBox1.Controls.Add(this.BtnBusqueda);
            this.groupBox1.Controls.Add(this.MotivoControl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 326);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cancelación";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "FOLIO DE CANCELACIÓN";
            // 
            // ClaveControl
            // 
            this.ClaveControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClaveControl.Location = new System.Drawing.Point(39, 52);
            this.ClaveControl.MaxLength = 20;
            this.ClaveControl.Name = "ClaveControl";
            this.ClaveControl.Size = new System.Drawing.Size(176, 20);
            this.ClaveControl.TabIndex = 7;
            this.ClaveControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClaveControl_KeyPress);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(286, 48);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(65, 26);
            this.btnVentas.TabIndex = 18;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBusqueda.BackColor = System.Drawing.Color.White;
            this.BtnBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(221, 48);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(59, 26);
            this.BtnBusqueda.TabIndex = 14;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // MotivoControl
            // 
            this.MotivoControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MotivoControl.Location = new System.Drawing.Point(38, 117);
            this.MotivoControl.MaxLength = 500;
            this.MotivoControl.Multiline = true;
            this.MotivoControl.Name = "MotivoControl";
            this.MotivoControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MotivoControl.Size = new System.Drawing.Size(313, 169);
            this.MotivoControl.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "MOTIVO DE CANCELACIÓN";
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.btnCancelar);
            this.panelbtn.Controls.Add(this.BtnGuardar);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtn.Location = new System.Drawing.Point(0, 356);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(971, 40);
            this.panelbtn.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(829, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(693, 9);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 28);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.paneltitulo.Controls.Add(this.label1);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(971, 58);
            this.paneltitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cancenlación de venta";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 454);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCancelacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación ";
            this.Load += new System.EventHandler(this.FrmCancelacion_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelCantenedor1.ResumeLayout(false);
            this.panelContenedor2.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsfDetalleVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelbtn.ResumeLayout(false);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panelCantenedor1;
        private System.Windows.Forms.Panel panelContenedor2;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.TextBox ClaveControl;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.TextBox MotivoControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Library.Controls.CIDDataGridsf.DataGridsf dataGridsfDetalleVenta;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}