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
        private IVentaRepository VentaRepository { get; set; }
        #endregion

        #region propiedades publicas
        public DataTable TablaEntradaAlmacen { get; set; }
        public DataTable TablaSalidaAlmacen { get; set; }
       // public BindingList<BusqueProducto> ListaBusquedaProducto { get; set; }
        public BindingList<EntradaSalidaAlmacen> ListaProducto { get; set; }
        #endregion

        #region constructor
        public EntradaSalidaAlmacenViewModel(IEntradaSalidaAlmacenRepository repository, IProductoRepository ProductoRepository, IVentaRepository Venta)
        {
            IRepository = repository;
            IProductoRepository = ProductoRepository;
            VentaRepository = Venta;
            ListaProducto = new BindingList<EntradaSalidaAlmacen>();
            #region  Binding
           // Folio = string.Empty;
            Busqueda = string.Empty;
            Tipo = "S";
            Cantidad = 0;
            Fecha = DateTime.Now;
            #endregion
        }
        #endregion

        #region Metodos
        public async Task<EntradaSalidaAlmacen> GuardarEntradaSalida(Guid IdUsuario)
        {
            EntradaSalidaAlmacen model = new EntradaSalidaAlmacen
            {
                TablaEntradaSalidaAlmacen = this.TablaEntradaAlmacen,
                Folio = this.Folio,
                Tipo = this.Tipo,
                Fecha = this.Fecha,
                Cantidad = this.Cantidad,
                Motivo = this.Motivo,
                SubTotal = this.SubTotal,
                Iva = this.Iva,
                Total = this.Total
               
            };
            return await IRepository.AddAsync(model, IdUsuario);
        }

        public async Task<int> CheckCantidadProducto(int IdProducto, int Cantidad, int IdSucursal)
        {
            try
            {
                return await VentaRepository.CheckCantidadProducto(IdProducto, Cantidad, IdSucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetFolio()
        {
            try
            {
                this.Folio = await IRepository.GetFolio();
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
        private string _Tipo;

        public string Tipo
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

        private string _Motivi;

        public string Motivo
        {
            get { return _Motivi; }
            set { _Motivi = value; OnPropertyChanged("Motivo"); }
        }

        private decimal _Total;
        public decimal Total
        {
            get { return _Total; }
            set
            {
                _Total = value;
                OnPropertyChanged(nameof(Total));
            }
        }
        private decimal _SubTotal;
        public decimal SubTotal
        {
            get { return _SubTotal; }
            set
            {
                _SubTotal = value;
                OnPropertyChanged(nameof(SubTotal));
            }
        }
        private decimal _Iva;
        public decimal Iva
        {
            get { return _Iva; }
            set
            {
                _Iva = value;
                OnPropertyChanged(nameof(Iva));
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
