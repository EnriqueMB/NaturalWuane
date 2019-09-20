using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmMedicionGrid : Form
    {
        #region Propiedades Publicas
        public MedicionViewModel Model { get; set; }
        #endregion
        public FrmMedicionGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<MedicionViewModel>();
        }

        private void FrmMedicionGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.GetAll();
                }, "Espere");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
