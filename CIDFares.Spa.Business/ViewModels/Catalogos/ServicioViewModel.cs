using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ServicioViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IServicioRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Servicio> ListaServicio { get; set; }
        public EntityState State { get; set; }
        #endregion

        public ServicioViewModel(IServicioRepository servicioRepository)
        {
            Repository = servicioRepository;
            ListaServicio = new BindingList<Servicio>();
            GetAllAsync();
        }

        #region Metodos
        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaServicio.Clear();
                foreach (var item in x)
                {
                    ListaServicio.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)
        private int _IdServicio;

        public int IdServicio
        {
            get { return _IdServicio; }
            set
            {
                _IdServicio = value;
                OnPropertyChanged(nameof(IdServicio));
            }
        }

        private int _IdTipoIva;

        public int IdTipoIva
        {
            get { return _IdTipoIva; }
            set
            {
                _IdTipoIva = value;
                OnPropertyChanged(nameof(IdTipoIva));
            }
        }

        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set
            {
                _Clave = value;
                OnPropertyChanged(nameof(Clave));
            }
        }

        private string _TipoServicio;

        public string TipoServicio
        {
            get { return _TipoServicio; }
            set
            {
                _TipoServicio = value;

                OnPropertyChanged(nameof(TipoServicio));
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

        private decimal _Precio;

        public decimal Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private decimal _Duracion;

        public decimal Duracion
        {
            get { return _Duracion; }
            set
            {
                _Duracion = value;
                OnPropertyChanged(nameof(Duracion));
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


        private decimal _Porcentaje;

        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set
            {
                _Porcentaje = value;
                OnPropertyChanged(nameof(Porcentaje));
            }
        }

        private string _PorcentajeStr;

        public string PorcentajeStr
        {
            get { return _PorcentajeStr; }
            set
            {
                _PorcentajeStr = value;
                OnPropertyChanged(nameof(PorcentajeStr));
            }
        }

        private string _DescIva;

        public string DescIva
        {
            get { return _DescIva; }
            set
            {
                _DescIva = value;
                OnPropertyChanged(nameof(DescIva));
            }
        }

        private bool _AplicaIva;

        public bool AplicaIva
        {
            get { return _AplicaIva; }
            set
            {
                _AplicaIva = value;
                OnPropertyChanged(nameof(AplicaIva));
            }
        }

        private bool _AplicaIEPS;

        public bool AplicaIEPS
        {
            get { return _AplicaIEPS; }
            set
            {
                _AplicaIEPS = value;
                OnPropertyChanged(nameof(AplicaIEPS));
            }
        }

        private bool _IEPSMonto;

        public bool IEPSMonto
        {
            get { return _IEPSMonto; }
            set
            {
                _IEPSMonto = value;
                OnPropertyChanged(nameof(IEPSMonto));
            }
        }

        private decimal _IEPS;

        public decimal IEPS
        {
            get { return _IEPS; }
            set
            {
                _IEPS = value;
                OnPropertyChanged(nameof(IEPS));
            }
        }

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        #endregion
    }

}
