namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmPaquete
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
            this.panelCantenedor = new System.Windows.Forms.Panel();
            this.panelcantenedo1 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.sfDataGridPaquete = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBTN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.panelCantenedor.SuspendLayout();
            this.panelcantenedo1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPaquete)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelBTN.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCantenedor
            // 
            this.panelCantenedor.Controls.Add(this.panelcantenedo1);
            this.panelCantenedor.Controls.Add(this.panelBTN);
            this.panelCantenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCantenedor.Location = new System.Drawing.Point(0, 0);
            this.panelCantenedor.Name = "panelCantenedor";
            this.panelCantenedor.Size = new System.Drawing.Size(918, 478);
            this.panelCantenedor.TabIndex = 0;
            // 
            // panelcantenedo1
            // 
            this.panelcantenedo1.Controls.Add(this.panelGrid);
            this.panelcantenedo1.Controls.Add(this.panelTitulo);
            this.panelcantenedo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcantenedo1.Location = new System.Drawing.Point(0, 0);
            this.panelcantenedo1.Name = "panelcantenedo1";
            this.panelcantenedo1.Size = new System.Drawing.Size(918, 417);
            this.panelcantenedo1.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridPaquete);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 58);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(918, 359);
            this.panelGrid.TabIndex = 1;
            // 
            // sfDataGridPaquete
            // 
            this.sfDataGridPaquete.AccessibleName = "Table";
            this.sfDataGridPaquete.AllowEditing = false;
            this.sfDataGridPaquete.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.HeaderText = "IdPaquete";
            gridTextColumn9.MappingName = "IdPaquete";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.HeaderText = "Clave";
            gridTextColumn10.MappingName = "Clave";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.HeaderText = "Nombre";
            gridTextColumn11.MappingName = "Nombre";
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.HeaderText = "Descripcion";
            gridTextColumn12.MappingName = "Descripción";
            gridTextColumn12.Visible = false;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.HeaderText = "Núm. Persona";
            gridTextColumn13.MappingName = "NPersona";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.HeaderText = "Núm. Pago";
            gridTextColumn14.MappingName = "NPago";
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.Format = "dd/MM/yyyy";
            gridTextColumn15.HeaderText = "Fecha vencimiento";
            gridTextColumn15.MappingName = "FechaVencimiento";
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.Format = "C2";
            gridTextColumn16.HeaderText = "Precio";
            gridTextColumn16.MappingName = "MontoPaquete";
            this.sfDataGridPaquete.Columns.Add(gridTextColumn9);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn10);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn11);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn12);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn13);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn14);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn15);
            this.sfDataGridPaquete.Columns.Add(gridTextColumn16);
            this.sfDataGridPaquete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridPaquete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDataGridPaquete.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridPaquete.Name = "sfDataGridPaquete";
            this.sfDataGridPaquete.Size = new System.Drawing.Size(918, 359);
            this.sfDataGridPaquete.TabIndex = 3;
            this.sfDataGridPaquete.Text = "sfDataGrid1";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(918, 58);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelBTN
            // 
            this.panelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panelBTN.Controls.Add(this.flowLayoutPanel1);
            this.panelBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBTN.Location = new System.Drawing.Point(0, 417);
            this.panelBTN.Name = "panelBTN";
            this.panelBTN.Size = new System.Drawing.Size(918, 61);
            this.panelBTN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 183;
            this.label1.Text = "Paquete";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 13, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(918, 61);
            this.flowLayoutPanel1.TabIndex = 22;
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
            this.BtnNuevo.Location = new System.Drawing.Point(23, 16);
            this.BtnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(123, 29);
            this.BtnNuevo.TabIndex = 22;
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
            this.btnModificar.Location = new System.Drawing.Point(152, 16);
            this.btnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 23;
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
            this.btnEliminar.Location = new System.Drawing.Point(281, 16);
            this.btnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 478);
            this.Controls.Add(this.panelCantenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaquete";
            this.Text = "FrmPaquete";
            this.Load += new System.EventHandler(this.FrmPaquete_Load);
            this.panelCantenedor.ResumeLayout(false);
            this.panelcantenedo1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPaquete)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBTN.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCantenedor;
        private System.Windows.Forms.Panel panelcantenedo1;
        private System.Windows.Forms.Panel panelBTN;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridPaquete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Library.Controls.Btn.Btn BtnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
    }
}