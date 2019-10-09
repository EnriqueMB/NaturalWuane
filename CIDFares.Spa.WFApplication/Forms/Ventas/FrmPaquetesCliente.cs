using CIDFares.Spa.Business.ViewModels.Catalogos;
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
    public partial class FrmPaquetesCliente : Form
    {
        public PaqueteViewModel Model { get; set; }
        public Paquetes paquetes { get; set; }

        public FrmPaquetesCliente(BindingList<Paquetes> listaPaqueteCliente, string Nombre)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Model.ListaPaqueteAgendada = listaPaqueteCliente;
            this.IniciarBinding();
            this.NombrePaqueteControl.Text = Nombre;
            paquetes = new Paquetes();
        }

        private void IniciarBinding()
        {
            try
            {
                
                this.GridPaquete.AutoGenerateColumns = false;
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaPaqueteAgendada", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                paquetes = (Paquetes)GridPaquete.SelectedItem;
                paquetes.IdTipo = 4;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
