using CIDFares.Library.Code.Extensions;
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
    public partial class FrmPromocionNxN : Form
    {
        public PromocionViewModel Model { get; set; } 
        public bool EsSiguiente { get; set; }
        public FrmPromocionNxN(PromocionViewModel model)
        {
            InitializeComponent();
            Model = model;
            EsSiguiente = false;
            this.IniciarBinding();
            Model.EsPromocionNxN = true;
            Model.EsDescuento = false;
            Model.EsPromocionMxN = false;
            Model.EsCapturaFecha = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

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
                //Model.EsMonto = true;
                Model.Nombre = String.Empty;
                Model.IdGenerico = 0;
                Model.EsProducto = true;
                //Model.Descuento = 0;
                Model.Cantidad = 0;
                Model.CantidadGratis = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
