namespace CIDFares.Spa.WFApplication.Forms.Promociones
{
    partial class FrmPromocionDias

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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDias = new System.Windows.Forms.RadioButton();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelPeriodo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaFinControl = new System.Windows.Forms.DateTimePicker();
            this.FechaInicioControl = new System.Windows.Forms.DateTimePicker();
            this.panelDias = new System.Windows.Forms.Panel();
            this.Domingo = new System.Windows.Forms.CheckBox();
            this.Sabado = new System.Windows.Forms.CheckBox();
            this.Viernes = new System.Windows.Forms.CheckBox();
            this.Jueves = new System.Windows.Forms.CheckBox();
            this.Miercoles = new System.Windows.Forms.CheckBox();
            this.Martes = new System.Windows.Forms.CheckBox();
            this.Lunes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelDias = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimiteControl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelPeriodo.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.tableLayoutPanelDias.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.tableLayoutPanelDias);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(792, 475);
            this.panelPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar si la duracion de la promocion es en dias de la semana o en un period" +
    "o de tiempo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDias);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbPeriodo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo/Dias";
            // 
            // rbDias
            // 
            this.rbDias.AutoSize = true;
            this.rbDias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDias.ForeColor = System.Drawing.Color.Black;
            this.rbDias.Location = new System.Drawing.Point(19, 56);
            this.rbDias.Name = "rbDias";
            this.rbDias.Size = new System.Drawing.Size(53, 21);
            this.rbDias.TabIndex = 8;
            this.rbDias.TabStop = true;
            this.rbDias.Text = "Dias";
            this.rbDias.UseVisualStyleBackColor = true;
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodo.ForeColor = System.Drawing.Color.Black;
            this.rbPeriodo.Location = new System.Drawing.Point(19, 27);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(76, 21);
            this.rbPeriodo.TabIndex = 7;
            this.rbPeriodo.TabStop = true;
            this.rbPeriodo.Text = "Periodo";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            this.rbPeriodo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.panelDias);
            this.groupBox5.Controls.Add(this.panelPeriodo);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(33, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(724, 118);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dias de promocion";
            // 
            // panelPeriodo
            // 
            this.panelPeriodo.Controls.Add(this.label5);
            this.panelPeriodo.Controls.Add(this.label4);
            this.panelPeriodo.Controls.Add(this.FechaFinControl);
            this.panelPeriodo.Controls.Add(this.FechaInicioControl);
            this.panelPeriodo.Location = new System.Drawing.Point(6, 35);
            this.panelPeriodo.Name = "panelPeriodo";
            this.panelPeriodo.Size = new System.Drawing.Size(606, 53);
            this.panelPeriodo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(227, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha fin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha inicio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaFinControl
            // 
            this.FechaFinControl.Location = new System.Drawing.Point(230, 25);
            this.FechaFinControl.Name = "FechaFinControl";
            this.FechaFinControl.Size = new System.Drawing.Size(200, 23);
            this.FechaFinControl.TabIndex = 1;
            // 
            // FechaInicioControl
            // 
            this.FechaInicioControl.Location = new System.Drawing.Point(10, 25);
            this.FechaInicioControl.Name = "FechaInicioControl";
            this.FechaInicioControl.Size = new System.Drawing.Size(200, 23);
            this.FechaInicioControl.TabIndex = 0;
            // 
            // panelDias
            // 
            this.panelDias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDias.Controls.Add(this.Domingo);
            this.panelDias.Controls.Add(this.Sabado);
            this.panelDias.Controls.Add(this.Viernes);
            this.panelDias.Controls.Add(this.Jueves);
            this.panelDias.Controls.Add(this.Miercoles);
            this.panelDias.Controls.Add(this.Martes);
            this.panelDias.Controls.Add(this.Lunes);
            this.panelDias.Location = new System.Drawing.Point(6, 42);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(612, 41);
            this.panelDias.TabIndex = 0;
            // 
            // Domingo
            // 
            this.Domingo.AutoSize = true;
            this.Domingo.Location = new System.Drawing.Point(247, 13);
            this.Domingo.Name = "Domingo";
            this.Domingo.Size = new System.Drawing.Size(37, 21);
            this.Domingo.TabIndex = 6;
            this.Domingo.Text = "D";
            this.Domingo.UseVisualStyleBackColor = true;
            // 
            // Sabado
            // 
            this.Sabado.AutoSize = true;
            this.Sabado.Location = new System.Drawing.Point(207, 14);
            this.Sabado.Name = "Sabado";
            this.Sabado.Size = new System.Drawing.Size(33, 21);
            this.Sabado.TabIndex = 5;
            this.Sabado.Text = "S";
            this.Sabado.UseVisualStyleBackColor = true;
            // 
            // Viernes
            // 
            this.Viernes.AutoSize = true;
            this.Viernes.Location = new System.Drawing.Point(168, 14);
            this.Viernes.Name = "Viernes";
            this.Viernes.Size = new System.Drawing.Size(36, 21);
            this.Viernes.TabIndex = 4;
            this.Viernes.Text = "V";
            this.Viernes.UseVisualStyleBackColor = true;
            // 
            // Jueves
            // 
            this.Jueves.AutoSize = true;
            this.Jueves.Location = new System.Drawing.Point(129, 14);
            this.Jueves.Name = "Jueves";
            this.Jueves.Size = new System.Drawing.Size(33, 21);
            this.Jueves.TabIndex = 3;
            this.Jueves.Text = "J";
            this.Jueves.UseVisualStyleBackColor = true;
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSize = true;
            this.Miercoles.Location = new System.Drawing.Point(90, 14);
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Size = new System.Drawing.Size(38, 21);
            this.Miercoles.TabIndex = 2;
            this.Miercoles.Text = "M";
            this.Miercoles.UseVisualStyleBackColor = true;
            // 
            // Martes
            // 
            this.Martes.AutoSize = true;
            this.Martes.Location = new System.Drawing.Point(51, 14);
            this.Martes.Name = "Martes";
            this.Martes.Size = new System.Drawing.Size(38, 21);
            this.Martes.TabIndex = 1;
            this.Martes.Text = "M";
            this.Martes.UseVisualStyleBackColor = true;
            // 
            // Lunes
            // 
            this.Lunes.AutoSize = true;
            this.Lunes.Location = new System.Drawing.Point(12, 14);
            this.Lunes.Name = "Lunes";
            this.Lunes.Size = new System.Drawing.Size(33, 21);
            this.Lunes.TabIndex = 0;
            this.Lunes.Text = "L";
            this.Lunes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione cual es la duracion de la promoción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelDias
            // 
            this.tableLayoutPanelDias.ColumnCount = 1;
            this.tableLayoutPanelDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDias.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanelDias.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanelDias.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanelDias.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanelDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDias.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDias.Name = "tableLayoutPanelDias";
            this.tableLayoutPanelDias.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanelDias.RowCount = 4;
            this.tableLayoutPanelDias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.93388F));
            this.tableLayoutPanelDias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.06612F));
            this.tableLayoutPanelDias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelDias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelDias.Size = new System.Drawing.Size(790, 473);
            this.tableLayoutPanelDias.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(33, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 60);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(60)))));
            this.btnAgregar.Location = new System.Drawing.Point(194, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(367, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cencelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LimiteControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limite de venta";
            // 
            // LimiteControl
            // 
            this.LimiteControl.BeforeTouchSize = new System.Drawing.Size(60, 23);
            this.LimiteControl.Location = new System.Drawing.Point(12, 36);
            this.LimiteControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.LimiteControl.Name = "LimiteControl";
            this.LimiteControl.Size = new System.Drawing.Size(60, 23);
            this.LimiteControl.TabIndex = 6;
            this.LimiteControl.Text = "10";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limite de ventas que se pueden realizar para esta promocion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPromocionDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 475);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPromocionDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromocionNxN";
            this.Load += new System.EventHandler(this.FrmPromocionDias_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panelPeriodo.ResumeLayout(false);
            this.panelDias.ResumeLayout(false);
            this.panelDias.PerformLayout();
            this.tableLayoutPanelDias.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDias;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaFinControl;
        private System.Windows.Forms.DateTimePicker FechaInicioControl;
        private System.Windows.Forms.Panel panelDias;
        private System.Windows.Forms.CheckBox Domingo;
        private System.Windows.Forms.CheckBox Sabado;
        private System.Windows.Forms.CheckBox Viernes;
        private System.Windows.Forms.CheckBox Jueves;
        private System.Windows.Forms.CheckBox Miercoles;
        private System.Windows.Forms.CheckBox Martes;
        private System.Windows.Forms.CheckBox Lunes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt LimiteControl;
        private System.Windows.Forms.Label label3;
    }
}