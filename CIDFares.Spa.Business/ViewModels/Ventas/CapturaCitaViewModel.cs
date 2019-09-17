using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class CapturaCitaViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ICapturaCitaRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<CapturaCita> ListaCapturaCita { get; set; }
        public BindingList<CapturaCita> ListaCapturaCitaDetalle { get; set; }
        //List<Syncfusion.WinForms.Input.SpecialDate> list = new List<Syncfusion.WinForms.Input.SpecialDate>();
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CapturaCitaViewModel(ICapturaCitaRepository capturaCitaRepository)
        {
            Repository = capturaCitaRepository;
            ListaCapturaCita = new BindingList<CapturaCita>();
            ListaCapturaCitaDetalle = new BindingList<CapturaCita>();
        }
        #endregion

        #region Metodos
        //public async Task GetAllAsync()
        //{
        //    try
        //    {
        //        var x = await Repository.GetAllAsync();
        //        ListaCapturaCita.Clear();
        //        foreach (var item in x)
        //        {
        //            ListaCapturaCita.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public async Task GetSpecialDates()
        //{
        //    try
        //    {
        //        var x = await Repository.GetCitaXPeriodo(this.FechaInicio, this.FechaFinal);
        //        ListaCapturaCita.Clear();
        //        foreach (var item in x)
        //        {
        //            ListaCapturaCita.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public async Task GetCitaXPeriodo()
        {
            try
            {
                var x = await Repository.GetCitaXPeriodo(this.FechaInicio, this.FechaFinal);
                ListaCapturaCita.Clear();
                foreach (var item in x)
                {
                    ListaCapturaCita.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetCitaDetalle(DateTime? fecha)
        {
            try
            {
                var x = await Repository.GetCitaDetalle(fecha);
                ListaCapturaCitaDetalle.Clear();
                foreach (var item in x)
                {
                    ListaCapturaCitaDetalle.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<CapturaCita> GuardarCita(Guid idCuentaUsuario, int IdSucursal)
        {
            CapturaCita model = new CapturaCita
            {
                //ClienteVenta = new Cliente { IdCliente = this.IdCliente },
                //Folio = this.Folio,
                //SubTotal = this.SubTotal,
                //Total = this.Total,
                //Efectivo = this.Efectivo,
                //PorcentajeIva = this.Iva,
                //TablaProducto = TablaProducto,
                //TablaFormaPago = TablaFormaPago,
                //TablaServicio = TablaServicio
            };
            return await Repository.AddCita(model, idCuentaUsuario, IdSucursal);
        }
        #endregion

        #region Binding
        private Guid _IdCita;

        public Guid IdCita
        {
            get { return _IdCita; }
            set
            {
                _IdCita = value;
                OnPropertyChanged(nameof(IdCita));
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

        private string _Observaciones;

        public string Observaciones
        {
            get { return _Observaciones; }
            set
            {
                _Observaciones = value;
                OnPropertyChanged(nameof(Observaciones));
            }
        }

        private DateTime _FechaCita;

        public DateTime FechaCita
        {
            get { return _FechaCita; }
            set
            {
                _FechaCita = value;
                OnPropertyChanged(nameof(FechaCita));
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

        private Image _imagen;

        public Image imagen
        {
            get { return _imagen; }
            set
            {
                _imagen = value;
                OnPropertyChanged(nameof(imagen));
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

        private string _EstadoCita;

        public string EstadoCita
        {
            get { return _EstadoCita; }
            set
            {
                _EstadoCita = value;
                OnPropertyChanged(nameof(EstadoCita));
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
