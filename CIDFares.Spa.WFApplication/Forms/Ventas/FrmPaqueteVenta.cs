using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
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
    public partial class FrmPaqueteVenta : Form
    {
        public VentasViewModel Model { get; set; }

        public FrmPaqueteVenta(VentasViewModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                //FolioClienteControl.DataBindings.Add("Text", Model, "FolioCliente", true, DataSourceUpdateMode.OnPropertyChanged);

                //TotalControl.DataBindings.Add("Text", Model, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
                //IvaControl.DataBindings.Add("Text", Model, "Iva", true, DataSourceUpdateMode.OnPropertyChanged);
                //SubtotalControl.DataBindings.Add("Text", Model, "Subtotal", true, DataSourceUpdateMode.OnPropertyChanged);
                //FolioVentaControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);

                this.GridPaquete.AutoGenerateColumns = false;
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
