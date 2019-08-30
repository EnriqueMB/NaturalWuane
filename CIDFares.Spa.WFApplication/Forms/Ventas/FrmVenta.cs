using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using Syncfusion.WinForms.DataGrid.Styles;
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
    public partial class FrmVenta : Form
    {
        #region propiedades públicas
        public VentasViewModel Model { get; set; }
        #endregion

        #region propiedades privadas
        private Cliente cliente = new Cliente();
        #endregion

        #region Constructor
        public FrmVenta()
        {
            try
            {
                InitializeComponent();
                Model = ServiceLocator.Instance.Resolve<VentasViewModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos
        private object ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (object)sfDataGrid1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void LlenarCliente(Cliente cliente)
        {
            try
            {
                NombreControl.Text = cliente.NombreCompleto;
                TelefonoControl.Text = cliente.Telefono;
                DireccionControl.Text = cliente.Direccion;
                ClaveControl.Text = cliente.Clave;
                await Model.ModelCliente.GetFoto(cliente.IdCliente);
                if (!string.IsNullOrEmpty(Model.ModelCliente.FotoBase64))
                {
                    FotoControl.Image = ComprimirImagenExtensions.ImageBase64ToImage(Model.ModelCliente.FotoBase64);
                }
                else
                    FotoControl.Image = Properties.Resources.imagen_subir;
                Model.ModelCliente.FotoBase64 = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarCliente cliente = new FrmBuscarCliente();
                cliente.ShowDialog();
                if (cliente.cliente.IdCliente != Guid.Empty)
                    LlenarCliente(cliente.cliente);
            }
            catch(Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            FechaControl.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FrmSeleccionarPago pago = new FrmSeleccionarPago();
            pago.ShowDialog();
        }
    }
}
