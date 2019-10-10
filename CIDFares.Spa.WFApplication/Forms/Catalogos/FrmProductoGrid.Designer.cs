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
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dataGridMain1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusqueda = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLimpiarBusqueda = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.pnlTitulos.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.panel1);
            this.pnlTitulos.Controls.Add(this.label1);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1048, 57);
            this.pnlTitulos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 184;
            this.label1.Text = "Producto";
            // 
            // FlpBotones
            // 
            this.FlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.FlpBotones.Controls.Add(this.BtnNuevo);
            this.FlpBotones.Controls.Add(this.btnModificar);
            this.FlpBotones.Controls.Add(this.btnEliminar);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.Location = new System.Drawing.Point(0, 534);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(1048, 68);
            this.FlpBotones.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dataGridMain1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 57);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1048, 477);
            this.pnlContainer.TabIndex = 4;
            // 
            // dataGridMain1
            // 
            this.dataGridMain1.AccessibleName = "Table";
            this.dataGridMain1.AllowEditing = false;
            this.dataGridMain1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdProducto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Producto";
            gridTextColumn3.MappingName = "Nombre";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Categoria";
            gridTextColumn4.MappingName = "Categoria";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.HeaderText = "Descripción";
            gridTextColumn5.MappingName = "Descripcion";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.HeaderText = "Stock";
            gridTextColumn6.MappingName = "StockStr";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.HeaderText = "StockMax";
            gridTextColumn7.MappingName = "StockMax";
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "StockMin";
            gridTextColumn8.MappingName = "StockMin";
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            gridTextColumn9.Format = "C";
            gridTextColumn9.HeaderText = "Precio";
            gridTextColumn9.MappingName = "Precio";
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "Ud. de medida";
            gridTextColumn10.MappingName = "UnidadMedida";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Clave SAT";
            gridTextColumn11.MappingName = "ClaveSat";
            gridTextColumn11.Visible = false;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.HeaderText = "IVA";
            gridTextColumn12.MappingName = "Porcentaje";
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
            this.dataGridMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMain1.Location = new System.Drawing.Point(0, 0);
            this.dataGridMain1.Name = "dataGridMain1";
            this.dataGridMain1.Size = new System.Drawing.Size(1048, 477);
            this.dataGridMain1.TabIndex = 0;
            this.dataGridMain1.Text = "sfDataGrid1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.btnLimpiarBusqueda);
            this.panel1.Controls.Add(this.BusquedaControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(513, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 57);
            this.panel1.TabIndex = 187;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnBusqueda.BeforeTouchSize = new System.Drawing.Size(31, 24);
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.btnBusqueda.IsBackStageButton = false;
            this.btnBusqueda.Location = new System.Drawing.Point(401, 16);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(31, 24);
            this.btnBusqueda.TabIndex = 189;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnLimpiarBusqueda.BeforeTouchSize = new System.Drawing.Size(68, 24);
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IsBackStageButton = false;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(438, 16);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(68, 24);
            this.btnLimpiarBusqueda.TabIndex = 188;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusquedaControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaControl.Location = new System.Drawing.Point(28, 17);
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(355, 22);
            this.BusquedaControl.TabIndex = 187;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.IsBackStageButton = false;
            this.BtnNuevo.Location = new System.Drawing.Point(13, 23);
            this.BtnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(123, 29);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(142, 23);
            this.btnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 17;
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
            this.btnEliminar.Location = new System.Drawing.Point(271, 23);
            this.btnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Panel pnlContainer;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dataGridMain1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnBusqueda;
        private Syncfusion.Windows.Forms.ButtonAdv btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox BusquedaControl;
        private Library.Controls.Btn.Btn BtnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
    }
}