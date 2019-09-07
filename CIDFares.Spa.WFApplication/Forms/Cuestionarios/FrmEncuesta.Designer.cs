namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmEncuesta
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
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarEncuesta = new System.Windows.Forms.Button();
            this.btnModificarEncuesta = new System.Windows.Forms.Button();
            this.btnNuevaEncuesta = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridsf1 = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.FlpBotones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnEliminarEncuesta);
            this.FlpBotones.Controls.Add(this.btnModificarEncuesta);
            this.FlpBotones.Controls.Add(this.btnNuevaEncuesta);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 376);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(800, 74);
            this.FlpBotones.TabIndex = 5;
            // 
            // btnEliminarEncuesta
            // 
            this.btnEliminarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminarEncuesta.FlatAppearance.BorderSize = 0;
            this.btnEliminarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEncuesta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEncuesta.Location = new System.Drawing.Point(647, 23);
            this.btnEliminarEncuesta.Name = "btnEliminarEncuesta";
            this.btnEliminarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnEliminarEncuesta.TabIndex = 16;
            this.btnEliminarEncuesta.Text = "ELIMINAR";
            this.btnEliminarEncuesta.UseVisualStyleBackColor = false;
            // 
            // btnModificarEncuesta
            // 
            this.btnModificarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnModificarEncuesta.FlatAppearance.BorderSize = 0;
            this.btnModificarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEncuesta.ForeColor = System.Drawing.Color.White;
            this.btnModificarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEncuesta.Location = new System.Drawing.Point(511, 23);
            this.btnModificarEncuesta.Name = "btnModificarEncuesta";
            this.btnModificarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnModificarEncuesta.TabIndex = 15;
            this.btnModificarEncuesta.Text = "MODIFICAR";
            this.btnModificarEncuesta.UseVisualStyleBackColor = false;
            // 
            // btnNuevaEncuesta
            // 
            this.btnNuevaEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnNuevaEncuesta.FlatAppearance.BorderSize = 0;
            this.btnNuevaEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEncuesta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaEncuesta.Location = new System.Drawing.Point(375, 23);
            this.btnNuevaEncuesta.Name = "btnNuevaEncuesta";
            this.btnNuevaEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnNuevaEncuesta.TabIndex = 15;
            this.btnNuevaEncuesta.Text = "AGREGAR";
            this.btnNuevaEncuesta.UseVisualStyleBackColor = false;
            this.btnNuevaEncuesta.Click += new System.EventHandler(this.BtnNuevaEncuesta_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 45);
            this.pnlTitulo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENCUESTAS";
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
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "Column1";
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Column2";
            gridTextColumn2.MappingName = "Column2";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Column3";
            gridTextColumn3.MappingName = "Column3";
            this.dataGridsf1.Columns.Add(gridTextColumn1);
            this.dataGridsf1.Columns.Add(gridTextColumn2);
            this.dataGridsf1.Columns.Add(gridTextColumn3);
            this.dataGridsf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridsf1.Location = new System.Drawing.Point(0, 45);
            this.dataGridsf1.Name = "dataGridsf1";
            this.dataGridsf1.RowHeight = 21;
            this.dataGridsf1.ShowGroupDropArea = true;
            this.dataGridsf1.Size = new System.Drawing.Size(800, 331);
            this.dataGridsf1.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridsf1.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsf1.Style.HeaderStyle.Font.Bold = false;
            this.dataGridsf1.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsf1.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.TabIndex = 1;
            this.dataGridsf1.Text = "dataGridsf1";
            // 
            // FrmEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridsf1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.FlpBotones);
            this.Name = "FrmEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuestionarios";
            this.FlpBotones.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnEliminarEncuesta;
        private System.Windows.Forms.Button btnModificarEncuesta;
        private System.Windows.Forms.Button btnNuevaEncuesta;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private Library.Controls.CIDDataGridsf.DataGridsf dataGridsf1;
    }
}