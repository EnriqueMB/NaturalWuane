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
        #endregion

        #region Propiedades públicas
        public BindingList<Producto> ListaProducto { get; set; }
        public BindingList<CategoriaProducto> ListaCategoria { get; set; }
        public BindingList<UnidadMedida> ListaUnidadMedida { get; set; }

        public EntityState State { get; set; }
        public ProductoViewModel PDatos { get; set; }
        #endregion

        #region Constructor
        public ProductoViewModel(IProductoRepository IProductoRepository, ICategoriaProductoRepository respositoryCategoria, IUnidadMedidaRepository respositoryUnidadMedida)
        {
            IRepository = IProductoRepository;
            ListaProducto = new BindingList<Producto>();
            ListaCategoria = new BindingList<CategoriaProducto>();
            RespositoryCategoria = respositoryCategoria;
            RespositoryUnidadMedida = respositoryUnidadMedida;


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

        public async Task<int> GuardarFotoProducto(string clave)
        {
            try
            {
                Producto producto = new Producto
                {
                    Clave = clave,
                    UpdateFoto = PDatos.UpdateFoto,
                    Base64String = new Bitmap(PDatos.Foto).ToBase64String(PDatos.Formato),
                    UrlFoto = PDatos.UrlFoto
                };
                return await IRepository.AddFotoProducto(producto);
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
                producto = await IRepository.GetProductoXid(PDatos.IdProducto);
                PDatos.Nombre = producto.Nombre;
                PDatos.IdCategoria = producto.IdCategoria;
                PDatos.Clave = producto.Clave;
                PDatos.UnidadMedida = producto.UnidadMedida;
                PDatos.PrecioPublico = producto.PrecioPublico;
                PDatos.AplicaIva = producto.AplicaIva;
                PDatos.Stock = producto.Stock;
                PDatos.StockMax = producto.StockMax;
                PDatos.StockMin = producto.StockMin;
                PDatos.PrecioMayoreo = producto.PrecioMayoreo;
                PDatos.PrecioMenudeo = producto.PrecioMenudeo;
                PDatos.StockMax = producto.StockMax;
                PDatos.Descripcion = producto.Descripcion;
                PDatos.Foto = (string.IsNullOrEmpty(producto.Base64String)) ? null : producto.Base64String.ImageBase64ToImage();
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
        #region combo UnidadNegocio

        public void LlenarListaUnidadNegocio(IEnumerable<UnidadMedida> UnidadNegocio)
        {
            foreach (var item in UnidadNegocio)
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
        public void LlenarListaCategoria(IEnumerable<CategoriaProducto> categoria)
        {
            foreach (var item in categoria)
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




        public async Task<string> GuardarCambios()
        {
            try
            {
                Producto producto = new Producto
                {
                    IdProducto = PDatos.IdProducto,
                    IdCategoria = PDatos.IdCategoria,
                    Clave = PDatos.Clave,
                    IdUnidadMedida = PDatos.IdUnidadMedida,
                    PrecioPublico = PDatos.PrecioPublico,
                    PrecioMayoreo = PDatos.PrecioMayoreo,
                    PrecioMenudeo = PDatos.PrecioMenudeo,
                    AplicaIva = PDatos.AplicaIva,
                    Stock = PDatos.Stock,
                    StockMax = PDatos.StockMax,
                    StockMin = PDatos.StockMin,
                    Descripcion = PDatos.Descripcion

                };
                if (State == EntityState.Create)
                {

                    return await IRepository.AddWitClave(producto);
                }
                else if (State == EntityState.Update)
                {               
                    return await IRepository.Update(producto);
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
            set { _IdProducto = value; OnPropertyChanged(nameof(IdProducto)); }
        }

        private string _Categoria;

        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; OnPropertyChanged(nameof(Categoria)); }
        }

        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; OnPropertyChanged(nameof(Clave)); }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged(nameof(Nombre)); }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; OnPropertyChanged(nameof(Descripcion)); }
        }


        private bool _Stock;

        public bool Stock
        {
            get { return _Stock; }
            set { _Stock = value; OnPropertyChanged(nameof(Stock)); }
        }

        private int _StockMax;

        public int StockMax
        {
            get { return _StockMax; }
            set { _StockMax = value; OnPropertyChanged(nameof(StockMax)); }
        }

        private int _StockMin;

        public int StockMin
        {
            get { return _StockMin; }
            set { _StockMin = value; OnPropertyChanged(nameof(StockMin)); }
        }

        private decimal _PrecioPublico;

        public decimal PrecioPublico
        {
            get { return _PrecioPublico; }
            set { _PrecioPublico = value; OnPropertyChanged(nameof(PrecioPublico)); }
        }


        private decimal _PrecioMayoreo;

        public decimal PrecioMayoreo
        {
            get { return _PrecioMayoreo; }
            set { _PrecioMayoreo = value; OnPropertyChanged(nameof(PrecioMayoreo)); }
        }

        private decimal _PrecioMenudeo;

        public decimal PrecioMenudeo
        {
            get { return _PrecioMenudeo; }
            set { _PrecioMenudeo = value; OnPropertyChanged(nameof(PrecioMenudeo)); }
        }

        private string _CodigoBarras;

        public string CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; OnPropertyChanged(nameof(CodigoBarras)); }
        }

        private int? _IdUnidadMedida;

        public int? IdUnidadMedida
        {
            get { return _IdUnidadMedida; }
            set { _IdUnidadMedida = value; OnPropertyChanged(nameof(IdUnidadMedida)); }
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
            set { _ClaveSat = value; OnPropertyChanged(nameof(ClaveSat)); }
        }

        private bool _AplicaIva;

        public bool AplicaIva
        {
            get { return _AplicaIva; }
            set { _AplicaIva = value; OnPropertyChanged(nameof(AplicaIva)); }
        }
        public string Extencion { get; set; } 
        private int _Usuario;

        public int Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; OnPropertyChanged(nameof(Usuario)); }
        }

        private int? _IdCategoria;
        public int? IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; OnPropertyChanged("IdCategoria"); }
        }

        //propiedades par la foto

        private string _BaseString64;

        public string BaseString64
        {
            get { return _BaseString64; }
            set { _BaseString64 = value; OnPropertyChanged(nameof(BaseString64)); }
        }

        private bool _UpdateFoto;

        public bool UpdateFoto
        {
            get { return _UpdateFoto; }
            set { _UpdateFoto = value; OnPropertyChanged(nameof(UpdateFoto)); }
        }

        //para combo
        private int? _IdCategoriaProducto;

        public int? IdCategoriaProducto
        {
            get { return _IdCategoriaProducto; }
            set { _IdCategoriaProducto = value; OnPropertyChanged("IdCategoriaProducto"); }
        }

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
