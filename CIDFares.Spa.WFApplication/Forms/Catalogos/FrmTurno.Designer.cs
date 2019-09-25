namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmTurno
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
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.Turnos = new System.Windows.Forms.Label();
            this.PanelBTN = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoTurno = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.panelGridDatosTurno = new System.Windows.Forms.Panel();
            this.sfDataGridTurno = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataGridValores = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataGridValoresTabla = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.NombreTurnoEdit = new System.Windows.Forms.Label();
            this.PanelTitulo.SuspendLayout();
            this.PanelBTN.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelGridDatosTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridValoresTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.Turnos);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1176, 58);
            this.PanelTitulo.TabIndex = 0;
            // 
            // Turnos
            // 
            this.Turnos.AutoSize = true;
            this.Turnos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turnos.Location = new System.Drawing.Point(47, 18);
            this.Turnos.Name = "Turnos";
            this.Turnos.Size = new System.Drawing.Size(67, 22);
            this.Turnos.TabIndex = 0;
            this.Turnos.Text = "Turnos";
            // 
            // PanelBTN
            // 
            this.PanelBTN.Controls.Add(this.flowLayoutPanel2);
            this.PanelBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBTN.Location = new System.Drawing.Point(0, 580);
            this.PanelBTN.Name = "PanelBTN";
            this.PanelBTN.Size = new System.Drawing.Size(1176, 47);
            this.PanelBTN.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNuevoTurno);
            this.flowLayoutPanel2.Controls.Add(this.btnModificarTurno);
            this.flowLayoutPanel2.Controls.Add(this.btnEliminarTurno);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(767, 38);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnNuevoTurno
            // 
            this.btnNuevoTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevoTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevoTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTurno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevoTurno.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoTurno.Name = "btnNuevoTurno";
            this.btnNuevoTurno.Size = new System.Drawing.Size(123, 29);
            this.btnNuevoTurno.TabIndex = 0;
            this.btnNuevoTurno.Text = "Nuevo";
            this.btnNuevoTurno.UseVisualStyleBackColor = false;
            this.btnNuevoTurno.Click += new System.EventHandler(this.btnNuevoTurno_Click);
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTurno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificarTurno.Location = new System.Drawing.Point(132, 3);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(123, 29);
            this.btnModificarTurno.TabIndex = 1;
            this.btnModificarTurno.Text = "Modificar";
            this.btnModificarTurno.UseVisualStyleBackColor = false;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarTurno_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminarTurno.Location = new System.Drawing.Point(261, 3);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(123, 29);
            this.btnEliminarTurno.TabIndex = 2;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = false;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // panelGridDatosTurno
            // 
            this.panelGridDatosTurno.BackColor = System.Drawing.Color.Transparent;
            this.panelGridDatosTurno.Controls.Add(this.NombreTurnoEdit);
            this.panelGridDatosTurno.Controls.Add(this.sfDataGridValoresTabla);
            this.panelGridDatosTurno.Controls.Add(this.sfDataGridValores);
            this.panelGridDatosTurno.Controls.Add(this.sfDataGridTurno);
            this.panelGridDatosTurno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridDatosTurno.Location = new System.Drawing.Point(0, 58);
            this.panelGridDatosTurno.Name = "panelGridDatosTurno";
            this.panelGridDatosTurno.Size = new System.Drawing.Size(1176, 522);
            this.panelGridDatosTurno.TabIndex = 3;
            // 
            // sfDataGridTurno
            // 
            this.sfDataGridTurno.AccessibleName = "Table";
            this.sfDataGridTurno.AllowEditing = false;
            this.sfDataGridTurno.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Nombre";
            gridTextColumn1.MappingName = "NombreTurno";
            this.sfDataGridTurno.Columns.Add(gridTextColumn1);
            this.sfDataGridTurno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridTurno.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridTurno.Name = "sfDataGridTurno";
            this.sfDataGridTurno.Size = new System.Drawing.Size(1176, 522);
            this.sfDataGridTurno.TabIndex = 1;
            this.sfDataGridTurno.Text = "sfDataGrid1";
            // 
            // sfDataGridValores
            // 
            this.sfDataGridValores.AccessibleName = "Table";
            this.sfDataGridValores.Location = new System.Drawing.Point(0, 3);
            this.sfDataGridValores.Name = "sfDataGridValores";
            this.sfDataGridValores.Size = new System.Drawing.Size(770, 522);
            this.sfDataGridValores.TabIndex = 2;
            this.sfDataGridValores.Text = "sfDataGrid1";
            // 
            // sfDataGridValoresTabla
            // 
            this.sfDataGridValoresTabla.AccessibleName = "Table";
            this.sfDataGridValoresTabla.Location = new System.Drawing.Point(0, 64);
            this.sfDataGridValoresTabla.Name = "sfDataGridValoresTabla";
            this.sfDataGridValoresTabla.Size = new System.Drawing.Size(770, 461);
            this.sfDataGridValoresTabla.TabIndex = 3;
            this.sfDataGridValoresTabla.Text = "sfDataGrid1";
            // 
            // NombreTurnoEdit
            // 
            this.NombreTurnoEdit.AutoSize = true;
            this.NombreTurnoEdit.Location = new System.Drawing.Point(37, 23);
            this.NombreTurnoEdit.Name = "NombreTurnoEdit";
            this.NombreTurnoEdit.Size = new System.Drawing.Size(35, 13);
            this.NombreTurnoEdit.TabIndex = 4;
            this.NombreTurnoEdit.Text = "label1";
            // 
            // FrmTurno
            // 
            this.AccessibleName = "Table";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 627);
            this.Controls.Add(this.panelGridDatosTurno);
            this.Controls.Add(this.PanelBTN);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTurno";
            this.Load += new System.EventHandler(this.FrmTurno_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.PanelBTN.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelGridDatosTurno.ResumeLayout(false);
            this.panelGridDatosTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridValoresTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label Turnos;
        private System.Windows.Forms.Panel PanelBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNuevoTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Panel panelGridDatosTurno;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridTurno;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridValores;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridValoresTabla;
        private System.Windows.Forms.Label NombreTurnoEdit;
    }
}