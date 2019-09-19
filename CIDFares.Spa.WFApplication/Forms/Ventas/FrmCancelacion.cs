using CIDFares.Library.Code.Extensions;
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
    public partial class FrmCancelacion : Form
    {
        #region Propiedades Publicas
        public CancelacionVentaViewModel Model { get; set; }
        public VentasViewModel Model1 { get; set; }
        #endregion

        #region Constructor
        public FrmCancelacion()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CancelacionVentaViewModel>();
            Model1 = ServiceLocator.Instance.Resolve<VentasViewModel>();
            dataGridsfDetalleVenta.ShowGroupDropArea = false;
            this.dataGridsfDetalleVenta.GroupCaptionTextFormat = "{Key} - {ItemsCount}";
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                this.ClaveControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);
                this.MotivoControl.DataBindings.Add("Text", Model, "Motivo", true, DataSourceUpdateMode.OnPropertyChanged);
                this.dataGridsfDetalleVenta.AutoGenerateColumns = false;
                dataGridsfDetalleVenta.DataBindings.Add("DataSource", Model, "ListaVentaDetalle", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async void DetalleVenta()
        {
            try
            {
                await Model.GetAllxID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LimpiarDatos()
        {
            try
            {
                Model.ListaVentaDetalle.Clear();
                Model.Folio = string.Empty;
                Model.IdVenta = Guid.Empty;
                Model.Motivo = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async void MetodoBuscar()
        {
            try
            {
                Model1.FechaVenta = DateTime.Now;
                Model1.IdSucursal = CurrentSession.IdSucursal;
                Model1.Folio = Model.Folio;
                await Model1.GetVentaFechaDiaIdSucursal();
                if (Model1.Listaventa.Count == 0)
                { 
                    CIDMessageBox.ShowAlert(Messages.SystemName, "VERIFICAR QUE LA EL TICKET SEA DEL DIA. GRACIAS.", TypeMessage.informacion);
                }
                else
                {
                    if (Model1.Listaventa.Count == 1)
                    {
                        Model1.Listaventa.Select(u =>
                        {
                            Model.IdVenta = u.IdVenta;
                            return u;
                        }).ToList();
                        DetalleVenta();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos
        private void FrmCancelacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = this.ClaveControl;
                this.ClaveControl.Focus();
                IniciarBinding();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion() ~ FrmCancelacion_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarVentas cancelacion = new FrmBuscarVentas();
                cancelacion.ShowDialog();
                if (cancelacion.Model.Listaventa.Count == 0)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, "NO HAY VENTAS DEL DIAS VERIFIQUE SU FECHA. GRACIAS", TypeMessage.informacion);
                }
                else
                {
                    if (cancelacion.Model.IdVenta != Guid.Empty)
                    {
                        ClaveControl.Text = cancelacion.Model.Folio;
                        Model.IdVenta = cancelacion.Model.IdVenta;
                        DetalleVenta();
                        // LLenarGrid2(Producto.producto, IdTipo);
                        //LLenarGrid(Producto.producto);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion() ~ BtnVentas_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(CancelacionVentaViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    VentasCancelaciones x = await Model.GuardarCancelacion(CurrentSession.IdCuentaUsuario);
                    if (x.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarDatos();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(CancelacionVentaViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion() ~ BtnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoBuscar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion() ~ BtnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void ClaveControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    MetodoBuscar();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion()  ~ ClaveControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmOutMessage) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCancelacion() ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion  
    }
}
