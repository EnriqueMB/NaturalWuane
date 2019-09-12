using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Citas
{
    public partial class FrmCapturaCitaNuevo : Form
    {
        #region Propiedades Públicas
        public CapturaCitaViewModel Model { get; set; }
        public CapturaCita cita { get; set; }
        #endregion
        public FrmCapturaCitaNuevo()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
        }

        public FrmCapturaCitaNuevo(Guid idCita)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
        }

        #region Métodos
        public void LimpiarPropiedades()
        {
            Model.IdCita = Guid.Empty;
            Model.IdCliente = Guid.Empty;
            Model.IdEstadoCita = 0;
            Model.NombreCompleto = string.Empty;
            Model.Observaciones = string.Empty;
            Model.FechaCita = DateTime.MinValue;            
        }

        #endregion

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente f = new FrmBuscarCliente();
            f.ShowDialog();
            Model.IdCliente = f.cliente.IdCliente;
            tbCliente.Text = f.cliente.NombreCompleto;
            //Model.State = EntityState.Create;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            FrmBuscarServicio bs = new FrmBuscarServicio();
            bs.ShowDialog();
            //Model.IdCliente = f.cliente.IdCliente;
            //tbCliente.Text = f.cliente.NombreCompleto;
        }
    }
}
