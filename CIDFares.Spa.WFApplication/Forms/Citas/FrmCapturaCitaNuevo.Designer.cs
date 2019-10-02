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
            this.HorasControl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HoraCitaControl = new System.Windows.Forms.DateTimePicker();
            this.FechaCitaControl = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblErrorControl = new System.Windows.Forms.Label();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblServicios = new System.Windows.Forms.Label();
            this.dgmServicio = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.ClienteControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgmCita = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteControl)).BeginInit();
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
            this.btnModificar.Text = "Ver";
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
            this.gbCita.Controls.Add(this.HorasControl);
            this.gbCita.Controls.Add(this.label1);
            this.gbCita.Controls.Add(this.HoraCitaControl);
            this.gbCita.Controls.Add(this.FechaCitaControl);
            this.gbCita.Controls.Add(this.dtpFechaFinal);
            this.gbCita.Controls.Add(this.lblErrorControl);
            this.gbCita.Controls.Add(this.btnEliminarServicio);
            this.gbCita.Controls.Add(this.label2);
            this.gbCita.Controls.Add(this.btnCancelar);
            this.gbCita.Controls.Add(this.lblServicios);
            this.gbCita.Controls.Add(this.dgmServicio);
            this.gbCita.Controls.Add(this.btnBuscarServicio);
            this.gbCita.Controls.Add(this.btnGuardar);
            this.gbCita.Controls.Add(this.btnBuscarCliente);
            this.gbCita.Controls.Add(this.ClienteControl);
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
            this.lblCitaOcupadaControl.Location = new System.Drawing.Point(350, 98);
            this.lblCitaOcupadaControl.Name = "lblCitaOcupadaControl";
            this.lblCitaOcupadaControl.Size = new System.Drawing.Size(0, 17);
            this.lblCitaOcupadaControl.TabIndex = 35;
            // 
            // HorasControl
            // 
            this.HorasControl.FormattingEnabled = true;
            this.HorasControl.Location = new System.Drawing.Point(46, 91);
            this.HorasControl.Name = "HorasControl";
            this.HorasControl.Size = new System.Drawing.Size(278, 24);
            this.HorasControl.TabIndex = 34;
            this.HorasControl.SelectedValueChanged += new System.EventHandler(this.HorasControl_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Inicio";
            this.label1.Visible = false;
            // 
            // HoraCitaControl
            // 
            this.HoraCitaControl.CustomFormat = "HH:mm";
            this.HoraCitaControl.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraCitaControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraCitaControl.Location = new System.Drawing.Point(56, 509);
            this.HoraCitaControl.Name = "HoraCitaControl";
            this.HoraCitaControl.ShowUpDown = true;
            this.HoraCitaControl.Size = new System.Drawing.Size(93, 28);
            this.HoraCitaControl.TabIndex = 32;
            this.HoraCitaControl.Visible = false;
            // 
            // FechaCitaControl
            // 
            this.FechaCitaControl.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCitaControl.Location = new System.Drawing.Point(174, 509);
            this.FechaCitaControl.Name = "FechaCitaControl";
            this.FechaCitaControl.Size = new System.Drawing.Size(250, 28);
            this.FechaCitaControl.TabIndex = 31;
            this.FechaCitaControl.Visible = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd MMMM yyyy, HH:mm tt";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(41, 374);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(368, 28);
            this.dtpFechaFinal.TabIndex = 30;
            this.dtpFechaFinal.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fin";
            this.label2.Visible = false;
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
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "IdServicio";
            gridTextColumn1.MappingName = "OrdenServicio.Servicio.IdServicio";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowMultiline = true;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Servicio";
            gridTextColumn2.MappingName = "OrdenServicio.Servicio.Nombre";
            this.dgmServicio.Columns.Add(gridTextColumn1);
            this.dgmServicio.Columns.Add(gridTextColumn2);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(353, 36);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(113, 32);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "   Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // ClienteControl
            // 
            this.ClienteControl.BackColor = System.Drawing.Color.White;
            this.ClienteControl.BeforeTouchSize = new System.Drawing.Size(300, 49);
            this.ClienteControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.ClienteControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClienteControl.Enabled = false;
            this.ClienteControl.FocusBorderColor = System.Drawing.Color.Transparent;
            this.ClienteControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteControl.Location = new System.Drawing.Point(41, 19);
            this.ClienteControl.Metrocolor = System.Drawing.Color.Transparent;
            this.ClienteControl.Multiline = true;
            this.ClienteControl.Name = "ClienteControl";
            this.ClienteControl.Size = new System.Drawing.Size(300, 49);
            this.ClienteControl.TabIndex = 12;
            this.ClienteControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Cliente";
            gridTextColumn3.MappingName = "OrdenServicio.Cliente.NombreCompleto";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Servicio";
            gridTextColumn4.MappingName = "OrdenServicio.Servicio.Nombre";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.Format = "hh:mm";
            gridTextColumn5.HeaderText = "Inicio";
            gridTextColumn5.MappingName = "FechaInicio";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.Format = "hh:mm";
            gridTextColumn6.HeaderText = "Fin";
            gridTextColumn6.MappingName = "FechaFinal";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "IdOrdenPaquete";
            gridTextColumn7.MappingName = "OrdenServicio.OrdenPaquete.IdOrdenPaquete";
            gridTextColumn7.Visible = false;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "IdAgendaCita";
            gridTextColumn8.MappingName = "IdAgendaCita";
            gridTextColumn8.Visible = false;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "IdOrdenServicio";
            gridTextColumn9.MappingName = "OrdenServicio.IdOrdenServicio";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "IdCliente";
            gridTextColumn10.MappingName = "OrdenServicio.Cliente.IdCliente";
            gridTextColumn10.Visible = false;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "IdServicio";
            gridTextColumn11.MappingName = "OrdenServicio.Servicio.IdServicio";
            gridTextColumn11.Visible = false;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Paquete";
            gridTextColumn12.MappingName = "OrdenServicio.OrdenPaquete.Paquete.Nombre";
            this.dgmCita.Columns.Add(gridTextColumn3);
            this.dgmCita.Columns.Add(gridTextColumn4);
            this.dgmCita.Columns.Add(gridTextColumn5);
            this.dgmCita.Columns.Add(gridTextColumn6);
            this.dgmCita.Columns.Add(gridTextColumn7);
            this.dgmCita.Columns.Add(gridTextColumn8);
            this.dgmCita.Columns.Add(gridTextColumn9);
            this.dgmCita.Columns.Add(gridTextColumn10);
            this.dgmCita.Columns.Add(gridTextColumn11);
            this.dgmCita.Columns.Add(gridTextColumn12);
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
            ((System.ComponentModel.ISupportInitialize)(this.ClienteControl)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ClienteControl;
        private System.Windows.Forms.Label lblServicios;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorControl;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.ComboBox HorasControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HoraCitaControl;
        private System.Windows.Forms.DateTimePicker FechaCitaControl;
        private System.Windows.Forms.Label lblCitaOcupadaControl;
        private System.Windows.Forms.Button btnAgregarPaquete;
    }
}