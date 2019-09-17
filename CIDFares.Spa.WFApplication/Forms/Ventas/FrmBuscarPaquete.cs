using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmBuscarPaquete : Form
    {
        #region Propiedades Públicas
        public PaqueteViewModel Model { get; set; }
        public int IDTipo { get; set; }
        public Paquetes paquetes { get; set; }
        #endregion

        #region Contructor

        public FrmBuscarPaquete()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            paquetes = new Paquetes();
        }
        #endregion
        
        #region Metodos

        private void IniciarBinding()
        {
            try
            {
                BandClaveControl.DataBindings.Add("Checked", Model, "BandClave", true, DataSourceUpdateMode.OnPropertyChanged);
                BuquedaClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);

                BandNombreControl.DataBindings.Add("Checked", Model, "BandNombre", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);

                CantidadServicioControl.DataBindings.Add("Text", Model, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);

                this.sfDataGridPaquete.AutoGenerateColumns = false;
                sfDataGridPaquete.DataBindings.Add("DataSource", Model, "ListaPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Paquetes ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridPaquete.SelectedItems.Count == 1)
                {
                    return (Paquetes)sfDataGridPaquete.SelectedItem;
                }
                return null;
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
                if (Model.BandClave == true || Model.BandNombre == true)
                {
                    if (!string.IsNullOrEmpty(Model.Clave))
                    {
                        errorProvider1.Clear();
                        await Model.BusquedaPaquete();
                        if (Model.ListaPaquete.Count == 0)
                            CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                        else if (Model.ListaPaquete.Count == 1)
                            this.AgregarRegistro();
                    }
                    else if (!string.IsNullOrEmpty(Model.Nombre))
                    {
                        errorProvider1.Clear();
                        await Model.BusquedaPaquete();
                        if (Model.ListaPaquete.Count == 0)
                            CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                        else if (Model.ListaPaquete.Count == 1)
                            this.AgregarRegistro();
                    }
                    else
                        errorProvider1.SetError(ErrorControl, "TIENE QUE INGRESAR EL NOMBRE DEL SERVICIO O CLAVE.");
                }
                else
                    errorProvider1.SetError(ErrorControl, "TIENE QUE SELECCIONAR AL MENOS UN METODO DE BUSQUEDA.");
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
                if (Model.ListaPaquete.Count == 1)
                {
                    var firstItem = Model.ListaPaquete.ElementAt(0);
                    var item = firstItem;
                    item.IdTipoServicio = this.IDTipo = 3;
                    item.CantidadServicio = 1;
                    paquetes = item;
                    this.Close();
                }
                else
                {
                    var item = ObtenerSeleccionado();
                    if (item != null)
                    {
                        item.IdTipoServicio = this.IDTipo = 3;
                        item.CantidadServicio = Model.Cantidad;
                        if (item.CantidadServicio > 0)
                        {
                            paquetes = item;
                            this.Close();
                        }
                        else
                            errorProvider1.SetError(CantidadServicioControl, "LA CANTIDAD DE SERVICIO TIENE QUE SER MAYOR A CERO.");
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void FrmBuscarPaquete_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                BandClaveControl.CheckedChanged -= BandClaveControl_CheckedChanged;
                BandClaveControl.Checked = false;
                BandClaveControl.CheckedChanged += BandClaveControl_CheckedChanged;
                this.Model.BandClave = true;
                this.ActiveControl = this.BuquedaClaveControl;
                this.BuquedaClaveControl.Focus();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ FrmBuscarServicio_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private void BandClaveControl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (BandClaveControl.CheckState == CheckState.Checked)
                {
                    //Model.BandNombre = false;
                    BandNombreControl.Enabled = false;
                    NombreControl.Enabled = false;
                }
                else
                {
                    //habilitar la busqueda por nombre
                    BandNombreControl.Enabled = true;
                    NombreControl.Enabled = true;
                    this.ActiveControl = this.NombreControl;
                    this.NombreControl.Focus();
                    BandNombreControl.CheckedChanged -= BandNombreControl_CheckedChanged;
                    BandNombreControl.Checked = false;
                    BandNombreControl.CheckedChanged += BandNombreControl_CheckedChanged;
                    Model.BandNombre = true;
                    //bloquear la busqueda por clave
                    //Model.BandClave = false;
                    BandClaveControl.Enabled = false;
                    BuquedaClaveControl.Enabled = false;
                    Model.Clave = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ BandClaveControl_CheckedChanged(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private void BandNombreControl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (BandNombreControl.CheckState == CheckState.Checked)
                {
                    //Model.BandClave = false;
                    BandClaveControl.Enabled = false;
                    BuquedaClaveControl.Enabled = false;
                }
                else
                {
                    //habilitar la busqueda por codigo o clave
                    BandClaveControl.Enabled = true;
                    BuquedaClaveControl.Enabled = true;
                    this.ActiveControl = this.BuquedaClaveControl;
                    this.BuquedaClaveControl.Focus();
                    BandClaveControl.CheckedChanged -= BandClaveControl_CheckedChanged;
                    BandClaveControl.Checked = false;
                    BandClaveControl.CheckedChanged += BandClaveControl_CheckedChanged;
                    Model.BandClave = true;
                    //    Model.BandClave = true;
                    //bloquear la busqueda por nombre 
                    // Model.BandNombre = false;
                    BandNombreControl.Enabled = false;
                    NombreControl.Enabled = false;
                    Model.Nombre = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ BandNombreControl_CheckedChanged(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoBuscar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ btnBuscar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.AgregarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ BtnAgregar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private void BuquedaClaveControl_KeyPress(object sender, KeyPressEventArgs e)
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
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ BuquedaClaveControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void NombreControl_KeyPress(object sender, KeyPressEventArgs e)
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
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ BuquedaClaveControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void sfDataGridPaquete_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                this.AgregarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBuscarServicio() ~ sfDataGridBusqServicio_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        #endregion
        
    }
}
