namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmCliente
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelGridDatos = new System.Windows.Forms.Panel();
            this.sfDataGridCliente = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.PanelCapturaDatos = new System.Windows.Forms.Panel();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.ClaveControl = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SexoControl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.DireccionControl = new System.Windows.Forms.TextBox();
            this.PnlFoto = new System.Windows.Forms.Panel();
            this.RutaControl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaNachimientoControl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonoControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RfcControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCompletoControl = new System.Windows.Forms.TextBox();
            this.PabelBTN = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FotoControl = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panelGridDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridCliente)).BeginInit();
            this.PanelCapturaDatos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SexoControl)).BeginInit();
            this.PnlFoto.SuspendLayout();
            this.PabelBTN.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoControl)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelContenedor);
            this.PanelPrincipal.Controls.Add(this.PanelTitulo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1154, 627);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.panelGridDatos);
            this.PanelContenedor.Controls.Add(this.PabelBTN);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 49);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1154, 578);
            this.PanelContenedor.TabIndex = 1;
            // 
            // panelGridDatos
            // 
            this.panelGridDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelGridDatos.Controls.Add(this.sfDataGridCliente);
            this.panelGridDatos.Controls.Add(this.PanelCapturaDatos);
            this.panelGridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridDatos.Location = new System.Drawing.Point(0, 0);
            this.panelGridDatos.Name = "panelGridDatos";
            this.panelGridDatos.Size = new System.Drawing.Size(1154, 531);
            this.panelGridDatos.TabIndex = 1;
            // 
            // sfDataGridCliente
            // 
            this.sfDataGridCliente.AccessibleName = "Table";
            this.sfDataGridCliente.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn7.HeaderText = "IdCliente";
            gridTextColumn7.MappingName = "IdCliente";
            gridTextColumn7.Visible = false;
            gridTextColumn8.HeaderText = "Clave";
            gridTextColumn8.MappingName = "Clave";
            gridTextColumn9.HeaderText = "Nombre";
            gridTextColumn9.MappingName = "NombreCompleto";
            gridTextColumn10.HeaderText = "Teléfono";
            gridTextColumn10.MappingName = "Telefono";
            gridTextColumn11.HeaderText = "Edad";
            gridTextColumn11.MappingName = "Edad";
            gridTextColumn12.HeaderText = "Genero";
            gridTextColumn12.MappingName = "Sexo";
            this.sfDataGridCliente.Columns.Add(gridTextColumn7);
            this.sfDataGridCliente.Columns.Add(gridTextColumn8);
            this.sfDataGridCliente.Columns.Add(gridTextColumn9);
            this.sfDataGridCliente.Columns.Add(gridTextColumn10);
            this.sfDataGridCliente.Columns.Add(gridTextColumn11);
            this.sfDataGridCliente.Columns.Add(gridTextColumn12);
            this.sfDataGridCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridCliente.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridCliente.Name = "sfDataGridCliente";
            this.sfDataGridCliente.Size = new System.Drawing.Size(764, 531);
            this.sfDataGridCliente.TabIndex = 1;
            this.sfDataGridCliente.Text = "sfDataGrid1";
            // 
            // PanelCapturaDatos
            // 
            this.PanelCapturaDatos.Controls.Add(this.groupBoxCliente);
            this.PanelCapturaDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelCapturaDatos.Location = new System.Drawing.Point(764, 0);
            this.PanelCapturaDatos.Name = "PanelCapturaDatos";
            this.PanelCapturaDatos.Size = new System.Drawing.Size(390, 531);
            this.PanelCapturaDatos.TabIndex = 0;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxCliente.Controls.Add(this.ClaveControl);
            this.groupBoxCliente.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxCliente.Controls.Add(this.label8);
            this.groupBoxCliente.Controls.Add(this.SexoControl);
            this.groupBoxCliente.Controls.Add(this.label6);
            this.groupBoxCliente.Controls.Add(this.DireccionControl);
            this.groupBoxCliente.Controls.Add(this.PnlFoto);
            this.groupBoxCliente.Controls.Add(this.label5);
            this.groupBoxCliente.Controls.Add(this.FechaNachimientoControl);
            this.groupBoxCliente.Controls.Add(this.label4);
            this.groupBoxCliente.Controls.Add(this.TelefonoControl);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.RfcControl);
            this.groupBoxCliente.Controls.Add(this.label1);
            this.groupBoxCliente.Controls.Add(this.NombreCompletoControl);
            this.groupBoxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBoxCliente.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCliente.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(390, 531);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Datos de cliente";
            // 
            // ClaveControl
            // 
            this.ClaveControl.Location = new System.Drawing.Point(238, 12);
            this.ClaveControl.Name = "ClaveControl";
            this.ClaveControl.ReadOnly = true;
            this.ClaveControl.Size = new System.Drawing.Size(135, 27);
            this.ClaveControl.TabIndex = 53;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 491);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 34);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(132, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(29, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Sexo";
            // 
            // SexoControl
            // 
            this.SexoControl.BackColor = System.Drawing.Color.White;
            this.SexoControl.BeforeTouchSize = new System.Drawing.Size(355, 29);
            this.SexoControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.SexoControl.FlatBorderColor = System.Drawing.Color.BurlyWood;
            this.SexoControl.Location = new System.Drawing.Point(22, 319);
            this.SexoControl.MetroBorderColor = System.Drawing.Color.Black;
            this.SexoControl.Name = "SexoControl";
            this.SexoControl.Size = new System.Drawing.Size(355, 29);
            this.SexoControl.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.SexoControl.TabIndex = 50;
            this.SexoControl.Text = "comboBoxAdv1";
            this.SexoControl.ThemeName = "Metro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Dirección";
            // 
            // DireccionControl
            // 
            this.DireccionControl.Location = new System.Drawing.Point(22, 267);
            this.DireccionControl.Name = "DireccionControl";
            this.DireccionControl.Size = new System.Drawing.Size(355, 27);
            this.DireccionControl.TabIndex = 48;
            // 
            // PnlFoto
            // 
            this.PnlFoto.Controls.Add(this.RutaControl);
            this.PnlFoto.Controls.Add(this.label7);
            this.PnlFoto.Controls.Add(this.BtnSeleccionar);
            this.PnlFoto.Controls.Add(this.FotoControl);
            this.PnlFoto.Location = new System.Drawing.Point(19, 363);
            this.PnlFoto.Name = "PnlFoto";
            this.PnlFoto.Size = new System.Drawing.Size(355, 110);
            this.PnlFoto.TabIndex = 47;
            // 
            // RutaControl
            // 
            this.RutaControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutaControl.Location = new System.Drawing.Point(6, 60);
            this.RutaControl.Multiline = true;
            this.RutaControl.Name = "RutaControl";
            this.RutaControl.Size = new System.Drawing.Size(207, 47);
            this.RutaControl.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 40;
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
            this.BtnSeleccionar.Location = new System.Drawing.Point(14, 26);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(182, 28);
            this.BtnSeleccionar.TabIndex = 14;
            this.BtnSeleccionar.Text = "SUBIR";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha nacimiento";
            // 
            // FechaNachimientoControl
            // 
            this.FechaNachimientoControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNachimientoControl.Location = new System.Drawing.Point(19, 213);
            this.FechaNachimientoControl.Name = "FechaNachimientoControl";
            this.FechaNachimientoControl.Size = new System.Drawing.Size(355, 27);
            this.FechaNachimientoControl.TabIndex = 9;
            this.FechaNachimientoControl.Value = new System.DateTime(2019, 8, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono";
            // 
            // TelefonoControl
            // 
            this.TelefonoControl.Location = new System.Drawing.Point(19, 158);
            this.TelefonoControl.Name = "TelefonoControl";
            this.TelefonoControl.Size = new System.Drawing.Size(355, 27);
            this.TelefonoControl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rfc";
            // 
            // RfcControl
            // 
            this.RfcControl.Location = new System.Drawing.Point(19, 105);
            this.RfcControl.Name = "RfcControl";
            this.RfcControl.Size = new System.Drawing.Size(355, 27);
            this.RfcControl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre completo";
            // 
            // NombreCompletoControl
            // 
            this.NombreCompletoControl.Location = new System.Drawing.Point(19, 51);
            this.NombreCompletoControl.Name = "NombreCompletoControl";
            this.NombreCompletoControl.Size = new System.Drawing.Size(355, 27);
            this.NombreCompletoControl.TabIndex = 3;
            // 
            // PabelBTN
            // 
            this.PabelBTN.Controls.Add(this.flowLayoutPanel2);
            this.PabelBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PabelBTN.Location = new System.Drawing.Point(0, 531);
            this.PabelBTN.Name = "PabelBTN";
            this.PabelBTN.Size = new System.Drawing.Size(1154, 47);
            this.PabelBTN.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
            this.flowLayoutPanel2.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(761, 38);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.label3);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1154, 49);
            this.PanelTitulo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // FotoControl
            // 
            this.FotoControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoControl.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.imagen_subir;
            this.FotoControl.Location = new System.Drawing.Point(219, 4);
            this.FotoControl.Name = "FotoControl";
            this.FotoControl.Size = new System.Drawing.Size(129, 103);
            this.FotoControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoControl.TabIndex = 0;
            this.FotoControl.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 627);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.panelGridDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridCliente)).EndInit();
            this.PanelCapturaDatos.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SexoControl)).EndInit();
            this.PnlFoto.ResumeLayout(false);
            this.PnlFoto.PerformLayout();
            this.PabelBTN.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel panelGridDatos;
        private System.Windows.Forms.Panel PabelBTN;
        private System.Windows.Forms.Panel PanelCapturaDatos;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCompletoControl;
        private System.Windows.Forms.Panel PnlFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.PictureBox FotoControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaNachimientoControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonoControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RfcControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DireccionControl;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv SexoControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox RutaControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox ClaveControl;
    }
}