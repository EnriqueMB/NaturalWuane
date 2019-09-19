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
        #endregion

        #region Propiedades públicas
        public BindingList<CapturaCita> ListaCapturaCita { get; set; }
        public BindingList<CapturaCita> ListaCapturaCitaDetalle { get; set; }
        public BindingList<CapturaCita> ListaCapturaCitaDetalleServicio { get; set; }
        public DataTable TablaGServicio { get; set; }
        //List<Syncfusion.WinForms.Input.SpecialDate> list = new List<Syncfusion.WinForms.Input.SpecialDate>();
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CapturaCitaViewModel(ICapturaCitaRepository capturaCitaRepository)
        {
            Repository = capturaCitaRepository;
            ListaCapturaCita = new BindingList<CapturaCita>();
            ListaCapturaCitaDetalle = new BindingList<CapturaCita>();
            ListaCapturaCitaDetalleServicio = new BindingList<CapturaCita>();
        }
        #endregion

        #region Metodos

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
                CapturaCita model = new CapturaCita
                {
                    IdCita = IdCita,
                    IdServicio = IdServicio,
                    Servicio = Servicio,
                    IdCliente = IdCliente,
                    FechaCita = FechaCita,
                    //FechaIServicio = FechaIServicio,
                    //FechaFServicio = FechaFServicio,
                    TablaServicio = TablaGServicio,                                        
                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddCita(model, IdUsuario, IdSucursal);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public async Task GetCitaDetalleServicio(Guid idCita)
        {
            try
            {
                var x = await Repository.GetCitaDetalleServicio(idCita);
                ListaCapturaCitaDetalleServicio.Clear();
                foreach (var item in x)
                {
                    ListaCapturaCitaDetalleServicio.Add(item);
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

        private DateTime _FechaIServicio;

        public DateTime FechaIServicio
        {
            get { return _FechaIServicio; }
            set
            {
                _FechaIServicio = value;
                OnPropertyChanged(nameof(FechaIServicio));
            }
        }

        private DateTime _FechaFServicio;

        public DateTime FechaFServicio
        {
            get { return _FechaFServicio; }
            set
            {
                _FechaFServicio = value;
                OnPropertyChanged(nameof(FechaFServicio));
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
