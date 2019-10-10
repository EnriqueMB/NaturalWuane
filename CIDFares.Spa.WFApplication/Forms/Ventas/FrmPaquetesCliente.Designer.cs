namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmPaquetesCliente
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgmPaquetes = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGeneral.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmPaquetes)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.pnlGrid);
            this.pnlGeneral.Controls.Add(this.pnlButtons);
            this.pnlGeneral.Controls.Add(this.pnlHeader);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(722, 389);
            this.pnlGeneral.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgmPaquetes);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 58);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(722, 272);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgmPaquetes
            // 
            this.dgmPaquetes.AccessibleName = "Table";
            this.dgmPaquetes.AllowResizingColumns = true;
            this.dgmPaquetes.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "IdCliente";
            gridTextColumn7.MappingName = "Cliente.IdCliente";
            gridTextColumn7.Visible = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "NombreCompleto";
            gridTextColumn8.MappingName = "Cliente.NombreCompleto";
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "IdOrdenServicio";
            gridTextColumn9.MappingName = "IdOrdenServicio";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "IdPaquete";
            gridTextColumn10.MappingName = "OrdenPaquete.Paquete.IdPaquete";
            gridTextColumn10.Visible = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "Paquete";
            gridTextColumn11.MappingName = "OrdenPaquete.Paquete.Nombre";
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "IdOrdenPaquete";
            gridTextColumn12.MappingName = "OrdenPaquete.IdOrdenPaquete";
            gridTextColumn12.Visible = false;
            this.dgmPaquetes.Columns.Add(gridTextColumn7);
            this.dgmPaquetes.Columns.Add(gridTextColumn8);
            this.dgmPaquetes.Columns.Add(gridTextColumn9);
            this.dgmPaquetes.Columns.Add(gridTextColumn10);
            this.dgmPaquetes.Columns.Add(gridTextColumn11);
            this.dgmPaquetes.Columns.Add(gridTextColumn12);
            this.dgmPaquetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgmPaquetes.Location = new System.Drawing.Point(0, 0);
            this.dgmPaquetes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgmPaquetes.Name = "dgmPaquetes";
            this.dgmPaquetes.Size = new System.Drawing.Size(722, 272);
            this.dgmPaquetes.TabIndex = 0;
            this.dgmPaquetes.Text = "sfDataGrid1";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnSeleccionar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 330);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(722, 59);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(595, 21);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(104, 26);
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Pagar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(722, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Paquetes agendas del cliente";
            // 
            // FrmPaquetesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 389);
            this.Controls.Add(this.pnlGeneral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(740, 435);
            this.Name = "FrmPaquetesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCitasSinAgendar";
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmPaquetes)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmPaquetes;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}