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
    public partial class FrmProducto : Form
    {
        #region Propiedades Publicas
        public ProductoViewModel Model { get; set; }
        #endregion
        #region Propiedades Privadas
        public string ClaveAux { get; set; }
        #endregion
        #region Constructor
        public FrmProducto()
        {
            InitializeComponent();
            lblSubtitle.Text = "NUEVO REGISTRO";
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
            Model.GetListaCataegoriaProduto();
        }
        public FrmProducto(int IdProducto)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
            LimpiarPropiedades();
            Model.IdProducto = IdProducto;
            Model.State = EntityState.Update;
        }
        #endregion

        #region metodos
        private void IniciarBinding()
        {
            NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioPublicoControl.DataBindings.Add("Text", Model, "PrecioPublico", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            //AplicaIvaControl.DataBindings.Add("Checked", Model, "AplicaIva", true, DataSourceUpdateMode.OnPropertyChanged);
            StockControl.DataBindings.Add("Checked", Model, "Stock", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMaxControl.DataBindings.Add("Text", Model, "StockMax", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMinControl.DataBindings.Add("Text", Model, "StockMin", true, DataSourceUpdateMode.OnPropertyChanged);
            ImagenControl.DataBindings.Add("Image", Model, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);
            DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            ClaveSatControl.DataBindings.Add("Text", Model, "ClaveSat", true, DataSourceUpdateMode.OnPropertyChanged);
            CodigoBarrasControl.DataBindings.Add("Text", Model, "CodigoBarras", true, DataSourceUpdateMode.OnPropertyChanged);
            RutaImagenControl.DataBindings.Add("Text", Model, "RutaImagen", true, DataSourceUpdateMode.OnPropertyChanged);
            CostoProductoControl.DataBindings.Add("Text", Model, "CostoProducto", true, DataSourceUpdateMode.OnPropertyChanged,"","C2");
            PorcentajePControl.DataBindings.Add("Text", Model, "PorcentajeP", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos(1);
            IdCategoriaProductoControl.DataBindings.Add("SelectedValue", Model, "IdCategoriaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            IdCategoriaProductoControl.DataBindings.Add("DataSource", Model, "ListaCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos(2);
            IdUnidadMedidaControl.DataBindings.Add("SelectedValue", Model, "IdUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            IdUnidadMedidaControl.DataBindings.Add("DataSource", Model, "ListaUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos(3);
            IdAplicaIvaControl.DataBindings.Add("SelectedValue", Model, "IdAplicaIva", true, DataSourceUpdateMode.OnPropertyChanged);
            IdAplicaIvaControl.DataBindings.Add("DataSource", Model, "ListaIva", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void IniciarCombos(int tipo)
        {
            try
            {
                if (tipo ==1)
                {
                    IdCategoriaProductoControl.DisplayMember = "Nombre";
                    IdCategoriaProductoControl.ValueMember = "IdCategoriaProducto";
                }

                else if (tipo == 2)
                {
                    IdUnidadMedidaControl.DisplayMember = "Nombre";
                    IdUnidadMedidaControl.ValueMember = "IdUnidadMedida";
                }
                else if(tipo==3)
                {
                    IdAplicaIvaControl.DisplayMember = "Porcentaje";
                    IdAplicaIvaControl.ValueMember = "IdTipoIva";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public void GuardarImagen(string Clave)
        //{
        //    try
        //    {
        //        string basePath = @"Resources\Image\";
        //        if (!Directory.Exists(basePath))
        //        {
        //            Directory.CreateDirectory(basePath);
        //        }

        //        if (Model.UpdateFoto)
        //        {
        //            string Url = Path.Combine(Application.StartupPath, basePath + Clave + "." + Model.Extencion);
        //            if (File.Exists(Url))
        //            {
        //                File.Delete(Url);
        //                Model.Foto.Save(Url);
        //                Model.UrlFoto = Url;
        //            }
        //            else
        //            {
        //                Model.Foto.Save(Url);
        //                Model.UrlFoto = Url;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = string.Empty;
                Model.IdCategoriaProducto = 0;
                Model.Clave = string.Empty;
                Model.IdUnidadMedida = 0;
                Model.PrecioPublico = 0;
                Model.PrecioMayoreo = 0;
                Model.PrecioMenudeo = 0;
                Model.IdAplicaIva = 0;
                Model.Stock = false;
                Model.StockMax =0;
                Model.StockMin = 0;
                Model.Descripcion = string.Empty;
                Model.ClaveSat = 0;
                Model.Descripcion = string.Empty;
                Model.CostoProducto = 0;
                Model.PorcentajeP = 0;
                Model.CodigoBarras = string.Empty;
                Model.RutaImagen = string.Empty;
                Model.Imagen = null;
                Model.UpdateFoto = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Botnones
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(ProductoViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    bool subir = false;
                    if (Model.UpdateImagen || (ClaveAux != Model.Clave && ClaveAux != null))//SI se cambia la clave o la imagen se sube la imagen
                    {
                        
                        CIDWait.Show(async () =>
                        {
                            //Subimos la imagen al Servidor FTP
                            subir = await Model.UploadFTP(Model.RutaImagen,
                                    ConfigurationManager.AppSettings.Get("ServerFtpTxt") + @"/imgProductos/" + Model.Clave + Model.Extencion,
                                    ConfigurationManager.AppSettings.Get("UsuarioFtpTxt"),
                                    ConfigurationManager.AppSettings.Get("ContraseñaFtpTxt"));
                        }, "Espere");

                        if (!subir)
                        {
                            //Mensaje de avertencia que la imagen no se pudo cargar
                            CIDMessageBox.ShowAlert(Messages.SystemName, "NO SE PUDO SUBIR LA IMAGEN", TypeMessage.informacion);

                        }
                    }
                    Model.UpdateFoto = false;
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resultado != null || Resultado != string.Empty)
                    {
                        if (Model.RutaAux != "" && Model.RutaAux != null)
                            File.Delete(Model.RutaAux);//Borramos la imagen desde la carpeta RESOURCES
                        this.LimpiarPropiedades();
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        this.Close();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ProductoViewModel), validationResults);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProducto ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        private async Task CargarImagen()
        {
            try
            {
                //Creamos el directorio para almacenar las fotos.
                string ruta = Path.Combine(Application.StartupPath + @"\Resources\imgProductos\");
                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);
                if (Model.UrlImagen != "" && Model.UrlImagen != null)
                {
                    string User = ConfigurationManager.AppSettings.Get("UsuarioFtpTxt");
                    string pass = ConfigurationManager.AppSettings.Get("ContraseñaFtpTxt");
                    Model.Extencion = Path.GetExtension(Model.UrlImagen);//Obtenemos la Extencion del archivo
                    Model.RutaAux = Path.Combine(Application.StartupPath + @"\Resources\imgProductos\" + Model.Clave + Model.Extencion);//Creamos la ruta para guardar la imagen
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
                        CIDMessageBox.ShowAlert(Messages.SystemName, "NO SE PUEDO OBTENER LA IMAGEN", TypeMessage.informacion);
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
        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                BtnSeleccionar.Enabled = false;
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
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPersonal ~ BtnSeleccionar_Click_1(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                BtnSeleccionar.Enabled = true;
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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProducto ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorAlCancelarFrm, TypeMessage.error);
            }
        }
        #endregion

        #region Eventos
        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();

                var x = await Model.GetListaCataegoriaProduto();
                Model.LlenarListaCategoria(x);

                var y = await Model.GetListaUnidadMedida();
                Model.LlenaUnidadMedida(y);

                var z = await Model.GetListaIva();
                Model.LlenarlistaIva(z);

                StockControl.Checked = false;
                StockMinControl.Enabled = false;
                StockMaxControl.Enabled = false;
                Model.IdAplicaIva = 1;

                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () => {
                        await Model.GetProducto();
                        await CargarImagen();
                        await Task.Delay(2000);
                    }, "Cargando producto");
                    if (Model.Imagen == null || Model.UrlImagen == "")
                    {
                        Model.Imagen = Properties.Resources.imagen_subir;
                        Model.RutaImagen = "SIN FOTO";

                    }
                    lblSubtitle.Text = Model.Nombre;
                }
                else
                {
                    Model.Imagen = Properties.Resources.imagen_subir;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void StockControl_CheckedChanged(object sender, EventArgs e)
        {
            if (StockControl.Checked == true)
            {
                StockMaxControl.Enabled = true;
                StockMinControl.Enabled = true;
            }
            else if (StockControl.Checked == false)
            {
                StockMaxControl.Text = Convert.ToString(0);
                StockMinControl.Text = Convert.ToString(0);
                StockMaxControl.Enabled = false;
                StockMinControl.Enabled = false;
            }
        }
        private void GenerarCodigoBarrasControl_CheckedChanged(object sender, EventArgs e)
        {
            if (GenerarCodigoBarrasControl.Checked == true)
            {
                CodigoBarrasControl.Enabled = false;
                CodigoBarrasControl.Text = ClaveControl.Text;
            }
            else if (GenerarCodigoBarrasControl.Checked == false)
            {
                CodigoBarrasControl.Enabled = true;
                CodigoBarrasControl.Text = string.Empty;
            }
        }
        private void PrecioPublicoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void PrecioMenudeoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PrecioMayoreoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void StockMaxControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void StockMinControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
