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
    public partial class CIDRadioButton : RadioButton
    {
        private object _Value;
        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public CIDRadioButton()
        {
            InitializeComponent();
        }
    }
}
