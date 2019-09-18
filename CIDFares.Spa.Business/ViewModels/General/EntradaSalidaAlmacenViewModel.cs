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
        private IProductoRepository BusqProductoRepository { get; set; }
        #endregion

        #region propiedades publicas
        public DataTable TablaEntradaAlmacen { get; set; }
        public DataTable TablaSalidaAlmacen { get; set; }
        public BindingList<BusqueProducto> ListaBusquedaProducto { get; set; }
        #endregion

        #region constructor
        public EntradaSalidaAlmacenViewModel(IEntradaSalidaAlmacenRepository repository, IProductoRepository BusquedaRepository)
        {
            IRepository = repository;
            BusqProductoRepository = BusquedaRepository;
            ListaBusquedaProducto = new BindingList<BusqueProducto>();
            #region  Binding

            #endregion
        }
        #endregion

        #region Metodos

        #endregion

        #region Binding
        

        private string _Folio;

        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; OnPropertyChanged("Folio"); }
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
