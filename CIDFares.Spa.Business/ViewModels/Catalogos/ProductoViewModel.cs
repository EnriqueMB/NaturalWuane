using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ProductoViewModel : INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IProductoRepository IRepository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Producto> ListaProducto { get; set; }
        public EntityState State { get; set; }
        public ProductoViewModel PDatos { get; set; }
        #endregion

        #region Constructor
        public ProductoViewModel(IProductoRepository IProductoRepository)
        {
            IRepository = IProductoRepository;
            ListaProducto = new BindingList<Producto>();
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
                    ListaProducto.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await IRepository.DeleteAsync(IdProducto);
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

        private int _Categoria;

        public int Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; OnPropertyChanged(nameof(Categoria)); }
        }

        private int _Clave;

        public int Clave
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

        private float _PrecioPublico;

        public float PrecioPublico
        {
            get { return _PrecioPublico; }
            set { _PrecioPublico = value; OnPropertyChanged(nameof(PrecioPublico)); }
        }


        private float _PrecioMayoreo;

        public float PrecioMayoreo
        {
            get { return _PrecioMayoreo; }
            set { _PrecioMayoreo = value; OnPropertyChanged(nameof(PrecioMayoreo)); }
        }

        private float _PrecioMenudeo;

        public float PrecioMenudeo
        {
            get { return _PrecioMenudeo; }
            set { _PrecioMenudeo = value; OnPropertyChanged(nameof(PrecioMenudeo)); }
        }

        private int _CodigoBarras;

        public int CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; OnPropertyChanged(nameof(CodigoBarras)); }
        }

        private string _UnidadMedida;

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; OnPropertyChanged(nameof(UnidadMedida)); }
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

        private int _Usuario;

        public int Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; OnPropertyChanged(nameof(Usuario)); }
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
