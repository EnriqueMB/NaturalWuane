namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmOpcionCuestionario
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
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContestarEncuesta = new System.Windows.Forms.Button();
            this.dtgEncuestas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.pnlTitulo.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(684, 45);
            this.pnlTitulo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "CUESTIONARIOS";
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnContestarEncuesta);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 487);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(684, 74);
            this.FlpBotones.TabIndex = 21;
            // 
            // btnContestarEncuesta
            // 
            this.btnContestarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContestarEncuesta.BackColor = System.Drawing.Color.White;
            this.btnContestarEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnContestarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContestarEncuesta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContestarEncuesta.ForeColor = System.Drawing.Color.Black;
            this.btnContestarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContestarEncuesta.Location = new System.Drawing.Point(531, 23);
            this.btnContestarEncuesta.Name = "btnContestarEncuesta";
            this.btnContestarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnContestarEncuesta.TabIndex = 15;
            this.btnContestarEncuesta.Text = "ACEPTAR";
            this.btnContestarEncuesta.UseVisualStyleBackColor = false;
            this.btnContestarEncuesta.Click += new System.EventHandler(this.BtnContestarEncuesta_Click);
            // 
            // dtgEncuestas
            // 
            this.dtgEncuestas.AccessibleName = "Table";
            this.dtgEncuestas.AllowDraggingColumns = true;
            this.dtgEncuestas.AllowEditing = false;
            this.dtgEncuestas.AllowFiltering = true;
            this.dtgEncuestas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEncuestas.AutoExpandGroups = true;
            this.dtgEncuestas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtgEncuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdEncuesta";
            gridTextColumn1.MappingName = "datos.IdEncuesta";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "ENCUESTA";
            gridTextColumn2.MappingName = "datos.NombreEncuesta";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "IdTipoEncuesta";
            gridTextColumn3.MappingName = "datos.IdTipoEncuesta";
            gridTextColumn3.Visible = false;
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "TIPO DE ENCUESTA";
            gridTextColumn4.MappingName = "datos.Descripcion";
            gridCheckBoxColumn1.AllowCheckBoxOnHeader = true;
            gridCheckBoxColumn1.AllowDragging = true;
            gridCheckBoxColumn1.AllowEditing = false;
            gridCheckBoxColumn1.AllowFiltering = true;
            gridCheckBoxColumn1.HeaderText = "ASIGNAR";
            gridCheckBoxColumn1.MappingName = "asignar";
            this.dtgEncuestas.Columns.Add(gridTextColumn1);
            this.dtgEncuestas.Columns.Add(gridTextColumn2);
            this.dtgEncuestas.Columns.Add(gridTextColumn3);
            this.dtgEncuestas.Columns.Add(gridTextColumn4);
            this.dtgEncuestas.Columns.Add(gridCheckBoxColumn1);
            this.dtgEncuestas.Location = new System.Drawing.Point(12, 51);
            this.dtgEncuestas.Name = "dtgEncuestas";
            this.dtgEncuestas.RowHeight = 21;
            this.dtgEncuestas.Size = new System.Drawing.Size(660, 430);
            this.dtgEncuestas.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dtgEncuestas.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtgEncuestas.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgEncuestas.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgEncuestas.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dtgEncuestas.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgEncuestas.Style.HeaderStyle.Font.Bold = false;
            this.dtgEncuestas.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgEncuestas.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgEncuestas.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgEncuestas.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgEncuestas.TabIndex = 13;
            this.dtgEncuestas.Text = "dataGridsf1";
            // 
            // FrmOpcionCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.FlpBotones);
            this.Controls.Add(this.dtgEncuestas);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOpcionCuestionario";
            this.Text = "FrmOpcionCuestionario";
            this.Load += new System.EventHandler(this.FrmOpcionCuestionario_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.FlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgEncuestas;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnContestarEncuesta;
    }
}