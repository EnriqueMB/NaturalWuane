using CIDFares.Spa.Business.ViewModels.Promociones;
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
    public partial class FrmPromocionMxN : Form
    {
        public PromocionViewModel Model { get; set; }
        public bool EsSiguiente { get; set; }
        public FrmPromocionMxN(PromocionViewModel model)
        {
            InitializeComponent();
            Model = model;
            EsSiguiente = false;
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                CantidadControl.DataBindings.Add("Text", Model, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreProductoControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                CantidadGratisControl.DataBindings.Add("Text", Model, "CantidadGratis", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
