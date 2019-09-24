using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.Business.ViewModels.Catalogos;
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

namespace CIDFares.Spa.WFApplication.Forms.Paquete
{
    public partial class FrmPagarPaquete : Form
    {
        public PaqueteViewModel Model { get; set; }
        public AbonoPaquete paquete { get; set; }
        public bool EsCerrar { get; set; }
        public FrmPagarPaquete(AbonoPaquete item, PaqueteViewModel model)
        {

            InitializeComponent();
            Model = model;
            IniciarBinding();
            paquete = new AbonoPaquete();
            paquete = item;
        }

        #region Métodos
        private void IniciarBinding()
        {
            try
            {

                AdeudoControl.DataBindings.Add("Text", Model, "Adeudo", true, DataSourceUpdateMode.OnPropertyChanged);
                PagoPaqueteControl.DataBindings.Add("Text", Model, "PagoPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EsCerrar = true;
            this.Close();
        }

        private void FrmPagarPaquete_Load(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = paquete.Total.ToString("C2");
                NombreControl.Text = paquete.NombrePaquete;
                AdeudoControl.Text = paquete.Adeudo.ToString("C2");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void pagar ()
        {
            try
            {
                var validationResults = Model.Validate();
            validationResults.ToString();
            if (validationResults.IsValid)
            {
                EsCerrar = false;
                paquete.PagoPaquete = Model.PagoPaquete;
                this.Close();
            }
            else
                this.ShowErrors(errorProvider1, typeof(PaqueteViewModel), validationResults);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(PaqueteViewModel));
                if (paquete.NPagosMax == paquete.NPago +1)
                {
                    if (Model.Adeudo == Model.PagoPaquete)
                        pagar();
                    else
                        errorProvider1.SetError(btnAgregar, "DEBE LIQUIDAR EL PAQUETE, NOSE PERMITEN MAS PAGOS");
                }
                else
                    pagar();
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
