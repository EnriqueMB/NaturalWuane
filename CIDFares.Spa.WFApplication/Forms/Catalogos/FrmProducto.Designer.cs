namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmProducto
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CategoriaControl = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ClaveControl = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.StockMinControl = new System.Windows.Forms.TextBox();
            this.StockMaxControl = new System.Windows.Forms.TextBox();
            this.lblStockMax = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPrecioMayoreo = new System.Windows.Forms.Label();
            this.PrecioMayoreoControl = new System.Windows.Forms.TextBox();
            this.pnlPrecio = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.FotoControl = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.DescripcionControl = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PrecioMenudeoControl = new System.Windows.Forms.TextBox();
            this.lblPrecioMenudeo = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.UnidadMedidaControl = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PrecioPublicoControl = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.AplicaIvaControl = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.StockControl = new System.Windows.Forms.CheckBox();
            this.ClaveSat = new System.Windows.Forms.Panel();
            this.ClaveSatControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoBarrasControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarCodigoBarras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlPrecio.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoControl)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            this.ClaveSat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubtitle);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.Location = new System.Drawing.Point(27, 34);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(102, 15);
            this.lblSubtitle.TabIndex = 182;
            this.lblSubtitle.Text = "NUEVO REGISTRO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 181;
            this.lblTitulo.Text = "INGRESAR PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 75);
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
            this.btnGuardar.Location = new System.Drawing.Point(842, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 28);
            this.btnGuardar.TabIndex = 7;
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
            this.btnCancelar.Location = new System.Drawing.Point(987, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 315);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrecio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ClaveSat, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.53398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.94498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NombreControl);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 51);
            this.panel4.TabIndex = 0;
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(6, 22);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(268, 20);
            this.NombreControl.TabIndex = 41;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "NOMBRE";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CategoriaControl);
            this.panel5.Controls.Add(this.lblCategoria);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 41);
            this.panel5.TabIndex = 1;
            // 
            // CategoriaControl
            // 
            this.CategoriaControl.FormattingEnabled = true;
            this.CategoriaControl.Location = new System.Drawing.Point(6, 13);
            this.CategoriaControl.Name = "CategoriaControl";
            this.CategoriaControl.Size = new System.Drawing.Size(268, 21);
            this.CategoriaControl.TabIndex = 42;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(3, -3);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 41;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ClaveControl);
            this.panel7.Controls.Add(this.Clave);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 46);
            this.panel7.TabIndex = 3;
            // 
            // ClaveControl
            // 
            this.ClaveControl.Location = new System.Drawing.Point(7, 20);
            this.ClaveControl.Name = "ClaveControl";
            this.ClaveControl.Size = new System.Drawing.Size(268, 20);
            this.ClaveControl.TabIndex = 53;
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(6, 0);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(44, 17);
            this.Clave.TabIndex = 52;
            this.Clave.Text = "CLAVE";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.StockMinControl);
            this.panel9.Controls.Add(this.StockMaxControl);
            this.panel9.Controls.Add(this.lblStockMax);
            this.panel9.Controls.Add(this.lblStockMin);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 263);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(396, 49);
            this.panel9.TabIndex = 5;
            // 
            // StockMinControl
            // 
            this.StockMinControl.Location = new System.Drawing.Point(215, 25);
            this.StockMinControl.Name = "StockMinControl";
            this.StockMinControl.Size = new System.Drawing.Size(156, 20);
            this.StockMinControl.TabIndex = 45;
            // 
            // StockMaxControl
            // 
            this.StockMaxControl.Location = new System.Drawing.Point(7, 25);
            this.StockMaxControl.Name = "StockMaxControl";
            this.StockMaxControl.Size = new System.Drawing.Size(160, 20);
            this.StockMaxControl.TabIndex = 44;
            // 
            // lblStockMax
            // 
            this.lblStockMax.AutoSize = true;
            this.lblStockMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMax.Location = new System.Drawing.Point(9, 6);
            this.lblStockMax.Name = "lblStockMax";
            this.lblStockMax.Size = new System.Drawing.Size(104, 17);
            this.lblStockMax.TabIndex = 43;
            this.lblStockMax.Text = "STOCK MAXIMO";
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMin.Location = new System.Drawing.Point(215, 6);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(101, 17);
            this.lblStockMin.TabIndex = 42;
            this.lblStockMin.Text = "STOCK MINIMO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPrecioMayoreo
            // 
            this.lblPrecioMayoreo.AutoSize = true;
            this.lblPrecioMayoreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayoreo.Location = new System.Drawing.Point(4, 4);
            this.lblPrecioMayoreo.Name = "lblPrecioMayoreo";
            this.lblPrecioMayoreo.Size = new System.Drawing.Size(115, 17);
            this.lblPrecioMayoreo.TabIndex = 48;
            this.lblPrecioMayoreo.Text = "PRECIO MAYOREO";
            // 
            // PrecioMayoreoControl
            // 
            this.PrecioMayoreoControl.Location = new System.Drawing.Point(7, 24);
            this.PrecioMayoreoControl.Name = "PrecioMayoreoControl";
            this.PrecioMayoreoControl.Size = new System.Drawing.Size(268, 20);
            this.PrecioMayoreoControl.TabIndex = 49;
            // 
            // pnlPrecio
            // 
            this.pnlPrecio.Controls.Add(this.PrecioMayoreoControl);
            this.pnlPrecio.Controls.Add(this.lblPrecioMayoreo);
            this.pnlPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrecio.Location = new System.Drawing.Point(405, 107);
            this.pnlPrecio.Name = "pnlPrecio";
            this.pnlPrecio.Size = new System.Drawing.Size(396, 46);
            this.pnlPrecio.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnGenerarCodigoBarras);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.CodigoBarrasControl);
            this.panel13.Location = new System.Drawing.Point(807, 159);
            this.panel13.Name = "panel13";
            this.tableLayoutPanel1.SetRowSpan(this.panel13, 3);
            this.panel13.Size = new System.Drawing.Size(319, 153);
            this.panel13.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.BtnSeleccionar);
            this.panel12.Controls.Add(this.FotoControl);
            this.panel12.Location = new System.Drawing.Point(807, 3);
            this.panel12.Name = "panel12";
            this.tableLayoutPanel1.SetRowSpan(this.panel12, 3);
            this.panel12.Size = new System.Drawing.Size(319, 150);
            this.panel12.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "SELECCIONAR IMAGEN";
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
            this.BtnSeleccionar.Location = new System.Drawing.Point(9, 93);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(130, 28);
            this.BtnSeleccionar.TabIndex = 43;
            this.BtnSeleccionar.Text = "SUBIR";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // FotoControl
            // 
            this.FotoControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoControl.Location = new System.Drawing.Point(159, 6);
            this.FotoControl.Name = "FotoControl";
            this.FotoControl.Size = new System.Drawing.Size(145, 124);
            this.FotoControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoControl.TabIndex = 42;
            this.FotoControl.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.DescripcionControl);
            this.panel11.Controls.Add(this.Descripcion);
            this.panel11.Location = new System.Drawing.Point(405, 211);
            this.panel11.Name = "panel11";
            this.tableLayoutPanel1.SetRowSpan(this.panel11, 2);
            this.panel11.Size = new System.Drawing.Size(396, 98);
            this.panel11.TabIndex = 12;
            // 
            // DescripcionControl
            // 
            this.DescripcionControl.Location = new System.Drawing.Point(7, 29);
            this.DescripcionControl.Multiline = true;
            this.DescripcionControl.Name = "DescripcionControl";
            this.DescripcionControl.Size = new System.Drawing.Size(378, 67);
            this.DescripcionControl.TabIndex = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(4, 9);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(88, 17);
            this.Descripcion.TabIndex = 41;
            this.Descripcion.Text = "DESCRIPCION";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.PrecioMenudeoControl);
            this.panel10.Controls.Add(this.lblPrecioMenudeo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(405, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(396, 41);
            this.panel10.TabIndex = 14;
            // 
            // PrecioMenudeoControl
            // 
            this.PrecioMenudeoControl.Location = new System.Drawing.Point(7, 19);
            this.PrecioMenudeoControl.Name = "PrecioMenudeoControl";
            this.PrecioMenudeoControl.Size = new System.Drawing.Size(268, 20);
            this.PrecioMenudeoControl.TabIndex = 51;
            // 
            // lblPrecioMenudeo
            // 
            this.lblPrecioMenudeo.AutoSize = true;
            this.lblPrecioMenudeo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMenudeo.Location = new System.Drawing.Point(4, 0);
            this.lblPrecioMenudeo.Name = "lblPrecioMenudeo";
            this.lblPrecioMenudeo.Size = new System.Drawing.Size(119, 17);
            this.lblPrecioMenudeo.TabIndex = 50;
            this.lblPrecioMenudeo.Text = "PRECIO MENUDEO";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(5, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(128, 17);
            this.lblUnidadMedida.TabIndex = 44;
            this.lblUnidadMedida.Text = "UNIDAD DE MEDIDA";
            // 
            // UnidadMedidaControl
            // 
            this.UnidadMedidaControl.FormattingEnabled = true;
            this.UnidadMedidaControl.Location = new System.Drawing.Point(6, 19);
            this.UnidadMedidaControl.Name = "UnidadMedidaControl";
            this.UnidadMedidaControl.Size = new System.Drawing.Size(268, 21);
            this.UnidadMedidaControl.TabIndex = 43;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.UnidadMedidaControl);
            this.panel6.Controls.Add(this.lblUnidadMedida);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(396, 46);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.PrecioPublicoControl);
            this.panel8.Controls.Add(this.lblPrecio);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(405, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 51);
            this.panel8.TabIndex = 15;
            // 
            // PrecioPublicoControl
            // 
            this.PrecioPublicoControl.Location = new System.Drawing.Point(7, 20);
            this.PrecioPublicoControl.Name = "PrecioPublicoControl";
            this.PrecioPublicoControl.Size = new System.Drawing.Size(268, 20);
            this.PrecioPublicoControl.TabIndex = 51;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 17);
            this.lblPrecio.TabIndex = 50;
            this.lblPrecio.Text = "PRECIO PUBLICO";
            // 
            // AplicaIvaControl
            // 
            this.AplicaIvaControl.AutoSize = true;
            this.AplicaIvaControl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AplicaIvaControl.Location = new System.Drawing.Point(25, 14);
            this.AplicaIvaControl.Name = "AplicaIvaControl";
            this.AplicaIvaControl.Size = new System.Drawing.Size(89, 21);
            this.AplicaIvaControl.TabIndex = 46;
            this.AplicaIvaControl.Text = "APLICA IVA";
            this.AplicaIvaControl.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.StockControl);
            this.panel14.Controls.Add(this.AplicaIvaControl);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 211);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(396, 46);
            this.panel14.TabIndex = 16;
            // 
            // StockControl
            // 
            this.StockControl.AutoSize = true;
            this.StockControl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.StockControl.Location = new System.Drawing.Point(221, 13);
            this.StockControl.Name = "StockControl";
            this.StockControl.Size = new System.Drawing.Size(66, 21);
            this.StockControl.TabIndex = 48;
            this.StockControl.Text = "STOCK";
            this.StockControl.UseVisualStyleBackColor = true;
            // 
            // ClaveSat
            // 
            this.ClaveSat.Controls.Add(this.ClaveSatControl);
            this.ClaveSat.Controls.Add(this.label1);
            this.ClaveSat.Location = new System.Drawing.Point(405, 159);
            this.ClaveSat.Name = "ClaveSat";
            this.ClaveSat.Size = new System.Drawing.Size(396, 46);
            this.ClaveSat.TabIndex = 17;
            // 
            // ClaveSatControl
            // 
            this.ClaveSatControl.Location = new System.Drawing.Point(7, 20);
            this.ClaveSatControl.Name = "ClaveSatControl";
            this.ClaveSatControl.Size = new System.Drawing.Size(268, 20);
            this.ClaveSatControl.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "CLAVE SAT";
            // 
            // CodigoBarrasControl
            // 
            this.CodigoBarrasControl.Location = new System.Drawing.Point(18, 52);
            this.CodigoBarrasControl.Name = "CodigoBarrasControl";
            this.CodigoBarrasControl.Size = new System.Drawing.Size(291, 20);
            this.CodigoBarrasControl.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "CODIGO DE BARRAS";
            // 
            // btnGenerarCodigoBarras
            // 
            this.btnGenerarCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnGenerarCodigoBarras.FlatAppearance.BorderSize = 0;
            this.btnGenerarCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarCodigoBarras.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCodigoBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCodigoBarras.Location = new System.Drawing.Point(62, 99);
            this.btnGenerarCodigoBarras.Name = "btnGenerarCodigoBarras";
            this.btnGenerarCodigoBarras.Size = new System.Drawing.Size(199, 28);
            this.btnGenerarCodigoBarras.TabIndex = 52;
            this.btnGenerarCodigoBarras.Text = "GENERAR CODIGO DE BARRAS";
            this.btnGenerarCodigoBarras.UseVisualStyleBackColor = false;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlPrecio.ResumeLayout(false);
            this.pnlPrecio.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoControl)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ClaveSat.ResumeLayout(false);
            this.ClaveSat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox CategoriaControl;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox StockMinControl;
        private System.Windows.Forms.TextBox StockMaxControl;
        private System.Windows.Forms.Label lblStockMax;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ClaveControl;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox PrecioPublicoControl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox PrecioMenudeoControl;
        private System.Windows.Forms.Label lblPrecioMenudeo;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.PictureBox FotoControl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox UnidadMedidaControl;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnGenerarCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoBarrasControl;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox DescripcionControl;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Panel pnlPrecio;
        private System.Windows.Forms.TextBox PrecioMayoreoControl;
        private System.Windows.Forms.Label lblPrecioMayoreo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.CheckBox StockControl;
        private System.Windows.Forms.CheckBox AplicaIvaControl;
        private System.Windows.Forms.Panel ClaveSat;
        private System.Windows.Forms.TextBox ClaveSatControl;
        private System.Windows.Forms.Label label1;
    }
}