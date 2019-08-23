using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
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

        private CategoriaProducto ObtenerSeleccionado()
        {
            try
            {
                if (dgmCat.SelectedRows.Count == 1)
                {
                    return dgmCat.SelectedRows;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(CategoriaProductoViewModel));
                var validationResults = Model.ValValidate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    FormaPago Resultado = await Model.GuardarCambios();
                    if (Resultado.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Constants.SystemName, Constants.SuccessMessage, TypeMessage.correcto);
                        grpBoxFormaPago.Enabled = false;
                        LimpiarPropiedades();
                        GridFromaPago.Refresh();
                        await Model.GetAllAsync();
                    }
                    else
                        CIDMessageBox.ShowAlert(Constants.ErrorMessage, ObtenerMensajeError(Resultado), TypeMessage.error);
                    MessageBox.Show("ERROR");
                }
                else
                    this.ShowErrors(errorProviderNacionalidad, typeof(Nacionalidad), validationResults);

            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "FrmNacionalidad ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Constants.SystemName, Constants.ErrorMessage, TypeMessage.error);
            }

        }
    }
}
