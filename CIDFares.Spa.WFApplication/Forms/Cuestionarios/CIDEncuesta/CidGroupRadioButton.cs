using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios.CIDEncuesta
{
    public partial class CidGroupRadioButton : UserControl
    {

        private object _SelectedValue;

        public object SelectedValue
        {
            get { return _SelectedValue; }
            set { _SelectedValue = value; }
        }

        public CidGroupRadioButton()
        {
            InitializeComponent();
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            CIDRadioButton rb = sender as CIDRadioButton;
            if (rb == null)
            {
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                SelectedValue = rb.Value;
            }
        }

        private void CidGroupRadioButton_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is CIDRadioButton)
            {
                CIDRadioButton radio = (e.Control as CIDRadioButton);
                radio.CheckedChanged += radioButton_CheckedChanged;
                panelRadio.Controls.Add(radio);
            }
            
        }
    }
}
