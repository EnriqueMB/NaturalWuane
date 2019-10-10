using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
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
        public PaquetesClienteViewModel Model { get; set; }
        public OrdenPaquete orden_paquete { get; set; }

        public FrmPaquetesCliente(Guid idCliente)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaquetesClienteViewModel>();
            this.IniciarBinding();
            orden_paquete = new OrdenPaquete();
            Model.IdCliente = idCliente;
            Model.GetAllAsync(CurrentSession.IdSucursal);
        }

        private void IniciarBinding()
        {
            try
            {
                this.dgmPaquetes.AutoGenerateColumns = false;
                dgmPaquetes.DataBindings.Add("DataSource", Model, "ListaOrdenServicio", true, DataSourceUpdateMode.OnPropertyChanged);
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
                //paquetes = (Paquetes)GridPaquete.SelectedItem;
                //paquetes.IdTipo = 4;
                //this.Close();
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
        private OrdenServicio ObtenerSeleccionado()
        {
            try
            {
                if (dgmPaquetes.SelectedItems.Count == 1)
                {
                    return (OrdenServicio)dgmPaquetes.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    OrdenPaquete op = new OrdenPaquete();
                    op.IdOrdenPaquete = item.OrdenPaquete.IdOrdenPaquete;
                    op.Paquete.Nombre = item.OrdenPaquete.Paquete.Nombre;
                    op.Paquete.IdPaquete = item.OrdenPaquete.Paquete.IdPaquete;
                    op.Paquete.IdTipo = 3;
                    op.Paquete.MontoPaquete = item.OrdenPaquete.Paquete.MontoPaquete;
                    op.Paquete.CantidadServicio = 1;
                    orden_paquete = op;
                    this.Close();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.error);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaquetesCliente ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
