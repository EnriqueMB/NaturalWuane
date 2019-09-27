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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.DGridAlimento = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
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
            this.pnlTitulo.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlTitulo.Controls.Add(this.btnBusqueda);
            this.pnlTitulo.Controls.Add(this.BusquedaControl);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1066, 57);
            this.pnlTitulo.TabIndex = 1;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(924, 14);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(130, 28);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "ELIMINAR FILTROS";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(778, 14);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(130, 28);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusquedaControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaControl.Location = new System.Drawing.Point(404, 19);
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(355, 19);
            this.BusquedaControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración Alimentos";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.flowLayoutPanel1);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 550);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(1066, 68);
            this.pnlAcciones.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 32);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowGrouping = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "IdAlimento";
            gridTextColumn9.MappingName = "IdAlimento";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowGrouping = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "Nombre";
            gridTextColumn10.MappingName = "Nombre";
            gridTextColumn10.MinimumWidth = 350D;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowGrouping = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "Grupo Alimenticio";
            gridTextColumn11.MappingName = "TipoAlimento";
            gridTextColumn11.MinimumWidth = 250D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowGrouping = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Calorias(Kcal.)";
            gridTextColumn12.MappingName = "Calorias";
            gridTextColumn12.MinimumWidth = 90D;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowGrouping = false;
            gridTextColumn13.AllowResizing = true;
            gridTextColumn13.HeaderText = "Hidratos Carbono";
            gridTextColumn13.MappingName = "HidratosCarbono";
            gridTextColumn13.MinimumWidth = 110D;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowGrouping = false;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "Proteína";
            gridTextColumn14.MappingName = "Proteina";
            gridTextColumn14.MinimumWidth = 85D;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowGrouping = false;
            gridTextColumn15.AllowResizing = true;
            gridTextColumn15.HeaderText = "Grasas";
            gridTextColumn15.MappingName = "Grasa";
            gridTextColumn15.MinimumWidth = 85D;
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.AllowGrouping = false;
            gridTextColumn16.AllowResizing = true;
            gridTextColumn16.HeaderText = "Fibras";
            gridTextColumn16.MappingName = "Fibra";
            gridTextColumn16.MinimumWidth = 85D;
            this.DGridAlimento.Columns.Add(gridTextColumn9);
            this.DGridAlimento.Columns.Add(gridTextColumn10);
            this.DGridAlimento.Columns.Add(gridTextColumn11);
            this.DGridAlimento.Columns.Add(gridTextColumn12);
            this.DGridAlimento.Columns.Add(gridTextColumn13);
            this.DGridAlimento.Columns.Add(gridTextColumn14);
            this.DGridAlimento.Columns.Add(gridTextColumn15);
            this.DGridAlimento.Columns.Add(gridTextColumn16);
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DGridAlimento;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.TextBox BusquedaControl;
        public System.Windows.Forms.Button btnBusqueda;
        public System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.ErrorProvider error;
    }
}