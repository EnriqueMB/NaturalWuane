using CIDFares.Spa.Business.ViewModels.General;
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

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmProductosMonedero : Form
    {
        #region Propiedades
        public ProductosMonederoViewModel Model { get; set; }
        #endregion
        public FrmProductosMonedero()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProductosMonederoViewModel>();
        }
    }
}
