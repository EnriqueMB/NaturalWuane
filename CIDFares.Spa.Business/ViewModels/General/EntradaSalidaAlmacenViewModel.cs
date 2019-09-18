using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
   public class EntradaSalidaAlmacenViewModel : Validable , INotifyPropertyChanged
    {
        #region proppiedades privadas
        private IEntradaSalidaAlmacenRepository IRepository { get; set; }
        private IProductoRepository IProductoRepository { get; set; }
        #endregion

        #region propiedades publicas
        public DataTable TablaEntradaAlmacen { get; set; }
        public DataTable TablaSalidaAlmacen { get; set; }
       // public BindingList<BusqueProducto> ListaBusquedaProducto { get; set; }
        public BindingList<Producto> ListaProducto { get; set; }
        #endregion

        #region constructor
        public EntradaSalidaAlmacenViewModel(IEntradaSalidaAlmacenRepository repository, IProductoRepository ProductoRepository)
        {
            IRepository = repository;
            IProductoRepository = ProductoRepository;
            ListaProducto = new BindingList<Producto>();
            #region  Binding
            Folio = string.Empty;
            Busqueda = string.Empty;
            Tipo = 0;
            Cantidad = 0;
            Fecha = DateTime.Now;
            #endregion
        }
        #endregion

        #region Metodos
        public async Task CargarDatos()
        {
            try
            {
                var x = await IProductoRepository.CargarDatos();
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

        public async Task GetBusqueda()
        {
            try
            {
                var x = await IProductoRepository.GetBusquedaAsync(this.Busqueda);
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

        #endregion

        #region Binding


        private string _Folio;

        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; OnPropertyChanged("Folio"); }
        }
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
        private int _Tipo;

        public int Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; OnPropertyChanged("Tipo"); }
        }

        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; OnPropertyChanged("Cantidad"); }
        }

        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; OnPropertyChanged("Fecha"); }
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
