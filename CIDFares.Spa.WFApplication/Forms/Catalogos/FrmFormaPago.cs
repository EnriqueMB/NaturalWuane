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
    public partial class FrmFormaPago : Form
    {
        public FormaPagoViewModel Model { get; set; }
        public FrmFormaPago()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<FormaPagoViewModel>();
            grpBoxFormaPago.Enabled = false;
            IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                this.GridFromaPago.AutoGenerateColumns = false;
                GridFromaPago.DataBindings.Add("DataSource", Model, "ListaFormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
