﻿namespace CIDFares.Spa.WFApplication.Forms.General
{
    partial class FrmEntradaSalidaAlmacen
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pblButtom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MotivoControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.FechaControl = new System.Windows.Forms.DateTimePicker();
            this.TipoControl = new System.Windows.Forms.ComboBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridsf1 = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CantidadControl = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.FolioProductoControl = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pblButtom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(772, 111);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 25);
            this.lblTitulo.TabIndex = 181;
            this.lblTitulo.Text = "ALMACEN";
            // 
            // pblButtom
            // 
            this.pblButtom.Controls.Add(this.flowLayoutPanel1);
            this.pblButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblButtom.Location = new System.Drawing.Point(0, 412);
            this.pblButtom.Name = "pblButtom";
            this.pblButtom.Size = new System.Drawing.Size(772, 100);
            this.pblButtom.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(132, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(261, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "MOTIVO";
            // 
            // MotivoControl
            // 
            this.MotivoControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotivoControl.Location = new System.Drawing.Point(35, 213);
            this.MotivoControl.Multiline = true;
            this.MotivoControl.Name = "MotivoControl";
            this.MotivoControl.Size = new System.Drawing.Size(207, 84);
            this.MotivoControl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "FECHA";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(32, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 18);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "TIPO";
            // 
            // FechaControl
            // 
            this.FechaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaControl.Location = new System.Drawing.Point(35, 64);
            this.FechaControl.Name = "FechaControl";
            this.FechaControl.Size = new System.Drawing.Size(204, 20);
            this.FechaControl.TabIndex = 8;
            // 
            // TipoControl
            // 
            this.TipoControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoControl.FormattingEnabled = true;
            this.TipoControl.Location = new System.Drawing.Point(35, 117);
            this.TipoControl.Name = "TipoControl";
            this.TipoControl.Size = new System.Drawing.Size(123, 21);
            this.TipoControl.TabIndex = 5;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlGrid);
            this.pnlCenter.Controls.Add(this.panel4);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 111);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(772, 301);
            this.pnlCenter.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dataGridsf1);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(498, 301);
            this.pnlGrid.TabIndex = 1;
            // 
            // dataGridsf1
            // 
            this.dataGridsf1.AccessibleName = "Table";
            this.dataGridsf1.AllowDraggingColumns = true;
            this.dataGridsf1.AllowEditing = false;
            this.dataGridsf1.AllowFiltering = true;
            this.dataGridsf1.AutoExpandGroups = true;
            this.dataGridsf1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dataGridsf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdProducto";
            gridTextColumn1.MappingName = "IdProducto";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Clave";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Nombre";
            gridTextColumn3.MappingName = "Nombre";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Cantidad";
            gridTextColumn4.MappingName = "Cantidad";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Descripcion";
            gridTextColumn5.MappingName = "Descripcion";
            this.dataGridsf1.Columns.Add(gridTextColumn1);
            this.dataGridsf1.Columns.Add(gridTextColumn2);
            this.dataGridsf1.Columns.Add(gridTextColumn3);
            this.dataGridsf1.Columns.Add(gridTextColumn4);
            this.dataGridsf1.Columns.Add(gridTextColumn5);
            this.dataGridsf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridsf1.Location = new System.Drawing.Point(0, 0);
            this.dataGridsf1.Name = "dataGridsf1";
            this.dataGridsf1.RowHeight = 21;
            this.dataGridsf1.ShowGroupDropArea = true;
            this.dataGridsf1.Size = new System.Drawing.Size(498, 301);
            this.dataGridsf1.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridsf1.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.dataGridsf1.Style.HeaderStyle.Font.Bold = false;
            this.dataGridsf1.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsf1.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.TabIndex = 1;
            this.dataGridsf1.Text = "dataGridsf1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CantidadControl);
            this.panel4.Controls.Add(this.lblCantidad);
            this.panel4.Controls.Add(this.FolioProductoControl);
            this.panel4.Controls.Add(this.lblProducto);
            this.panel4.Controls.Add(this.FechaControl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TipoControl);
            this.panel4.Controls.Add(this.MotivoControl);
            this.panel4.Controls.Add(this.lblTipo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(498, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 301);
            this.panel4.TabIndex = 0;
            // 
            // CantidadControl
            // 
            this.CantidadControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadControl.AutoSize = true;
            this.CantidadControl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadControl.Location = new System.Drawing.Point(198, 156);
            this.CantidadControl.Name = "CantidadControl";
            this.CantidadControl.Size = new System.Drawing.Size(17, 18);
            this.CantidadControl.TabIndex = 15;
            this.CantidadControl.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(35, 156);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(162, 18);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "CANTIDAD PRODUCTO:";
            // 
            // FolioProductoControl
            // 
            this.FolioProductoControl.AutoSize = true;
            this.FolioProductoControl.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.FolioProductoControl.ForeColor = System.Drawing.Color.Red;
            this.FolioProductoControl.Location = new System.Drawing.Point(82, 9);
            this.FolioProductoControl.Name = "FolioProductoControl";
            this.FolioProductoControl.Size = new System.Drawing.Size(76, 18);
            this.FolioProductoControl.TabIndex = 13;
            this.FolioProductoControl.Text = "00000001";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.lblProducto.Location = new System.Drawing.Point(34, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(43, 18);
            this.lblProducto.TabIndex = 12;
            this.lblProducto.Text = "Folio:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEntradaSalidaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 512);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pblButtom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntradaSalidaAlmacen";
            this.Text = "FrmEntradaSalidaAlmacen";
            this.Load += new System.EventHandler(this.FrmEntradaSalidaAlmacen_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pblButtom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pblButtom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MotivoControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker FechaControl;
        private System.Windows.Forms.ComboBox TipoControl;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label FolioProductoControl;
        private System.Windows.Forms.Label lblProducto;
        private Library.Controls.CIDDataGridsf.DataGridsf dataGridsf1;
        private System.Windows.Forms.Label CantidadControl;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
    }
}