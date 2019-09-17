using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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
        public FrmCapturaCitaNuevo(DateTime? fecha)
        {
            InitializeComponent();
            lblTitle.Text = Convert.ToDateTime(fecha).ToString("dddd, dd MMMM yyyy").ToUpper();
            Model = ServiceLocator.Instance.Resolve<CapturaCitaViewModel>();
            Model.GetCitaDetalle(fecha);                        
        }

        public FrmCapturaCitaNuevo(Guid IdCuenta, DateTime? fech)
        {
            InitializeComponent();
            lblTitle.Text = Convert.ToDateTime(fech).ToString("dddd, dd MMMM yyyy").ToUpper();
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

        private void IniciarBinding()
        {
            try
            {
                this.dgmCita.AutoGenerateColumns = false;
                dgmCita.DataBindings.Add("DataSource", Model, "ListaCapturaCitaDetalle", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void FrmCapturaCitaNuevo_Load(object sender, EventArgs e)
        {
            IniciarBinding();            
        }

        private CapturaCita ObtenerSeleccionado()
        {
            try
            {
                if (dgmCita.SelectedItems.Count == 1)
                {
                    return (CapturaCita)dgmCita.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbCita.Enabled = true;
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FrmBuscarCliente f = new FrmBuscarCliente();
            f.ShowDialog();
            Model.IdCliente = f.cliente.IdCliente;
            ClienteControl.Text = f.cliente.NombreCompleto;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnBuscarServicio_Click_1(object sender, EventArgs e)
        {
            FrmBuscarServicio bs = new FrmBuscarServicio();
            bs.ShowDialog();
            //Model.IdCliente = f.cliente.IdCliente;
            //tbCliente.Text = f.cliente.NombreCompleto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.State = EntityState.Update;
                    gbCita.Enabled = true;
                    //gbCita.Text = item.NombreCompleto;
                    ClienteControl.Text = item.NombreCompleto;
                    //Model.GetAllAsync(); Metodo que carga datos
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CitaSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {            
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbCita.Enabled = false;
            ClienteControl.Text = string.Empty;
        }
    }
}
