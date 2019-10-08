namespace CIDFares.Spa.WFApplication.Forms.Promociones
{
    partial class FrmNuevaPromocion
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
            this.panelOpcines = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grServProd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbServicio = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbTipoPromocion = new System.Windows.Forms.GroupBox();
            this.DescripcionControl = new System.Windows.Forms.Label();
            this.IdTipoPromocion = new System.Windows.Forms.ComboBox();
            this.grbBuscarServProd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombrePromocionControl = new System.Windows.Forms.TextBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelOpcines.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grServProd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTipoPromocion.SuspendLayout();
            this.grbBuscarServProd.SuspendLayout();
            this.gbNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpcines
            // 
            this.panelOpcines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOpcines.Controls.Add(this.tableLayoutPanel1);
            this.panelOpcines.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcines.Location = new System.Drawing.Point(0, 0);
            this.panelOpcines.Name = "panelOpcines";
            this.panelOpcines.Size = new System.Drawing.Size(274, 600);
            this.panelOpcines.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.grServProd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbBuscarServProd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbNombre, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grServProd
            // 
            this.grServProd.Controls.Add(this.label1);
            this.grServProd.Controls.Add(this.rbServicio);
            this.grServProd.Controls.Add(this.rbProducto);
            this.grServProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grServProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grServProd.Location = new System.Drawing.Point(23, 337);
            this.grServProd.Name = "grServProd";
            this.grServProd.Size = new System.Drawing.Size(230, 151);
            this.grServProd.TabIndex = 1;
            this.grServProd.TabStop = false;
            this.grServProd.Text = "Producto o servicio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciones si la promocion es dirigida a un servicio o producto\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbServicio
            // 
            this.rbServicio.AutoSize = true;
            this.rbServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbServicio.ForeColor = System.Drawing.Color.Black;
            this.rbServicio.Location = new System.Drawing.Point(9, 63);
            this.rbServicio.Name = "rbServicio";
            this.rbServicio.Size = new System.Drawing.Size(75, 21);
            this.rbServicio.TabIndex = 1;
            this.rbServicio.TabStop = true;
            this.rbServicio.Text = "Servicio";
            this.rbServicio.UseVisualStyleBackColor = true;
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProducto.ForeColor = System.Drawing.Color.Black;
            this.rbProducto.Location = new System.Drawing.Point(9, 37);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(86, 21);
            this.rbProducto.TabIndex = 0;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gbTipoPromocion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(23, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 151);
            this.panel2.TabIndex = 0;
            // 
            // gbTipoPromocion
            // 
            this.gbTipoPromocion.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.gbTipoPromocion.Controls.Add(this.DescripcionControl);
            this.gbTipoPromocion.Controls.Add(this.IdTipoPromocion);
            this.gbTipoPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTipoPromocion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPromocion.Location = new System.Drawing.Point(0, 0);
            this.gbTipoPromocion.Name = "gbTipoPromocion";
            this.gbTipoPromocion.Size = new System.Drawing.Size(230, 151);
            this.gbTipoPromocion.TabIndex = 0;
            this.gbTipoPromocion.TabStop = false;
            this.gbTipoPromocion.Text = "Tipo de promocion";
            this.gbTipoPromocion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.BackColor = System.Drawing.Color.Transparent;
            this.DescripcionControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionControl.ForeColor = System.Drawing.Color.Black;
            this.DescripcionControl.Location = new System.Drawing.Point(3, 80);
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.Size = new System.Drawing.Size(218, 52);
            this.DescripcionControl.TabIndex = 2;
            this.DescripcionControl.Text = "Agregar una promocion de compra un articulo y te llevas otro gratis";
            this.DescripcionControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdTipoPromocion
            // 
            this.IdTipoPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdTipoPromocion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTipoPromocion.FormattingEnabled = true;
            this.IdTipoPromocion.Location = new System.Drawing.Point(9, 44);
            this.IdTipoPromocion.Name = "IdTipoPromocion";
            this.IdTipoPromocion.Size = new System.Drawing.Size(212, 28);
            this.IdTipoPromocion.TabIndex = 0;
            this.IdTipoPromocion.SelectedIndexChanged += new System.EventHandler(this.IdTipoPromocion_SelectedIndexChanged);
            // 
            // grbBuscarServProd
            // 
            this.grbBuscarServProd.Controls.Add(this.button1);
            this.grbBuscarServProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBuscarServProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarServProd.Location = new System.Drawing.Point(23, 494);
            this.grbBuscarServProd.Name = "grbBuscarServProd";
            this.grbBuscarServProd.Size = new System.Drawing.Size(230, 83);
            this.grbBuscarServProd.TabIndex = 3;
            this.grbBuscarServProd.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbNombre
            // 
            this.gbNombre.Controls.Add(this.label2);
            this.gbNombre.Controls.Add(this.NombrePromocionControl);
            this.gbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNombre.Location = new System.Drawing.Point(23, 180);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(230, 151);
            this.gbNombre.TabIndex = 4;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar un nombre a la promocion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombrePromocionControl
            // 
            this.NombrePromocionControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePromocionControl.Location = new System.Drawing.Point(9, 22);
            this.NombrePromocionControl.Multiline = true;
            this.NombrePromocionControl.Name = "NombrePromocionControl";
            this.NombrePromocionControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NombrePromocionControl.Size = new System.Drawing.Size(195, 89);
            this.NombrePromocionControl.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(274, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(910, 600);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // FrmNuevaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelOpcines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNuevaPromocion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNuevaPromocion_Load);
            this.panelOpcines.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grServProd.ResumeLayout(false);
            this.grServProd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbTipoPromocion.ResumeLayout(false);
            this.grbBuscarServProd.ResumeLayout(false);
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpcines;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbTipoPromocion;
        private System.Windows.Forms.GroupBox grServProd;
        private System.Windows.Forms.ComboBox IdTipoPromocion;
        private System.Windows.Forms.Label DescripcionControl;
        private System.Windows.Forms.RadioButton rbServicio;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbBuscarServProd;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombrePromocionControl;
    }
}