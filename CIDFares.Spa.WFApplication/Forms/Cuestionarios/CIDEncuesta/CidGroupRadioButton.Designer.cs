namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios.CIDEncuesta
{
    partial class CidGroupRadioButton
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelRadio
            // 
            this.panelRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadio.Location = new System.Drawing.Point(0, 0);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Padding = new System.Windows.Forms.Padding(60, 30, 20, 0);
            this.panelRadio.Size = new System.Drawing.Size(429, 288);
            this.panelRadio.TabIndex = 0;
            // 
            // CidGroupRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRadio);
            this.Name = "CidGroupRadioButton";
            this.Size = new System.Drawing.Size(429, 288);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.CidGroupRadioButton_ControlAdded);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelRadio;
    }
}
