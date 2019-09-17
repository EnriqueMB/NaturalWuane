using CIDFares.Spa.Business.ViewModels.Promociones;
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

namespace CIDFares.Spa.WFApplication.Forms.Promociones
{
    public partial class FrmPromocionDescuento : Form
    {
        public PromocionViewModel Model { get; set; }
        public BusqueProducto Producto { get; set; }
        public FrmPromocionDescuento(PromocionViewModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {

                NombreProductoControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Agregar(BusqueProducto producto)
        {
            try
            {
                Model.Nombre = producto.Nombre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmPromocionDescuento_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
