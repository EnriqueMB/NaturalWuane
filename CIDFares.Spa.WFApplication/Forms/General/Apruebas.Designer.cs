namespace CIDFares.Spa.WFApplication.Forms.General
{
    partial class Apruebas
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
            this.EXPORTTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EXPORTTAR
            // 
            this.EXPORTTAR.Location = new System.Drawing.Point(504, 169);
            this.EXPORTTAR.Name = "EXPORTTAR";
            this.EXPORTTAR.Size = new System.Drawing.Size(90, 44);
            this.EXPORTTAR.TabIndex = 0;
            this.EXPORTTAR.Text = "exportar";
            this.EXPORTTAR.UseVisualStyleBackColor = true;
            this.EXPORTTAR.Click += new System.EventHandler(this.EXPORTTAR_Click);
            // 
            // Apruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXPORTTAR);
            this.Name = "Apruebas";
            this.Text = "Apruebas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXPORTTAR;
    }
}