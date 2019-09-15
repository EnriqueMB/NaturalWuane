using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Ventas;
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

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmProductosMonedero : Form
    {
        #region Propiedades
        public ProductosMonederoViewModel Model { get; set; }
        #endregion
        public FrmProductosMonedero()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProductosMonederoViewModel>();
        }

        private void LimpiarPropiedades()
        {
            Model.IdProducto = 0;
            Model.PuntosMonedero = 0;
            Model.AplicaDescuento = false;
            Model.PuntosDescuento = 0;
            Model.EsMonto = false;
            Model.Monto = 0;
        }
        private void IniciarBinding()
        {
            try
            {
                PuntosMonederoControl.DataBindings.Add("Text", Model, "PuntosMonedero", true, DataSourceUpdateMode.OnPropertyChanged);
                AplicaDescuentoControl.DataBindings.Add("Checked", Model, "AplicaDescuento", true, DataSourceUpdateMode.OnPropertyChanged);
                PuntosDescuentoControl.DataBindings.Add("Text", Model, "PuntosDescuento", true, DataSourceUpdateMode.OnPropertyChanged);
                EsMontoControl.DataBindings.Add("Checked", Model, "EsMonto", true, DataSourceUpdateMode.OnPropertyChanged);
                MontoControl.DataBindings.Add("Text", Model, "Monto", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                FrmBusquedaProducto Producto = new FrmBusquedaProducto(1);
                Producto.ShowDialog();
                if (Producto.producto.IdProducto != 0)
                {
                    IdProductoControl.Text = Producto.producto.Nombre;
                    Model.IdProducto = Producto.producto.IdProducto;
                    await Model.GetPuntosMonedero();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmProductosMonedero_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            DescuentoGroup.Enabled = AplicaDescuentoControl.Checked;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(ProductosMonederoViewModel));
                var ValidationsResult = Model.Validate();
                if (ValidationsResult.IsValid)
                {
                    int result = 0;
                    result = await Model.AddPuntosProducto(CurrentSession.IdCuentaUsuario);
                    if (result > 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ProductosMonederoViewModel), ValidationsResult);
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

        private void AplicaDescuentoControl_CheckedChanged(object sender, EventArgs e)
        {
            DescuentoGroup.Enabled = AplicaDescuentoControl.Checked;
        }

        private void EsMontoControl_CheckedChanged(object sender, EventArgs e)
        {
            if (EsMontoControl.Checked)
                lbTipoDescuento.Text = "$";
            else
                lbTipoDescuento.Text = "%";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
