﻿namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmFormaPago
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridFromaPago = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.grpBoxFormaPago = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGuardar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pnlPrincipal.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFromaPago)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.grpBoxFormaPago.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panelCentral);
            this.pnlPrincipal.Controls.Add(this.pnlTitulo);
            this.pnlPrincipal.Controls.Add(this.pnlBotones);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.ForeColor = System.Drawing.Color.White;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1001, 517);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.pnlDatos);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 57);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1001, 392);
            this.panelCentral.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridFromaPago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 392);
            this.panel1.TabIndex = 4;
            // 
            // GridFromaPago
            // 
            this.GridFromaPago.AccessibleName = "Table";
            this.GridFromaPago.AllowGrouping = false;
            this.GridFromaPago.AllowResizingColumns = true;
            this.GridFromaPago.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdFormaPago";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Nombre";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Descripción";
            gridTextColumn3.MappingName = "Descripcion";
            this.GridFromaPago.Columns.Add(gridTextColumn1);
            this.GridFromaPago.Columns.Add(gridTextColumn2);
            this.GridFromaPago.Columns.Add(gridTextColumn3);
            this.GridFromaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFromaPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridFromaPago.Location = new System.Drawing.Point(0, 0);
            this.GridFromaPago.Name = "GridFromaPago";
            this.GridFromaPago.PreviewRowHeightMode = Syncfusion.WinForms.DataGrid.Enums.PreviewRowHeightMode.Auto;
            this.GridFromaPago.Size = new System.Drawing.Size(706, 392);
            this.GridFromaPago.TabIndex = 0;
            this.GridFromaPago.Text = "sfDataGrid1";
            this.toolTip1.SetToolTip(this.GridFromaPago, "Formas de pago");
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.grpBoxFormaPago);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatos.Location = new System.Drawing.Point(706, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(295, 392);
            this.pnlDatos.TabIndex = 3;
            // 
            // grpBoxFormaPago
            // 
            this.grpBoxFormaPago.BackColor = System.Drawing.Color.White;
            this.grpBoxFormaPago.Controls.Add(this.flowLayoutPanel2);
            this.grpBoxFormaPago.Controls.Add(this.label2);
            this.grpBoxFormaPago.Controls.Add(this.label1);
            this.grpBoxFormaPago.Controls.Add(this.DescripcionControl);
            this.grpBoxFormaPago.Controls.Add(this.NombreControl);
            this.grpBoxFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFormaPago.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxFormaPago.Location = new System.Drawing.Point(0, 0);
            this.grpBoxFormaPago.Name = "grpBoxFormaPago";
            this.grpBoxFormaPago.Size = new System.Drawing.Size(295, 392);
            this.grpBoxFormaPago.TabIndex = 0;
            this.grpBoxFormaPago.TabStop = false;
            this.grpBoxFormaPago.Text = "Datos forma de pago";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 334);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(259, 35);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Location = new System.Drawing.Point(18, 132);
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.Size = new System.Drawing.Size(266, 175);
            this.DescripcionControl.TabIndex = 1;
            this.toolTip1.SetToolTip(this.DescripcionControl, "Ingrese una descripción no mayor a 300 caracteres");
            this.DescripcionControl.TextChanged += new System.EventHandler(this.DescripcionControl_TextChanged);
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(18, 73);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(266, 29);
            this.NombreControl.TabIndex = 0;
            this.toolTip1.SetToolTip(this.NombreControl, "Ingrese un nombre no mayor a 200 caracteres");
            this.NombreControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitulo.Controls.Add(this.label4);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1001, 57);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlBotones.Controls.Add(this.flowLayoutPanel1);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 449);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1001, 68);
            this.pnlBotones.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1001, 68);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Forma de pago";
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
            this.btnCancelar.Location = new System.Drawing.Point(132, 3);
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
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 517);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFormaPago";
            this.Text = "FrmFormaPago";
            this.pnlPrincipal.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFromaPago)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.grpBoxFormaPago.ResumeLayout(false);
            this.grpBoxFormaPago.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox grpBoxFormaPago;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlBotones;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridFromaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Library.Controls.Btn.Btn btnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnGuardar;
    }
}