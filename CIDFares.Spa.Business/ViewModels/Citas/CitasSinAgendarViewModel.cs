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

namespace CIDFares.Spa.Business.ViewModels.Citas
{
    public class CitasSinAgendarViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ICapturaCitaRepository Repository { get; set; }        
        #endregion

        #region Propiedades públicas
        public BindingList<CapturaCita> ListaCitasSinAgendar { get; set; }              
        public EntityState State { get; set; }
        #endregion

        public CitasSinAgendarViewModel(ICapturaCitaRepository capturaCitaRepository)
        {
            Repository = capturaCitaRepository;
            ListaCitasSinAgendar = new BindingList<CapturaCita>();            
        }

        public async Task GetCitasSinAgendar(string nombreCompleto, int IdSucursal)
        {
            try
            {
                var x = await Repository.GetCitasSinAgendar(nombreCompleto, IdSucursal);
                ListaCitasSinAgendar.Clear();
                foreach (var item in x)
                {
                    ListaCitasSinAgendar.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Binding
        private int _IdSucursal;

        public int IdSucursal
        {
            get { return _IdSucursal; }
            set
            {
                _IdSucursal = value;
                OnPropertyChanged(nameof(IdSucursal));
            }
        }

        private Guid _IdAgendaCita;

        public Guid IdAgendaCita
        {
            get { return _IdAgendaCita; }
            set
            {
                _IdAgendaCita = value;
                OnPropertyChanged(nameof(IdAgendaCita));
            }
        }

        private Guid _IdOrdenServicio;

        public Guid IdOrdenServicio
        {
            get { return _IdOrdenServicio; }
            set
            {
                _IdOrdenServicio = value;
                OnPropertyChanged(nameof(IdOrdenServicio));
            }
        }

        private Guid _IdOrdenPaquete;

        public Guid IdOrdenPaquete
        {
            get { return _IdOrdenPaquete; }
            set
            {
                _IdOrdenPaquete = value;
                OnPropertyChanged(nameof(IdOrdenPaquete));
            }
        }

        private int _IdPaquete;

        public int IdPaquete
        {
            get { return _IdPaquete; }
            set
            {
                _IdPaquete = value;
                OnPropertyChanged(nameof(IdPaquete));
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

        private string _NombrePaquete;

        public string NombrePaquete
        {
            get { return _NombrePaquete; }
            set
            {
                _NombrePaquete = value;
                OnPropertyChanged(nameof(NombrePaquete));
            }
        }

        private DateTime _FechaInicio;

        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set
            {
                _FechaInicio = value;
                OnPropertyChanged(nameof(FechaInicio));
            }
        }

        private DateTime _FechaFinal;

        public DateTime FechaFinal
        {
            get { return _FechaFinal; }
            set
            {
                _FechaFinal = value;
                OnPropertyChanged(nameof(FechaFinal));
            }
        }

        private Guid _IdCliente;

        public Guid IdCliente
        {
            get { return _IdCliente; }
            set
            {
                _IdCliente = value;
                OnPropertyChanged(nameof(IdCliente));
            }
        }

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

        private int _IdEstadoCita;


        public int IdEstadoCita
        {
            get { return _IdEstadoCita; }
            set
            {
                _IdEstadoCita = value;
                OnPropertyChanged(nameof(IdEstadoCita));
            }
        }

        private string _NombreCompleto;

        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set
            {
                _NombreCompleto = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }                       

        private string _Servicio;

        public string Servicio
        {
            get { return _Servicio; }
            set
            {
                _Servicio = value;
                OnPropertyChanged(nameof(Servicio));
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
