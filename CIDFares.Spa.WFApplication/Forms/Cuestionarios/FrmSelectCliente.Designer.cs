namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmSelectCliente
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
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.dtgClientes = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.AccessibleName = "Table";
            this.dtgClientes.AllowDraggingColumns = true;
            this.dtgClientes.AllowDrop = true;
            this.dtgClientes.AllowEditing = false;
            this.dtgClientes.AllowFiltering = true;
            this.dtgClientes.AllowSelectionOnMouseDown = true;
            this.dtgClientes.AutoExpandGroups = true;
            this.dtgClientes.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtgClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdCliente";
            gridTextColumn1.MappingName = "IdCliente";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "CLAVE";
            gridTextColumn2.MappingName = "Clave";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "NOMBRE";
            gridTextColumn3.MappingName = "NombreCompleto";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "TELEFONO";
            gridTextColumn4.MappingName = "Telefono";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "EDAD";
            gridTextColumn5.MappingName = "Edad";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "DEPENDE";
            gridTextColumn6.MappingName = "IdPreguntaDepende";
            gridTextColumn6.Visible = false;
            this.dtgClientes.Columns.Add(gridTextColumn1);
            this.dtgClientes.Columns.Add(gridTextColumn2);
            this.dtgClientes.Columns.Add(gridTextColumn3);
            this.dtgClientes.Columns.Add(gridTextColumn4);
            this.dtgClientes.Columns.Add(gridTextColumn5);
            this.dtgClientes.Columns.Add(gridTextColumn6);
            this.dtgClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgClientes.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgClientes.Location = new System.Drawing.Point(0, 0);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeight = 21;
            this.dtgClientes.Size = new System.Drawing.Size(800, 405);            
            this.dtgClientes.Style.RowHeaderStyle.Borders = gridBordersInfo1;
            this.dtgClientes.TabIndex = 2;
            this.dtgClientes.Text = "dataGridsf1";
            this.dtgClientes.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.DtgClientes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 405);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "SELECCIONAR CLIENTE";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 45);
            this.pnlTitulo.TabIndex = 10;
            // 
            // FrmSelectCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmSelectCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectCliente";
            this.Load += new System.EventHandler(this.FrmSelectCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Controls.CIDDataGridsf.DataGridsf dtgClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTitulo;
    }
}