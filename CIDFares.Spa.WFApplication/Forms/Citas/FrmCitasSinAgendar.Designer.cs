namespace CIDFares.Spa.WFApplication.Forms.Citas
{
    partial class FrmCitasSinAgendar
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgmCitasSinAgendar = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BusquedaControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGeneral.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmCitasSinAgendar)).BeginInit();
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
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(963, 479);
            this.pnlGeneral.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgmCitasSinAgendar);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 72);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(963, 334);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgmCitasSinAgendar
            // 
            this.dgmCitasSinAgendar.AccessibleName = "Table";
            this.dgmCitasSinAgendar.AllowResizingColumns = true;
            this.dgmCitasSinAgendar.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "IdCliente";
            gridTextColumn1.MappingName = "Cliente.IdCliente";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "NombreCompleto";
            gridTextColumn2.MappingName = "Cliente.NombreCompleto";
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "IdOrdenServicio";
            gridTextColumn3.MappingName = "IdOrdenServicio";
            gridTextColumn3.Visible = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "IdPaquete";
            gridTextColumn4.MappingName = "OrdenPaquete.Paquete.IdPaquete";
            gridTextColumn4.Visible = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderText = "Paquete";
            gridTextColumn5.MappingName = "OrdenPaquete.Paquete.Nombre";
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "IdOrdenPaquete";
            gridTextColumn6.MappingName = "OrdenPaquete.IdOrdenPaquete";
            gridTextColumn6.Visible = false;
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn1);
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn2);
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn3);
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn4);
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn5);
            this.dgmCitasSinAgendar.Columns.Add(gridTextColumn6);
            this.dgmCitasSinAgendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgmCitasSinAgendar.Location = new System.Drawing.Point(0, 0);
            this.dgmCitasSinAgendar.Name = "dgmCitasSinAgendar";
            this.dgmCitasSinAgendar.Size = new System.Drawing.Size(963, 334);
            this.dgmCitasSinAgendar.TabIndex = 0;
            this.dgmCitasSinAgendar.Text = "sfDataGrid1";
            this.dgmCitasSinAgendar.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgmCitasSinAgendar_CellDoubleClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnSeleccionar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 406);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(963, 73);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(818, 28);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(119, 32);
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnBuscar);
            this.pnlHeader.Controls.Add(this.BusquedaControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(963, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Citas sin agendar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(818, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BusquedaControl
            // 
            this.BusquedaControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusquedaControl.Location = new System.Drawing.Point(510, 29);
            this.BusquedaControl.Margin = new System.Windows.Forms.Padding(4);
            this.BusquedaControl.MaxLength = 200;
            this.BusquedaControl.Name = "BusquedaControl";
            this.BusquedaControl.Size = new System.Drawing.Size(300, 22);
            this.BusquedaControl.TabIndex = 13;
            this.BusquedaControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusquedaControl_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre del cliente";
            // 
            // FrmCitasSinAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 479);
            this.Controls.Add(this.pnlGeneral);
            this.MaximumSize = new System.Drawing.Size(981, 526);
            this.Name = "FrmCitasSinAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCitasSinAgendar";
            this.Load += new System.EventHandler(this.FrmCitasSinAgendar_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmCitasSinAgendar)).EndInit();
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox BusquedaControl;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmCitasSinAgendar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label2;
    }
}