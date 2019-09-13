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
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public PromocionViewModel(IPromocionRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaPromocion = new BindingList<Promocion>();
            GetAllAsync();
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
        

        
        #endregion

        #region Binding
        private int _IdFormaPago;

        public int IdFormaPago
        {
            get { return _IdFormaPago; }
            set
            {
                _IdFormaPago = value;
                OnPropertyChanged(nameof(IdFormaPago));
            }
        }

        private Guid? _IdUsuarioL;
        public Guid? IdUsuarioL
        {
            get { return _IdUsuarioL; }
            set
            {
                _IdUsuarioL = value;
                OnPropertyChanged(nameof(IdUsuarioL));
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
