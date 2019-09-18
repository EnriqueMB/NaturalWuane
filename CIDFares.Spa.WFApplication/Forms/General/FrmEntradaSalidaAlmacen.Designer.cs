namespace CIDFares.Spa.WFApplication.Forms.General
{
    partial class FrmEntradaSalidaAlmacen
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pblButtom = new System.Windows.Forms.Panel();
            this.pblCenter = new System.Windows.Forms.Panel();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.TipoControl = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pblCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.dateTimePicker1);
            this.pnlTop.Controls.Add(this.lblTipo);
            this.pnlTop.Controls.Add(this.TipoControl);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(772, 111);
            this.pnlTop.TabIndex = 0;
            // 
            // pblButtom
            // 
            this.pblButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblButtom.Location = new System.Drawing.Point(0, 412);
            this.pblButtom.Name = "pblButtom";
            this.pblButtom.Size = new System.Drawing.Size(772, 100);
            this.pblButtom.TabIndex = 1;
            // 
            // pblCenter
            // 
            this.pblCenter.Controls.Add(this.sfDataGrid1);
            this.pblCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblCenter.Location = new System.Drawing.Point(0, 111);
            this.pblCenter.Name = "pblCenter";
            this.pblCenter.Size = new System.Drawing.Size(772, 301);
            this.pblCenter.TabIndex = 2;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(772, 301);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // TipoControl
            // 
            this.TipoControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoControl.FormattingEnabled = true;
            this.TipoControl.Location = new System.Drawing.Point(615, 69);
            this.TipoControl.Name = "TipoControl";
            this.TipoControl.Size = new System.Drawing.Size(123, 21);
            this.TipoControl.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(612, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 18);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "TIPO";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA";
            // 
            // FrmEntradaSalidaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 512);
            this.Controls.Add(this.pblCenter);
            this.Controls.Add(this.pblButtom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntradaSalidaAlmacen";
            this.Text = "FrmEntradaSalidaAlmacen";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pblCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pblButtom;
        private System.Windows.Forms.Panel pblCenter;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox TipoControl;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}