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

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class VentasViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IFormaPagoRepository RepositoryFormaPago { get; set; }
        private IVentaRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public ClienteViewModel ModelCliente{ get; set; }
        public BindingList<Venta> Listaventa { get; set; }
        public BindingList<FormaPago> ListaFormaPago { get; set; }
        public DataTable TablaFormaPago { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public VentasViewModel(IFormaPagoRepository formaPagoRepository, IVentaRepository ventaRepository)
        {
            Repository = ventaRepository;
            RepositoryFormaPago = formaPagoRepository;
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            Listaventa = new BindingList<Venta>();
            ListaFormaPago = new BindingList<FormaPago>();
            GetAllAsync();
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
        #endregion

        #region InotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task<Venta> GuardarVenta(Guid idCuentaUsuario)
        {
            Venta model = new Venta
            {
                //TablaPersonal = obtenerTabla(),
                TablaFormaPago = TablaFormaPago
                //IdPersonal = GDatos.IdPersonal,
            };
            return await Repository.AddAsync(model, idCuentaUsuario);
        }
        #endregion
    }
}
