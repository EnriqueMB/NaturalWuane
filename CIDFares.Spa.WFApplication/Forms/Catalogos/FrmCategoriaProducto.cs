using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
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

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmCategoriaProducto : Form
    {        
        #region Propiedades Públicas
        public CategoriaProductoViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmCategoriaProducto()
        {
            InitializeComponent();           
            Model = ServiceLocator.Instance.Resolve<CategoriaProductoViewModel>();
            IniciarBinding();        
        }        
        #endregion

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dgCat.AutoGenerateColumns = false;
                dgCat.DataBindings.Add("DataSource", Model, "ListaCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LimpiarPropiedades()
        {
            gbCat.Text = "Nueva categoría";
            Model.IdCategoriaProducto = 0;
            Model.Nombre = string.Empty;
            Model.Descripcion = string.Empty;
        }

        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -1:
                        ErrorMessage = "El nombre de la forma de pago ya se encuentra en los registros";
                        break;
                    case -2:
                        ErrorMessage = "Desconocido";
                        break;
                }
                return ErrorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CategoriaProducto ObtenerSeleccionado()
        {
            try
            {
                if (dgCat.SelectedItems.Count == 1)
                {
                    return (CategoriaProducto)dgCat.SelectedItem;
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
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    CategoriaProducto Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resul.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        gbCat.Enabled = false;                        
                        dgCat.Refresh();
                        await Model.GetAllAsync();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, ObtenerMensajeError(Resul.Resultado), TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(CategoriaProductoViewModel), validationResults);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCategoriaProducto ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                gbCat.Enabled = true;
                LimpiarPropiedades();
                Model.State = EntityState.Create;
                this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
                    Model.IdCategoriaProducto = item.IdCategoriaProducto;
                    Model.Nombre = item.Nombre;
                    Model.Descripcion = item.Descripcion;
                    gbCat.Enabled = true;
                    gbCat.Text = item.Nombre;
                    Model.State = EntityState.Update;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                gbCat.Enabled = false;
                LimpiarPropiedades();
                this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado();
            if (item != null)
            {

                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                {
                    Model.IdCategoriaProducto = item.IdCategoriaProducto;
                    gbCat.Enabled = false;
                    var result = await Model.DeleteAsync();
                    if (result == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                        LimpiarPropiedades();
                        await Model.GetAllAsync();
                    }
                    else if(result == 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.CategoryIsOcuped, TypeMessage.informacion);
                        LimpiarPropiedades();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                }
            }
            else
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);                     
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            var x = this.NombreControl.SelectionStart;
            this.NombreControl.Text = this.NombreControl.Text.Replace("  ", " ");
            //this.NombreControl.Select(this.NombreControl.Text.Length, 0);
            this.NombreControl.SelectionStart = x;
        }

        private void DescripcionControl_TextChanged(object sender, EventArgs e)
        {
            var x = this.DescripcionControl.SelectionStart;
            this.DescripcionControl.Text = this.DescripcionControl.Text.Replace("  ", " ");
            this.DescripcionControl.Select(this.DescripcionControl.Text.Length, 0);
            this.DescripcionControl.SelectionStart = x;
        }
        #endregion
    }
}
