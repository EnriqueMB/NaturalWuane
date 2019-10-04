namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmTurnoPrincipal
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.LblTurno = new System.Windows.Forms.Label();
            this.PanelContainsButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelContainsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelContainsPrincipalTable = new System.Windows.Forms.Panel();
            this.GridNombresTurnos = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.PanelTitulo.SuspendLayout();
            this.PanelContainsButtons.SuspendLayout();
            this.flowLayoutPanelContainsButtons.SuspendLayout();
            this.PanelContainsPrincipalTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNombresTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.PanelTitulo.Controls.Add(this.LblTurno);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1052, 58);
            this.PanelTitulo.TabIndex = 0;
            // 
            // LblTurno
            // 
            this.LblTurno.AutoSize = true;
            this.LblTurno.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LblTurno.Location = new System.Drawing.Point(47, 18);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(60, 22);
            this.LblTurno.TabIndex = 0;
            this.LblTurno.Text = "Turno";
            // 
            // PanelContainsButtons
            // 
            this.PanelContainsButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContainsButtons.Controls.Add(this.flowLayoutPanelContainsButtons);
            this.PanelContainsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelContainsButtons.Location = new System.Drawing.Point(0, 502);
            this.PanelContainsButtons.Name = "PanelContainsButtons";
            this.PanelContainsButtons.Size = new System.Drawing.Size(1052, 72);
            this.PanelContainsButtons.TabIndex = 1;
            // 
            // flowLayoutPanelContainsButtons
            // 
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnNuevo);
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnModificar);
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnEliminar);
            this.flowLayoutPanelContainsButtons.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanelContainsButtons.Name = "flowLayoutPanelContainsButtons";
            this.flowLayoutPanelContainsButtons.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.flowLayoutPanelContainsButtons.Size = new System.Drawing.Size(541, 69);
            this.flowLayoutPanelContainsButtons.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnNuevo.Location = new System.Drawing.Point(23, 18);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(137, 30);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnModificar.Location = new System.Drawing.Point(166, 18);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(137, 30);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnEliminar.Location = new System.Drawing.Point(309, 18);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(137, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PanelContainsPrincipalTable
            // 
            this.PanelContainsPrincipalTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainsPrincipalTable.Controls.Add(this.GridNombresTurnos);
            this.PanelContainsPrincipalTable.Location = new System.Drawing.Point(0, 59);
            this.PanelContainsPrincipalTable.Name = "PanelContainsPrincipalTable";
            this.PanelContainsPrincipalTable.Size = new System.Drawing.Size(1052, 437);
            this.PanelContainsPrincipalTable.TabIndex = 2;
            // 
            // GridNombresTurnos
            // 
            this.GridNombresTurnos.AccessibleName = "Table";
            this.GridNombresTurnos.AllowEditing = false;
            this.GridNombresTurnos.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Nombre del turno";
            gridTextColumn2.MappingName = "NombreTurno";
            this.GridNombresTurnos.Columns.Add(gridTextColumn2);
            this.GridNombresTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridNombresTurnos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridNombresTurnos.Location = new System.Drawing.Point(0, 0);
            this.GridNombresTurnos.Name = "GridNombresTurnos";
            this.GridNombresTurnos.Size = new System.Drawing.Size(1052, 437);
            this.GridNombresTurnos.TabIndex = 2;
            this.GridNombresTurnos.Text = "sfDataGrid1";
            // 
            // FrmTurnoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 574);
            this.Controls.Add(this.PanelContainsPrincipalTable);
            this.Controls.Add(this.PanelContainsButtons);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurnoPrincipal";
            this.Text = "FrmTurnoPrincipal";
            this.Shown += new System.EventHandler(this.FrmTurnoPrincipal_Shown);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.PanelContainsButtons.ResumeLayout(false);
            this.flowLayoutPanelContainsButtons.ResumeLayout(false);
            this.PanelContainsPrincipalTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNombresTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel PanelContainsButtons;
        private System.Windows.Forms.Panel PanelContainsPrincipalTable;
        private System.Windows.Forms.Label LblTurno;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridNombresTurnos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContainsButtons;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}