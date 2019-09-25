using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.WinForms.DataGrid;
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
    public partial class FrmAbonarPaquete : Form
    {
        public PaqueteViewModel Model { get; set; }
        #region propiedades privadas
        private Cliente cliente = new Cliente();
        #endregion

        public FrmAbonarPaquete()
        {
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            InitializeComponent();
            this.IniciarBinding();
            this.GridPaquete.GroupCaptionTextFormat = "{Key} - ({ItemsCount})";
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarCliente cliente = new FrmBuscarCliente();
                cliente.ShowDialog();
                if (cliente.cliente.IdCliente != Guid.Empty)
                {
                    LlenarCliente(cliente.cliente);
                    await Model.GetAllAbonoPaquete(CurrentSession.IdSucursal);
                }

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarVenta ~ btnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        #region Métodos
        private void IniciarBinding()
        {
            try
            {
                TotalControl.DataBindings.Add("Text", Model, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
                FolioClienteControl.DataBindings.Add("Text", Model, "FolioCliente", true, DataSourceUpdateMode.OnPropertyChanged);

                this.GridPaquete.AutoGenerateColumns = false;
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaAbonoPaquete", true, DataSourceUpdateMode.OnPropertyChanged);

                this.DataGridAbono.AutoGenerateColumns = false;
                DataGridAbono.DataBindings.Add("DataSource", Model, "ListaEspera", true, DataSourceUpdateMode.OnPropertyChanged);
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
                Model.IdCliente = cliente.IdCliente;
                NombreControl.Text = cliente.NombreCompleto;
                FolioClienteControl.Text = cliente.Clave;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public void ObtenerTotal()
        {
            try
            {
                Model.Total = Model.ListaEspera.Sum(x => x.PagoPaquete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado(GridPaquete);
            if (item != null)
            {
                Model.PagoPaquete = item.Adeudo;
                FrmPagarPaquete pagar = new FrmPagarPaquete(item, Model);
                pagar.ShowDialog();
                if (!pagar.EsCerrar)
                {
                    Model.ListaAbonoPaquete.Remove(pagar.paquete);
                    Model.ListaEspera.Add(pagar.paquete);
                    ObtenerTotal();
                }
            }
            else
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
        }

        private AbonoPaquete ObtenerSeleccionado(SfDataGrid grid)
        {
            try
            {
                if (grid.SelectedItems.Count == 1)
                {
                    return (AbonoPaquete)grid.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado(DataGridAbono);
            if (item != null)
            {
                Model.ListaAbonoPaquete.Add(item);
                Model.ListaEspera.Remove(item);
                ObtenerTotal();
            }
            else
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
        }

        private DataTable ObtenerDatosTabla(BindingList<AbonoPaquete> Lista)
        {
           
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdVentaPaquete", typeof(Guid));
            Tabla.Columns.Add("NumeroPago", typeof(int));
            Tabla.Columns.Add("Pago", typeof(decimal));
            Tabla.Columns.Add("PagoCompletado", typeof(bool));
            foreach (var item in Lista)
            {
                bool PagoCompletado = false;
                if (item.Adeudo == item.PagoPaquete)
                    PagoCompletado = true;

                    Tabla.Rows.Add(new object[] {
                        item.IdVentaPaquete,
                        item.NPago + 1,
                        item.PagoPaquete,
                        PagoCompletado
                    });
            }
            return Tabla;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.ListaEspera.Count > 0)
                {
                    BindingList<AbonoPaquete> ListaPaquete = (BindingList<AbonoPaquete>)DataGridAbono.DataSource;
                    Model.TablaAbonoPaquete = ObtenerDatosTabla(ListaPaquete);
                    FrmSeleccionarPago pago = new FrmSeleccionarPago(Model);
                    pago.ShowDialog();
                    if(pago.resultado)
                    {
                        LimpiarPropiedades();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName,Messages.ErrorMessage, TypeMessage.informacion);
                }
                else
                CIDMessageBox.ShowAlert(Messages.SystemName,"AGREGUE UN PAQUETE A ABONAR", TypeMessage.informacion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void LimpiarPropiedades()
        {
            try
            {
                Model.Total = 0;
                Model.ListaEspera.Clear();
                Model.ListaAbonoPaquete.Clear();
                await Model.GetAllAbonoPaquete(CurrentSession.IdSucursal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado(GridPaquete);
                if (item != null)
                {
                    FrmAbonoPaqueteDetalle detalle = new FrmAbonoPaqueteDetalle(item.IdVentaPaquete, item.NombrePaquete);
                    detalle.ShowDialog();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
