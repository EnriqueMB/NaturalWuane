namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmAlimentoGrid
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.PictureBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.DGridAlimento = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridAlimento)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.BtnBuscar);
            this.pnlTitulo.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlTitulo.Controls.Add(this.BusquedaControl);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1066, 57);
            this.pnlTitulo.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnBuscar.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.BtnBuscar.Location = new System.Drawing.Point(944, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(31, 24);
            this.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(981, 19);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(68, 24);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusquedaControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BusquedaControl.Location = new System.Drawing.Point(573, 20);
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(355, 22);
            this.BusquedaControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración alimentos";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlAcciones.Controls.Add(this.flowLayoutPanel1);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 550);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(1066, 68);
            this.pnlAcciones.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 35);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.DGridAlimento);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1066, 493);
            this.pnlGrid.TabIndex = 0;
            // 
            // DGridAlimento
            // 
            this.DGridAlimento.AccessibleName = "Table";
            this.DGridAlimento.AllowEditing = false;
            this.DGridAlimento.AllowGrouping = false;
            this.DGridAlimento.AllowResizingColumns = true;
            this.DGridAlimento.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "IdAlimento";
            gridTextColumn1.MappingName = "IdAlimento";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Nombre";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn2.MinimumWidth = 350D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Grupo alimenticio";
            gridTextColumn3.MappingName = "TipoAlimento";
            gridTextColumn3.MinimumWidth = 250D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Calorias (Kcal.)";
            gridTextColumn4.MappingName = "Calorias";
            gridTextColumn4.MinimumWidth = 90D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderText = "Hidratos carbono";
            gridTextColumn5.MappingName = "HidratosCarbono";
            gridTextColumn5.MinimumWidth = 110D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "Proteína";
            gridTextColumn6.MappingName = "Proteina";
            gridTextColumn6.MinimumWidth = 85D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowGrouping = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "Grasas";
            gridTextColumn7.MappingName = "Grasa";
            gridTextColumn7.MinimumWidth = 85D;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowGrouping = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "Fibras";
            gridTextColumn8.MappingName = "Fibra";
            gridTextColumn8.MinimumWidth = 85D;
            this.DGridAlimento.Columns.Add(gridTextColumn1);
            this.DGridAlimento.Columns.Add(gridTextColumn2);
            this.DGridAlimento.Columns.Add(gridTextColumn3);
            this.DGridAlimento.Columns.Add(gridTextColumn4);
            this.DGridAlimento.Columns.Add(gridTextColumn5);
            this.DGridAlimento.Columns.Add(gridTextColumn6);
            this.DGridAlimento.Columns.Add(gridTextColumn7);
            this.DGridAlimento.Columns.Add(gridTextColumn8);
            this.DGridAlimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGridAlimento.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGridAlimento.Location = new System.Drawing.Point(0, 0);
            this.DGridAlimento.Name = "DGridAlimento";
            this.DGridAlimento.SerializationController = null;
            this.DGridAlimento.Size = new System.Drawing.Size(1066, 493);
            this.DGridAlimento.TabIndex = 0;
            this.DGridAlimento.Text = "sfDataGrid1";
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pnlGrid);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 57);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1066, 493);
            this.pnlCentral.TabIndex = 1;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmAlimentoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 618);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlimentoGrid";
            this.Text = "FrmAlimentoGrid";
            this.Shown += new System.EventHandler(this.FrmAlimentoGrid_Shown);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridAlimento)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DGridAlimento;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.TextBox BusquedaControl;
        public System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.ErrorProvider error;
        private Library.Controls.Btn.Btn btnNuevo;
        private System.Windows.Forms.PictureBox BtnBuscar;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
    }
}