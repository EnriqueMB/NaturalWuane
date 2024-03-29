﻿namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    partial class FrmAlimentoNuevo
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGuardar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.FibrasControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.GrasasControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.ProteinasControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.CaloriasControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.IdTipoAlimentoControl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.HidratosControl = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FibrasControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrasasControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProteinasControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloriasControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTipoAlimentoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidratosControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitulo.ForeColor = System.Drawing.Color.White;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(367, 58);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar alimento";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 440);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(367, 60);
            this.pnlAcciones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(202, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 29);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.btnGuardar.BeforeTouchSize = new System.Drawing.Size(123, 29);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IsBackStageButton = false;
            this.btnGuardar.Location = new System.Drawing.Point(29, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 29);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.FibrasControl);
            this.pnlCentral.Controls.Add(this.GrasasControl);
            this.pnlCentral.Controls.Add(this.ProteinasControl);
            this.pnlCentral.Controls.Add(this.CaloriasControl);
            this.pnlCentral.Controls.Add(this.IdTipoAlimentoControl);
            this.pnlCentral.Controls.Add(this.HidratosControl);
            this.pnlCentral.Controls.Add(this.label8);
            this.pnlCentral.Controls.Add(this.label7);
            this.pnlCentral.Controls.Add(this.label6);
            this.pnlCentral.Controls.Add(this.label5);
            this.pnlCentral.Controls.Add(this.label4);
            this.pnlCentral.Controls.Add(this.label3);
            this.pnlCentral.Controls.Add(this.NombreControl);
            this.pnlCentral.Controls.Add(this.label2);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(0, 58);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(367, 382);
            this.pnlCentral.TabIndex = 1;
            // 
            // FibrasControl
            // 
            this.FibrasControl.BeforeTouchSize = new System.Drawing.Size(141, 29);
            this.FibrasControl.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.FibrasControl.CurrencyGroupSeparator = "";
            this.FibrasControl.CurrencySymbol = "";
            this.FibrasControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.FibrasControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FibrasControl.Location = new System.Drawing.Point(29, 315);
            this.FibrasControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.FibrasControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FibrasControl.Name = "FibrasControl";
            this.FibrasControl.NullString = "";
            this.FibrasControl.Size = new System.Drawing.Size(141, 29);
            this.FibrasControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.UICulture;
            this.FibrasControl.TabIndex = 7;
            this.FibrasControl.Text = "0,00";
            // 
            // GrasasControl
            // 
            this.GrasasControl.BeforeTouchSize = new System.Drawing.Size(141, 29);
            this.GrasasControl.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.GrasasControl.CurrencyGroupSeparator = "";
            this.GrasasControl.CurrencySymbol = "";
            this.GrasasControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.GrasasControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GrasasControl.Location = new System.Drawing.Point(202, 249);
            this.GrasasControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.GrasasControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GrasasControl.Name = "GrasasControl";
            this.GrasasControl.NullString = "";
            this.GrasasControl.Size = new System.Drawing.Size(141, 29);
            this.GrasasControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.UICulture;
            this.GrasasControl.TabIndex = 6;
            this.GrasasControl.Text = "0,00";
            // 
            // ProteinasControl
            // 
            this.ProteinasControl.BeforeTouchSize = new System.Drawing.Size(141, 29);
            this.ProteinasControl.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.ProteinasControl.CurrencyGroupSeparator = "";
            this.ProteinasControl.CurrencySymbol = "";
            this.ProteinasControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ProteinasControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProteinasControl.Location = new System.Drawing.Point(29, 249);
            this.ProteinasControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.ProteinasControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ProteinasControl.Name = "ProteinasControl";
            this.ProteinasControl.NullString = "";
            this.ProteinasControl.Size = new System.Drawing.Size(141, 29);
            this.ProteinasControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.UICulture;
            this.ProteinasControl.TabIndex = 5;
            this.ProteinasControl.Text = "0,00";
            // 
            // CaloriasControl
            // 
            this.CaloriasControl.BeforeTouchSize = new System.Drawing.Size(141, 29);
            this.CaloriasControl.CurrencyGroupSeparator = "";
            this.CaloriasControl.CurrencySymbol = "";
            this.CaloriasControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.CaloriasControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CaloriasControl.Location = new System.Drawing.Point(29, 183);
            this.CaloriasControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.CaloriasControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CaloriasControl.Name = "CaloriasControl";
            this.CaloriasControl.NullString = "";
            this.CaloriasControl.Size = new System.Drawing.Size(141, 29);
            this.CaloriasControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.UICulture;
            this.CaloriasControl.TabIndex = 3;
            this.CaloriasControl.Text = "0,00 ";
            // 
            // IdTipoAlimentoControl
            // 
            this.IdTipoAlimentoControl.BeforeTouchSize = new System.Drawing.Size(314, 29);
            this.IdTipoAlimentoControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IdTipoAlimentoControl.Location = new System.Drawing.Point(29, 114);
            this.IdTipoAlimentoControl.Name = "IdTipoAlimentoControl";
            this.IdTipoAlimentoControl.Size = new System.Drawing.Size(314, 29);
            this.IdTipoAlimentoControl.TabIndex = 2;
            // 
            // HidratosControl
            // 
            this.HidratosControl.BeforeTouchSize = new System.Drawing.Size(141, 29);
            this.HidratosControl.ClipMode = Syncfusion.Windows.Forms.Tools.CurrencyClipModes.ExcludeFormatting;
            this.HidratosControl.CurrencyGroupSeparator = "";
            this.HidratosControl.CurrencySymbol = "";
            this.HidratosControl.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.HidratosControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HidratosControl.Location = new System.Drawing.Point(202, 183);
            this.HidratosControl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.HidratosControl.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HidratosControl.Name = "HidratosControl";
            this.HidratosControl.NullString = "";
            this.HidratosControl.Size = new System.Drawing.Size(141, 29);
            this.HidratosControl.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.UICulture;
            this.HidratosControl.TabIndex = 4;
            this.HidratosControl.Text = "0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(25, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Grupo alimenticio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(198, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grasas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(198, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hidratos de carb.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(25, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fibras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(25, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proteínas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calorías (Kcal.)";
            // 
            // NombreControl
            // 
            this.NombreControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NombreControl.Location = new System.Drawing.Point(29, 48);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Size = new System.Drawing.Size(314, 29);
            this.NombreControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del alimento";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmAlimentoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 500);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlimentoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAlimentoNuevo";
            this.Shown += new System.EventHandler(this.FrmAlimentoNuevo_Shown);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FibrasControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrasasControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProteinasControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloriasControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTipoAlimentoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidratosControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreControl;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox HidratosControl;
        private System.Windows.Forms.ErrorProvider error;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv IdTipoAlimentoControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox FibrasControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox GrasasControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox ProteinasControl;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox CaloriasControl;
        private Syncfusion.Windows.Forms.ButtonAdv btnGuardar;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
    }
}