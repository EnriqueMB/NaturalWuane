namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmCategoriaProducto
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgCat = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGuardar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pnlHeader.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCat)).BeginInit();
            this.gbCat.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(918, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBtns
            // 
            this.pnlBtns.Controls.Add(this.flowLayoutPanel1);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtns.Location = new System.Drawing.Point(0, 469);
            this.pnlBtns.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(918, 68);
            this.pnlBtns.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(918, 68);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgCat);
            this.pnlGrid.Controls.Add(this.gbCat);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 58);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(918, 411);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgCat
            // 
            this.dgCat.AccessibleName = "Table";
            this.dgCat.AllowEditing = false;
            this.dgCat.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.HeaderText = "Column1";
            gridTextColumn4.MappingName = "IdCategoriaProducto";
            gridTextColumn4.Visible = false;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.HeaderText = "Nombre";
            gridTextColumn5.MappingName = "Nombre";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.HeaderText = "Descripción";
            gridTextColumn6.MappingName = "Descripcion";
            this.dgCat.Columns.Add(gridTextColumn4);
            this.dgCat.Columns.Add(gridTextColumn5);
            this.dgCat.Columns.Add(gridTextColumn6);
            this.dgCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCat.Location = new System.Drawing.Point(0, 0);
            this.dgCat.Margin = new System.Windows.Forms.Padding(4);
            this.dgCat.Name = "dgCat";
            this.dgCat.PreviewRowHeightMode = Syncfusion.WinForms.DataGrid.Enums.PreviewRowHeightMode.Auto;
            this.dgCat.Size = new System.Drawing.Size(630, 411);
            this.dgCat.TabIndex = 1;
            this.dgCat.Text = "sfDataGrid1";
            // 
            // gbCat
            // 
            this.gbCat.Controls.Add(this.flowLayoutPanel2);
            this.gbCat.Controls.Add(this.label2);
            this.gbCat.Controls.Add(this.label1);
            this.gbCat.Controls.Add(this.DescripcionControl);
            this.gbCat.Controls.Add(this.NombreControl);
            this.gbCat.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCat.Enabled = false;
            this.gbCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCat.Location = new System.Drawing.Point(630, 0);
            this.gbCat.Margin = new System.Windows.Forms.Padding(4);
            this.gbCat.Name = "gbCat";
            this.gbCat.Padding = new System.Windows.Forms.Padding(4);
            this.gbCat.Size = new System.Drawing.Size(288, 411);
            this.gbCat.TabIndex = 0;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Nueva categoria";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 331);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(288, 35);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionControl.Location = new System.Drawing.Point(25, 155);
            this.DescripcionControl.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionControl.MaxLength = 300;
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripcionControl.Size = new System.Drawing.Size(241, 150);
            this.DescripcionControl.TabIndex = 1;
            this.DescripcionControl.TextChanged += new System.EventHandler(this.DescripcionControl_TextChanged);
            // 
            // NombreControl
            // 
            this.NombreControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreControl.Location = new System.Drawing.Point(25, 84);
            this.NombreControl.Margin = new System.Windows.Forms.Padding(4);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(241, 29);
            this.NombreControl.TabIndex = 0;
            this.NombreControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoría de producto";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.IsBackStageButton = false;
            this.btnNuevo.Location = new System.Drawing.Point(23, 18);
            this.btnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(152, 18);
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
            this.btnEliminar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IsBackStageButton = false;
            this.btnEliminar.Location = new System.Drawing.Point(281, 18);
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(147, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IsBackStageButton = false;
            this.btnGuardar.Location = new System.Drawing.Point(18, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoriaProducto";
            this.Text = "FrmCategoriaProducto";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCat)).EndInit();
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgCat;
        private System.Windows.Forms.Label label4;
        private Library.Controls.Btn.Btn btnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnGuardar;
    }
}