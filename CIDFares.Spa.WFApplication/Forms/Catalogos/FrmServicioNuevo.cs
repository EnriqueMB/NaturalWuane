using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmServicioNuevo : Form
    {
        #region Propiedades Públicas
        public ServicioViewModel Model { get; set; } 
        private Servicio infoServicio { get; set; }
        private string ClaveAux { get; set; }
        #endregion

        public FrmServicioNuevo()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ServicioViewModel>();
            //IniciarBinding();
            Model.Duracion = new DateTime(1900, 1, 1, 0, 30, 0);
        }

        public FrmServicioNuevo(Servicio ServId)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ServicioViewModel>();
            infoServicio = ServId;
            //CargarDatos();
            //IniciarBinding();
            Model.State = EntityState.Update;
            
        }

        private void IniciarBinding()
        {
            try
            {                
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                PrecioControl.DataBindings.Add("Text", Model, "Precio", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
                //DuracionControl.DataBindings.Add("Text", Model, "Duracion", true, DataSourceUpdateMode.OnPropertyChanged);
                DuracionControl.DataBindings.Add("Value", Model, "Duracion", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);                
                AplicaIEPSControl.DataBindings.Add("Checked", Model, "AplicaIEPS", true, DataSourceUpdateMode.OnPropertyChanged);
                IEPSMontoControl.DataBindings.Add("Checked", Model, "IEPSMonto", true, DataSourceUpdateMode.OnPropertyChanged);
                IEPSControl.DataBindings.Add("Text", Model, "IEPS", true, DataSourceUpdateMode.OnPropertyChanged);
                ImagenControl.DataBindings.Add("Image", Model, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);
                RutaImagenControl.DataBindings.Add("Text", Model, "RutaImagen", true, DataSourceUpdateMode.OnPropertyChanged);
                PorcentajePControl.DataBindings.Add("Text", Model, "PorcentajeP", true, DataSourceUpdateMode.OnPropertyChanged);

                IdTipoIvaControl.DataBindings.Add("SelectedValue", Model, "IdTipoIva", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoIvaControl.DataBindings.Add("DataSource", Model, "ListaIva", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarCombito(0);

                IdTipoServicioControl.DataBindings.Add("SelectedValue", Model, "IdTipoServicio", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoServicioControl.DataBindings.Add("DataSource", Model, "ListaTipoServicio", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarCombito(1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarCombito(int n)
        {
            try
            {
                if (n == 1)
                {
                    IdTipoServicioControl.DisplayMember = "NombreTipoServicio";
                    IdTipoServicioControl.ValueMember = "IdTipoServicio";
                }                
                else
                {
                    IdTipoIvaControl.DisplayMember = "Porcentaje";
                    IdTipoIvaControl.ValueMember = "IdTipoIva";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task CargarDatos()
        {
            try
            {

                Model.IdServicio = infoServicio.IdServicio;
                Model.IdTipoServicio = infoServicio.IdTipoServicio;
                Model.IdTipoIva = infoServicio.IdTipoIva;
                Model.Nombre = infoServicio.Nombre;
                Model.Clave = infoServicio.Clave;
                Model.Precio = infoServicio.Precio;
                Model.Duracion = infoServicio.Duracion;
                Model.Descripcion = infoServicio.Descripcion;
                Model.AplicaIEPS = infoServicio.AplicaIEPS;
                Model.IEPSMonto = infoServicio.IEPSMonto;
                Model.IEPS = infoServicio.IEPS;
                Model.Porcentaje = infoServicio.Porcentaje;
                Model.PorcentajeP = infoServicio.PorcentajePaquete;
                Model.UrlImagen = infoServicio.UrlImagen;
                this.lblTitle.Text = infoServicio.Nombre;
                //await Model.GetFoto(Model.IdServicio);
                //if (!string.IsNullOrEmpty(Model.FotoBase64))
                //{
                //    Model.Foto = ComprimirImagenExtensions.ImageBase64ToImage(Model.FotoBase64);
                //}
                //else
                //    Model.ImageLocation = "Sin Foto";
                //Model.FotoBase64 = string.Empty;
                //Model.Foto = (string.IsNullOrEmpty(infoServicio.Base64String)) ? null : infoServicio.Base64String.ImageBase64ToImage();
                //Model.Foto = infoServicio.Base64String;//(string.IsNullOrEmpty(infoServicio.Base64String)) ? null : infoServicio.Base64String.ImageBase64ToImage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(ServicioViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    if (Model.UpdateImagen || (ClaveAux != Model.Clave && ClaveAux != null))//SI se cambia la clave o la imagen se sube la imagen
                    {
                        bool subir = false;
                        CIDWait.Show(async () =>
                        {
                            //Subimos la imagen al Servidor FTP
                            subir = await Model.UploadFTP(Model.RutaImagen,
                                    ConfigurationManager.AppSettings.Get("ServerFtpTxt") + @"/imgServicios/" + Model.Clave + Model.Extencion,
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
                    var aux = Model.Duracion;
                    var otroAux = DuracionControl.Value;
                    Servicio Resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resul.Resultado == 1)
                    {
                        if (Model.RutaAux != "" && Model.RutaAux != null)
                            File.Delete(Model.RutaAux);//Borramos la imagen desde la carpeta RESOURCES
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        //await Model.GetAllAsync();
                        this.Close();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, "Error", TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ServicioViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicioNuevo ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        private async Task  CargarImagen()
        {
            try
            {
                if (Model.UrlImagen != "" && Model.UrlImagen != null)
                {
                    string User = ConfigurationManager.AppSettings.Get("UsuarioFtpTxt");
                    string pass = ConfigurationManager.AppSettings.Get("ContraseñaFtpTxt");
                    Model.Extencion = Path.GetExtension(Model.UrlImagen);//Obtenemos la Extencion del archivo
                    Model.RutaAux = Path.Combine(Application.StartupPath + @"\Resources\imgServicios\" + Model.Clave + Model.Extencion);//Creamos la ruta para guardar la imagen
                                                                                                                                       //Verificamos que la imagen no exista, si existe la borramos.
                    if (File.Exists(Model.RutaAux))
                    {
                        File.Delete(Model.RutaAux);//Borramos la imagen.
                    }

                    CIDWait.Show(async () =>
                    {
                        //Descargamos la imagen del Servidor FTP a Resources
                        await Model.DownloadFile(Model.RutaAux, Model.UrlImagen, User, pass);
                    }, "Espere");

                    if (!File.Exists(Model.RutaAux))
                    {
                        //Mensage de error en caso que no se haya obtenido la imagen.
                        Model.RutaImagen = "NO SE PUDO OBTENER LA IMAGEN";
                    }
                    else
                    {
                        Model.RutaImagen = Model.RutaAux;
                        var x = Image.FromFile(Model.RutaAux);
                        var y = Model.Convertir_Imagen_Bytes(x);
                        x.Dispose();
                        Model.Imagen = Model.Convertir_Bytes_Imagen(y);
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
        public void LimpiarPropiedades()
        {
            Model.IdServicio = 0;
            Model.IdTipoIva = 1;
            Model.IdTipoServicio = 1;
            Model.Nombre = string.Empty;
            Model.Clave = string.Empty;
            Model.Precio = 0;
            Model.Duracion = DateTime.Now;
            //Model.Duracion = TimeSpan.Zero;
            Model.DescIva = string.Empty;
            Model.AplicaIEPS = false;
            Model.IEPSMonto = false;
            Model.IEPS = 0;
           // Model.FotoBase64 = string.Empty;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    if (Model.RutaAux != "" && Model.RutaAux != null)
                        File.Delete(Model.RutaAux);//Borramos la imagen desde la carpeta RESOURCES
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicioNuevo ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        
        private void AplicaIEPS_CheckedChanged(object sender, EventArgs e)
        {
            //IEPSMontoControl.Visible = true;
            //pnlIEPS.Visible = true;
            if (AplicaIEPSControl.Checked)
            {
                //IEPSMontoControl.Visible = true;
                pnlIEPS.Visible = true;
                gbRadioButtons.Visible = true;
                
                //rbMonto.Visible = true;
                //rbPorcentaje.Visible = true;
            }
            else
            {
                //IEPSMontoControl.Visible = false; ;
                pnlIEPS.Visible = false;
                gbRadioButtons.Visible = false;
                //rbMonto.Visible = false;
                //rbPorcentaje.Visible = false;
            }
        }        

        private void rbMonto_CheckedChanged(object sender, EventArgs e)
        {
            IEPSControl.Text = "0";
            if (rbMontoControl.Checked)
            {
                IEPSMontoControl.Checked = true;
                lblIEPS.Text = "$";
            }
            else if (rbPorcentajeControl.Checked)
            {
                IEPSMontoControl.Checked = false;
                lblIEPS.Text = "%";
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
                    Model.Imagen = null;
                    Model.UpdateImagen = true;
                    Model.Extencion = Path.GetExtension(BuscarImagen.FileName);//Obtenemos la extención de la imagen.
                    Model.RutaImagen = BuscarImagen.FileName; //Guardamos la ruta de la imagen.
                    var x = Image.FromFile(Model.RutaImagen).VaryQualityLevel(35L);//Almacenamos la imagen creada en una variable(Imagen).
                    var y = Model.Convertir_Imagen_Bytes(x); //Mandamos la variable para convertirla a bytes.
                    x.Dispose();
                    Model.Imagen = Model.Convertir_Bytes_Imagen(y); //Le pasamos la imagen convertida a la propiedad Imagen del modelo para mostrarlo en el formulario.
                    var a = Model.UrlImagen;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmServicio ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        
        private async void FrmServicioNuevo_Shown(object sender, EventArgs e)
        {
            try
            {
                var z = await Model.GetListaTipoIva();
                Model.LlenarListaTI(z);
                var a = await Model.GetListaTipoServicio();
                Model.LlenarListaTServicio(a);
                IniciarBinding();
                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () =>
                    {
                        await CargarDatos();
                        await CargarImagen();
                    }, "ESPERE");
                    //if (Model.Foto == null)
                    //    Model.Foto = Properties.Resources.imagen_subir;
                    //await Task.Delay(2000);
                }
                //else
                //{
                //    Model.Foto = Properties.Resources.imagen_subir;
                //}  
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, "ERROR AL CARGAR LA IMAGEN", TypeMessage.error);
                //throw ex;
            }
        }
    }
}
