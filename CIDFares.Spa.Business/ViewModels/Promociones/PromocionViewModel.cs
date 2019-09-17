using System;
using System.Collections.Generic;
using System.ComponentModel;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;

namespace CIDFares.Spa.Business.ViewModels.Promociones
{
    public class PromocionViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IPromocionRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Promocion> ListaPromocion { get; set; }
        public BindingList<TipoPromocion> ListaTipoPromocion { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public PromocionViewModel(IPromocionRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaPromocion = new BindingList<Promocion>();
            ListaTipoPromocion = new BindingList<TipoPromocion>();
        }
        #endregion

        #region Metodos
        public async Task<IEnumerable<Promocion>> GetAllAsync()
            {
            try
            {
                var Puesto = await Repository.GetAllAsync();
                    return Puesto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region combo tipo promoción 

        public void LlenarTipoPromocion(IEnumerable<TipoPromocion> tipoPromocions)
        {
            ListaTipoPromocion.Clear();
            foreach (var item in tipoPromocions)
            {
                ListaTipoPromocion.Add(item);
            }
        }

        public async Task<IEnumerable<TipoPromocion>> GetListaTipoPromocion()
        {
            try
            {
                var tipoPromocion = await Repository.LlenarComboTipoPromocion();
                return tipoPromocion;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Binding
        private int _IdTipoPromocion;

        public int IdTipoPromocion
        {
            get { return _IdTipoPromocion; }
            set { _IdTipoPromocion = value; OnPropertyChanged("IdTipoPromocion"); }
        }

        private bool _EsProducto;

        public bool EsProducto
        {
            get { return _EsProducto; }
            set
            {
                _EsProducto = value;
                OnPropertyChanged(nameof(EsProducto));
            }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private BusqueProducto _Producto;

        public BusqueProducto Producto
        {
            get { return _Producto; }
            set {
                _Producto = value;
                OnPropertyChanged(nameof(Producto));
            }
        }


        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
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
