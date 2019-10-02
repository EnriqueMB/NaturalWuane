namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmCapturaConsulta
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.btnModificarConsulta = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.dtgClientes = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.pnlTitulo.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1018, 58);
            this.pnlTitulo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONSULTAS";
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnEliminarConsulta);
            this.FlpBotones.Controls.Add(this.btnModificarConsulta);
            this.FlpBotones.Controls.Add(this.btnNuevaConsulta);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 594);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(1018, 74);
            this.FlpBotones.TabIndex = 11;
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarConsulta.BackColor = System.Drawing.Color.White;
            this.btnEliminarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarConsulta.Location = new System.Drawing.Point(865, 23);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(130, 28);
            this.btnEliminarConsulta.TabIndex = 16;
            this.btnEliminarConsulta.Text = "ELIMINAR";
            this.btnEliminarConsulta.UseVisualStyleBackColor = false;
            // 
            // btnModificarConsulta
            // 
            this.btnModificarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarConsulta.BackColor = System.Drawing.Color.White;
            this.btnModificarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarConsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnModificarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarConsulta.Location = new System.Drawing.Point(729, 23);
            this.btnModificarConsulta.Name = "btnModificarConsulta";
            this.btnModificarConsulta.Size = new System.Drawing.Size(130, 28);
            this.btnModificarConsulta.TabIndex = 15;
            this.btnModificarConsulta.Text = "MODIFICAR";
            this.btnModificarConsulta.UseVisualStyleBackColor = false;
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaConsulta.BackColor = System.Drawing.Color.White;
            this.btnNuevaConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaConsulta.Location = new System.Drawing.Point(593, 23);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(130, 28);
            this.btnNuevaConsulta.TabIndex = 15;
            this.btnNuevaConsulta.Text = "AGREGAR";
            this.btnNuevaConsulta.UseVisualStyleBackColor = false;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.BtnNuevaConsulta_Click);
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
            this.dtgClientes.AutoFitGroupDropAreaItem = true;
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
            this.dtgClientes.Location = new System.Drawing.Point(0, 58);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeight = 21;
            this.dtgClientes.ShowGroupDropArea = true;           
            this.dtgClientes.TabIndex = 12;
            this.dtgClientes.Text = "dataGridsf1";
            // 
            // FrmCapturaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 668);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapturaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapturaConsulta";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnEliminarConsulta;
        private System.Windows.Forms.Button btnModificarConsulta;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgClientes;
    }
}