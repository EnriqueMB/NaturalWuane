namespace CIDFares.Spa.WFApplication.Forms.General
{
    partial class FrmProductosMonedero
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PuntosMonederoControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.DescuentoGroup = new System.Windows.Forms.GroupBox();
            this.MontoControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.PuntosDescuentoControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTipoDescuento = new System.Windows.Forms.Label();
            this.EsMontoControl = new System.Windows.Forms.CheckBox();
            this.AplicaDescuentoControl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProductoControl = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosMonederoControl)).BeginInit();
            this.DescuentoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDescuentoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 68);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 25);
            this.lblTitulo.TabIndex = 182;
            this.lblTitulo.Text = "AGREGAR PUNTOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(121, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(266, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PuntosMonederoControl);
            this.panel3.Controls.Add(this.DescuentoGroup);
            this.panel3.Controls.Add(this.AplicaDescuentoControl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BtnSeleccionar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.IdProductoControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 354);
            this.panel3.TabIndex = 2;
            // 
            // PuntosMonederoControl
            // 
            this.PuntosMonederoControl.BeforeTouchSize = new System.Drawing.Size(244, 27);
            this.PuntosMonederoControl.Culture = new System.Globalization.CultureInfo("es-MX");
            this.PuntosMonederoControl.CurrencyDecimalDigits = 0;
            this.PuntosMonederoControl.CurrencySymbol = "";
            this.PuntosMonederoControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PuntosMonederoControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosMonederoControl.Location = new System.Drawing.Point(17, 113);
            this.PuntosMonederoControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PuntosMonederoControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PuntosMonederoControl.Name = "PuntosMonederoControl";
            this.PuntosMonederoControl.NullString = "";
            this.PuntosMonederoControl.Size = new System.Drawing.Size(244, 27);
            this.PuntosMonederoControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            this.PuntosMonederoControl.TabIndex = 49;
            this.PuntosMonederoControl.Text = "0";
            // 
            // DescuentoGroup
            // 
            this.DescuentoGroup.Controls.Add(this.MontoControl);
            this.DescuentoGroup.Controls.Add(this.PuntosDescuentoControl);
            this.DescuentoGroup.Controls.Add(this.label5);
            this.DescuentoGroup.Controls.Add(this.label4);
            this.DescuentoGroup.Controls.Add(this.lbTipoDescuento);
            this.DescuentoGroup.Controls.Add(this.EsMontoControl);
            this.DescuentoGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoGroup.Location = new System.Drawing.Point(17, 164);
            this.DescuentoGroup.Name = "DescuentoGroup";
            this.DescuentoGroup.Size = new System.Drawing.Size(369, 175);
            this.DescuentoGroup.TabIndex = 48;
            this.DescuentoGroup.TabStop = false;
            this.DescuentoGroup.Text = "Puntos Descuento";
            // 
            // MontoControl
            // 
            this.MontoControl.BeforeTouchSize = new System.Drawing.Size(244, 27);
            this.MontoControl.Culture = new System.Globalization.CultureInfo("es-MX");
            this.MontoControl.CurrencyDecimalDigits = 0;
            this.MontoControl.CurrencySymbol = "";
            this.MontoControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MontoControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoControl.Location = new System.Drawing.Point(162, 133);
            this.MontoControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.MontoControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MontoControl.Name = "MontoControl";
            this.MontoControl.NullString = "";
            this.MontoControl.Size = new System.Drawing.Size(189, 27);
            this.MontoControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            this.MontoControl.TabIndex = 53;
            this.MontoControl.Text = "0";
            // 
            // PuntosDescuentoControl
            // 
            this.PuntosDescuentoControl.BeforeTouchSize = new System.Drawing.Size(244, 27);
            this.PuntosDescuentoControl.Culture = new System.Globalization.CultureInfo("es-MX");
            this.PuntosDescuentoControl.CurrencyDecimalDigits = 0;
            this.PuntosDescuentoControl.CurrencySymbol = "";
            this.PuntosDescuentoControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PuntosDescuentoControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosDescuentoControl.Location = new System.Drawing.Point(18, 59);
            this.PuntosDescuentoControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PuntosDescuentoControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PuntosDescuentoControl.Name = "PuntosDescuentoControl";
            this.PuntosDescuentoControl.NullString = "";
            this.PuntosDescuentoControl.Size = new System.Drawing.Size(244, 27);
            this.PuntosDescuentoControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            this.PuntosDescuentoControl.TabIndex = 50;
            this.PuntosDescuentoControl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cantidad Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Puntos Descuento";
            // 
            // lbTipoDescuento
            // 
            this.lbTipoDescuento.AutoSize = true;
            this.lbTipoDescuento.Location = new System.Drawing.Point(135, 134);
            this.lbTipoDescuento.Name = "lbTipoDescuento";
            this.lbTipoDescuento.Size = new System.Drawing.Size(21, 20);
            this.lbTipoDescuento.TabIndex = 49;
            this.lbTipoDescuento.Text = "%";
            this.lbTipoDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EsMontoControl
            // 
            this.EsMontoControl.AutoSize = true;
            this.EsMontoControl.Location = new System.Drawing.Point(18, 135);
            this.EsMontoControl.Name = "EsMontoControl";
            this.EsMontoControl.Size = new System.Drawing.Size(72, 24);
            this.EsMontoControl.TabIndex = 48;
            this.EsMontoControl.Text = "Monto";
            this.EsMontoControl.UseVisualStyleBackColor = true;
            this.EsMontoControl.CheckedChanged += new System.EventHandler(this.EsMontoControl_CheckedChanged);
            // 
            // AplicaDescuentoControl
            // 
            this.AplicaDescuentoControl.AutoSize = true;
            this.AplicaDescuentoControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AplicaDescuentoControl.Location = new System.Drawing.Point(293, 113);
            this.AplicaDescuentoControl.Name = "AplicaDescuentoControl";
            this.AplicaDescuentoControl.Size = new System.Drawing.Size(98, 24);
            this.AplicaDescuentoControl.TabIndex = 47;
            this.AplicaDescuentoControl.Text = "Descuento";
            this.AplicaDescuentoControl.UseVisualStyleBackColor = true;
            this.AplicaDescuentoControl.CheckedChanged += new System.EventHandler(this.AplicaDescuentoControl_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Puntos Monedero";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(293, 37);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(93, 28);
            this.BtnSeleccionar.TabIndex = 44;
            this.BtnSeleccionar.Text = "BUSCAR";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // IdProductoControl
            // 
            this.IdProductoControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProductoControl.Location = new System.Drawing.Point(17, 37);
            this.IdProductoControl.Name = "IdProductoControl";
            this.IdProductoControl.Size = new System.Drawing.Size(244, 27);
            this.IdProductoControl.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductosMonedero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductosMonedero";
            this.Text = "FrmProductosMonedero";
            this.Load += new System.EventHandler(this.FrmProductosMonedero_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosMonederoControl)).EndInit();
            this.DescuentoGroup.ResumeLayout(false);
            this.DescuentoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuntosDescuentoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProductoControl;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox DescuentoGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTipoDescuento;
        private System.Windows.Forms.CheckBox EsMontoControl;
        private System.Windows.Forms.CheckBox AplicaDescuentoControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox PuntosMonederoControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox MontoControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox PuntosDescuentoControl;
    }
}