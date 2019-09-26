using CIDFares.Spa.Business.ViewModels.Paquete;
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

namespace CIDFares.Spa.WFApplication.Forms.Paquete
{
    public partial class FrmAbonoPaqueteDetalle : Form
    {
        public AbonoPaqueteDetalleViewModel Model { get; set; }
        public FrmAbonoPaqueteDetalle(Guid idVentaPaquete, string NombrePaquete)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<AbonoPaqueteDetalleViewModel>();
            this.IniciarBinding();
            Model.IdVentaPaquete = idVentaPaquete;
            Model.GetAll();
            NombrePaqueteControl.Text = NombrePaquete;
        }

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                this.GridPaquete.AutoGenerateColumns = false;
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
