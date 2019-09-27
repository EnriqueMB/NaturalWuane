using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmCapturaConsulta : Form
    {
        public FrmCapturaConsulta()
        {
            InitializeComponent();
        }

        #region Eventos
        private void BtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOpcionesCuestionario _consulta = new FrmOpcionesCuestionario();
                _consulta.ShowDialog();
                _consulta.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
