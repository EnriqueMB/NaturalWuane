using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private IPaqueteRepository PaqueteRepository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<CapturaCita> ListaCapturaCita { get; set; }
        public BindingList<CapturaCita> ListaCapturaCitaDetalle { get; set; }
        public BindingList<CapturaCita> ListaCapturaCitaDetalleServicio { get; set; }
        public BindingList<CapturaCita> ListaHoras { get; set; }
        public BindingList<Servicio> ListaServicioPaquete { get; set; }
        public DataTable TablaGServicio { get; set; }        
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CapturaCitaViewModel(ICapturaCitaRepository capturaCitaRepository, IPaqueteRepository paqueteRepository)
        {
            Repository = capturaCitaRepository;
            PaqueteRepository = paqueteRepository;
            ListaCapturaCita = new BindingList<CapturaCita>();
            ListaCapturaCitaDetalle = new BindingList<CapturaCita>();
            ListaCapturaCitaDetalleServicio = new BindingList<CapturaCita>();
            ListaHoras = new BindingList<CapturaCita>();
            ListaServicioPaquete = new BindingList<Servicio>();
            IdHora = new TimeSpan();
        }
        #endregion

        #region Metodos

        //public async Task GetAllServicioPaquete(Paquetes paquete)
        //{
        //    try
        //    {
        //        var x = await PaqueteRepository.GetAsync(paquete.IdPaquete);
        //        ListaCapturaCitaDetalleServicio.Clear();
        //        foreach (var item in x.ListaDetallePaquete)
        //        {
        //            if (item.IdTipo == 2)
        //            {
        //                CapturaCita cita = new CapturaCita();
        //                cita.OrdenServicio.Servicio.Nombre = item.Nombre;
        //                cita.OrdenServicio.Servicio.IdServicio = item.IdGenerico;
        //                ListaCapturaCitaDetalleServicio.Add(cita);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public DataTable obtenerTabla()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdServicio", typeof(int));
                dt.Columns.Add("FechaInicio", typeof(DateTime));
                dt.Columns.Add("FechaFinal", typeof(DateTime));
                foreach (var item in ListaCapturaCitaDetalleServicio)
                {
                    dt.Rows.Add(item);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public async Task<CapturaCita> GuardarCambios(Guid IdUsuario, int IdSucursal)
        {
            try
            {
                //CapturaCita item = new CapturaCita();
                //item.OrdenServicio.IdOrdenServicio = this.IdOrdenServicio;
                //item.OrdenServicio.OrdenPaquete.IdOrdenPaquete = this.IdOrdenPaquete;
                CapturaCita model = new CapturaCita
                {
                    IdAgendaCita = IdAgendaCita,
                    FechaInicio = FechaInicio,
                    FechaFinal = FechaFinal,
                    OrdenServicio = new OrdenServicio
                    {
                        IdOrdenServicio = IdOrdenServicio,                        
                        OrdenPaquete = new OrdenPaquete { IdOrdenPaquete = IdOrdenPaquete,
                                                          Paquete = new Paquetes { IdPaquete = IdPaquete,
                                                                                   Nombre = Nombre } },
                        Cliente = new Cliente { IdCliente = IdCliente,
                                                NombreCompleto = NombreCompleto },
                        Servicio = new Servicio { IdServicio = IdServicio,
                                                  Nombre = Servicio}
                    },

                    //IdCliente = IdCliente,                    
                    //TablaServicio = TablaGServicio,                                        
                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddCita(model, IdUsuario, IdSucursal);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateCita(model, IdUsuario, IdSucursal);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Combo servicio producto
        public async Task<IEnumerable<Servicio>> GetAllServicioPaquete(Paquetes paquetes)
        {
            try
            {
                return await PaqueteRepository.ComboServicios(paquetes.IdPaquete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarListaServicioPaquete(IEnumerable<Servicio> servicios)
        {
            try
            {
                ListaHoras.Clear();
                foreach (var item in servicios)
                {
                    ListaServicioPaquete.Add(item);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        #endregion
        public async Task<int> DeleteAsync(Guid IdAgendaCita, Guid idUsuario)
        {
            try
            {
                return await Repository.DeleteAsync(IdAgendaCita, idUsuario);                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> BusyService( int IdSucursal)
        {
            try
            {
                CapturaCita model = new CapturaCita
                {                    
                    //TablaServicio = TablaGServicio,
                    IdAgendaCita = IdAgendaCita,
                    FechaInicio = FechaInicio,
                    OrdenServicio = new OrdenServicio
                    {
                        IdOrdenServicio = IdOrdenServicio,                        
                        Servicio = new Servicio
                        {
                            IdServicio = IdServicio,
                            Nombre = Servicio
                        }
                    },
                };
                return await Repository.BusyService(model, IdSucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region ComboHoras
        public void LlenarListaHoras(IEnumerable<CapturaCita> cbHoras)
        {
            try
            {
                ListaHoras.Clear();
                foreach (var item in cbHoras)
                {
                    ListaHoras.Add(item);
                }
                if(cbHoras.Count() > 0)
                {
                    IdHora = ListaHoras[0].IdHora;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task<IEnumerable<CapturaCita>> HorarioSucursal(int Dias, int IdSucursal)
        {
            try
            {
                return await Repository.LlenarComboHorarioSucursal(Dias, IdSucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

        public async Task GetCitaXPeriodo(int IdSucursal)
        {
            try
            {
                var x = await Repository.GetCitaXPeriodo(this.FechaInicio, this.FechaFinal, IdSucursal);
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

        public async Task GetCitaDetalle(DateTime? fecha, int IdSucursal)
        {
            try
            {
                var x = await Repository.GetCitaDetalle(fecha, IdSucursal);
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

        //public async Task GetCitaDetalleServicio(Guid idCita)
        //{
        //    try
        //    {
        //        var x = await Repository.GetCitaDetalleServicio(idCita);
        //        ListaCapturaCitaDetalleServicio.Clear();
        //        foreach (var item in x)
        //        {
        //            ListaCapturaCitaDetalleServicio.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}        
        #endregion

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
       
        private DateTime _HoraCita;

        public DateTime HoraCita
        {
            get { return _HoraCita; }
            set
            {
                _HoraCita = value;//FechaCita;
                OnPropertyChanged(nameof(HoraCita));
            }
        }                      

        private string _Cliente;

        public string Cliente
        {
            get { return _Cliente; }
            set
            {
                _Cliente = value;
                OnPropertyChanged(nameof(Cliente));
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

        private TimeSpan _IdHora;

        public TimeSpan IdHora
        {
            get { return _IdHora; }
            set
            {
                _IdHora = value;
                OnPropertyChanged(nameof(IdHora));
            }
        }

        private string _Hora;

        public string Hora
        {
            get { return _Hora; }
            set
            {
                _Hora = value;
                OnPropertyChanged(nameof(Hora));
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

        public int Dias(DateTime FechaSeleccionada)
        {
            switch (FechaSeleccionada.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 7;
                    break;
                case DayOfWeek.Monday:
                    return 1;
                    break;
                case DayOfWeek.Tuesday:
                    return 2;
                    break;
                case DayOfWeek.Wednesday:
                    return 3;
                    break;
                case DayOfWeek.Thursday:
                    return 4;
                    break;
                case DayOfWeek.Friday:
                    return 5;
                    break;
                case DayOfWeek.Saturday:
                    return 6;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
