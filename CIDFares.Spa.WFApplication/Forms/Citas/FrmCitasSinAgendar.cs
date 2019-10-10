using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Citas;
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

namespace CIDFares.Spa.WFApplication.Forms.Citas
{
    public partial class FrmCitasSinAgendar : Form
    {
        public CitasSinAgendarViewModel Model { get; set;}
        public CapturaCita capturaCita { get; set; }

        public FrmCitasSinAgendar()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CitasSinAgendarViewModel>();
            capturaCita = new CapturaCita();
        }

        #region Métodos
        private void IniciarBinding()
        {
            try
            {
                BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);
                this.dgmCitasSinAgendar.AutoGenerateColumns = false;
                dgmCitasSinAgendar.DataBindings.Add("DataSource", Model, "ListaCitasSinAgendar", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CapturaCita ObtenerSeleccionado()
        {
            try
            {
                if (dgmCitasSinAgendar.SelectedItems.Count == 1)
                {
                    return (CapturaCita)dgmCitasSinAgendar.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetCitasSinAgendar(Model.Busqueda, CurrentSession.IdSucursal);
                    //sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    // errorProvider1.SetError(BusquedaControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 200 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCitasSinAgendar ~ btnBuscar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void FrmCitasSinAgendar_Load(object sender, EventArgs e)
        {
            try
            {
                this.IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCitasSinAgendar ~ FrmCitasSinAgendar_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    capturaCita = item;
                    this.Close();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.error);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCitasSinAgendar ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void BusquedaControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar.PerformClick();
            }
        }

        private void dgmCitasSinAgendar_DoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            //btnGuardar_Click(sender, e);
        }

        private void dgmCitasSinAgendar_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            btnSeleccionar_Click(sender, e);
        }
    }
}
