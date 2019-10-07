using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System.Data;
using CIDFares.Library.Code.Utilities.IBase;

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class VentasViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IFormaPagoRepository RepositoryFormaPago { get; set; }
        private IVentaRepository Repository { get; set; }
        private IServicioRepository ServicioRepository { get; set; }
        private IPaqueteRepository PaqueteRepository { get; set; }
        public IBusqProductoRepository BusqProductoRepository { get; set; }
        public IImpresoraTicket         Ticket { get; set; }
        #endregion

        #region Propiedades públicas
        public ClienteViewModel ModelCliente { get; set; }
        public PaqueteViewModel ModelPaquete { get; set; }
        public BindingList<Venta> Listaventa { get; set; }
        public BindingList<FormaPago> ListaFormaPago { get; set; }
        public BindingList<BusqueProducto> ListaBusquedaProducto { get; set; }
        public BindingList<Servicio> ListaServicio { get; set; }
        public BindingList<Paquetes> ListaPaquete { get; set; }
        public DataTable TablaFormaPago { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }
        public DataTable TablaPaquete { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public VentasViewModel(IFormaPagoRepository formaPagoRepository, IVentaRepository ventaRepository, IBusqProductoRepository busqProductoRepository, IServicioRepository servicioRepository, IPaqueteRepository paqueteRepository, IImpresoraTicket ticket)
        {
            ServicioRepository = servicioRepository;
            PaqueteRepository = paqueteRepository;
            Repository = ventaRepository;
            RepositoryFormaPago = formaPagoRepository;
            BusqProductoRepository = busqProductoRepository;
            Ticket = ticket;
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            ModelPaquete = ServiceLocator.Instance.Resolve<PaqueteViewModel>();
            Listaventa = new BindingList<Venta>();
            ListaFormaPago = new BindingList<FormaPago>();
            ListaBusquedaProducto = new BindingList<BusqueProducto>();
            ListaServicio = new BindingList<Servicio>();
            ListaPaquete = new BindingList<Paquetes>();
            this.FechaVenta = DateTime.Now;
            this.IdSucursal = 1;
            //this.Folio = string.Empty;
            GetAllAsync();
            GetFolio();
        }
        #endregion

        #region Metodos
        public async Task GetAllAsync()
        {
            try
            {
                var x = await RepositoryFormaPago.GetAllAsync();
                ListaFormaPago.Clear();
                foreach (var item in x)
                {
                    if (item.Nombre == "Efectivo")
                    {
                        item.Seleccionar = true;
                        item.Cantidad = this.Total;
                    }
                    ListaFormaPago.Add(item);
                }
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
                this.Folio = await Repository.GetFolio();
            }
            catch (Exception ex)
            {
        
                throw ex;
            }
        }

        public async Task GetBusquedaRapida(int TipoBusqueda, string Busqueda)
        {
            try
            {
                if (TipoBusqueda == 1)
                {
                    var x = await BusqProductoRepository.GetBusquedaProductoAsync(false, Busqueda, true, Busqueda);
                    ListaBusquedaProducto.Clear();
                    foreach (var item in x)
                    {
                        ListaBusquedaProducto.Add(item);
                    }
                }
                else if (TipoBusqueda == 2)
                {
                    var x = await ServicioRepository.GetBusqServicioAsync(false, Busqueda, true, Busqueda);
                    ListaServicio.Clear();
                    foreach (var item in x)
                    {
                        ListaServicio.Add(item);
                    }
                }
                else if (TipoBusqueda == 3)
                {
                    var x = await PaqueteRepository.GetBusqPaqueteAsync(false, Busqueda, true, Busqueda);
                    ListaPaquete.Clear();
                    foreach (var item in x)
                    {
                        ListaPaquete.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> CheckCantidadProducto(int IdProducto, int Cantidad)
        {
            try
            {
                return await Repository.CheckCantidadProducto(IdProducto, Cantidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetVentaFechaDiaIdSucursal()
        {
            var x = await Repository.GetVentaDiasSucursalActiva(this.FechaVenta, this.IdSucursal, this.Folio);
            Listaventa.Clear();
            foreach (var item in x)
            {
                Listaventa.Add(item);
            }
        }
        #endregion

        #region Binding
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

        private decimal _Efectivo;
        public decimal Efectivo
        {
            get { return _Efectivo; }
            set
            {
                _Efectivo = value;
                OnPropertyChanged(nameof(Efectivo));
            }
        }

        private Guid _IdCliente;
        public Guid IdCliente
        {
            get { return _IdCliente; }
            set
            {
                _IdCliente = value;
                OnPropertyChanged(nameof(Efectivo));
            }
        }

        private string _Folio;
        public string Folio
        {
            get { return _Folio; }
            set
            {
                _Folio = value;
                OnPropertyChanged(nameof(Folio));
            }
        }

        private string _FolioCliente;
        public string FolioCliente
        {
            get { return _FolioCliente; }
            set
            {
                _FolioCliente = value;
                OnPropertyChanged(nameof(FolioCliente));
            }
        }

        private int _IdTurno;
        public int IdTurno
        {
            get { return _IdTurno; }
            set
            {
                _IdTurno = value;
                OnPropertyChanged(nameof(IdTurno));
            }
        }

        private DateTime _FechaVenta;
        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set
            {
                _FechaVenta = value;
                OnPropertyChanged(nameof(FechaVenta));
            }
        }

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

        private Guid _IdVenta;

        public Guid IdVenta
        {
            get { return _IdVenta; }
            set
            {
                _IdVenta = value;
                OnPropertyChanged(nameof(IdVenta));
            }
        }


        #endregion

        #region InotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task<Venta> GuardarVenta(Guid idCuentaUsuario, int IdSucursal)
        {
            Venta model = new Venta
            {
                ClienteVenta = new Cliente { IdCliente = this.IdCliente },
                Folio = this.Folio,
                SubTotal = this.SubTotal,
                Total = this.Total,
                Efectivo = this.Efectivo,
                PorcentajeIva = this.Iva,
                TablaProducto = TablaProducto,
                TablaFormaPago = TablaFormaPago,
                TablaServicio = TablaServicio,
                TablaPaquete = TablaPaquete,
                IdTurno = this.IdTurno
            };
            return await Repository.AddWithIdSucursalAsync(model, idCuentaUsuario, IdSucursal);
        }

        public async Task<int> GuardarAbono(Guid idCuentaUsuario)
        {
            AbonoPaquete model = new AbonoPaquete
            {
                TablaFormaPago = TablaFormaPago,
                TablaPaquete = ModelPaquete.TablaAbonoPaquete,
                IdTurno = this.IdTurno
            };
            return await PaqueteRepository.AddAbonoAsync(model, idCuentaUsuario);
        }
        #endregion
    }

}