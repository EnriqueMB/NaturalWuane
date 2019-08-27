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

        #region Propiedades Privadas

    

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
            lblSubtitle.Text = "MODIFICAR REGISTRO";
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
            LimpiarPropiedades();
            Model.PDatos.IdProducto = IdProducto;
            Model.State = EntityState.Update;
        }
        #endregion

        #region metodos
        private void IniciarBinding()
        {
            NombreControl.DataBindings.Add("Text", Model.PDatos, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
          //  UnidadMedidaControl.DataBindings.Add("Text", Model.PDatos, "UnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioPublicoControl.DataBindings.Add("Text", Model.PDatos, "PrecioPublico", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioMayoreoControl.DataBindings.Add("Text", Model.PDatos, "PrecioMayoreo", true, DataSourceUpdateMode.OnPropertyChanged);
            PrecioMenudeoControl.DataBindings.Add("Text", Model.PDatos, "PrecioMenudeo", true, DataSourceUpdateMode.OnPropertyChanged);
            AplicaIvaControl.DataBindings.Add("Checked", Model.PDatos, "AplicaIva", true, DataSourceUpdateMode.OnPropertyChanged);
            StockControl.DataBindings.Add("Checked", Model.PDatos, "Stock", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMaxControl.DataBindings.Add("Text", Model.PDatos, "StockMax", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMinControl.DataBindings.Add("Text", Model.PDatos, "StockMin", true, DataSourceUpdateMode.OnPropertyChanged);
            FotoControl.DataBindings.Add("Image", Model.PDatos, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
            DescripcionControl.DataBindings.Add("Text", Model.PDatos, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

            CategoriaControl.DataBindings.Add("SelectedValue", Model.PDatos, "IdCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
            CategoriaControl.DataBindings.Add("DataSource", Model, "ListaCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos(1);


            //UnidadMedidaControl.DataBindings.Add("SelectedValue", Model.PDatos, "IdUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            //UnidadMedidaControl.DataBindings.Add("DataSource", Model, "ListaUnidadMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            //IniciarCombos(2);
        }

        private void IniciarCombos(int tipo)
        {
            try
            {
                if (tipo ==1)
                {
                    CategoriaControl.DisplayMember = "Nombre";
                    CategoriaControl.ValueMember = "IdCategoria";
                }

                else if (tipo == 2)
                {
                    CategoriaControl.DisplayMember = "Unidad de Medida";
                    CategoriaControl.ValueMember = "IdUnidadMedida";
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

                if (Model.PDatos.UpdateFoto)
                {
                    string Url = Path.Combine(Application.StartupPath, basePath + Clave + "." + Model.PDatos.Extencion);
                    if (File.Exists(Url))
                    {
                        File.Delete(Url);
                        Model.PDatos.Foto.Save(Url);
                        Model.PDatos.UrlFoto = Url;
                    }
                    else
                    {
                        Model.PDatos.Foto.Save(Url);
                        Model.PDatos.UrlFoto = Url;
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
                Model.PDatos.Nombre = string.Empty;
                Model.PDatos.IdCategoriaProducto = 0;
                Model.PDatos.Clave = string.Empty;
                Model.PDatos.UnidadMedida = string.Empty;
                Model.PDatos.PrecioPublico = 0;
                Model.PDatos.PrecioMayoreo = 0;
                Model.PDatos.PrecioMenudeo = 0;
                Model.PDatos.AplicaIva = false;
                Model.PDatos.Stock = false;
                Model.PDatos.StockMax =0;
                Model.PDatos.StockMin = 0;
                Model.PDatos.Descripcion = string.Empty;
               

            }
            catch (Exception)
            {

                throw;
            }
        }



        #endregion

        #region Eventos

        #endregion

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
                    Model.PDatos.Foto = null;
                    Model.PDatos.UpdateFoto = true;
                    string ext = Path.GetExtension(BuscarImagen.FileName);
                    Model.PDatos.Extencion = BuscarImagen.FileName.Substring(BuscarImagen.FileName.LastIndexOf('.') + 1);
                    if (Model.PDatos.Extencion == "png")
                        Model.PDatos.Formato = ImageFormat.Png;
                    else if (Model.PDatos.Extencion == "jpg")
                        Model.PDatos.Formato = ImageFormat.Jpeg;
                    else if (Model.PDatos.Extencion == "bmp")
                        Model.PDatos.Formato = ImageFormat.Bmp;


                    Model.PDatos.ImageLocation = BuscarImagen.FileName;
                    Model.PDatos.UrlFoto = BuscarImagen.FileName;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPersonal ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void FrmProducto_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    var _ListaCategoriaProducto = await Model.GetListaCataegoriaProduto();
                    Model.LlenarListaCategoria(_ListaCategoriaProducto);

                   

                    await Task.Delay(2000);
                }, "Espere");

                IniciarBinding();

                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () =>
                    {
                        await Model.GetProducto();
                        if (Model.PDatos.Foto == null)
                            Model.PDatos.Foto = Properties.Resources.imagen_subir;
                        await Task.Delay(2000);
                    }, "Cargando personal");
                    lblSubtitle.Text = Model.PDatos.Nombre;
                    CategoriaControl.Enabled = false;
                    StockMaxControl.Enabled = !StockControl.Checked;
                    StockMinControl.Enabled = !StockControl.Checked;
                }
                else
                {
                    Model.PDatos.Foto = Properties.Resources.imagen_subir;
                    StockMaxControl.Enabled = !StockControl.Checked;
                    StockMinControl.Enabled = !StockControl.Checked;
                }
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
                Close();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(ProductoViewModel));
                var validationResults = Model.PDatos.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    var Resultado = await Model.GuardarCambios();
                    if (Resultado != null || Resultado != string.Empty)
                    {
                        int res = 0;
                        if (Model.PDatos.UpdateFoto)
                        {
                            var x = Model.PDatos.Foto.VaryQualityLevel(35L);
                            Model.PDatos.Foto = x;
                            this.GuardarImagen(Resultado.ToString());
                            res = await Model.GuardarFotoProducto(Resultado.ToString());
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

        private void FrmProducto_Load(object sender, EventArgs e)
        {
//IniciarBinding();
        }
    }
}
