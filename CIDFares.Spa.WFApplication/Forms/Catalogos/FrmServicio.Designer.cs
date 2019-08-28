namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmServicio
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn21 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn22 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn23 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn24 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgServicio = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.flpnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).BeginInit();
            this.flpnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 68);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpnlButtons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 80);
            this.panel2.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgServicio);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 68);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1238, 388);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgServicio
            // 
            this.dgServicio.AccessibleName = "Table";
            this.dgServicio.AllowGrouping = false;
            gridTextColumn13.AllowGrouping = false;
            gridTextColumn13.HeaderText = "IdServicio";
            gridTextColumn13.MappingName = "IdServicio";
            gridTextColumn13.Visible = false;
            gridTextColumn14.AllowGrouping = false;
            gridTextColumn14.HeaderText = "IdTipoServicio";
            gridTextColumn14.MappingName = "IdTipoServicio";
            gridTextColumn14.Visible = false;
            gridTextColumn15.AllowGrouping = false;
            gridTextColumn15.HeaderText = "IdTipoIva";
            gridTextColumn15.MappingName = "IdTipoIva";
            gridTextColumn15.Visible = false;
            gridTextColumn16.AllowGrouping = false;
            gridTextColumn16.HeaderText = "Clave";
            gridTextColumn16.MappingName = "Clave";
            gridTextColumn17.AllowGrouping = false;
            gridTextColumn17.HeaderText = "Nombre";
            gridTextColumn17.MappingName = "Nombre";
            gridTextColumn18.AllowGrouping = false;
            gridTextColumn18.HeaderText = "Descripcion";
            gridTextColumn18.MappingName = "Descripcion";
            gridTextColumn19.AllowGrouping = false;
            gridTextColumn19.HeaderText = "Precio";
            gridTextColumn19.MappingName = "Precio";
            gridTextColumn20.AllowGrouping = false;
            gridTextColumn20.HeaderText = "Duracion";
            gridTextColumn20.MappingName = "Duracion";
            gridTextColumn21.AllowGrouping = false;
            gridTextColumn21.HeaderText = "AplicaIva";
            gridTextColumn21.MappingName = "AplicaIva";
            gridTextColumn22.AllowGrouping = false;
            gridTextColumn22.HeaderText = "AplicaIEPS";
            gridTextColumn22.MappingName = "AplicaIEPS";
            gridTextColumn23.AllowGrouping = false;
            gridTextColumn23.HeaderText = "IEPSMonto";
            gridTextColumn23.MappingName = "IEPSMonto";
            gridTextColumn24.AllowGrouping = false;
            gridTextColumn24.HeaderText = "IEPS";
            gridTextColumn24.MappingName = "IEPS";
            this.dgServicio.Columns.Add(gridTextColumn13);
            this.dgServicio.Columns.Add(gridTextColumn14);
            this.dgServicio.Columns.Add(gridTextColumn15);
            this.dgServicio.Columns.Add(gridTextColumn16);
            this.dgServicio.Columns.Add(gridTextColumn17);
            this.dgServicio.Columns.Add(gridTextColumn18);
            this.dgServicio.Columns.Add(gridTextColumn19);
            this.dgServicio.Columns.Add(gridTextColumn20);
            this.dgServicio.Columns.Add(gridTextColumn21);
            this.dgServicio.Columns.Add(gridTextColumn22);
            this.dgServicio.Columns.Add(gridTextColumn23);
            this.dgServicio.Columns.Add(gridTextColumn24);
            this.dgServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgServicio.Location = new System.Drawing.Point(0, 0);
            this.dgServicio.Margin = new System.Windows.Forms.Padding(4);
            this.dgServicio.Name = "dgServicio";
            this.dgServicio.PreviewRowHeightMode = Syncfusion.WinForms.DataGrid.Enums.PreviewRowHeightMode.Auto;
            this.dgServicio.Size = new System.Drawing.Size(1238, 388);
            this.dgServicio.TabIndex = 1;
            this.dgServicio.Text = "sfDataGrid1";
            // 
            // flpnlButtons
            // 
            this.flpnlButtons.Controls.Add(this.btnNuevo);
            this.flpnlButtons.Controls.Add(this.btnModificar);
            this.flpnlButtons.Controls.Add(this.btnEliminar);
            this.flpnlButtons.Location = new System.Drawing.Point(317, 21);
            this.flpnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.flpnlButtons.Name = "flpnlButtons";
            this.flpnlButtons.Size = new System.Drawing.Size(604, 39);
            this.flpnlButtons.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(4, 4);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(176, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(164, 36);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(348, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(70, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Servicios";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 536);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmServicio";
            this.Text = "FrmServicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).EndInit();
            this.flpnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgServicio;
        private System.Windows.Forms.FlowLayoutPanel flpnlButtons;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitle;
    }
}