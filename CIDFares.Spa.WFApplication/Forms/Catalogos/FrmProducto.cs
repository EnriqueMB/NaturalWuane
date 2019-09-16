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
            PrecioMayoreoControl.DataBindings.Add("Text", Model, "PrecioMayoreo", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            PrecioMenudeoControl.DataBindings.Add("Text", Model, "PrecioMenudeo", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            //AplicaIvaControl.DataBindings.Add("Checked", Model, "AplicaIva", true, DataSourceUpdateMode.OnPropertyChanged);
            StockControl.DataBindings.Add("Checked", Model, "Stock", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMaxControl.DataBindings.Add("Text", Model, "StockMax", true, DataSourceUpdateMode.OnPropertyChanged);
            StockMinControl.DataBindings.Add("Text", Model, "StockMin", true, DataSourceUpdateMode.OnPropertyChanged);
            FotoControl.DataBindings.Add("Image", Model, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
            DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            ClaveSatControl.DataBindings.Add("Text", Model, "ClaveSat", true, DataSourceUpdateMode.OnPropertyChanged);
            CodigoBarrasControl.DataBindings.Add("Text", Model, "CodigoBarras", true, DataSourceUpdateMode.OnPropertyChanged);
            RutaControl.DataBindings.Add("Text", Model, "ImageLocation", true, DataSourceUpdateMode.OnPropertyChanged);
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
            finally
            {
                BtnSeleccionar.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
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
               // IdAplicaIvaControl.Enabled = false;
                

                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () => {
                        await Model.GetProducto();
                        if (Model.Foto == null)
                            Model.Foto = Properties.Resources.imagen_subir;
                        await Task.Delay(2000);
                    }, "Cargando producto");
                    lblSubtitle.Text = Model.Nombre;
                }
                else
                {
                    Model.Foto = Properties.Resources.imagen_subir;
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
        //private void AplicaIvaControl_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (AplicaIvaControl.Checked == true)
        //    {
        //        IdAplicaIvaControl.Enabled = true;
        //    }
        //    else if (AplicaIvaControl.Checked == false)
        //    {
        //        IdAplicaIvaControl.Enabled = false;
        //    }
        //}
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
