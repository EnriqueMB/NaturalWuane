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
using CIDFares.Library.Controls.CIDWait.Code;
using Syncfusion.WinForms.Controls;
using System.Configuration;

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
        public string ClaveAux { get; set; }
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

            Model.Page = -1;
            Model.Opcion = 1;
            this.btnDirecciones.FlatAppearance.BorderSize = 1;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 1;
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
                RutaImagenControl.DataBindings.Add("Text", Model, "RutaImagen", true, DataSourceUpdateMode.OnPropertyChanged);
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
            Model.Foto = Properties.Resources.imagen_subir;
            Model.RutaImagen = string.Empty;
            Model.RutaAux = string.Empty;
            Model.ListaDireccionesR.Clear();
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

        private void CargarGrid()
        {
            try
            {
                if (Model.Opcion == 1)
                    Model.Page++;
                CIDWait.Show(async () =>
                {
                    await Model.GetAll();
                }, "Espere");
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
                //await Model.GetAll();
                //IniciarBinding();
                //Model.Foto = Properties.Resources.imagen_subir;
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
            try
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
                    ClaveAux = Model.Clave;
                    Model.FechaNacimiento = item.FechaNacimiento;
                    Model.UrlFoto = item.UrlFoto;
                    CargarImagen();
                    //await Model.GetFoto(Model.IdCliente);
                    //if (!string.IsNullOrEmpty(Model.FotoBase64))
                    //{
                    //    Model.Foto = ComprimirImagenExtensions.ImageBase64ToImage(Model.FotoBase64);
                    //}
                    //else
                    //    Model.ImageLocation = "Sin Foto";
                    //Model.FotoBase64 = string.Empty;
                    await Model.GetDireciones();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                    groupBoxCliente.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void CargarImagen()
        {
            try
            {
                //Creamos la ruta para guardar las fotos si no existe
                string ruta = Path.Combine(Application.StartupPath + @"\Resources\imgClientes\");
                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);
                if (Model.UrlFoto != "" && Model.UrlFoto != null)
                {
                    string User = ConfigurationManager.AppSettings.Get("UsuarioFtpTxt");
                    string pass = ConfigurationManager.AppSettings.Get("ContraseñaFtpTxt");
                    Model.Extencion = Path.GetExtension(Model.UrlFoto);//Obtenemos la Extencion del archivo
                    Model.RutaAux = Path.Combine(Application.StartupPath + @"\Resources\imgClientes\" + Model.Clave + Model.Extencion);//Creamos la ruta para guardar la imagen
                    
                    

                    //Verificamos que la imagen no exista, si existe la borramos.
                    if (File.Exists(Model.RutaAux))
                    {
                        File.Delete(Model.RutaAux);//Borramos la imagen.
                    }

                    CIDWait.Show(async () =>
                    {
                        //Descargamos la imagen del Servidor FTP a Resources
                        await Model.DownloadFile(Model.RutaAux, Model.UrlFoto, User, pass);
                    }, "Espere");

                    if (!File.Exists(Model.RutaAux))
                    {
                        //Mensage de error en caso que no se haya obtenido la imagen.
                        CIDMessageBox.ShowAlert(Messages.SystemName, "NO SE PUEDO OBTENER LA IMAGEN", TypeMessage.informacion);
                    }
                    else
                    {
                        CIDWait.Show(async () =>
                        {
                            Model.RutaImagen = Model.RutaAux;
                            var x = Image.FromFile(Model.RutaAux);
                            var y = await Model.Convertir_Imagen_Bytes(x);
                            x.Dispose();
                            Model.Foto = await Model.Convertir_Bytes_Imagen(y);
                            Model.UrlFoto = ConfigurationManager.AppSettings.Get("ServerFtpTxt") + "/imgCliente/";
                        }, "Espere");
                        
                    }
                }
                else
                {
                    Model.RutaImagen = "SIN FOTO";
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPaqueteNuevo() ~ CargarImagen()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridCliente.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                this.CleanErrors(errorProvider1, typeof(ClienteViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    //int result = Convert.ToInt32(Resultado);
                    if (Convert.ToInt32(Resultado) > 0 )
                    {
                        if (Model.UpdateImagen)
                        {
                            bool subir = false;
                            CIDWait.Show(async () =>
                            {
                                //Subimos la imagen al Servidor FTP
                                subir = await Model.UploadFTP(Model.RutaImagen,
                                        ConfigurationManager.AppSettings.Get("ServerFtpTxt") + @"/imgCliente/" + Model.Clave + Model.Extencion,
                                        ConfigurationManager.AppSettings.Get("UsuarioFtpTxt"),
                                        ConfigurationManager.AppSettings.Get("ContraseñaFtpTxt"));
                            }, "Espere");

                            if (!subir)
                            {
                                //Mensaje de avertencia que la imagen no se pudo cargar
                                CIDMessageBox.ShowAlert(Messages.SystemName, "NO SE PUDO SUBIR LA IMAGEN", TypeMessage.informacion);

                            }
                        }
                        Model.UpdateImagen = false;
                        if (Model.RutaAux != "" && Model.RutaAux != null)
                            File.Delete(Model.RutaAux);//Borramos la imagen desde la carpeta RESOURCES
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        groupBoxCliente.Enabled = false;
                        Model.Opcion = 2;
                        CargarGrid();
                        x.ValueChanged += X_ValueChanged;

                    }
                    else if (Convert.ToInt32(Resultado) == 5)
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
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridCliente.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
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
                            Model.Opcion = 2;
                            CargarGrid();
                            x.ValueChanged += X_ValueChanged;
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
                    CIDWait.Show(async () =>
                    {
                        Model.Foto = null;
                        Model.UpdateImagen = true;
                        Model.Extencion = Path.GetExtension(BuscarImagen.FileName);//Obtenemos la extención de la imagen.
                        Model.RutaImagen = BuscarImagen.FileName; //Guardamos la ruta de la imagen.
                        var x = Image.FromFile(Model.RutaImagen).VaryQualityLevel(35L);//Almacenamos la imagen creada en una variable(Imagen).
                        var y = await Model.Convertir_Imagen_Bytes(x); //Mandamos la variable para convertirla a bytes.
                        x.Dispose();
                        Model.Foto = await Model.Convertir_Bytes_Imagen(y); //Le pasamos la imagen convertida a la propiedad Imagen del modelo para mostrarlo en el formulario.
                        Model.UrlFoto = ConfigurationManager.AppSettings.Get("ServerFtpTxt") + "/imgCliente/";
                    }, "Espere");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    if (Model.RutaAux != "" && Model.RutaAux != null)
                        File.Delete(Model.RutaAux);//Borramos la imagen desde la carpeta RESOURCES
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
                    errorProvider1.Clear();
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
                errorProvider1.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async void btnClienteFrecuente_Click(object sender, EventArgs e)
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnClienteFrecuente_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        #endregion

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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnDirecciones_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridCliente.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged += X_ValueChanged;
                CargarGrid();
                IniciarBinding();
                Model.Foto = Properties.Resources.imagen_subir;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ FrmCliente_Shown(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Evento que detecta cada movimiento del Scroll Vertical del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Syncfusion.WinForms.DataGrid.TableControl tableControl = sfDataGridCliente.TableControl;
                if (tableControl.VerticalScroll.Value + tableControl.VerticalScroll.LargeChange == tableControl.VerticalScroll.Maximum)
                {
                    if (!Model.PaginaMaxima)
                    {
                        Model.Opcion = 1;
                        CargarGrid();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "No hay mas registros", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)sfDataGridCliente.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                BusquedaControl.Text = string.Empty;
                Model.Opcion = 2;
                CargarGrid();
                x.ValueChanged += X_ValueChanged;
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
