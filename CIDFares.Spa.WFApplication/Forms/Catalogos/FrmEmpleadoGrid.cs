using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDMessageBox.Forms;
using CIDFares.Library.Controls.CIDWait.Code;
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
    public partial class FrmEmpleadoGrid : Form
    {
        #region Propiedades Publicas

        public EmpleadoViewModel Model { get; set; }

        public FrmMessageBox mensaje { get; set; }

        #endregion
        public FrmEmpleadoGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EmpleadoViewModel>();
        }

        #region Metodos
        private void IniciarBinding()
        {
            this.sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataBindings.Add("DataSource", Model, "ListaEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);

           // BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void CargarDatosAsync()
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.CargarDatos();
                    await Task.Delay(2000);
                }, "Espere");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Empleado ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (Empleado)sfDataGrid1.SelectedItem;
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

        private void FrmEmpleadoGrid_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosAsync();
                IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleadoGrid_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                Close();
            }

        }

        #endregion

    }
}
