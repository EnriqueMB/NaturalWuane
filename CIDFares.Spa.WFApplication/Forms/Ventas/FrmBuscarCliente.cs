using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmBuscarCliente : Form
    {
        #region Propiedades públucas
        public ClienteViewModel Model { get; set; }
        public Cliente cliente { get; set; }
        #endregion

        #region Contructor
        public FrmBuscarCliente()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            cliente = new Cliente();
        }
        #endregion

        #region Métodos
        private void IniciarBinding()
        {
            try
            {
                this.sfDataGridCliente.AutoGenerateColumns = false;
                sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
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
                if (sfDataGridCliente.SelectedItems.Count == 1)
                {
                    return (Cliente)sfDataGridCliente.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                this.IniciarBinding();
            }
            catch(Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ FrmBuscarCliente_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    cliente = item;
                    this.Close();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.error);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            
        }
        #endregion
    }
}
