using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmSelectCliente : Form
    {
        #region Propiedades
        public OpcionesViewModel Model { get; set; }
        public Cliente cliente { get; set; }
        #endregion

        #region constructor
        public FrmSelectCliente()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            cliente = new Cliente();
            dtgClientes.ShowGroupDropArea = false;
        }
        #endregion

        #region Eventos
        private async void FrmSelectCliente_Load(object sender, EventArgs e)
        {
            await Model.GetAll();
            IniciarBinding();
        }
        private void DtgClientes_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    cliente = item;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmSelectCliente ~ DtgClientes_CellDoubleClick(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        #region metodos
        private void IniciarBinding()
        {
            try
            {                
                this.dtgClientes.AutoGenerateColumns = false;
                dtgClientes.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);           
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Cliente ObtenerSeleccionado()
        {
            try
            {
                if (dtgClientes.SelectedItems.Count == 1)
                {
                    return (Cliente)dtgClientes.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

      
    }
}
