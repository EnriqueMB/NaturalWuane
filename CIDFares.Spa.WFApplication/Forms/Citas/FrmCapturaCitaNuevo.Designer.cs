﻿namespace CIDFares.Spa.WFApplication.Forms.Citas
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCita = new System.Windows.Forms.GroupBox();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblServicios = new System.Windows.Forms.Label();
            this.dgmServicio = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.HoraCitaControl = new System.Windows.Forms.DateTimePicker();
            this.FechaCitaControl = new System.Windows.Forms.DateTimePicker();
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
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 39);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(4, 4);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Agregar cita";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(176, 4);
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
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(348, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCita);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(601, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 606);
            this.panel1.TabIndex = 2;
            // 
            // gbCita
            // 
            this.gbCita.BackColor = System.Drawing.Color.White;
            this.gbCita.Controls.Add(this.btnEliminarServicio);
            this.gbCita.Controls.Add(this.label2);
            this.gbCita.Controls.Add(this.dtpFechafin);
            this.gbCita.Controls.Add(this.dtpFechaFinal);
            this.gbCita.Controls.Add(this.label1);
            this.gbCita.Controls.Add(this.btnCancelar);
            this.gbCita.Controls.Add(this.lblServicios);
            this.gbCita.Controls.Add(this.dgmServicio);
            this.gbCita.Controls.Add(this.btnBuscarServicio);
            this.gbCita.Controls.Add(this.btnGuardar);
            this.gbCita.Controls.Add(this.HoraCitaControl);
            this.gbCita.Controls.Add(this.FechaCitaControl);
            this.gbCita.Controls.Add(this.btnBuscarCliente);
            this.gbCita.Controls.Add(this.ClienteControl);
            this.gbCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCita.Enabled = false;
            this.gbCita.Location = new System.Drawing.Point(0, 0);
            this.gbCita.Name = "gbCita";
            this.gbCita.Size = new System.Drawing.Size(668, 606);
            this.gbCita.TabIndex = 12;
            this.gbCita.TabStop = false;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.eliminar;
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarServicio.Location = new System.Drawing.Point(493, 147);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(162, 32);
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
            this.label2.Location = new System.Drawing.Point(25, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fin";
            // 
            // dtpFechafin
            // 
            this.dtpFechafin.CustomFormat = "HH:mm";
            this.dtpFechafin.Enabled = false;
            this.dtpFechafin.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechafin.Location = new System.Drawing.Point(323, 496);
            this.dtpFechafin.Name = "dtpFechafin";
            this.dtpFechafin.ShowUpDown = true;
            this.dtpFechafin.Size = new System.Drawing.Size(70, 28);
            this.dtpFechafin.TabIndex = 26;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Location = new System.Drawing.Point(18, 496);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(269, 28);
            this.dtpFechaFinal.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inicio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(345, 547);
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
            this.dgmServicio.AllowEditing = false;
            this.dgmServicio.AllowResizingColumns = true;
            this.dgmServicio.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "IdServicio";
            gridTextColumn9.MappingName = "IdServicio";
            gridTextColumn9.Visible = false;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowMultiline = true;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "Servicio";
            gridTextColumn10.MappingName = "Servicio";
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.Format = "HH:mm";
            gridTextColumn11.HeaderText = "Inicio";
            gridTextColumn11.MappingName = "FechaIServicio";
            gridTextColumn11.MaximumWidth = 110D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.Format = "HH:mm";
            gridTextColumn12.HeaderText = "Fin";
            gridTextColumn12.MappingName = "FechaFServicio";
            gridTextColumn12.MaximumWidth = 110D;
            this.dgmServicio.Columns.Add(gridTextColumn9);
            this.dgmServicio.Columns.Add(gridTextColumn10);
            this.dgmServicio.Columns.Add(gridTextColumn11);
            this.dgmServicio.Columns.Add(gridTextColumn12);
            this.dgmServicio.Location = new System.Drawing.Point(16, 193);
            this.dgmServicio.Name = "dgmServicio";
            this.dgmServicio.Size = new System.Drawing.Size(641, 260);
            this.dgmServicio.TabIndex = 18;
            this.dgmServicio.Text = "sfDataGrid1";
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarServicio.FlatAppearance.BorderSize = 0;
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.btnBuscarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarServicio.Location = new System.Drawing.Point(304, 147);
            this.btnBuscarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(162, 32);
            this.btnBuscarServicio.TabIndex = 17;
            this.btnBuscarServicio.Text = "Agregar Servicio";
            this.btnBuscarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(159, 547);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Cita";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // HoraCitaControl
            // 
            this.HoraCitaControl.CustomFormat = "HH:mm";
            this.HoraCitaControl.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraCitaControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraCitaControl.Location = new System.Drawing.Point(323, 109);
            this.HoraCitaControl.Name = "HoraCitaControl";
            this.HoraCitaControl.ShowUpDown = true;
            this.HoraCitaControl.Size = new System.Drawing.Size(82, 28);
            this.HoraCitaControl.TabIndex = 15;
            // 
            // FechaCitaControl
            // 
            this.FechaCitaControl.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCitaControl.Location = new System.Drawing.Point(18, 109);
            this.FechaCitaControl.Name = "FechaCitaControl";
            this.FechaCitaControl.Size = new System.Drawing.Size(269, 28);
            this.FechaCitaControl.TabIndex = 14;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.buscar;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(446, 27);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(96, 32);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // ClienteControl
            // 
            this.ClienteControl.BackColor = System.Drawing.Color.White;
            this.ClienteControl.BeforeTouchSize = new System.Drawing.Size(364, 49);
            this.ClienteControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.ClienteControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClienteControl.Enabled = false;
            this.ClienteControl.FocusBorderColor = System.Drawing.Color.Transparent;
            this.ClienteControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteControl.Location = new System.Drawing.Point(41, 19);
            this.ClienteControl.Metrocolor = System.Drawing.Color.Transparent;
            this.ClienteControl.Multiline = true;
            this.ClienteControl.Name = "ClienteControl";
            this.ClienteControl.Size = new System.Drawing.Size(364, 49);
            this.ClienteControl.TabIndex = 12;
            this.ClienteControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgmCita);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 89);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(601, 606);
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
            gridTextColumn1.HeaderText = "IdCita";
            gridTextColumn1.MappingName = "IdCita";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "IdCliente";
            gridTextColumn2.MappingName = "IdCliente";
            gridTextColumn2.Visible = false;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Cliente";
            gridTextColumn3.MappingName = "NombreCompleto";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.Format = "HH:mm";
            gridTextColumn4.HeaderText = "Hora";
            gridTextColumn4.MappingName = "FechaCita";
            gridTextColumn4.MaximumWidth = 150D;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowMultiline = true;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "Observaciones";
            gridTextColumn14.MappingName = "Observaciones";
            gridTextColumn14.Visible = false;
            this.dgmCita.Columns.Add(gridTextColumn1);
            this.dgmCita.Columns.Add(gridTextColumn2);
            this.dgmCita.Columns.Add(gridTextColumn3);
            this.dgmCita.Columns.Add(gridTextColumn4);
            this.dgmCita.Columns.Add(gridTextColumn14);
            this.dgmCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgmCita.Location = new System.Drawing.Point(0, 0);
            this.dgmCita.Name = "dgmCita";
            this.dgmCita.Size = new System.Drawing.Size(601, 606);
            this.dgmCita.TabIndex = 0;
            this.dgmCita.Text = "sfDataGrid1";
            // 
            // errorProvider1
            // 
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
            this.Name = "FrmCapturaCitaNuevo";
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
        private System.Windows.Forms.DateTimePicker HoraCitaControl;
        private System.Windows.Forms.DateTimePicker FechaCitaControl;
        private System.Windows.Forms.Button btnBuscarCliente;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ClienteControl;
        private System.Windows.Forms.Label lblServicios;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgmServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechafin;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}