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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panelCantenedor = new System.Windows.Forms.Panel();
            this.panelBTN = new System.Windows.Forms.Panel();
            this.panelcantenedo1 = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblPaquete = new System.Windows.Forms.Label();
            this.sfDataGridPaquete = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.panelCantenedor.SuspendLayout();
            this.panelBTN.SuspendLayout();
            this.panelcantenedo1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPaquete)).BeginInit();
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
            // panelBTN
            // 
            this.panelBTN.Controls.Add(this.btnEliminar);
            this.panelBTN.Controls.Add(this.btnModificar);
            this.panelBTN.Controls.Add(this.BtnNuevo);
            this.panelBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBTN.Location = new System.Drawing.Point(0, 417);
            this.panelBTN.Name = "panelBTN";
            this.panelBTN.Size = new System.Drawing.Size(918, 61);
            this.panelBTN.TabIndex = 0;
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
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.panelTitulo.Controls.Add(this.lblPaquete);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(918, 64);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.sfDataGridPaquete);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 64);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(918, 353);
            this.panelGrid.TabIndex = 1;
            // 
            // lblPaquete
            // 
            this.lblPaquete.AutoSize = true;
            this.lblPaquete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaquete.Location = new System.Drawing.Point(12, 20);
            this.lblPaquete.Name = "lblPaquete";
            this.lblPaquete.Size = new System.Drawing.Size(95, 25);
            this.lblPaquete.TabIndex = 182;
            this.lblPaquete.Text = "PAQUETE";
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
            gridTextColumn12.MappingName = "Descripcion";
            gridTextColumn12.Visible = false;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.HeaderText = "Número Persona";
            gridTextColumn13.MappingName = "NPersona";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.HeaderText = "Número Pago";
            gridTextColumn14.MappingName = "NPago";
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.Format = "dd/MM/yyyy";
            gridTextColumn15.HeaderText = "Fecha Vencimiento";
            gridTextColumn15.MappingName = "FechaVencimiento";
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.Format = "C2";
            gridTextColumn16.HeaderText = "Precio Paquete";
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
            this.sfDataGridPaquete.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridPaquete.Name = "sfDataGridPaquete";
            this.sfDataGridPaquete.Size = new System.Drawing.Size(918, 353);
            this.sfDataGridPaquete.TabIndex = 3;
            this.sfDataGridPaquete.Text = "sfDataGrid1";
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
            this.btnEliminar.Location = new System.Drawing.Point(766, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 28);
            this.btnEliminar.TabIndex = 20;
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
            this.btnModificar.Location = new System.Drawing.Point(630, 21);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 28);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.BtnNuevo.Location = new System.Drawing.Point(494, 21);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 28);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // FrmPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 478);
            this.Controls.Add(this.panelCantenedor);
            this.Name = "FrmPaquete";
            this.Text = "FrmPaquete";
            this.Load += new System.EventHandler(this.FrmPaquete_Load);
            this.panelCantenedor.ResumeLayout(false);
            this.panelBTN.ResumeLayout(false);
            this.panelcantenedo1.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPaquete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCantenedor;
        private System.Windows.Forms.Panel panelcantenedo1;
        private System.Windows.Forms.Panel panelBTN;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblPaquete;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridPaquete;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}