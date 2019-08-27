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
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dataGridMain1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlTitulos.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1048, 70);
            this.pnlTitulos.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 35);
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
            this.pnlContainer.Location = new System.Drawing.Point(0, 70);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1048, 458);
            this.pnlContainer.TabIndex = 4;
            // 
            // dataGridMain1
            // 
            this.dataGridMain1.AccessibleName = "Table";
            this.dataGridMain1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdProducto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.HeaderText = "Categoria";
            gridTextColumn2.MappingName = "Categoria";
            gridTextColumn3.HeaderText = "Clave";
            gridTextColumn3.MappingName = "Clave";
            gridTextColumn4.HeaderText = "Producto";
            gridTextColumn4.MappingName = "Nombre";
            gridTextColumn5.HeaderText = "Descripcion";
            gridTextColumn5.MappingName = "Descripcion";
            gridTextColumn6.HeaderText = "Stock";
            gridTextColumn6.MappingName = "StockStr";
            gridTextColumn7.HeaderText = "StockMax";
            gridTextColumn7.MappingName = "StockMax";
            gridTextColumn8.HeaderText = "StockMin";
            gridTextColumn8.MappingName = "StockMin";
            gridTextColumn9.HeaderText = "Precio publico";
            gridTextColumn9.MappingName = "PrecioPublico";
            gridTextColumn10.HeaderText = "Precio mayoreo";
            gridTextColumn10.MappingName = "PrecioMayoreo";
            gridTextColumn11.HeaderText = "Precio menudeo";
            gridTextColumn11.MappingName = "PrecioMenudeo";
            gridTextColumn12.HeaderText = "Unidad de medida";
            gridTextColumn12.MappingName = "UnidadMedida";
            gridTextColumn13.HeaderText = "Clave SAT";
            gridTextColumn13.MappingName = "ClaveSat";
            gridTextColumn13.Visible = false;
            gridTextColumn14.HeaderText = "IVA";
            gridTextColumn14.MappingName = "AplicaIvaStr";
            this.dataGridMain1.Columns.Add(gridTextColumn1);
            this.dataGridMain1.Columns.Add(gridTextColumn2);
            this.dataGridMain1.Columns.Add(gridTextColumn3);
            this.dataGridMain1.Columns.Add(gridTextColumn4);
            this.dataGridMain1.Columns.Add(gridTextColumn5);
            this.dataGridMain1.Columns.Add(gridTextColumn6);
            this.dataGridMain1.Columns.Add(gridTextColumn7);
            this.dataGridMain1.Columns.Add(gridTextColumn8);
            this.dataGridMain1.Columns.Add(gridTextColumn9);
            this.dataGridMain1.Columns.Add(gridTextColumn10);
            this.dataGridMain1.Columns.Add(gridTextColumn11);
            this.dataGridMain1.Columns.Add(gridTextColumn12);
            this.dataGridMain1.Columns.Add(gridTextColumn13);
            this.dataGridMain1.Columns.Add(gridTextColumn14);
            this.dataGridMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMain1.Location = new System.Drawing.Point(0, 0);
            this.dataGridMain1.Name = "dataGridMain1";
            this.dataGridMain1.Size = new System.Drawing.Size(1048, 458);
            this.dataGridMain1.TabIndex = 0;
            this.dataGridMain1.Text = "sfDataGrid1";
            // 
            // FrmProductoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 602);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.pnlTitulos);
            this.Name = "FrmProductoGrid";
            this.Text = "FrmProductoGrid";
            this.Shown += new System.EventHandler(this.FrmProductoGrid_Shown);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain1)).EndInit();
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
    }
}