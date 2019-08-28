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

      

        #region Constructor

        public FrmProducto()
        {
            InitializeComponent();
            lblSubtitle.Text = "NUEVO REGISTRO";
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
           // Model.GetListaCataegoriaProduto();

           

        }

        public FrmProducto(int IdProducto)
        {
            InitializeComponent();
            lblSubtitle.Text = "MODIFICAR REGISTRO";
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
            PrecioPublicoControl.DataBindings.Add("Text", Model, "PrecioPublico", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioMayoreoControl.DataBindings.Add("Text", Model, "PrecioMayoreo", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioMenudeoControl.DataBindings.Add("Text", Model, "PrecioMenudeo", true, DataSourceUpdateMode.OnPropertyChanged);
            AplicaIvaControl.DataBindings.Add("Checked", Model, "AplicaIva", true, DataSourceUpdateMode.OnPropertyChanged);
            StockControl.DataBindings.Add("Checked", Model, "Stock", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMaxControl.DataBindings.Add("Text", Model, "StockMax", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMinControl.DataBindings.Add("Text", Model, "StockMin", true, DataSourceUpdateMode.OnPropertyChanged);
            FotoControl.DataBindings.Add("Image", Model, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
            DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            ClaveSatControl.DataBindings.Add("Text", Model, "ClaveSat", true, DataSourceUpdateMode.OnPropertyChanged);
            CodigoBarrasControl.DataBindings.Add("Text", Model, "CodigoBarras", true, DataSourceUpdateMode.OnPropertyChanged);
            RutaControl.DataBindings.Add("Text", Model, "ImageLocation", true, DataSourceUpdateMode.OnPropertyChanged);

            IniciarCombos(1);
            CategoriaControl.DataBindings.Add("SelectedValue", Model, "IdCategoriaProducto", true, DataSourceUpdateMode.OnPropertyChanged);
            CategoriaControl.DataBindings.Add("DataSource", Model, "ListaCategoria", true, DataSourceUpdateMode.OnPropertyChanged);


            IniciarCombos(2);
            UnidadMedidaControl.DataBindings.Add("SelectedValue", Model, "IdUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            UnidadMedidaControl.DataBindings.Add("DataSource", Model, "ListaUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void IniciarCombos(int tipo)
        {
            try
            {
                if (tipo ==1)
                {
                    CategoriaControl.DisplayMember = "Nombre";
                    CategoriaControl.ValueMember = "IdCategoriaProducto";
                }

                else if (tipo == 2)
                {
                    UnidadMedidaControl.DisplayMember = "Nombre";
                    UnidadMedidaControl.ValueMember = "IdUnidadMedida";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void GuardarImagen(string Clave)
        {
            try
            {
                string basePath = @"Resources\Image\";
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                if (Model.UpdateFoto)
                {
                    string Url = Path.Combine(Application.StartupPath, basePath + Clave + "." + Model.Extencion);
                    if (File.Exists(Url))
                    {
                        File.Delete(Url);
                        Model.Foto.Save(Url);
                        Model.UrlFoto = Url;
                    }
                    else
                    {
                        Model.Foto.Save(Url);
                        Model.UrlFoto = Url;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = string.Empty;
               // Model.PDatos.IdCategoriaProducto = 0;
                Model.Clave = string.Empty;
                Model.UnidadMedida = string.Empty;
                Model.PrecioPublico = 0;
                Model.PrecioMayoreo = 0;
                Model.PrecioMenudeo = 0;
                Model.AplicaIva = false;
                Model.Stock = false;
                Model.StockMax =0;
                Model.StockMin = 0;
                Model.Descripcion = string.Empty;
               

            }
            catch (Exception)
            {
                throw;
            }
        }



        #endregion

        #region Eventos

        #endregion

     

        

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
               // this.CleanErrors(errorProvider1, typeof(ProductoViewModel));
               // var validationResults = Model.PDatos.Validate();
               // validationResults.ToString();
              //  if (validationResults.IsValid)
               // {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resultado != null || Resultado != string.Empty)
                    {
                        int res = 0;
                        if (Model.UpdateFoto)
                        {
                            var x = Model.Foto.VaryQualityLevel(35L);
                            Model.Foto = x;

                            this.GuardarImagen(Resultado.ToString());
                            res = await Model.GuardarFotoProducto(Resultado.ToString(), CurrentSession.IdCuentaUsuario);
                            if (res > 0)
                            {
                                this.LimpiarPropiedades();
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                                this.Close();
                            }
                            else
                            {
                                this.LimpiarPropiedades();
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                            }
                        }
                        else
                        {
                            this.LimpiarPropiedades();
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                            this.Close();
                        }

                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
              //  }
               // else
                  //  this.ShowErrors(errorProvider1, typeof(ProductoViewModel), validationResults);

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

        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            //IniciarBinding();
            var x = await Model.GetListaCataegoriaProduto();
            Model.LlenarListaCategoria(x);

            var y = await Model.GetListaUnidadMedida();
            Model.LlenaUnidadMedida(y);

            IniciarBinding();
        }

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
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
                    Model.Foto = null;
                    Model.UpdateFoto = true;
                    string ext = Path.GetExtension(BuscarImagen.FileName);
                    Model.Extencion = Path.GetExtension(BuscarImagen.FileName);
                    if (Model.Extencion == ".png")
                        Model.Formato = ImageFormat.Png;
                    else if (Model.Extencion == ".jpg")
                        Model.Formato = ImageFormat.Jpeg;
                    else if (Model.Extencion == ".bmp")
                        Model.Formato = ImageFormat.Bmp;


                    Model.ImageLocation = BuscarImagen.FileName;
                    Model.UrlFoto = BuscarImagen.FileName;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPersonal ~ BtnSeleccionar_Click_1(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
