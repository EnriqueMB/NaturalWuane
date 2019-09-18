namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    partial class FrmCapturaCita
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.FechaFinalControl = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaInicioControl = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mcCita2 = new Syncfusion.WinForms.Input.SfCalendar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.FechaFinalControl);
            this.pnlHeader.Controls.Add(this.btnBuscar);
            this.pnlHeader.Controls.Add(this.lblFechaFinal);
            this.pnlHeader.Controls.Add(this.lblFechaInicio);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.FechaInicioControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // FechaFinalControl
            // 
            this.FechaFinalControl.Location = new System.Drawing.Point(754, 40);
            this.FechaFinalControl.Name = "FechaFinalControl";
            this.FechaFinalControl.Size = new System.Drawing.Size(269, 22);
            this.FechaFinalControl.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1056, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 32);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFinal.Location = new System.Drawing.Point(749, 0);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(150, 30);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(464, 0);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(166, 30);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cita";
            // 
            // FechaInicioControl
            // 
            this.FechaInicioControl.Enabled = false;
            this.FechaInicioControl.Location = new System.Drawing.Point(466, 41);
            this.FechaInicioControl.Name = "FechaInicioControl";
            this.FechaInicioControl.Size = new System.Drawing.Size(269, 22);
            this.FechaInicioControl.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 961);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1160, 94);
            this.pnlButtons.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcCita2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 882);
            this.panel1.TabIndex = 3;
            // 
            // mcCita2
            // 
            this.mcCita2.Culture = new System.Globalization.CultureInfo("es-ES");
            this.mcCita2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcCita2.Location = new System.Drawing.Point(0, 0);
            this.mcCita2.Name = "mcCita2";
            this.mcCita2.SelectedDate = new System.DateTime(2019, 9, 10, 0, 0, 0, 0);
            this.mcCita2.Size = new System.Drawing.Size(1155, 882);
            this.mcCita2.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.mcCita2.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.mcCita2.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.mcCita2.TabIndex = 0;
            this.mcCita2.Text = "sfCalendar1";
            this.mcCita2.Click += new System.EventHandler(this.mcCita2_Click);
            this.mcCita2.DoubleClick += new System.EventHandler(this.mcCita2_DoubleClick);
            // 
            // FrmCapturaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmCapturaCita";
            this.Text = "FrmCapturaCita";
            this.Load += new System.EventHandler(this.FrmCapturaCita_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DateTimePicker FechaInicioControl;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker FechaFinalControl;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Input.SfCalendar mcCita2;
    }
}