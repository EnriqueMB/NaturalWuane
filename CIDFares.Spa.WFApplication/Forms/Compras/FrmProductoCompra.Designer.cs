namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    partial class FrmProductoCompra
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
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorControl = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.BuquedaClaveCodigoControl = new System.Windows.Forms.TextBox();
            this.BusqueNombreControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BusClaveBarraControl = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProducto = new System.Windows.Forms.Panel();
            this.GridBuscarProducto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CantidadControl = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).BeginInit();
            this.panelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBuscarProducto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panelBuscador.Controls.Add(this.label3);
            this.panelBuscador.Controls.Add(this.ErrorControl);
            this.panelBuscador.Controls.Add(this.NombreControl);
            this.panelBuscador.Controls.Add(this.BuquedaClaveCodigoControl);
            this.panelBuscador.Controls.Add(this.BusqueNombreControl);
            this.panelBuscador.Controls.Add(this.BusClaveBarraControl);
            this.panelBuscador.Controls.Add(this.BtnBusqueda);
            this.panelBuscador.Controls.Add(this.label2);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(916, 53);
            this.panelBuscador.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            // 
            // ErrorControl
            // 
            this.ErrorControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ErrorControl.AutoSize = true;
            this.ErrorControl.Location = new System.Drawing.Point(458, 20);
            this.ErrorControl.Name = "ErrorControl";
            this.ErrorControl.Size = new System.Drawing.Size(0, 13);
            this.ErrorControl.TabIndex = 20;
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NombreControl.Location = new System.Drawing.Point(486, 29);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(226, 20);
            this.NombreControl.TabIndex = 16;
            this.NombreControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreControl_KeyPress);
            // 
            // BuquedaClaveCodigoControl
            // 
            this.BuquedaClaveCodigoControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuquedaClaveCodigoControl.Location = new System.Drawing.Point(204, 28);
            this.BuquedaClaveCodigoControl.MaxLength = 200;
            this.BuquedaClaveCodigoControl.Name = "BuquedaClaveCodigoControl";
            this.BuquedaClaveCodigoControl.Size = new System.Drawing.Size(238, 20);
            this.BuquedaClaveCodigoControl.TabIndex = 18;
            this.BuquedaClaveCodigoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusquedaClaveCodigoControl_KeyPress);
            // 
            // BusqueNombreControl
            // 
            this.BusqueNombreControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusqueNombreControl.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.BusqueNombreControl.Location = new System.Drawing.Point(512, 4);
            this.BusqueNombreControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusqueNombreControl.Name = "BusqueNombreControl";
            this.BusqueNombreControl.Size = new System.Drawing.Size(175, 21);
            this.BusqueNombreControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusqueNombreControl.TabIndex = 17;
            this.BusqueNombreControl.Text = "Buscar por producto";
            this.BusqueNombreControl.ThemeName = "Metro";
            this.BusqueNombreControl.ThemesEnabled = false;
            this.BusqueNombreControl.CheckedChanged += new System.EventHandler(this.BusqueNombreControl_CheckedChanged);
            // 
            // BusClaveBarraControl
            // 
            this.BusClaveBarraControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusClaveBarraControl.BeforeTouchSize = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Location = new System.Drawing.Point(214, 4);
            this.BusClaveBarraControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.BusClaveBarraControl.Name = "BusClaveBarraControl";
            this.BusClaveBarraControl.Size = new System.Drawing.Size(238, 21);
            this.BusClaveBarraControl.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.BusClaveBarraControl.TabIndex = 19;
            this.BusClaveBarraControl.Text = "Buscar por clave o codigo de barra";
            this.BusClaveBarraControl.ThemeName = "Metro";
            this.BusClaveBarraControl.ThemesEnabled = false;
            this.BusClaveBarraControl.CheckedChanged += new System.EventHandler(this.BusClaveBarraControl_CheckedChanged);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(787, 14);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(89, 26);
            this.BtnBusqueda.TabIndex = 15;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar producto";
            // 
            // panelProducto
            // 
            this.panelProducto.Controls.Add(this.GridBuscarProducto);
            this.panelProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProducto.Location = new System.Drawing.Point(0, 53);
            this.panelProducto.Name = "panelProducto";
            this.panelProducto.Size = new System.Drawing.Size(742, 430);
            this.panelProducto.TabIndex = 1;
            // 
            // GridBuscarProducto
            // 
            this.GridBuscarProducto.AccessibleName = "Table";
            this.GridBuscarProducto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdProducto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.HeaderText = "Nombre";
            gridTextColumn3.MappingName = "Nombre";
            gridTextColumn4.HeaderText = "Categoria";
            gridTextColumn4.MappingName = "NombreCategoria";
            gridTextColumn5.HeaderText = "Unidad medida";
            gridTextColumn5.MappingName = "UnidadMedida";
            gridTextColumn6.Format = "C";
            gridTextColumn6.HeaderText = "Costo";
            gridTextColumn6.MappingName = "CostoProducto";
            this.GridBuscarProducto.Columns.Add(gridTextColumn1);
            this.GridBuscarProducto.Columns.Add(gridTextColumn2);
            this.GridBuscarProducto.Columns.Add(gridTextColumn3);
            this.GridBuscarProducto.Columns.Add(gridTextColumn4);
            this.GridBuscarProducto.Columns.Add(gridTextColumn5);
            this.GridBuscarProducto.Columns.Add(gridTextColumn6);
            this.GridBuscarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBuscarProducto.Location = new System.Drawing.Point(0, 0);
            this.GridBuscarProducto.Name = "GridBuscarProducto";
            this.GridBuscarProducto.Size = new System.Drawing.Size(742, 430);
            this.GridBuscarProducto.TabIndex = 0;
            this.GridBuscarProducto.Text = "sfDataGrid1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CantidadControl);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(742, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 430);
            this.panel1.TabIndex = 2;
            // 
            // CantidadControl
            // 
            this.CantidadControl.Location = new System.Drawing.Point(23, 194);
            this.CantidadControl.Name = "CantidadControl";
            this.CantidadControl.Size = new System.Drawing.Size(125, 20);
            this.CantidadControl.TabIndex = 13;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(23, 249);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(139, 29);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar compra";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad a comprar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProducto);
            this.Controls.Add(this.panelBuscador);
            this.Name = "FrmProductoCompra";
            this.Text = "FrmProductoCompra";
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusqueNombreControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusClaveBarraControl)).EndInit();
            this.panelProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBuscarProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Panel panelProducto;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadControl;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.TextBox BuquedaClaveCodigoControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusqueNombreControl;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv BusClaveBarraControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ErrorControl;
        private System.Windows.Forms.Label label3;
    }
}