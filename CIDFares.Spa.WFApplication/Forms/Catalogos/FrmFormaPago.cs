using CIDFares.Spa.Business.ViewModels.Catalogos;
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
            //Model = ServiceLocator.Instance.Resolve<NacionalidadViewModel>();
            grpBoxFormaPago.Enabled = false;
        }

        private void IniciarBinding()
        {
            try
            {
               // DescripcionControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
               // NombreControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
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
