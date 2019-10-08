using CIDFares.Library.Code.Extensions;
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
        public bool EsSiguiente { get; set; }
        public PromocionViewModel Model { get; set; }
        public BusqueProducto Producto { get; set; }
        public FrmPromocionDescuento(PromocionViewModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.IniciarBinding();
            Model.EsDescuento = true;
            Model.EsPromocionMxN = false;
            Model.EsPromocionNxN = false;
        }

        private void IniciarBinding()
        {
            try
            {
                EsMonto.DataBindings.Add("Checked", Model, "EsMonto", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescuentoControl.DataBindings.Add("Text", Model, "Descuento", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbProcentaje.Checked)
                {
                    EsMontoControl.Text = "%";
                    Model.EsMonto = false;
                }
                else if (EsMonto.Checked)
                {
                    EsMontoControl.Text = "$";
                    Model.EsMonto = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Agregar(BusqueProducto producto)
        {
            try
            {
                Model.Nombre = producto.Nombre;
                Model.IdGenerico = producto.IdProducto;
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
                if(Model.IdPromocion != Guid.Empty)
                {
                    if (Model.EsMonto)
                    {
                        EsMontoControl.Text = "$";
                        EsMonto.Checked = true;
                    }
                    else
                    {
                        EsMontoControl.Text = "%";
                        rbProcentaje.Checked = true;
                    }
                }
                else
                EsMonto.Checked = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                this.CleanErrors(errorProvider1, typeof(PromocionViewModel));
                if (String.IsNullOrEmpty(Model.Nombre))
                    errorProvider1.SetError(btnAgregar, "Selecione un producto o servicio");
                else
                {
                    if (String.IsNullOrEmpty(Model.NombrePromocion))
                        errorProvider1.SetError(btnAgregar, "Ingrese un nombre de la promoción");
                    else
                    {
                        var validationResults = Model.Validate();
                        validationResults.ToString();
                        if (validationResults.IsValid)
                        {
                            FrmPromocionDias dias = new FrmPromocionDias(Model);
                            dias.ShowDialog();
                            if (dias.Resultado == 1)
                            {
                                this.Close();
                                Model.Resultado = 1;
                                LimpiarPropiedades();
                            }
                        }
                        else
                            this.ShowErrors(errorProvider1, typeof(PromocionViewModel), validationResults);
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimpiarPropiedades()
        {
            try
            {
                Model.EsMonto = true;
                Model.Nombre = String.Empty;
                Model.IdGenerico = 0;
                Model.EsProducto = true;
                Model.Descuento = 0;
                Model.NombrePromocion = String.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void Agregar(Servicio servicio)
        {
            try
            {
                Model.Nombre = servicio.Nombre;
                Model.IdGenerico = servicio.IdServicio;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
