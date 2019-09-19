using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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
    public partial class FrmBuscarVentas : Form
    {
        #region propiedades públicas
        public VentasViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmBuscarVentas()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<VentasViewModel>();
            IniciarBinding();
            Model.IdSucursal = CurrentSession.IdSucursal;
            Model.FechaVenta = DateTime.Now;
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                this.dataGridsfBVentas.AutoGenerateColumns = false;
                dataGridsfBVentas.DataBindings.Add("DataSource", Model, "Listaventa", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Venta ObtenerSeleccionado()
        {
            try
            {
                if (dataGridsfBVentas.SelectedItems.Count == 1)
                {
                    return (Venta)dataGridsfBVentas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SeleccionarRegistro()
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.IdVenta = item.IdVenta;
                    Model.Folio = item.Folio;
                    this.Close();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos
        private async void FrmBuscarVentas_Load(object sender, EventArgs e)
        {
            try
            {
                await Model.GetVentaFechaDiaIdSucursal();
                if (Model.Listaventa.Count == 0)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVentas() ~ FrmBuscarVentas_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.SeleccionarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private void DataGridsfBVentas_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                this.SeleccionarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ DataGridsfBVentas_CellDoubleClick");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion
    }
}
