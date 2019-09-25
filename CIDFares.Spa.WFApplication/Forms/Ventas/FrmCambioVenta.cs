using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
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
    public partial class FrmCambioVenta : Form
    {
        #region Propiedades Publicas

        private CambioVenta Datos { get; set; }
        public CambioVentaViewModel Model { get; set; }

        #endregion

        #region Metodos
        public FrmCambioVenta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CambioVentaViewModel>();
            IniciarBinding();
        }

        public void LimpiarPropiedades()
        {
            Model.CambioTurno = 0;
        }

        #endregion
        private void IniciarBinding()
        {
            try
            {
                CambioTurnoControl.DataBindings.Add("Text", Model, "CambioTurno", true, DataSourceUpdateMode.OnPropertyChanged);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #region eventos
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProviderCambio, typeof(CambioVentaViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    Model.State = EntityState.Update;
                    CambioVenta Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal, CurrentSession.IdEmpleado, CurrentSession.IdTurnoEmpleado);
                    if (Resultado.Resultado == 1)
                    {

                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        this.Close();
                        btnGuardar.Enabled = false;
                  
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProviderCambio, typeof(CambioVentaViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCambioVenta ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }

            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        #endregion

        private void CambioTurnoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
