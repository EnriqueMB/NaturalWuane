using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.Business.ValueObjects;
using System.IO;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmCliente: Form
    {
        #region Propiedades Públicas
        public ClienteViewModel Model { get; set; }
        #endregion

        #region Propiedades Privadas
        private class Sexo
        {
            public string Nombre { get; set; }
            public char Id { get; set; }
            public Sexo(string N, char I)
            {
                Nombre = N;
                Id = I;
            }
        }
        #endregion

        #region Constructor
        public FrmCliente()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            groupBoxCliente.Enabled = false;
            ClaveControl.Visible = false;
            Model.IdUsuarioL = CurrentSession.IdCuentaUsuario;

            btnNuevo.Visible = CurrentSession.PermisoUsuario("4");
            btnModificar.Visible = CurrentSession.PermisoUsuario("5");
            btnEliminar.Visible = CurrentSession.PermisoUsuario("6");

            PanelCapturaDatos.Visible = CurrentSession.PermisoUsuario("4,5");
        }
        #endregion

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                NombreCompletoControl.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);
                RfcControl.DataBindings.Add("Text", Model, "Rfc", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoControl.DataBindings.Add("Text", Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaNacimientoControl.DataBindings.Add("Text", Model, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                FotoControl.DataBindings.Add("Image", Model, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
                SexoControl.DataBindings.Add("SelectedValue", Model, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
                RutaControl.DataBindings.Add("Text", Model, "ImageLocation", true, DataSourceUpdateMode.OnPropertyChanged);
                BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);
                EmailControl.DataBindings.Add("Text", Model, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
                this.sfDataGridCliente.AutoGenerateColumns = false;
                sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                this.InicializarCombo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InicializarCombo()
        {
            try
            {
                List<Sexo> ListaSexo = new List<Sexo>();
                ListaSexo.Add(new Sexo("SELECCIONE", 'S'));
                ListaSexo.Add(new Sexo("MASCULINO", 'M'));
                ListaSexo.Add(new Sexo("FEMENINO", 'F'));

                SexoControl.DataSource = ListaSexo;

                SexoControl.DisplayMember = "Nombre";
                SexoControl.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void LimpiarPropiedades()
        {
            Model.IdCliente = Guid.Empty;
            Model.NombreCompleto = string.Empty;
            Model.Email = string.Empty;
            Model.Clave = string.Empty;
            Model.Sexo = 'S';
            Model.FechaNacimiento = DateTime.Now;
            Model.Telefono = string.Empty;
            Model.Rfc = string.Empty;
            Model.Foto = Properties.Resources.imagen_subir; ;
            Model.ImageLocation = string.Empty;
        }

        private Cliente ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridCliente.SelectedItems.Count == 1)
                {
                    return (Cliente)sfDataGridCliente.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Evento
        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                await Model.GetAll();
                IniciarBinding();
                Model.Foto = Properties.Resources.imagen_subir;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ FrmCliente_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Model.State = EntityState.Create;
                groupBoxCliente.Enabled = true;
                ClaveControl.Visible = false;
                LimpiarPropiedades();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado();
            if (item != null)
            {
                groupBoxCliente.Enabled = true;
                ClaveControl.Visible = true;
                Model.State = EntityState.Update;
                Model.IdCliente = item.IdCliente;
                Model.NombreCompleto = item.NombreCompleto;
                Model.Rfc = item.Rfc;
                Model.Sexo = item.Sexo;
                Model.Telefono = item.Telefono;
                Model.Email = item.Email;
                Model.Clave = item.Clave;
                Model.FechaNacimiento = item.FechaNacimiento;
                await Model.GetFoto(Model.IdCliente);
                if (!string.IsNullOrEmpty(Model.FotoBase64))
                {
                    Model.Foto = ComprimirImagenExtensions.ImageBase64ToImage(Model.FotoBase64);
                }
                else
                    Model.ImageLocation = "Sin Foto";
                Model.FotoBase64 = string.Empty;
                await Model.GetDireciones();
            }
            else
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                groupBoxCliente.Enabled = false;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(ClienteViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        groupBoxCliente.Enabled = false;
                        await Model.GetAll();

                    }
                    else if (Resultado == 5)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorClaveExistente, TypeMessage.informacion);
                        LimpiarPropiedades();
                        groupBoxCliente.Enabled = false;
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        LimpiarPropiedades();
                        groupBoxCliente.Enabled = false;
                    }
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ClienteViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdCliente = item.IdCliente;
                        //Model.IdUsuarioL = CurrentSession.IdCuentaUsuario;
                        groupBoxCliente.Enabled = false;
                        var result = await Model.DeleteAsync();
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                            await Model.GetAll();
                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~  btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Image Files|*.png;*.jpg;*.bmp";
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                BuscarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    Model.UpdateFoto = true;
                    Model.ImageLocation = BuscarImagen.FileName;
                    var x = Model.Foto.VaryQualityLevel(35L);
                   // Bitmap bit = new Bitmap((Image)x.Clone());
                    Model.Foto = x;
                    Model.FotoBase64 = ((Image)x.Clone()).ToBase64String(x.RawFormat);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    this.groupBoxCliente.Enabled = false;
                    this.LimpiarPropiedades();
                    this.CleanErrors(errorProvider1, typeof(ClienteViewModel));
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorAlCancelarFrm, TypeMessage.error);
            }
        }

        private async void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetBusqueda();
                }
                else
                {
                    errorProvider1.SetError(BusquedaControl, "INGRESE EL CAMPO BUSQUEDA. Y NO PUEDE SER MAYOR A 200 CARACTERES");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorBusqueda, TypeMessage.error);
            }
        }

        private void BusquedaControl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.ListaCliente.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
               var item = ObtenerSeleccionado();
               if (item != null)
                {
                    if (!Convert.ToBoolean(item.TieneTarjeta))
                    {
                        FrmClaveTarjeta frmClaveTarjeta = new FrmClaveTarjeta();
                        frmClaveTarjeta.ShowDialog();
                        if (frmClaveTarjeta.DialogResult == DialogResult.OK)
                        {
                            Model.IdCliente = item.IdCliente;
                            var resul = await Model.SetMonedero(CurrentSession.IdCuentaUsuario, frmClaveTarjeta.ClaveTarjeta, 1);
                            if (resul == 1)
                            {
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                                await Model.GetAll();
                            }
                            else
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        }
                    }
                    else
                    {
                        if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, "EL cliente ya cuenta con una tarjeta. ¿Desea Cambiarla?") == DialogResult.OK)
                        {
                            FrmClaveTarjeta frmClaveTarjeta = new FrmClaveTarjeta();
                            frmClaveTarjeta.ShowDialog();
                            if (frmClaveTarjeta.DialogResult == DialogResult.OK)
                            {
                                Model.IdCliente = item.IdCliente;
                                var resul = await Model.SetMonedero(CurrentSession.IdCuentaUsuario, frmClaveTarjeta.ClaveTarjeta, 2);
                                if (resul == 1)
                                {
                                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                                    await Model.GetAll();
                                }
                                else
                                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                            }
                        }
                    }
               }
               else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDirecciones_Click(object sender, EventArgs e)
        {
            try
            {   
                    FrmDireccionesCliente frmDireccionesCliente = new FrmDireccionesCliente(Model.IdCliente, Model.NombreCompleto, Model.ListaDireccionesR);
                    frmDireccionesCliente.ShowDialog();
                    if(frmDireccionesCliente.DialogResult == DialogResult.OK)
                    {
                        Model.ListaDireccionesR = frmDireccionesCliente.ListaDirecciones;
                    }
                    frmDireccionesCliente.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
