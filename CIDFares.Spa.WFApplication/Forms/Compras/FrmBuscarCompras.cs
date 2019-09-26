using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Compras;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
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

namespace CIDFares.Spa.WFApplication.Forms.Compras
{
    public partial class FrmBuscarCompras : Form
    {
        #region Propiedades Publicas
        public ComprasViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmBuscarCompras()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ComprasViewModel>();
            dataGridBuscarCompras.ShowGroupDropArea = false;
            this.dataGridBuscarCompras.GroupCaptionTextFormat = "{Key} - {ItemsCount}";
            this.dataGridBuscarCompras.GroupColumnDescriptions.Add(new GroupColumnDescription()
            {
                ColumnName = "FechaCompra",
                KeySelector = (string ColumnName, object o) =>
                {
                    var dt = DateTime.Now;
                    var item = (o as Compra).FechaCompra;
                    return item.ToShortDateString();
                }

            });
            Model.FechaInicio = DateTime.Now;
            Model.FechaFin = DateTime.Now;
        }

        #endregion

        #region Metodo
        private void IniciarBinding()
        {
            try
            {
                this.ClaveControl.DataBindings.Add("Text", Model, "Folio", true, DataSourceUpdateMode.OnPropertyChanged);
                this.dtpFechaInicioControl.DataBindings.Add("Value", Model, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
                this.dtpFechaFinControl.DataBindings.Add("Value", Model, "FechaFin", true, DataSourceUpdateMode.OnPropertyChanged);
                this.dataGridBuscarCompras.AutoGenerateColumns = false;
                this.dataGridBuscarCompras.DataBindings.Add("DataSource", Model, "ListaCompra", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Compra ObtenerSeleccionado()
        {
            try
            {
                if (dataGridBuscarCompras.SelectedItems.Count == 1)
                {
                    return (Compra)dataGridBuscarCompras.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SeleccionarRegistro()
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.IdCompra = item.IdCompra;
                    Model.Folio = item.Folio;
                    Model.ModelProveedor.Clave = item.ProveedorCompra.Clave;
                    this.Close();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
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
                errorProvider1.Clear();
                await Model.ObtenerComprasCreadas(CurrentSession.IdSucursal);
                if (Model.ListaCompra.Count == 0)
                    CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                else if (Model.ListaCompra.Count == 1)
                    this.AgregarRegistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarRegistro()
        {
            try
            {
                if (Model.ListaCompra.Count == 1)
                {
                    var firstItem = Model.ListaCompra.ElementAt(0);
                    var item = firstItem;
                    Model.IdCompra = item.IdCompra;
                    Model.Folio = item.Folio;
                    this.Close();
                }
                else
                {
                    SeleccionarRegistro();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Eventos
        private async void FrmBuscarCompras_Load(object sender, EventArgs e)
        {
            try
            {
                this.IniciarBinding();
                await Model.ObtenerComprasCreadas(CurrentSession.IdSucursal);
                this.ActiveControl = this.ClaveControl;
                this.ClaveControl.Focus();
                this.rbBusquedaClave.Checked = true;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarCompras() ~ FrmBuscarCompras_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.SeleccionarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarCompras() ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void DataGridBuscarCompras_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                this.SeleccionarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBuscarCompras() ~ DataGridBuscarCompras_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void ClaveControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(Model.Folio))
                    {
                        this.MetodoBuscar();
                    }                  
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarCompras() ~ ClaveControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }
        #endregion

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbBusquedaClave.Checked == true)
                {
                    if (!string.IsNullOrEmpty(Model.Folio))
                        this.MetodoBuscar();
                    else
                    {
                        Model.Folio = string.Empty;
                        this.MetodoBuscar();
                    }
                }
                if (rbBusquedaFecha.Checked == true)
                {
                    if (this.dtpFechaInicioControl.Value.CompareTo(this.dtpFechaFinControl.Value) == 1)
                    {
                        errorProvider1.SetError(dtpFechaFinControl, "LA FECHA FIN NO PUEDE SER MENOS A LA FECHA INICIO.");
                    }
                    else
                    {
                        errorProvider1.Clear();
                        Model.Folio = null;
                        this.MetodoBuscar();
                    }                   
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarCompras() ~ ClaveControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }
    }
}
