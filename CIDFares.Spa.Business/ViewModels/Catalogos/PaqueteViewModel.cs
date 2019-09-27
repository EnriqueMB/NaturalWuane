using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.CrossCutting.Services;
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

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class PaqueteViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IPaqueteRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        public ClienteViewModel ModelCliente { get; set; }
        public BindingList<Paquetes> ListaPaquete { get; set; }
        public BindingList<Paquetes> ListaPaqueteAgendada { get; set; }
        public BindingList<PaqueteDetalle> ListaDetallePaquete { get; set; }
        public BindingList<AbonoPaquete> ListaAbonoPaquete { get; set; }
        public BindingList<AbonoPaquete> ListaEspera { get; set; }
        public EntityState State { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }


        public DataTable TablaAbonoPaquete { get; set; }
        #endregion

        #region Constructor

        public PaqueteViewModel(IPaqueteRepository paqueteRepository)
        {
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            Repository = paqueteRepository;
            ListaPaquete = new BindingList<Paquetes>();
            ListaDetallePaquete = new BindingList<PaqueteDetalle>();
            ListaAbonoPaquete = new BindingList<AbonoPaquete>();
            ListaEspera = new BindingList<AbonoPaquete>();
            ListaPaqueteAgendada = new BindingList<Paquetes>();
            this.Cantidad = 1;
        }

        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetAllAgendada(int idSucursal)
        {
            try
            {
                var x = await Repository.GetAllAgendaAsync(this.IdCliente, idSucursal);
                ListaPaqueteAgendada.Clear();
                foreach (var item in x)
                {
                    ListaPaqueteAgendada.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetAllAbonoPaquete(int idSucursal)
        {
            try
            {
                var x = await Repository.GetAllAbonoPaqueteAsync(this.IdCliente, idSucursal);
                ListaAbonoPaquete.Clear();
                foreach (var item in x)
                {
                    item.Fecha = item.FechaVenta.ToString("yyyy/MM/dd");
                    ListaAbonoPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ListaDetalle()
        {
            try
            {
                var x = await Repository.GetAsync(this.IdPaquete);
                ListaDetallePaquete.Clear();
                foreach (var item in x.ListaDetallePaquete)
                {
                    ListaDetallePaquete.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Paquetes> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Paquetes model = new Paquetes();               
                model.IdPaquete = this.IdPaquete;
                model.Clave = this.Clave;
                model.Nombre = this.Nombre;
                model.Descripcion = this.Descripcion;
                model.NPersona = this.NPersonal;
                model.NPago = this.NPago;
                model.MontoPaquete = this.MontoPaquete;
                model.FechaVencimiento = this.FechaVencimiento;
                model.TablaProducto = this.TablaProducto;
                model.TablaServicio = this.TablaServicio;
                if (State == EntityState.Create)
                {
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    model = await Repository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await Repository.DeleteAsync(this.IdPaquete, this.IdUsuarioL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task BusquedaPaquete()
        {
            try
            {
                var x = await Repository.GetBusqPaqueteAsync(this.BandNombre, this.Nombre, this.BandClave, this.Clave);
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Binding(Variables)
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

        private string _NPersonal;
        public string NPersonal
        {
            get { return _NPersonal; }
            set
            {
                _NPersonal = value;
                OnPropertyChanged(nameof(NPersonal));
            }
        }

        private string _NPago;
        public string NPago
        {
            get { return _NPago; }
            set
            {
                _NPago = value;
                OnPropertyChanged(nameof(NPago));
            }
        }

        private decimal _MontoPaquete;
        public decimal MontoPaquete
        {
            get { return _MontoPaquete; }
            set
            {
                _MontoPaquete = value;
                OnPropertyChanged(nameof(MontoPaquete));
            }
        }

        private DateTime _FechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set
            {
                _FechaVencimiento = value;
                OnPropertyChanged(nameof(FechaVencimiento));
            }
        }

        private Guid _IdUsuarioL;
        public Guid IdUsuarioL
        {
            get { return _IdUsuarioL; }
            set
            {
                _IdUsuarioL = value;
                OnPropertyChanged(nameof(IdUsuarioL));
            }
        }

        private bool _BandNombre;
        public bool BandNombre
        {
            get { return _BandNombre; }
            set
            {
                _BandNombre = value;
                OnPropertyChanged(nameof(BandNombre));
            }
        }

        private bool _BandClave;
        public bool BandClave
        {
            get { return _BandClave; }
            set
            {
                _BandClave = value;
                OnPropertyChanged(nameof(BandClave));
            }
        }

        private int _Cantidad;
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
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

        private decimal _PagoPaquete;
        public decimal PagoPaquete
        {
            get { return _PagoPaquete; }
            set
            {
                _PagoPaquete = value;
                OnPropertyChanged(nameof(PagoPaquete));
            }
        }

        private decimal _Adeudo;

        public decimal Adeudo
        {
            get { return _Adeudo; }
            set
            {
                _Adeudo = value;
                OnPropertyChanged(nameof(Adeudo));
            }
        }

        private decimal _Total ;

        public decimal Total 
        {
            get { return _Total ; }
            set
            {
                _Total = value;
                OnPropertyChanged(nameof(Total));
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
