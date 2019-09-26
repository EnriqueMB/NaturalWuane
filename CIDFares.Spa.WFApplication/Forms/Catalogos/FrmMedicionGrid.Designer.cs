namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmMedicionGrid
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
            this.PnlHead = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlFoot = new System.Windows.Forms.Panel();
            this.pnlBotonesDatos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlContainerGrid = new System.Windows.Forms.Panel();
            this.sfDataGridMedicion = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.PnlContainerDatos = new System.Windows.Forms.Panel();
            this.GroupMedicion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.IdUnidaMedidaControl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EsAbiertaControl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarLista = new System.Windows.Forms.Button();
            this.IdListaMedicionControl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnElimiarLista = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlHead.SuspendLayout();
            this.PnlFoot.SuspendLayout();
            this.pnlBotonesDatos.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.PnlContainerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMedicion)).BeginInit();
            this.PnlContainerDatos.SuspendLayout();
            this.GroupMedicion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdUnidaMedidaControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdListaMedicionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.Controls.Add(this.label3);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(1052, 94);
            this.PnlHead.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicion";
            // 
            // PnlFoot
            // 
            this.PnlFoot.Controls.Add(this.pnlBotonesDatos);
            this.PnlFoot.Controls.Add(this.flowLayoutPanel2);
            this.PnlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFoot.Location = new System.Drawing.Point(0, 498);
            this.PnlFoot.Name = "PnlFoot";
            this.PnlFoot.Size = new System.Drawing.Size(1052, 76);
            this.PnlFoot.TabIndex = 1;
            // 
            // pnlBotonesDatos
            // 
            this.pnlBotonesDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotonesDatos.Controls.Add(this.btnGuardar);
            this.pnlBotonesDatos.Controls.Add(this.btnCancelar);
            this.pnlBotonesDatos.Enabled = false;
            this.pnlBotonesDatos.Location = new System.Drawing.Point(717, 6);
            this.pnlBotonesDatos.Name = "pnlBotonesDatos";
            this.pnlBotonesDatos.Padding = new System.Windows.Forms.Padding(35, 17, 17, 17);
            this.pnlBotonesDatos.Size = new System.Drawing.Size(330, 67);
            this.pnlBotonesDatos.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(38, 20);
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
            this.btnCancelar.Location = new System.Drawing.Point(167, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel2.Controls.Add(this.btnModificar);
            this.flowLayoutPanel2.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(708, 67);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(8, 18);
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
            this.btnModificar.Location = new System.Drawing.Point(137, 18);
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
            this.btnEliminar.Location = new System.Drawing.Point(266, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.PnlContainerGrid);
            this.PnlBody.Controls.Add(this.PnlContainerDatos);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 94);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(1052, 404);
            this.PnlBody.TabIndex = 2;
            // 
            // PnlContainerGrid
            // 
            this.PnlContainerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContainerGrid.Controls.Add(this.sfDataGridMedicion);
            this.PnlContainerGrid.Location = new System.Drawing.Point(1, 0);
            this.PnlContainerGrid.Name = "PnlContainerGrid";
            this.PnlContainerGrid.Size = new System.Drawing.Size(710, 401);
            this.PnlContainerGrid.TabIndex = 1;
            // 
            // sfDataGridMedicion
            // 
            this.sfDataGridMedicion.AccessibleName = "Table";
            this.sfDataGridMedicion.AllowEditing = false;
            this.sfDataGridMedicion.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "IdMedicion";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.HeaderText = "Nombre medicion";
            gridTextColumn2.MappingName = "Nombre";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Unidad medida";
            gridTextColumn3.MappingName = "NombreUnidadMedida";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Valor";
            gridTextColumn4.MappingName = "NombreLista";
            this.sfDataGridMedicion.Columns.Add(gridTextColumn1);
            this.sfDataGridMedicion.Columns.Add(gridTextColumn2);
            this.sfDataGridMedicion.Columns.Add(gridTextColumn3);
            this.sfDataGridMedicion.Columns.Add(gridTextColumn4);
            this.sfDataGridMedicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridMedicion.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridMedicion.Name = "sfDataGridMedicion";
            this.sfDataGridMedicion.Size = new System.Drawing.Size(710, 401);
            this.sfDataGridMedicion.TabIndex = 2;
            this.sfDataGridMedicion.Text = "sfDataGrid1";
            // 
            // PnlContainerDatos
            // 
            this.PnlContainerDatos.Controls.Add(this.GroupMedicion);
            this.PnlContainerDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlContainerDatos.Location = new System.Drawing.Point(713, 0);
            this.PnlContainerDatos.Name = "PnlContainerDatos";
            this.PnlContainerDatos.Size = new System.Drawing.Size(339, 404);
            this.PnlContainerDatos.TabIndex = 0;
            // 
            // GroupMedicion
            // 
            this.GroupMedicion.Controls.Add(this.tableLayoutPanel1);
            this.GroupMedicion.Enabled = false;
            this.GroupMedicion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.GroupMedicion.Location = new System.Drawing.Point(4, 6);
            this.GroupMedicion.Name = "GroupMedicion";
            this.GroupMedicion.Size = new System.Drawing.Size(332, 392);
            this.GroupMedicion.TabIndex = 0;
            this.GroupMedicion.TabStop = false;
            this.GroupMedicion.Text = "Datos medicion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NombreControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(7, 44);
            this.NombreControl.MaxLength = 200;
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(280, 27);
            this.NombreControl.TabIndex = 5;
            this.NombreControl.TextChanged += new System.EventHandler(this.NombreControl_TextChanged);
            this.NombreControl.Leave += new System.EventHandler(this.NombreControl_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.IdUnidaMedidaControl);
            this.panel2.Location = new System.Drawing.Point(3, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 83);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Unidad medida";
            // 
            // IdUnidaMedidaControl
            // 
            this.IdUnidaMedidaControl.AutoComplete = false;
            this.IdUnidaMedidaControl.BackColor = System.Drawing.Color.White;
            this.IdUnidaMedidaControl.BeforeTouchSize = new System.Drawing.Size(280, 29);
            this.IdUnidaMedidaControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.IdUnidaMedidaControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdUnidaMedidaControl.FlatBorderColor = System.Drawing.Color.BurlyWood;
            this.IdUnidaMedidaControl.Location = new System.Drawing.Point(7, 41);
            this.IdUnidaMedidaControl.MetroBorderColor = System.Drawing.Color.Black;
            this.IdUnidaMedidaControl.Name = "IdUnidaMedidaControl";
            this.IdUnidaMedidaControl.Size = new System.Drawing.Size(280, 29);
            this.IdUnidaMedidaControl.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.IdUnidaMedidaControl.TabIndex = 52;
            this.IdUnidaMedidaControl.ThemeName = "Metro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EsAbiertaControl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditarLista);
            this.groupBox1.Controls.Add(this.IdListaMedicionControl);
            this.groupBox1.Controls.Add(this.btnElimiarLista);
            this.groupBox1.Controls.Add(this.BtnSeleccionar);
            this.groupBox1.Location = new System.Drawing.Point(3, 181);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(311, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // EsAbiertaControl
            // 
            this.EsAbiertaControl.AutoSize = true;
            this.EsAbiertaControl.Location = new System.Drawing.Point(215, 26);
            this.EsAbiertaControl.Name = "EsAbiertaControl";
            this.EsAbiertaControl.Size = new System.Drawing.Size(89, 25);
            this.EsAbiertaControl.TabIndex = 0;
            this.EsAbiertaControl.Text = "Es libre?";
            this.EsAbiertaControl.UseVisualStyleBackColor = true;
            this.EsAbiertaControl.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Listas de valores";
            // 
            // btnEditarLista
            // 
            this.btnEditarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(65)))));
            this.btnEditarLista.FlatAppearance.BorderSize = 0;
            this.btnEditarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLista.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnEditarLista.ForeColor = System.Drawing.Color.White;
            this.btnEditarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLista.Location = new System.Drawing.Point(104, 122);
            this.btnEditarLista.Name = "btnEditarLista";
            this.btnEditarLista.Size = new System.Drawing.Size(85, 28);
            this.btnEditarLista.TabIndex = 61;
            this.btnEditarLista.Text = "Modificar";
            this.btnEditarLista.UseVisualStyleBackColor = false;
            this.btnEditarLista.Click += new System.EventHandler(this.btnEditarLista_Click);
            // 
            // IdListaMedicionControl
            // 
            this.IdListaMedicionControl.AutoComplete = false;
            this.IdListaMedicionControl.BackColor = System.Drawing.Color.White;
            this.IdListaMedicionControl.BeforeTouchSize = new System.Drawing.Size(280, 29);
            this.IdListaMedicionControl.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.IdListaMedicionControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdListaMedicionControl.FlatBorderColor = System.Drawing.Color.BurlyWood;
            this.IdListaMedicionControl.Location = new System.Drawing.Point(7, 67);
            this.IdListaMedicionControl.MetroBorderColor = System.Drawing.Color.Black;
            this.IdListaMedicionControl.Name = "IdListaMedicionControl";
            this.IdListaMedicionControl.Size = new System.Drawing.Size(280, 29);
            this.IdListaMedicionControl.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.IdListaMedicionControl.TabIndex = 54;
            this.IdListaMedicionControl.ThemeName = "Metro";
            // 
            // btnElimiarLista
            // 
            this.btnElimiarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnElimiarLista.FlatAppearance.BorderSize = 0;
            this.btnElimiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimiarLista.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnElimiarLista.ForeColor = System.Drawing.Color.White;
            this.btnElimiarLista.Location = new System.Drawing.Point(202, 122);
            this.btnElimiarLista.Name = "btnElimiarLista";
            this.btnElimiarLista.Size = new System.Drawing.Size(85, 28);
            this.btnElimiarLista.TabIndex = 60;
            this.btnElimiarLista.Text = "Eliminar";
            this.btnElimiarLista.UseVisualStyleBackColor = false;
            this.btnElimiarLista.Click += new System.EventHandler(this.btnElimiarLista_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(7, 122);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(85, 28);
            this.BtnSeleccionar.TabIndex = 59;
            this.BtnSeleccionar.Text = "Agregar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMedicionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 574);
            this.Controls.Add(this.PnlBody);
            this.Controls.Add(this.PnlFoot);
            this.Controls.Add(this.PnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMedicionGrid";
            this.Text = "FrmMedicionGrid";
            this.Shown += new System.EventHandler(this.FrmMedicionGrid_Shown);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            this.PnlFoot.ResumeLayout(false);
            this.pnlBotonesDatos.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            this.PnlContainerGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMedicion)).EndInit();
            this.PnlContainerDatos.ResumeLayout(false);
            this.GroupMedicion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdUnidaMedidaControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdListaMedicionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHead;
        private System.Windows.Forms.Panel PnlFoot;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlContainerGrid;
        private System.Windows.Forms.Panel PnlContainerDatos;
        private System.Windows.Forms.GroupBox GroupMedicion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv IdUnidaMedidaControl;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv IdListaMedicionControl;
        private System.Windows.Forms.CheckBox EsAbiertaControl;
        private System.Windows.Forms.FlowLayoutPanel pnlBotonesDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridMedicion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarLista;
        private System.Windows.Forms.Button btnElimiarLista;
        private System.Windows.Forms.Button BtnSeleccionar;
    }
}