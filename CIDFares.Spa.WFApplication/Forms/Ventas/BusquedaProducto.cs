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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class BusquedaProducto : Form
    {
        #region Propiedades Públicas
        public BusquedaProductoViewModel Model { get; set; }
        #endregion

        public BusquedaProducto()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<BusquedaProductoViewModel>();
            IniciarBinding();
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void IniciarBinding()
        {
            try
            {              
                this.sfDataGridBuquedaProducto.AutoGenerateColumns = false;
                sfDataGridBuquedaProducto.DataBindings.Add("DataSource", Model, "ListaBusquedaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
