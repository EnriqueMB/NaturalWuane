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
            this.components = new System.ComponentModel.Container();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.LblTurno = new System.Windows.Forms.Label();
            this.PanelContainsButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelContainsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.BtnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.BtnEliminar = new CIDFares.Library.Controls.Btn.Btn();
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
            this.LblTurno.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblTurno.Location = new System.Drawing.Point(47, 18);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(68, 30);
            this.LblTurno.TabIndex = 0;
            this.LblTurno.Text = "Turno";
            // 
            // PanelContainsButtons
            // 
            this.PanelContainsButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.PanelContainsButtons.Controls.Add(this.flowLayoutPanelContainsButtons);
            this.PanelContainsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelContainsButtons.Location = new System.Drawing.Point(0, 506);
            this.PanelContainsButtons.Name = "PanelContainsButtons";
            this.PanelContainsButtons.Size = new System.Drawing.Size(1052, 68);
            this.PanelContainsButtons.TabIndex = 1;
            // 
            // flowLayoutPanelContainsButtons
            // 
            this.flowLayoutPanelContainsButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnNuevo);
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnModificar);
            this.flowLayoutPanelContainsButtons.Controls.Add(this.BtnEliminar);
            this.flowLayoutPanelContainsButtons.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanelContainsButtons.Name = "flowLayoutPanelContainsButtons";
            this.flowLayoutPanelContainsButtons.Size = new System.Drawing.Size(398, 37);
            this.flowLayoutPanelContainsButtons.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.IsBackStageButton = false;
            this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
            this.BtnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(123, 29);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.White;
            this.BtnModificar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.IsBackStageButton = false;
            this.BtnModificar.Location = new System.Drawing.Point(132, 3);
            this.BtnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(123, 29);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.IsBackStageButton = false;
            this.BtnEliminar.Location = new System.Drawing.Point(261, 3);
            this.BtnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(123, 29);
            this.BtnEliminar.TabIndex = 6;
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
            this.PanelContainsPrincipalTable.Size = new System.Drawing.Size(1052, 446);
            this.PanelContainsPrincipalTable.TabIndex = 2;
            // 
            // GridNombresTurnos
            // 
            this.GridNombresTurnos.AccessibleName = "Table";
            this.GridNombresTurnos.AllowEditing = false;
            this.GridNombresTurnos.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Nombre del turno";
            gridTextColumn1.MappingName = "NombreTurno";
            this.GridNombresTurnos.Columns.Add(gridTextColumn1);
            this.GridNombresTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridNombresTurnos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridNombresTurnos.Location = new System.Drawing.Point(0, 0);
            this.GridNombresTurnos.Name = "GridNombresTurnos";
            this.GridNombresTurnos.Size = new System.Drawing.Size(1052, 446);
            this.GridNombresTurnos.TabIndex = 2;
            this.GridNombresTurnos.Text = "sfDataGrid1";
            this.GridNombresTurnos.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.GridNombresTurnos_CellDoubleClick);
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
        private Library.Controls.Btn.Btn BtnNuevo;
        private Library.Controls.Btn.Btn BtnModificar;
        private Library.Controls.Btn.Btn BtnEliminar;
    }
}