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

        public async Task<int> GuardarFotoProducto(string Clave, Guid IdUsuario)
        {
            try
            {
                Producto producto = new Producto
                {
                    Clave = Clave,
                    UpdateFoto = UpdateFoto,
                    Base64String = new Bitmap(Foto).ToBase64String(Formato),
                    UrlFoto = UrlFoto
                };
                return await IRepository.AddFotoProducto(producto, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
                PrecioMayoreo = producto.PrecioMayoreo;
                PrecioMenudeo = producto.PrecioMenudeo;
                CodigoBarras = producto.CodigoBarras;
                IdUnidadMedida = producto.IdUnidadMedida;
                ClaveSat = producto.ClaveSat;
                AplicaIva = producto.AplicaIva;                                            
                Foto = (string.IsNullOrEmpty(producto.Base64String)) ? null : producto.Base64String.ImageBase64ToImage();
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
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    IdProducto = IdProducto,
                    IdCategoriaProducto = IdCategoriaProducto,
                    IdUnidadMedida = IdUnidadMedida,
                    Clave = Clave,
                    PrecioPublico = PrecioPublico,
                    PrecioMayoreo = PrecioMayoreo,
                    PrecioMenudeo = PrecioMenudeo,
                    AplicaIva = AplicaIva,
                    Stock = Stock,
                    StockMax = StockMax,
                    StockMin = StockMin,
                    Descripcion = Descripcion,
                    ClaveSat = ClaveSat,
                    CodigoBarras=CodigoBarras,
                    IdAplicaIva=IdAplicaIva,
                    CostoProducto = this.CostoProducto,
                    PorcentajeP = this.PorcentajeP
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
        public string Extencion { get; set; } 
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

        private Image _Foto;
        public Image Foto
        {
            get { return _Foto; }
            set { _Foto = value; OnPropertyChanged("Foto"); }
        }

        public ImageFormat Formato { get; set; }

        public string UrlFoto { get; set; }

        private string _ImageLocation;
        public string ImageLocation
        {
            get { return _ImageLocation; }
            set
            {
                _ImageLocation = value; OnPropertyChanged("ImageLocation");
                if (ImageLocation != string.Empty)
                {
                    try
                    {
                        Foto = Image.FromFile(_ImageLocation);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

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
