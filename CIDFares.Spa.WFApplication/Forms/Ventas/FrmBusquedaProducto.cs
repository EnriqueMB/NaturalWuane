﻿using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
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

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmBusquedaProducto : Form
    {
        #region Propiedades Públicas
        public BusquedaProductoViewModel Model { get; set; }
        public BusqueProducto producto { get; set; }
        public int IDTipo { get; set; }
        public int TipoBusqueda { get; set; }
        #endregion

        public FrmBusquedaProducto(string compra)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<BusquedaProductoViewModel>();
            producto = new BusqueProducto();
            IniciarBinding();
            BusClaveBarraControl.CheckedChanged -= BusClaveBarraControl_CheckedChanged;
            BusClaveBarraControl.Checked = false;
            BusClaveBarraControl.CheckedChanged += BusClaveBarraControl_CheckedChanged;
            this.Model.BuscaClaveCodigo = true;
            this.ActiveControl = this.BuquedaClaveCodigoControl;
            this.BuquedaClaveCodigoControl.Focus();

            sfDataGridBuquedaProducto.Columns[5].Visible = false;
            sfDataGridBuquedaProducto.Columns[6].Visible = false;
            sfDataGridBuquedaProducto.Columns[7].Visible = false;

        }

        public FrmBusquedaProducto()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<BusquedaProductoViewModel>();
            producto = new BusqueProducto();
            IniciarBinding();
            BusClaveBarraControl.CheckedChanged -= BusClaveBarraControl_CheckedChanged;
            BusClaveBarraControl.Checked = false;
            BusClaveBarraControl.CheckedChanged += BusClaveBarraControl_CheckedChanged;
            this.Model.BuscaClaveCodigo = true;
            this.ActiveControl = this.BuquedaClaveCodigoControl;
            this.BuquedaClaveCodigoControl.Focus();
            sfDataGridBuquedaProducto.Columns[8].Visible = false;
        }

        public FrmBusquedaProducto(int tipoBusqueda)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<BusquedaProductoViewModel>();
            producto = new BusqueProducto();
            IniciarBinding();
            BusClaveBarraControl.CheckedChanged -= BusClaveBarraControl_CheckedChanged;
            BusClaveBarraControl.Checked = false;
            BusClaveBarraControl.CheckedChanged += BusClaveBarraControl_CheckedChanged;
            this.Model.BuscaClaveCodigo = true;
            this.ActiveControl = this.BuquedaClaveCodigoControl;
            this.BuquedaClaveCodigoControl.Focus();

            label1.Visible = false;
            CantidadProductoControl.Visible = false;
            BtnAgregar.Text = "Seleccionar";
            CantidadProductoControl.Visible = false;
            Model.CantidadProducto = tipoBusqueda;
            //Model.CantidadProducto = cant;
            sfDataGridBuquedaProducto.Columns[8].Visible = false;
        }

        #region Metodo

        private void IniciarBinding()
        {
            try
            {
                CantidadProductoControl.DataBindings.Add("Text", Model, "CantidadProducto", true, DataSourceUpdateMode.OnPropertyChanged);
                BusqueNombreControl.DataBindings.Add("Checked", Model, "BuscarNombre", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "BusquedaNombre", true, DataSourceUpdateMode.OnPropertyChanged);
                BuquedaClaveCodigoControl.DataBindings.Add("Text", Model, "BusquedaClaveCodigo", true, DataSourceUpdateMode.OnPropertyChanged);
                BusClaveBarraControl.DataBindings.Add("Checked", Model, "BuscaClaveCodigo", true, DataSourceUpdateMode.OnPropertyChanged);
                this.sfDataGridBuquedaProducto.AutoGenerateColumns = false;
                sfDataGridBuquedaProducto.DataBindings.Add("DataSource", Model, "ListaBusquedaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private BusqueProducto ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridBuquedaProducto.SelectedItems.Count == 1)
                {
                    return (BusqueProducto)sfDataGridBuquedaProducto.SelectedItem;
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
                if (Model.BuscaClaveCodigo == true || Model.BuscarNombre == true)
                {
                    if (!string.IsNullOrEmpty(Model.BusquedaClaveCodigo))
                    {
                        errorProvider1.Clear();
                        await Model.GetAll(CurrentSession.IdSucursal);
                        if (Model.ListaBusquedaProducto.Count == 0)
                            CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                        else if (Model.ListaBusquedaProducto.Count == 1)
                            this.AgregarRegistro();
                    }
                    else if (!string.IsNullOrEmpty(Model.BusquedaNombre))
                    {
                        errorProvider1.Clear();
                        await Model.GetAll(CurrentSession.IdSucursal);
                        if (Model.ListaBusquedaProducto.Count == 0)
                            CIDMessageBox.ShowAlert(Messages.SystemName, "LA BUSQUEDA REALIZADA NO SE ENCUENTA EN LA BASE DE DATOS.", TypeMessage.informacion);
                        else if (Model.ListaBusquedaProducto.Count == 1)
                            this.AgregarRegistro();
                    }
                    else
                        errorProvider1.SetError(ErrorControl, "TIENE QUE INGRESAR EL NOMBRE DEL PRODUCTO O CLAVE.");
                }
                else
                    errorProvider1.SetError(ErrorControl, "TIENE QUE SELECCIONAR AL MENOS UN METODO DE BUSQUEDA.");
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBusquedaProducto() ~ MetodoBuscar()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        public void AgregarRegistro()
        {
            try
            {
                if (Model.ListaBusquedaProducto.Count == 1)
                {
                    if (Model.CantidadProducto > 0)
                    {
                        var item = Model.ListaBusquedaProducto.ElementAt(0);
                        item.IdTipo = this.IDTipo = 1;
                        item.CantidadProducto = Model.CantidadProducto;
                        producto = item;
                        this.Close();
                    }
                    else
                        errorProvider1.SetError(CantidadProductoControl, "LA CANTIDAD DE PRODUCTO TIENE QUE SER MAYOR A CERO.");
                }
                else
                {
                    var item = ObtenerSeleccionado();
                    if (item != null)
                    {
                        item.IdTipo = this.IDTipo = 1;
                        item.CantidadProducto = Model.CantidadProducto;
                        if (Model.CantidadProducto > 0)
                        {
                            producto = item;
                            this.Close();
                        }
                        else
                            errorProvider1.SetError(CantidadProductoControl, "LA CANTIDAD DE PRODUCTO TIENE QUE SER MAYOR A CERO.");
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBusquedaProducto() ~ AgregarRegistro()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        #endregion

        #region Evento

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                this.MetodoBuscar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBusquedaProducto() ~ BtnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void BusqueNombreControl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (BusqueNombreControl.CheckState == CheckState.Checked)
                {
                    Model.BuscaClaveCodigo = false;
                    BusClaveBarraControl.Enabled = false;
                    BuquedaClaveCodigoControl.Enabled = false;
                }
                else
                {
                    //bloquear la busqueda por nombre 
                    Model.BuscarNombre = false;
                    BusqueNombreControl.Enabled = false;
                    NombreControl.Enabled = false;
                    Model.BusquedaNombre = string.Empty;
                    //habilitar la busqueda por codigo o clave
                    BusClaveBarraControl.Enabled = true;
                    BuquedaClaveCodigoControl.Enabled = true;
                    BusClaveBarraControl.CheckedChanged -= BusClaveBarraControl_CheckedChanged;
                    BusClaveBarraControl.Checked = true;
                    BusClaveBarraControl.CheckedChanged += BusClaveBarraControl_CheckedChanged;
                    this.Model.BuscaClaveCodigo = true;
                    this.ActiveControl = this.BuquedaClaveCodigoControl;
                    this.BuquedaClaveCodigoControl.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BusClaveBarraControl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (BusClaveBarraControl.CheckState == CheckState.Checked)
                {
                    Model.BuscarNombre = false;
                    BusqueNombreControl.Enabled = false;
                    NombreControl.Enabled = false;
                }
                else
                {
                    //bloquear la busqueda por codigo o clave
                    Model.BuscaClaveCodigo = false;
                    BusClaveBarraControl.Enabled = false;
                    BuquedaClaveCodigoControl.Enabled = false;
                    Model.BusquedaClaveCodigo = string.Empty;
                    //habilitar la busqueda  por nombre
                    BusqueNombreControl.Enabled = true;
                    NombreControl.Enabled = true;
                    BusqueNombreControl.CheckedChanged -= BusqueNombreControl_CheckedChanged;
                    BusqueNombreControl.Checked = true;
                    BusqueNombreControl.CheckedChanged += BusqueNombreControl_CheckedChanged;
                    this.Model.BuscarNombre = true;
                    this.ActiveControl = this.NombreControl;
                    this.NombreControl.Focus();
                }
            }
            catch (Exception)
            {

                throw;
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
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBusquedaProducto() ~ BtnAgregar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private void BuquedaClaveCodigoControl_KeyPress(object sender, KeyPressEventArgs e)
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBusquedaProducto() ~ BuquedaClaveCodigoControl_KeyPress(object sender, KeyPressEventArgs e)");
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmBusquedaProducto() ~ NombreControl_KeyPress(object sender, KeyPressEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void sfDataGridBuquedaProducto_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                this.AgregarRegistro();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, " FrmBusquedaProducto() ~ sfDataGridBuquedaProducto_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        #endregion

    }
}
