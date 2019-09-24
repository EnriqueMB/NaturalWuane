namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    partial class FrmNuevaEncuesta
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
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarEncuesta = new System.Windows.Forms.Button();
            this.btnNuevaEncuesta = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarRespuesta = new System.Windows.Forms.Button();
            this.btnAgregarRespuesta = new System.Windows.Forms.Button();
            this.dtgRespuestas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPregunta = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            this.dtgPreguntas = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            this.IdTipoEncuestaControl = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreEncuestaControl = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FlpBotones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRespuestas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.btnCancelarEncuesta);
            this.FlpBotones.Controls.Add(this.btnNuevaEncuesta);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(0, 650);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.FlpBotones.Size = new System.Drawing.Size(662, 74);
            this.FlpBotones.TabIndex = 6;
            // 
            // btnCancelarEncuesta
            // 
            this.btnCancelarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEncuesta.BackColor = System.Drawing.Color.White;
            this.btnCancelarEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnCancelarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEncuesta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEncuesta.Location = new System.Drawing.Point(509, 23);
            this.btnCancelarEncuesta.Name = "btnCancelarEncuesta";
            this.btnCancelarEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnCancelarEncuesta.TabIndex = 15;
            this.btnCancelarEncuesta.Text = "CANCELAR";
            this.btnCancelarEncuesta.UseVisualStyleBackColor = false;
            this.btnCancelarEncuesta.Click += new System.EventHandler(this.BtnCancelarEncuesta_Click);
            // 
            // btnNuevaEncuesta
            // 
            this.btnNuevaEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaEncuesta.BackColor = System.Drawing.Color.White;
            this.btnNuevaEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnNuevaEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEncuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEncuesta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaEncuesta.Location = new System.Drawing.Point(373, 23);
            this.btnNuevaEncuesta.Name = "btnNuevaEncuesta";
            this.btnNuevaEncuesta.Size = new System.Drawing.Size(130, 28);
            this.btnNuevaEncuesta.TabIndex = 15;
            this.btnNuevaEncuesta.Text = "GUARDAR";
            this.btnNuevaEncuesta.UseVisualStyleBackColor = false;
            this.btnNuevaEncuesta.Click += new System.EventHandler(this.BtnNuevaEncuesta_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(662, 45);
            this.pnlTitulo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "NUEVA ENCUESTA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.IdTipoEncuestaControl);
            this.panel1.Controls.Add(this.lblUnidadMedida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NombreEncuestaControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 605);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarRespuesta);
            this.groupBox2.Controls.Add(this.btnAgregarRespuesta);
            this.groupBox2.Controls.Add(this.dtgRespuestas);
            this.groupBox2.Location = new System.Drawing.Point(0, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 241);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESPUESTAS";
            // 
            // btnEliminarRespuesta
            // 
            this.btnEliminarRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminarRespuesta.FlatAppearance.BorderSize = 0;
            this.btnEliminarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRespuesta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRespuesta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRespuesta.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.minus35px;
            this.btnEliminarRespuesta.Location = new System.Drawing.Point(607, 109);
            this.btnEliminarRespuesta.Name = "btnEliminarRespuesta";
            this.btnEliminarRespuesta.Size = new System.Drawing.Size(47, 36);
            this.btnEliminarRespuesta.TabIndex = 16;
            this.btnEliminarRespuesta.UseVisualStyleBackColor = false;
            this.btnEliminarRespuesta.Click += new System.EventHandler(this.BtnEliminarRespuesta_Click);
            // 
            // btnAgregarRespuesta
            // 
            this.btnAgregarRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnAgregarRespuesta.FlatAppearance.BorderSize = 0;
            this.btnAgregarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRespuesta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRespuesta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRespuesta.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.plus35Px;
            this.btnAgregarRespuesta.Location = new System.Drawing.Point(607, 67);
            this.btnAgregarRespuesta.Name = "btnAgregarRespuesta";
            this.btnAgregarRespuesta.Size = new System.Drawing.Size(47, 36);
            this.btnAgregarRespuesta.TabIndex = 17;
            this.btnAgregarRespuesta.UseVisualStyleBackColor = false;
            this.btnAgregarRespuesta.Click += new System.EventHandler(this.BtnAgregarRespuesta_Click);
            // 
            // dtgRespuestas
            // 
            this.dtgRespuestas.AccessibleName = "Table";
            this.dtgRespuestas.AllowDraggingColumns = true;
            this.dtgRespuestas.AllowEditing = false;
            this.dtgRespuestas.AllowFiltering = true;
            this.dtgRespuestas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRespuestas.AutoExpandGroups = true;
            this.dtgRespuestas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtgRespuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "IdPregunta";
            gridTextColumn1.MappingName = "IdPregunta";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "PREGUNTA";
            gridTextColumn2.MappingName = "pregunta";
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "RESPUESTAS";
            gridTextColumn3.MappingName = "Respuesta";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "IdRespuesta";
            gridTextColumn4.MappingName = "IdRespuesta";
            gridTextColumn4.Visible = false;
            this.dtgRespuestas.Columns.Add(gridTextColumn1);
            this.dtgRespuestas.Columns.Add(gridTextColumn2);
            this.dtgRespuestas.Columns.Add(gridTextColumn3);
            this.dtgRespuestas.Columns.Add(gridTextColumn4);
            this.dtgRespuestas.Location = new System.Drawing.Point(6, 19);
            this.dtgRespuestas.Name = "dtgRespuestas";
            this.dtgRespuestas.RowHeight = 21;
            this.dtgRespuestas.ShowGroupDropArea = true;
            this.dtgRespuestas.Size = new System.Drawing.Size(591, 216);
            this.dtgRespuestas.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dtgRespuestas.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtgRespuestas.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgRespuestas.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgRespuestas.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dtgRespuestas.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgRespuestas.Style.HeaderStyle.Font.Bold = false;
            this.dtgRespuestas.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgRespuestas.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgRespuestas.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgRespuestas.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgRespuestas.TabIndex = 1;
            this.dtgRespuestas.Text = "dataGridsf1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarPregunta);
            this.groupBox1.Controls.Add(this.btnBajar);
            this.groupBox1.Controls.Add(this.btnSubir);
            this.groupBox1.Controls.Add(this.btnAgregarPregunta);
            this.groupBox1.Controls.Add(this.dtgPreguntas);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 262);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREGUNTAS";
            // 
            // btnEliminarPregunta
            // 
            this.btnEliminarPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminarPregunta.FlatAppearance.BorderSize = 0;
            this.btnEliminarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPregunta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPregunta.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.minus35px;
            this.btnEliminarPregunta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPregunta.Location = new System.Drawing.Point(607, 109);
            this.btnEliminarPregunta.Name = "btnEliminarPregunta";
            this.btnEliminarPregunta.Size = new System.Drawing.Size(47, 36);
            this.btnEliminarPregunta.TabIndex = 15;
            this.btnEliminarPregunta.UseVisualStyleBackColor = false;
            this.btnEliminarPregunta.Click += new System.EventHandler(this.BtnEliminarPregunta_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnBajar.FlatAppearance.BorderSize = 0;
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajar.ForeColor = System.Drawing.Color.White;
            this.btnBajar.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.chevrondown35px;
            this.btnBajar.Location = new System.Drawing.Point(607, 193);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(47, 36);
            this.btnBajar.TabIndex = 15;
            this.btnBajar.UseVisualStyleBackColor = false;
            this.btnBajar.Click += new System.EventHandler(this.BtnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.chevronup35px;
            this.btnSubir.Location = new System.Drawing.Point(607, 151);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(47, 36);
            this.btnSubir.TabIndex = 15;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.btnAgregarPregunta.FlatAppearance.BorderSize = 0;
            this.btnAgregarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPregunta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPregunta.Image = global::CIDFares.Spa.WFApplication.Properties.Resources.plus35Px;
            this.btnAgregarPregunta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPregunta.Location = new System.Drawing.Point(607, 67);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(47, 36);
            this.btnAgregarPregunta.TabIndex = 15;
            this.btnAgregarPregunta.UseVisualStyleBackColor = false;
            this.btnAgregarPregunta.Click += new System.EventHandler(this.BtnAgregarPregunta_Click);
            // 
            // dtgPreguntas
            // 
            this.dtgPreguntas.AccessibleName = "Table";
            this.dtgPreguntas.AllowDraggingColumns = true;
            this.dtgPreguntas.AllowDrop = true;
            this.dtgPreguntas.AllowEditing = false;
            this.dtgPreguntas.AllowFiltering = true;
            this.dtgPreguntas.AllowSelectionOnMouseDown = true;
            this.dtgPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPreguntas.AutoExpandGroups = true;
            this.dtgPreguntas.AutoFitGroupDropAreaItem = true;
            this.dtgPreguntas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtgPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "IdPregunta";
            gridTextColumn5.MappingName = "IdPregunta";
            gridTextColumn5.Visible = false;
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "PREGUNTA";
            gridTextColumn6.MappingName = "Pregunta";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "TIPO DE RESPUESTA";
            gridTextColumn7.MappingName = "TipoPregunta";
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "DEPENDE DE...";
            gridTextColumn8.MappingName = "DependePregunta";
            gridTextColumn9.AllowDragging = true;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.HeaderText = "CUANDO SEA";
            gridTextColumn9.MappingName = "ActivarCuando";
            gridTextColumn10.AllowDragging = true;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.HeaderText = "DEPENDE";
            gridTextColumn10.MappingName = "IdPreguntaDepende";
            gridTextColumn10.Visible = false;
            this.dtgPreguntas.Columns.Add(gridTextColumn5);
            this.dtgPreguntas.Columns.Add(gridTextColumn6);
            this.dtgPreguntas.Columns.Add(gridTextColumn7);
            this.dtgPreguntas.Columns.Add(gridTextColumn8);
            this.dtgPreguntas.Columns.Add(gridTextColumn9);
            this.dtgPreguntas.Columns.Add(gridTextColumn10);
            this.dtgPreguntas.Location = new System.Drawing.Point(6, 19);
            this.dtgPreguntas.Name = "dtgPreguntas";
            this.dtgPreguntas.RowHeight = 21;
            this.dtgPreguntas.ShowGroupDropArea = true;
            this.dtgPreguntas.Size = new System.Drawing.Size(591, 237);
            this.dtgPreguntas.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dtgPreguntas.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtgPreguntas.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgPreguntas.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgPreguntas.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dtgPreguntas.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgPreguntas.Style.HeaderStyle.Font.Bold = false;
            this.dtgPreguntas.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dtgPreguntas.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPreguntas.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPreguntas.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dtgPreguntas.Style.RowHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            gridBordersInfo1.Bottom = new Syncfusion.WinForms.DataGrid.Styles.GridBorder(Syncfusion.WinForms.DataGrid.Styles.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))));
            this.dtgPreguntas.Style.RowHeaderStyle.Borders = gridBordersInfo1;
            this.dtgPreguntas.TabIndex = 1;
            this.dtgPreguntas.Text = "dataGridsf1";
            // 
            // IdTipoEncuestaControl
            // 
            this.IdTipoEncuestaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTipoEncuestaControl.FormattingEnabled = true;
            this.IdTipoEncuestaControl.Location = new System.Drawing.Point(360, 46);
            this.IdTipoEncuestaControl.Name = "IdTipoEncuestaControl";
            this.IdTipoEncuestaControl.Size = new System.Drawing.Size(234, 26);
            this.IdTipoEncuestaControl.TabIndex = 45;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(357, 15);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(129, 19);
            this.lblUnidadMedida.TabIndex = 46;
            this.lblUnidadMedida.Text = "TIPO DE ENCUESTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DE LA ENCUESTA";
            // 
            // NombreEncuestaControl
            // 
            this.NombreEncuestaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEncuestaControl.Location = new System.Drawing.Point(6, 46);
            this.NombreEncuestaControl.Name = "NombreEncuestaControl";
            this.NombreEncuestaControl.Size = new System.Drawing.Size(324, 26);
            this.NombreEncuestaControl.TabIndex = 3;
            this.NombreEncuestaControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNuevaEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.FlpBotones);
            this.Name = "FrmNuevaEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaEncuesta";
            this.Load += new System.EventHandler(this.FrmNuevaEncuesta_Load);
            this.FlpBotones.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRespuestas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button btnCancelarEncuesta;
        private System.Windows.Forms.Button btnNuevaEncuesta;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreEncuestaControl;
        private System.Windows.Forms.ComboBox IdTipoEncuestaControl;
        private System.Windows.Forms.Label lblUnidadMedida;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgRespuestas;
        private Library.Controls.CIDDataGridsf.DataGridsf dtgPreguntas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarPregunta;
        private System.Windows.Forms.Button btnAgregarPregunta;
        private System.Windows.Forms.Button btnEliminarRespuesta;
        private System.Windows.Forms.Button btnAgregarRespuesta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
    }
}