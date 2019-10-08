namespace CIDFares.Spa.WFApplication.Forms.Citas
{
    partial class FrmCapturaCitaNuevo
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn21 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn22 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregarPaquete = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCita = new System.Windows.Forms.GroupBox();
            this.lblCitaOcupadaControl = new System.Windows.Forms.Label();
            this.IdHoraControl = new System.Windows.Forms.ComboBox();
            this.lblErrorControl = new System.Windows.Forms.Label();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblServicios = new System.Windows.Forms.Label();
            this.dgmServicio = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.NombreCompletoControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgmCita = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreCompletoControl)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1269, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nueva Cita";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.flowLayoutPanel1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 695);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1269, 67);
            this.pnlButtons.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarPaquete);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 44);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(4, 4);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Agregar cita";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregarPaquete
            // 
            this.btnAgregarPaquete.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPaquete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnAgregarPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnAgregarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgregarPaquete.Location = new System.Drawing.Point(176, 4);
            this.btnAgregarPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Size = new System.Drawing.Size(200, 36);
            this.btnAgregarPaquete.TabIndex = 3;
            this.btnAgregarPaquete.Text = "Agregar paquete";
            this.btnAgregarPaquete.UseVisualStyleBackColor = false;
            this.btnAgregarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(384, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(164, 36);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(556, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCita);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(783, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 606);
            this.panel1.TabIndex = 2;
            // 
            // gbCita
            // 
            this.gbCita.BackColor = System.Drawing.Color.White;
            this.gbCita.Controls.Add(this.lblCitaOcupadaControl);
            this.gbCita.Controls.Add(this.IdHoraControl);
            this.gbCita.Controls.Add(this.lblErrorControl);
            this.gbCita.Controls.Add(this.btnEliminarServicio);
            this.gbCita.Controls.Add(this.btnCancelar);
            this.gbCita.Controls.Add(this.lblServicios);
            this.gbCita.Controls.Add(this.dgmServicio);
            this.gbCita.Controls.Add(this.btnBuscarServicio);
            this.gbCita.Controls.Add(this.btnGuardar);
            this.gbCita.Controls.Add(this.btnBuscarCliente);
            this.gbCita.Controls.Add(this.NombreCompletoControl);
            this.gbCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCita.Enabled = false;
            this.gbCita.Location = new System.Drawing.Point(0, 0);
            this.gbCita.Name = "gbCita";
            this.gbCita.Size = new System.Drawing.Size(486, 606);
            this.gbCita.TabIndex = 12;
            this.gbCita.TabStop = false;
            // 
            // lblCitaOcupadaControl
            // 
            this.lblCitaOcupadaControl.AutoSize = true;
            this.lblCitaOcupadaControl.Location = new System.Drawing.Point(349, 91);
            this.lblCitaOcupadaControl.Name = "lblCitaOcupadaControl";
            this.lblCitaOcupadaControl.Size = new System.Drawing.Size(0, 17);
            this.lblCitaOcupadaControl.TabIndex = 35;
            // 
            // IdHoraControl
            // 
            this.IdHoraControl.FormattingEnabled = true;
            this.IdHoraControl.Location = new System.Drawing.Point(46, 91);
            this.IdHoraControl.Name = "IdHoraControl";
            this.IdHoraControl.Size = new System.Drawing.Size(278, 24);
            this.IdHoraControl.TabIndex = 34;
            this.IdHoraControl.SelectedValueChanged += new System.EventHandler(this.HorasControl_SelectedValueChanged);
            // 
            // lblErrorControl
            // 
            this.lblErrorControl.AutoSize = true;
            this.lblErrorControl.Location = new System.Drawing.Point(118, 153);
            this.lblErrorControl.Name = "lblErrorControl";
            this.lblErrorControl.Size = new System.Drawing.Size(0, 17);
            this.lblErrorControl.TabIndex = 29;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnEliminarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.eliminar;
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarServicio.Location = new System.Drawing.Point(327, 147);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(96, 32);
            this.btnEliminarServicio.TabIndex = 28;
            this.btnEliminarServicio.Text = " Elimnar Servicio";
            this.btnEliminarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(245, 418);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(23, 147);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(89, 24);
            this.lblServicios.TabIndex = 19;
            this.lblServicios.Text = "Servicios";
            // 
            // dgmServicio
            // 
            this.dgmServicio.AccessibleName = "Table";
            this.dgmServicio.AllowResizingColumns = true;
            this.dgmServicio.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowResizing = true;
            gridTextColumn13.HeaderText = "IdServicio";
            gridTextColumn13.MappingName = "OrdenServicio.Servicio.IdServicio";
            gridTextColumn13.Visible = false;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowMultiline = true;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "Servicio";
            gridTextColumn14.MappingName = "OrdenServicio.Servicio.Nombre";
            this.dgmServicio.Columns.Add(gridTextColumn13);
            this.dgmServicio.Columns.Add(gridTextColumn14);
            this.dgmServicio.Location = new System.Drawing.Point(27, 186);
            this.dgmServicio.Name = "dgmServicio";
            this.dgmServicio.Size = new System.Drawing.Size(428, 117);
            this.dgmServicio.TabIndex = 18;
            this.dgmServicio.Text = "sfDataGrid1";
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnBuscarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.mas_26px;
            this.btnBuscarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarServicio.Location = new System.Drawing.Point(142, 147);
            this.btnBuscarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(162, 32);
            this.btnBuscarServicio.TabIndex = 17;
            this.btnBuscarServicio.Text = "Servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(62, 418);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Cita";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(363, 34);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(113, 32);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "   Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // NombreCompletoControl
            // 
            this.NombreCompletoControl.BackColor = System.Drawing.Color.White;
            this.NombreCompletoControl.BeforeTouchSize = new System.Drawing.Size(300, 49);
            this.NombreCompletoControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.NombreCompletoControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreCompletoControl.Enabled = false;
            this.NombreCompletoControl.FocusBorderColor = System.Drawing.Color.Transparent;
            this.NombreCompletoControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompletoControl.Location = new System.Drawing.Point(18, 19);
            this.NombreCompletoControl.Metrocolor = System.Drawing.Color.Transparent;
            this.NombreCompletoControl.Multiline = true;
            this.NombreCompletoControl.Name = "NombreCompletoControl";
            this.NombreCompletoControl.Size = new System.Drawing.Size(300, 49);
            this.NombreCompletoControl.TabIndex = 12;
            this.NombreCompletoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgmCita);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 89);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(783, 606);
            this.pnlGrid.TabIndex = 3;
            // 
            // dgmCita
            // 
            this.dgmCita.AccessibleName = "Table";
            this.dgmCita.AllowEditing = false;
            this.dgmCita.AllowResizingColumns = true;
            this.dgmCita.AutoExpandGroups = true;
            this.dgmCita.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Cliente";
            gridTextColumn1.MappingName = "OrdenServicio.Cliente.NombreCompleto";
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Servicio";
            gridTextColumn2.MappingName = "OrdenServicio.Servicio.Nombre";
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowResizing = true;
            gridTextColumn15.Format = "HH:mm";
            gridTextColumn15.HeaderText = "Inicio";
            gridTextColumn15.MappingName = "FechaInicio";
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.AllowResizing = true;
            gridTextColumn16.Format = "HH:mm";
            gridTextColumn16.HeaderText = "Fin";
            gridTextColumn16.MappingName = "FechaFinal";
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.AllowResizing = true;
            gridTextColumn17.HeaderText = "IdOrdenPaquete";
            gridTextColumn17.MappingName = "OrdenServicio.OrdenPaquete.IdOrdenPaquete";
            gridTextColumn17.Visible = false;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.AllowResizing = true;
            gridTextColumn18.HeaderText = "IdAgendaCita";
            gridTextColumn18.MappingName = "IdAgendaCita";
            gridTextColumn18.Visible = false;
            gridTextColumn19.AllowEditing = false;
            gridTextColumn19.AllowResizing = true;
            gridTextColumn19.HeaderText = "IdOrdenServicio";
            gridTextColumn19.MappingName = "OrdenServicio.IdOrdenServicio";
            gridTextColumn19.Visible = false;
            gridTextColumn20.AllowEditing = false;
            gridTextColumn20.AllowResizing = true;
            gridTextColumn20.HeaderText = "IdCliente";
            gridTextColumn20.MappingName = "OrdenServicio.Cliente.IdCliente";
            gridTextColumn20.Visible = false;
            gridTextColumn21.AllowEditing = false;
            gridTextColumn21.AllowResizing = true;
            gridTextColumn21.HeaderText = "IdServicio";
            gridTextColumn21.MappingName = "OrdenServicio.Servicio.IdServicio";
            gridTextColumn21.Visible = false;
            gridTextColumn22.AllowEditing = false;
            gridTextColumn22.AllowResizing = true;
            gridTextColumn22.HeaderText = "Paquete";
            gridTextColumn22.MappingName = "OrdenServicio.OrdenPaquete.Paquete.Nombre";
            this.dgmCita.Columns.Add(gridTextColumn1);
            this.dgmCita.Columns.Add(gridTextColumn2);
            this.dgmCita.Columns.Add(gridTextColumn15);
            this.dgmCita.Columns.Add(gridTextColumn16);
            this.dgmCita.Columns.Add(gridTextColumn17);
            this.dgmCita.Columns.Add(gridTextColumn18);
            this.dgmCita.Columns.Add(gridTextColumn19);
            this.dgmCita.Columns.Add(gridTextColumn20);
            this.dgmCita.Columns.Add(gridTextColumn21);
            this.dgmCita.Columns.Add(gridTextColumn22);
            this.dgmCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgmCita.Location = new System.Drawing.Point(0, 0);
            this.dgmCita.Name = "dgmCita";
            this.dgmCita.Size = new System.Drawing.Size(783, 606);
            this.dgmCita.TabIndex = 0;
            this.dgmCita.Text = "sfDataGrid1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCapturaCitaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 762);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(1287, 809);
            this.Name = "FrmCapturaCitaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapturaCitaNuevo";
            this.Load += new System.EventHandler(this.FrmCapturaCitaNuevo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbCita.ResumeLayout(false);
            this.gbCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreCompletoControl)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmCita;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbCita;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NombreCompletoControl;
        private System.Windows.Forms.Label lblServicios;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorControl;
        private System.Windows.Forms.ComboBox IdHoraControl;
        private System.Windows.Forms.Label lblCitaOcupadaControl;
        private System.Windows.Forms.Button btnAgregarPaquete;
    }
}