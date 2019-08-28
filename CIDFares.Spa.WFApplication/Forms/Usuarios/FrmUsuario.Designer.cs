namespace CIDFares.Spa.WFApplication.Forms.Usuarios
{
    partial class FrmUsuario
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupUsuario = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CuentaControl = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.ContraseniaControl = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.ContraseniaDosControl = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.IdRolControl = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.IdEmpleadoControl = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridUsuario = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblUsuario.Location = new System.Drawing.Point(12, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 70);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 29);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(132, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(261, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 423);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupUsuario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(519, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 423);
            this.panel5.TabIndex = 1;
            // 
            // groupUsuario
            // 
            this.groupUsuario.Controls.Add(this.tableLayoutPanel1);
            this.groupUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupUsuario.Location = new System.Drawing.Point(3, 3);
            this.groupUsuario.Name = "groupUsuario";
            this.groupUsuario.Size = new System.Drawing.Size(492, 414);
            this.groupUsuario.TabIndex = 0;
            this.groupUsuario.TabStop = false;
            this.groupUsuario.Text = "Datos usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 391);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CuentaControl);
            this.panel6.Controls.Add(this.lblCuenta);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(474, 59);
            this.panel6.TabIndex = 1;
            // 
            // CuentaControl
            // 
            this.CuentaControl.Location = new System.Drawing.Point(3, 20);
            this.CuentaControl.Margin = new System.Windows.Forms.Padding(0);
            this.CuentaControl.Name = "CuentaControl";
            this.CuentaControl.Size = new System.Drawing.Size(336, 27);
            this.CuentaControl.TabIndex = 1;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblCuenta.Location = new System.Drawing.Point(3, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(68, 20);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblContrasenia);
            this.panel7.Controls.Add(this.ContraseniaControl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(474, 59);
            this.panel7.TabIndex = 2;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblContrasenia.Location = new System.Drawing.Point(0, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(102, 20);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseñia:";
            // 
            // ContraseniaControl
            // 
            this.ContraseniaControl.Location = new System.Drawing.Point(4, 23);
            this.ContraseniaControl.Name = "ContraseniaControl";
            this.ContraseniaControl.Size = new System.Drawing.Size(336, 27);
            this.ContraseniaControl.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblConfirmar);
            this.panel8.Controls.Add(this.ContraseniaDosControl);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(474, 59);
            this.panel8.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblConfirmar.Location = new System.Drawing.Point(-1, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(176, 20);
            this.lblConfirmar.TabIndex = 8;
            this.lblConfirmar.Text = "Confirmar contraseñia:";
            // 
            // ContraseniaDosControl
            // 
            this.ContraseniaDosControl.Location = new System.Drawing.Point(0, 23);
            this.ContraseniaDosControl.Name = "ContraseniaDosControl";
            this.ContraseniaDosControl.Size = new System.Drawing.Size(336, 27);
            this.ContraseniaDosControl.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblRol);
            this.panel9.Controls.Add(this.IdRolControl);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 198);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(474, 59);
            this.panel9.TabIndex = 4;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblRol.Location = new System.Drawing.Point(3, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 20);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol:";
            // 
            // IdRolControl
            // 
            this.IdRolControl.FormattingEnabled = true;
            this.IdRolControl.Location = new System.Drawing.Point(0, 23);
            this.IdRolControl.Name = "IdRolControl";
            this.IdRolControl.Size = new System.Drawing.Size(215, 29);
            this.IdRolControl.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.IdEmpleadoControl);
            this.panel10.Controls.Add(this.lblEmpleado);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 263);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(474, 59);
            this.panel10.TabIndex = 5;
            // 
            // IdEmpleadoControl
            // 
            this.IdEmpleadoControl.FormattingEnabled = true;
            this.IdEmpleadoControl.Location = new System.Drawing.Point(4, 27);
            this.IdEmpleadoControl.Name = "IdEmpleadoControl";
            this.IdEmpleadoControl.Size = new System.Drawing.Size(211, 29);
            this.IdEmpleadoControl.TabIndex = 6;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblEmpleado.Location = new System.Drawing.Point(3, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(152, 20);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Nombre empleado:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnCancelar);
            this.panel11.Controls.Add(this.btnGuardar);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 328);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(474, 60);
            this.panel11.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(262, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(92, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataGridUsuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 423);
            this.panel4.TabIndex = 0;
            // 
            // DataGridUsuario
            // 
            this.DataGridUsuario.AccessibleName = "Table";
            this.DataGridUsuario.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn5.HeaderText = "Column1";
            gridTextColumn5.MappingName = "IdCuentaUsuario";
            gridTextColumn5.Visible = false;
            gridTextColumn6.HeaderText = "Cuenta";
            gridTextColumn6.MappingName = "Cuenta";
            gridTextColumn7.HeaderText = "IdRol";
            gridTextColumn7.MappingName = "IdRol";
            gridTextColumn7.Visible = false;
            gridTextColumn8.HeaderText = "Rol";
            gridTextColumn8.MappingName = "Nombre";
            this.DataGridUsuario.Columns.Add(gridTextColumn5);
            this.DataGridUsuario.Columns.Add(gridTextColumn6);
            this.DataGridUsuario.Columns.Add(gridTextColumn7);
            this.DataGridUsuario.Columns.Add(gridTextColumn8);
            this.DataGridUsuario.Location = new System.Drawing.Point(0, 0);
            this.DataGridUsuario.Name = "DataGridUsuario";
            this.DataGridUsuario.Size = new System.Drawing.Size(516, 420);
            this.DataGridUsuario.TabIndex = 0;
            this.DataGridUsuario.Text = "sfDataGrid1";
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Shown += new System.EventHandler(this.FrmUsuario_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGridUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupUsuario;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox CuentaControl;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox IdRolControl;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox ContraseniaControl;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox ContraseniaDosControl;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox IdEmpleadoControl;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ErrorProvider errorProviderUsuario;
    }
}