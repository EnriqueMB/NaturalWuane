namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmOpcionesCuestionario
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
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn2 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabCuestionarios = new System.Windows.Forms.TabPage();
            this.dtgEncuestas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.tabMediciones = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabPlanAlimentacion = new System.Windows.Forms.TabPage();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabCuestionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).BeginInit();
            this.FlpBotones.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(812, 45);
            this.pnlTitulo.TabIndex = 11;
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
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.tab);
            this.pnlContenedor.Controls.Add(this.FlpBotones);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 45);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(812, 642);
            this.pnlContenedor.TabIndex = 21;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabCuestionarios);
            this.tab.Controls.Add(this.tabMediciones);
            this.tab.Controls.Add(this.tabServicios);
            this.tab.Controls.Add(this.tabProductos);
            this.tab.Controls.Add(this.tabPlanAlimentacion);
            this.tab.Location = new System.Drawing.Point(13, 6);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(786, 486);
            this.tab.TabIndex = 48;
            this.tab.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabCuestionarios
            // 
            this.tabCuestionarios.Controls.Add(this.dtgEncuestas);
            this.tabCuestionarios.Location = new System.Drawing.Point(4, 22);
            this.tabCuestionarios.Name = "tabCuestionarios";
            this.tabCuestionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuestionarios.Size = new System.Drawing.Size(778, 460);
            this.tabCuestionarios.TabIndex = 0;
            this.tabCuestionarios.Text = "CUESTIONARIOS";
            this.tabCuestionarios.UseVisualStyleBackColor = true;
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
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "IdEncuesta";
            gridTextColumn5.MappingName = "datos.IdEncuesta";
            gridTextColumn5.Visible = false;
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "ENCUESTA";
            gridTextColumn6.MappingName = "datos.NombreEncuesta";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "IdTipoEncuesta";
            gridTextColumn7.MappingName = "datos.IdTipoEncuesta";
            gridTextColumn7.Visible = false;
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "TIPO DE ENCUESTA";
            gridTextColumn8.MappingName = "datos.Descripcion";
            gridCheckBoxColumn2.AllowCheckBoxOnHeader = true;
            gridCheckBoxColumn2.AllowDragging = true;
            gridCheckBoxColumn2.AllowEditing = false;
            gridCheckBoxColumn2.AllowFiltering = true;
            gridCheckBoxColumn2.HeaderText = "ASIGNAR";
            gridCheckBoxColumn2.MappingName = "asignar";
            this.dtgEncuestas.Columns.Add(gridTextColumn5);
            this.dtgEncuestas.Columns.Add(gridTextColumn6);
            this.dtgEncuestas.Columns.Add(gridTextColumn7);
            this.dtgEncuestas.Columns.Add(gridTextColumn8);
            this.dtgEncuestas.Columns.Add(gridCheckBoxColumn2);
            this.dtgEncuestas.Location = new System.Drawing.Point(3, 5);
            this.dtgEncuestas.Name = "dtgEncuestas";
            this.dtgEncuestas.RowHeight = 21;
            this.dtgEncuestas.ShowGroupDropArea = true;
            this.dtgEncuestas.Size = new System.Drawing.Size(772, 344);
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
            this.dtgEncuestas.TabIndex = 14;
            this.dtgEncuestas.Text = "dataGridsf1";
            // 
            // tabMediciones
            // 
            this.tabMediciones.Location = new System.Drawing.Point(4, 22);
            this.tabMediciones.Name = "tabMediciones";
            this.tabMediciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabMediciones.Size = new System.Drawing.Size(778, 460);
            this.tabMediciones.TabIndex = 1;
            this.tabMediciones.Text = "MEDICIONES";
            this.tabMediciones.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Size = new System.Drawing.Size(778, 460);
            this.tabServicios.TabIndex = 2;
            this.tabServicios.Text = "SERVICIOS";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(778, 460);
            this.tabProductos.TabIndex = 3;
            this.tabProductos.Text = "PRODUCTOS";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnAceptar);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 568);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(812, 74);
            this.FlpBotones.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(659, 23);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 28);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // tabPlanAlimentacion
            // 
            this.tabPlanAlimentacion.Location = new System.Drawing.Point(4, 22);
            this.tabPlanAlimentacion.Name = "tabPlanAlimentacion";
            this.tabPlanAlimentacion.Size = new System.Drawing.Size(778, 460);
            this.tabPlanAlimentacion.TabIndex = 4;
            this.tabPlanAlimentacion.Text = "PLAN DE ALIMENTACION";
            this.tabPlanAlimentacion.UseVisualStyleBackColor = true;
            // 
            // FrmOpcionesCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 687);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "FrmOpcionesCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpcionesCuestionario";
            this.Load += new System.EventHandler(this.FrmOpcionesCuestionario_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabCuestionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuestas)).EndInit();
            this.FlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabCuestionarios;
        private System.Windows.Forms.TabPage tabMediciones;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgEncuestas;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabPlanAlimentacion;
    }
}