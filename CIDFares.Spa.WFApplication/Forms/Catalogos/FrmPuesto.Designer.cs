namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmPuesto
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBtnGeneral = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.sfDataGridPuesto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBoxPuesto = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipGrid = new System.Windows.Forms.ToolTip(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlBtnGeneral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPuesto)).BeginInit();
            this.groupBoxPuesto.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(892, 52);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(19, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Puestos";
            // 
            // pnlBtnGeneral
            // 
            this.pnlBtnGeneral.Controls.Add(this.flowLayoutPanel1);
            this.pnlBtnGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnGeneral.Location = new System.Drawing.Point(0, 447);
            this.pnlBtnGeneral.Name = "pnlBtnGeneral";
            this.pnlBtnGeneral.Size = new System.Drawing.Size(892, 61);
            this.pnlBtnGeneral.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 32);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.pnlGrid.Controls.Add(this.sfDataGridPuesto);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrid.Location = new System.Drawing.Point(0, 52);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(472, 395);
            this.pnlGrid.TabIndex = 2;
            // 
            // sfDataGridPuesto
            // 
            this.sfDataGridPuesto.AccessibleName = "Table";
            this.sfDataGridPuesto.AllowGrouping = false;
            this.sfDataGridPuesto.AllowResizingColumns = true;
            this.sfDataGridPuesto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "IdPuesto";
            gridTextColumn1.MappingName = "IdPuesto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Nombre";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Descripción";
            gridTextColumn3.MappingName = "Descripcion";
            this.sfDataGridPuesto.Columns.Add(gridTextColumn1);
            this.sfDataGridPuesto.Columns.Add(gridTextColumn2);
            this.sfDataGridPuesto.Columns.Add(gridTextColumn3);
            this.sfDataGridPuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridPuesto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfDataGridPuesto.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridPuesto.Name = "sfDataGridPuesto";
            this.sfDataGridPuesto.PreviewRowHeightMode = Syncfusion.WinForms.DataGrid.Enums.PreviewRowHeightMode.Auto;
            this.sfDataGridPuesto.Size = new System.Drawing.Size(472, 395);
            this.sfDataGridPuesto.TabIndex = 0;
            this.sfDataGridPuesto.Text = "sfDataGrid1";
            this.toolTipGrid.SetToolTip(this.sfDataGridPuesto, "Puestos");
            // 
            // groupBoxPuesto
            // 
            this.groupBoxPuesto.Controls.Add(this.label2);
            this.groupBoxPuesto.Controls.Add(this.lblNombre);
            this.groupBoxPuesto.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxPuesto.Controls.Add(this.DescripcionControl);
            this.groupBoxPuesto.Controls.Add(this.NombreControl);
            this.groupBoxPuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPuesto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBoxPuesto.Location = new System.Drawing.Point(472, 52);
            this.groupBoxPuesto.MaximumSize = new System.Drawing.Size(420, 395);
            this.groupBoxPuesto.MinimumSize = new System.Drawing.Size(420, 395);
            this.groupBoxPuesto.Name = "groupBoxPuesto";
            this.groupBoxPuesto.Size = new System.Drawing.Size(420, 395);
            this.groupBoxPuesto.TabIndex = 2;
            this.groupBoxPuesto.TabStop = false;
            this.groupBoxPuesto.Text = "Datos Puesto";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(72, 334);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(293, 32);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(132, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Location = new System.Drawing.Point(84, 150);
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.Size = new System.Drawing.Size(229, 137);
            this.DescripcionControl.TabIndex = 2;
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(84, 78);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(229, 27);
            this.NombreControl.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción";
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 508);
            this.Controls.Add(this.groupBoxPuesto);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBtnGeneral);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "FrmPuesto";
            this.Text = "FrmPuesto";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBtnGeneral.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPuesto)).EndInit();
            this.groupBoxPuesto.ResumeLayout(false);
            this.groupBoxPuesto.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlBtnGeneral;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox groupBoxPuesto;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridPuesto;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTipGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
    }
}