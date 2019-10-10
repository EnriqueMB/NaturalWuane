using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Library.Code;
using CIDFares.Spa.DataAccess.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using CIDFares.Library.Code.Extensions;
using System.IO;
using System.Net;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ProductoViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IProductoRepository IRepository { get; set; }

        private ICategoriaProductoRepository RespositoryCategoria { get; set; }
        private IUnidadMedidaRepository RespositoryUnidadMedida { get; set; }
        private IIvaRepository RespositoryIva { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Producto> ListaProducto { get; set; }
        public BindingList<CategoriaProducto> ListaCategoria { get; set; }
        public BindingList<UnidadMedida> ListaUnidadMedida { get; set; }
        public BindingList<Iva> ListaIva { get; set; }
        public BindingList<Cliente> ListaProducto2 { get; set; }

        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ProductoViewModel(IProductoRepository IProductoRepository, ICategoriaProductoRepository respositoryCategoria, IUnidadMedidaRepository respositoryUnidadMedida, IIvaRepository respositoryIva)
        {
            IRepository = IProductoRepository;
            RespositoryIva = respositoryIva;

            ListaProducto = new BindingList<Producto>();
            ListaCategoria = new BindingList<CategoriaProducto>();
            ListaUnidadMedida = new BindingList<UnidadMedida>();
            ListaIva = new BindingList<Iva>();
            RespositoryCategoria = respositoryCategoria;
            RespositoryUnidadMedida = respositoryUnidadMedida;

            #region propiedades binding
            IdAplicaIva = 0;
            Nombre = string.Empty;
            IdCategoriaProducto = 0;
            IdProducto = 0;
            Categoria = string.Empty;
            Clave = string.Empty;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Stock = false;
            StockMax = 0;
            StockMin = 0;
            PrecioPublico = 0;
            PrecioMayoreo = 0;
            PrecioMenudeo = 0;
            CodigoBarras = string.Empty;
            UnidadMedida = string.Empty;
            IdUnidadMedida = 0;
            ClaveSat = 0;
            AplicaIva = false;
            Usuario = Guid.Empty;
            
            #endregion




        }
        #endregion

        #region Metodos
        public async Task CargarDatos()
        {
            try
            {               
                var x = await IRepository.CargarDatos();
                ListaProducto.Clear();
                foreach (var item in x)
                {
                    item.StockStr = item.Stock ? "SI" : "NO";
                    ListaProducto.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<int> GuardarFotoProducto(string Clave, Guid IdUsuario)
        //{
        //    try
        //    {
        //        Producto producto = new Producto
        //        {
        //            Clave = Clave,
        //            UpdateFoto = UpdateFoto,
        //            Base64String = new Bitmap(Foto).ToBase64String(Formato),
        //            UrlFoto = UrlFoto
        //        };
        //        return await IRepository.AddFotoProducto(producto, IdUsuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public async Task GetProducto()
        {
            try
            {
                Producto producto;
                producto = await IRepository.GetProductoXid(IdProducto);
                
                Nombre = producto.Nombre;
                Descripcion = producto.Descripcion;
                Clave = producto.Clave;
                Stock = producto.Stock;
                IdAplicaIva = producto.IdAplicaIva;
                IdCategoriaProducto = producto.IdCategoriaProducto;
                StockMax = producto.StockMax;
                StockMin = producto.StockMin;
                PrecioPublico = producto.PrecioPublico;
                CodigoBarras = producto.CodigoBarras;
                IdUnidadMedida = producto.IdUnidadMedida;
                ClaveSat = producto.ClaveSat;
                AplicaIva = producto.AplicaIva;
                UrlImagen = producto.UrlImagen;
                //Foto = (string.IsNullOrEmpty(producto.Base64String)) ? null : producto.Base64String.ImageBase64ToImage();
                this.CostoProducto = producto.CostoProducto;
                this.PorcentajeP = producto.PorcentajeP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(Guid IdUsuario)
        {
            try
            {
                return await IRepository.DeleteAsync(IdProducto, IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region combo UnidadMedida

        public void LlenaUnidadMedida(IEnumerable<UnidadMedida> UnidadMedida)
        {
            ListaUnidadMedida.Clear();
            foreach (var item in UnidadMedida)
            {
                ListaUnidadMedida.Add(item);
            }
        }

        public async Task<IEnumerable<UnidadMedida>> GetListaUnidadMedida()
        {
            try
            {
                var UnidadMedida = await RespositoryUnidadMedida.LlenarComboUnidadMedida();
                return UnidadMedida;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Combo Categorias
        public void LlenarListaCategoria(IEnumerable<CategoriaProducto> CategoriaProducto)
        {
            ListaCategoria.Clear();
            foreach (var item in CategoriaProducto)
            {
                ListaCategoria.Add(item);
            }
        }

        public async Task<IEnumerable<CategoriaProducto>> GetListaCataegoriaProduto()
        {
            try
            {
                var CategoriaProducto = await RespositoryCategoria.LlenarComboCategoria();
                return CategoriaProducto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Combo iva
        public void LlenarlistaIva(IEnumerable<Iva> Iva)
        {
            ListaIva.Clear();
            foreach (var item in Iva)
            {
                ListaIva.Add(item);
            }
        }

        public async Task<IEnumerable<Iva>> GetListaIva()
        {
            try
            {
                var Iva = await RespositoryIva.LlenarComboIva();
                return Iva;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public async Task GetBusqueda()
        {
            try
            {
                var x = await IRepository.GetBusquedaAsync(this.Busqueda);
                ListaProducto.Clear();
                foreach (var item in x)
                {
                    item.AplicaIvaStr = item.AplicaIva ? "SI" : "NO";
                    item.StockStr = item.Stock ? "SI" : "NO";
                    ListaProducto.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<string> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                if (this.UrlImagen == null)
                    this.UrlImagen = "";
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    IdProducto = IdProducto,
                    IdCategoriaProducto = IdCategoriaProducto,
                    IdUnidadMedida = IdUnidadMedida,
                    Clave = Clave,
                    PrecioPublico = PrecioPublico,
                    AplicaIva = AplicaIva,
                    Stock = Stock,
                    StockMax = StockMax,
                    StockMin = StockMin,
                    Descripcion = Descripcion,
                    ClaveSat = ClaveSat,
                    CodigoBarras = CodigoBarras,
                    IdAplicaIva = IdAplicaIva,
                    CostoProducto = this.CostoProducto,
                    PorcentajeP = this.PorcentajeP,
                    UrlImagen = this.UrlImagen

                };
                if (State == EntityState.Create)
                {
                    return await IRepository.AddWitClave(producto, IdUsuario);
                }
                else if (State == EntityState.Update)
                {               
                    return await IRepository.Update(producto, IdUsuario);
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos Imagen
        /// <summary>
        /// Método para subir la imagen al Servidor FTP
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="RemotePath"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<bool> UploadFTP(string FilePath, string RemotePath, string Login, string Password)
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    UrlImagen = RemotePath;
                    FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlImagen);
                    ftp.Credentials = new NetworkCredential(Login, Password);
                    ftp.Method = WebRequestMethods.Ftp.UploadFile;
                    ftp.KeepAlive = false;
                    ftp.UseBinary = true;
                    ftp.ContentLength = fs.Length;
                    ftp.Proxy = null;
                    fs.Position = 0;
                    int buffLength = 2048;
                    byte[] buff = new byte[buffLength];
                    int contentLen;
                    using (Stream strm = ftp.GetRequestStream())
                    {
                        contentLen = fs.Read(buff, 0, buffLength);
                        while (contentLen != 0)
                        {
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //LogError.AddExcFileTxt(ex, "UtilFtp ~ UploadFTP");
                //return false;
                throw ex;
            }
        }

        /// <summary>
        /// Método para descargar la imagen del Servidor FTP
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="RemotePath"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<bool> DownloadFile(string FilePath, string RemotePath, string Login, string Password)
        {
            try
            {
                //string url = Path.Combine(RemotePath, Path.GetFileName(FilePath));
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlImagen);
                ftp.Credentials = new NetworkCredential(Login, Password);
                ftp.Method = WebRequestMethods.Ftp.DownloadFile;
                ftp.KeepAlive = false;
                ftp.UseBinary = true;
                ftp.Proxy = null;
                FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream fs = new FileStream(FilePath, FileMode.Create);
                int ReadCount = stream.Read(buffer, 0, buffer.Length);
                while (ReadCount > 0)
                {
                    fs.Write(buffer, 0, ReadCount);
                    ReadCount = stream.Read(buffer, 0, buffer.Length);
                }
                fs.Close();
                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                //LogError.AddExcFileTxt(ex, "UtilFtp ~ DownloadFile");
                //return false;
                throw ex;
            }
        }

        /// <summary>
        /// Método para convertir de Bytes a Imagen
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        /// <summary>
        /// Método para convertir de Imagen a Bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
        #endregion
        #region Binding Imagen
        /// <summary>
        /// Variable para almacenar la url de la imagen(urlFTP)
        /// </summary>
        private string _UrlImagen;

        public string UrlImagen
        {
            get { return _UrlImagen; }
            set
            {
                _UrlImagen = value;
                OnPropertyChanged(nameof(UrlImagen));
            }
        }

        /// <summary>
        /// Propiedad para almacenar la imagen y mostrarlo en el Formulario
        /// </summary>
        private Image _Imagen;

        public Image Imagen
        {
            get { return _Imagen; }
            set
            {
                _Imagen = value;
                OnPropertyChanged(nameof(Imagen));
            }
        }

        /// <summary>
        /// Propiedad Booleana para saber cuando el usuario modificó la imagen
        /// </summary>
        public bool UpdateImagen { get; set; }
        /// <summary>
        /// Propiedad para almacenar la extensión de la imagen
        /// </summary>
        public string Extencion { get; set; }
        /// <summary>
        /// Propiedad para almacenar la ruta de la imagen en Resources
        /// </summary>
        public string RutaAux { get; set; }

        /// <summary>
        /// Propiedad para almacenar la ruta de la imagen a subir
        /// </summary>
        private string _RutaImagen;

        public string RutaImagen
        {
            get { return _RutaImagen; }
            set
            {
                _RutaImagen = value;
                OnPropertyChanged(nameof(RutaImagen));
            }
        }
        #endregion
        #region Binding
        private int _IdProducto;
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; OnPropertyChanged("IdProducto"); }
        }

        private string _Categoria;
        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; OnPropertyChanged("Categoria"); }
        }

        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; OnPropertyChanged("Clave"); }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged("Nombre"); }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; OnPropertyChanged("Descripcion"); }
        }

        private bool _Stock;
        public bool Stock
        {
            get { return _Stock; }
            set { _Stock = value; OnPropertyChanged("Stock"); }
        }

        private int _StockMax;
        public int StockMax
        {
            get { return _StockMax; }
            set { _StockMax = value; OnPropertyChanged("StockMax"); }
        }

        private int _StockMin;
        public int StockMin
        {
            get { return _StockMin; }
            set { _StockMin = value; OnPropertyChanged("StockMin"); }
        }

        private decimal _PrecioPublico;
        public decimal PrecioPublico
        {
            get { return _PrecioPublico; }
            set { _PrecioPublico = value; OnPropertyChanged("PrecioPublico"); }
        }
        
        private decimal _PrecioMayoreo;
        public decimal PrecioMayoreo
        {
            get { return _PrecioMayoreo; }
            set { _PrecioMayoreo = value; OnPropertyChanged("PrecioMayoreo"); }
        }

        private decimal _PrecioMenudeo;
        public decimal PrecioMenudeo
        {
            get { return _PrecioMenudeo; }
            set { _PrecioMenudeo = value; OnPropertyChanged("PrecioMenudeo"); }
        }

        private string _CodigoBarras;
        public string CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; OnPropertyChanged("CodigoBarras"); }
        }

        private int? _IdUnidadMedida;
        public int? IdUnidadMedida
        {
            get { return _IdUnidadMedida; }
            set { _IdUnidadMedida = value; OnPropertyChanged("IdUnidadMedida"); }
        }

        private int? _IdAplicaIva;
        public int? IdAplicaIva
        {
            get { return _IdAplicaIva; }
            set { _IdAplicaIva = value; OnPropertyChanged("IdAplicaIva"); }
        }

        private string _UnidadMedida;
        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; OnPropertyChanged("UnidadMedida"); }
        }

        private int _ClaveSat;
        public int ClaveSat
        {
            get { return _ClaveSat; }
            set { _ClaveSat = value; OnPropertyChanged("ClaveSat"); }
        }

        private bool _AplicaIva;
        public bool AplicaIva
        {
            get { return _AplicaIva; }
            set { _AplicaIva = value; OnPropertyChanged("AplicaIva"); }
        }
        private Guid _Usuario;
        public Guid Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; OnPropertyChanged("Usuario"); }
        }

        private int? _IdCategoriaProducto;
        public int? IdCategoriaProducto
        {
            get { return _IdCategoriaProducto; }
            set { _IdCategoriaProducto = value; OnPropertyChanged("IdCategoriaProducto"); }
        }

        //propiedades par la foto

        private string _BaseString64;
        public string BaseString64
        {
            get { return _BaseString64; }
            set { _BaseString64 = value; OnPropertyChanged("BaseString64"); }
        }

        public bool UpdateFoto; 

        //private Image _Foto;
        //public Image Foto
        //{
        //    get { return _Foto; }
        //    set { _Foto = value; OnPropertyChanged("Foto"); }
        //}

        //public ImageFormat Formato { get; set; }

        //public string UrlFoto { get; set; }

        //private string _ImageLocation;
        //public string ImageLocation
        //{
        //    get { return _ImageLocation; }
        //    set
        //    {
        //        _ImageLocation = value; OnPropertyChanged("ImageLocation");
        //        if (ImageLocation != string.Empty)
        //        {
        //            try
        //            {
        //                Foto = Image.FromFile(_ImageLocation);
        //            }
        //            catch (Exception)
        //            {

        //            }
        //        }
        //    }
        //}

        private decimal _CostoProducto;

        public decimal CostoProducto
        {
            get { return _CostoProducto; }
            set
            {
                _CostoProducto = value;
                OnPropertyChanged(nameof(CostoProducto));
            }
        }

        private decimal _PorcentajeP;
        public decimal PorcentajeP
        {
            get { return _PorcentajeP; }
            set
            {
                _PorcentajeP = value;
                OnPropertyChanged(nameof(PorcentajeP));
            }
        }


        //BUSQUEDA
        private string _Busqueda;
        public string Busqueda
        {
            get { return _Busqueda; }
            set
            {
                _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }
        #endregion

        #region InotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
