namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmSucursalesGrid
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNuevo = new CIDFares.Library.Controls.Btn.Btn();
            this.btnModificar = new CIDFares.Library.Controls.Btn.Btn();
            this.btnEliminar = new CIDFares.Library.Controls.Btn.Btn();
            this.pnlHead.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1048, 58);
            this.pnlHead.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlFooter.Controls.Add(this.flowLayoutPanel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 534);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1048, 68);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.sfDataGrid1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 58);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1048, 476);
            this.pnlBody.TabIndex = 2;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdSucursal";
            gridTextColumn1.Visible = false;
            gridTextColumn2.HeaderText = "Nombre";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn3.HeaderText = "Num. Sucursal";
            gridTextColumn3.MappingName = "NumSucursal";
            gridTextColumn3.Width = 100D;
            gridTextColumn4.HeaderText = "Dirección";
            gridTextColumn4.MappingName = "Direccion";
            gridTextColumn4.Width = 200D;
            gridTextColumn5.HeaderText = "Telefono";
            gridTextColumn5.MappingName = "Telefono";
            gridTextColumn5.Width = 100D;
            gridTextColumn6.HeaderText = "Pais";
            gridTextColumn6.MappingName = "NombrePais";
            gridTextColumn6.Width = 100D;
            gridTextColumn7.HeaderText = "Estado";
            gridTextColumn7.MappingName = "NombreEstado";
            gridTextColumn7.Width = 100D;
            gridTextColumn8.HeaderText = "Municipio";
            gridTextColumn8.MappingName = "NombreMunicipio";
            gridTextColumn8.Width = 120D;
            gridTextColumn9.HeaderText = "Código postal";
            gridTextColumn9.MappingName = "CodigoPostal";
            gridTextColumn9.Width = 100D;
            gridTextColumn10.HeaderText = "RFC";
            gridTextColumn10.MappingName = "Rfc";
            gridTextColumn10.Width = 100D;
            gridTextColumn11.HeaderText = "Representante";
            gridTextColumn11.MappingName = "NombreRepresentante";
            gridTextColumn11.Width = 120D;
            gridTextColumn12.HeaderText = "Regimen Fiscal";
            gridTextColumn12.MappingName = "RegimenFiscal";
            gridTextColumn12.Width = 150D;
            this.sfDataGrid1.Columns.Add(gridTextColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn2);
            this.sfDataGrid1.Columns.Add(gridTextColumn3);
            this.sfDataGrid1.Columns.Add(gridTextColumn4);
            this.sfDataGrid1.Columns.Add(gridTextColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn6);
            this.sfDataGrid1.Columns.Add(gridTextColumn7);
            this.sfDataGrid1.Columns.Add(gridTextColumn8);
            this.sfDataGrid1.Columns.Add(gridTextColumn9);
            this.sfDataGrid1.Columns.Add(gridTextColumn10);
            this.sfDataGrid1.Columns.Add(gridTextColumn11);
            this.sfDataGrid1.Columns.Add(gridTextColumn12);
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(1048, 476);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 182;
            this.label1.Text = "Sucursales";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1048, 68);
            this.flowLayoutPanel1.TabIndex = 19;
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
            this.BtnNuevo.Location = new System.Drawing.Point(23, 18);
            this.BtnNuevo.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.BtnNuevo.MouseHoverForeColor = System.Drawing.Color.White;
            this.BtnNuevo.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(123, 29);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.IsBackStageButton = false;
            this.btnModificar.Location = new System.Drawing.Point(152, 18);
            this.btnModificar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnModificar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IsBackStageButton = false;
            this.btnEliminar.Location = new System.Drawing.Point(281, 18);
            this.btnEliminar.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnEliminar.MouseHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.MouseLeaveForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmSucursalesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 602);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSucursalesGrid";
            this.Text = "FrmSucursalesGrid";
            this.Shown += new System.EventHandler(this.FrmSucursalesGrid_Shown);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Library.Controls.Btn.Btn BtnNuevo;
        private Library.Controls.Btn.Btn btnModificar;
        private Library.Controls.Btn.Btn btnEliminar;
    }
}