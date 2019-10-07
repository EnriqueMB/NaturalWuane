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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarEncuesta = new System.Windows.Forms.Button();
            this.btnModificarEncuesta = new System.Windows.Forms.Button();
            this.btnNuevaEncuesta = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgEncuestas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.FlpBotones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).BeginInit();
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
            this.btnEliminarEncuesta.BackColor = System.Drawing.Color.White;
            this.btnEliminarEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEncuesta.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEncuesta.Location = new System.Drawing.Point(647, 23);
            this.btnEliminarEncuesta.Name = "btnEliminarEncuesta";
            this.btnEliminarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnEliminarEncuesta.TabIndex = 16;
            this.btnEliminarEncuesta.Text = "ELIMINAR";
            this.btnEliminarEncuesta.UseVisualStyleBackColor = false;
            this.btnEliminarEncuesta.Click += new System.EventHandler(this.BtnEliminarEncuesta_Click);
            // 
            // btnModificarEncuesta
            // 
            this.btnModificarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEncuesta.BackColor = System.Drawing.Color.White;
            this.btnModificarEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEncuesta.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEncuesta.Location = new System.Drawing.Point(511, 23);
            this.btnModificarEncuesta.Name = "btnModificarEncuesta";
            this.btnModificarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnModificarEncuesta.TabIndex = 15;
            this.btnModificarEncuesta.Text = "MODIFICAR";
            this.btnModificarEncuesta.UseVisualStyleBackColor = false;
            this.btnModificarEncuesta.Click += new System.EventHandler(this.BtnModificarEncuesta_Click);
            // 
            // btnNuevaEncuesta
            // 
            this.btnNuevaEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaEncuesta.BackColor = System.Drawing.Color.White;
            this.btnNuevaEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevaEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEncuesta.ForeColor = System.Drawing.Color.Black;
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
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 58);
            this.pnlTitulo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENCUESTAS";
            // 
            // dtgEncuestas
            // 
            this.dtgEncuestas.AccessibleName = "Table";
            this.dtgEncuestas.AllowDraggingColumns = true;
            this.dtgEncuestas.AllowEditing = false;
            this.dtgEncuestas.AllowFiltering = true;
            this.dtgEncuestas.AutoExpandGroups = true;
            this.dtgEncuestas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtgEncuestas.BackColor = System.Drawing.Color.White;
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "IdEncuesta";
            gridTextColumn5.MappingName = "IdEncuesta";
            gridTextColumn5.Visible = false;
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "ENCUESTA";
            gridTextColumn6.MappingName = "NombreEncuesta";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "IdTipoEncuesta";
            gridTextColumn7.MappingName = "IdTipoEncuesta";
            gridTextColumn7.Visible = false;
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "TIPO DE ENCUESTA";
            gridTextColumn8.MappingName = "Descripcion";
            this.dtgEncuestas.Columns.Add(gridTextColumn5);
            this.dtgEncuestas.Columns.Add(gridTextColumn6);
            this.dtgEncuestas.Columns.Add(gridTextColumn7);
            this.dtgEncuestas.Columns.Add(gridTextColumn8);
            this.dtgEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEncuestas.ForeColor = System.Drawing.Color.Black;
            this.dtgEncuestas.Location = new System.Drawing.Point(0, 58);
            this.dtgEncuestas.Name = "dtgEncuestas";
            this.dtgEncuestas.RowHeight = 21;
            this.dtgEncuestas.ShowGroupDropArea = true;
            this.dtgEncuestas.Size = new System.Drawing.Size(800, 318);
            this.dtgEncuestas.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dtgEncuestas.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtgEncuestas.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgEncuestas.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgEncuestas.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dtgEncuestas.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.dtgEncuestas.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgEncuestas.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgEncuestas.TabIndex = 1;
            this.dtgEncuestas.Text = "dataGridsf1";
            // 
            // FrmEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgEncuestas);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.FlpBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuestionarios";
            this.Load += new System.EventHandler(this.FrmEncuesta_Load);
            this.Shown += new System.EventHandler(this.FrmEncuesta_Shown);
            this.FlpBotones.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnEliminarEncuesta;
        private System.Windows.Forms.Button btnModificarEncuesta;
        private System.Windows.Forms.Button btnNuevaEncuesta;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgEncuestas;
    }
}