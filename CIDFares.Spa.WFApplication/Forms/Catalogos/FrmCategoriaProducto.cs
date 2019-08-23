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

                this.dgmCat.AutoGenerateColumns = false;
                dgmCat.DataBindings.Add("DataSource", Model, "ListaCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        //private CategoriaProducto ObtenerSeleccionado()
        //{
        //    try
        //    {
        //        if (dgmCat.SelectedRows.Count == 1)
        //        {
        //            return dgmCat.SelectedRows;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    CategoriaProducto Resul = await Model.GuardarCambios();
                    if (Resul.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        gbCat.Enabled = false;
                        //LimpiarPropiedades();
                        dgmCat.Refresh();
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

        public void LimpiarPropiedades()
        {
            Model.IdCategoriaProducto = 0;
            Model.Nombre = string.Empty;
            Model.Descripcion = string.Empty;
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
    }
}
