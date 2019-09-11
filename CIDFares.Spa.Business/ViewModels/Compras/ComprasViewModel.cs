using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
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

namespace CIDFares.Spa.Business.ViewModels.Compras
{
    public class ComprasViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ICompraRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public ProveedorViewModel ModelProveedor { get; set; }
        public BindingList<Compra> ListaCompra { get; set; }
        public DataTable TablaProducto { get; set; }
        public EntityState State { get; set; }
      
        #endregion

     


        #region Constructor
        public ComprasViewModel(ICompraRepository compraRepository)
        {
            Repository = compraRepository;
            ModelProveedor = ServiceLocator.Instance.Resolve<ProveedorViewModel>();
            ListaCompra = new BindingList<Compra>();
            GetFolio();

        }
        #endregion

        #region Metodos
        /*
        public  Task GetAllAsync()
        {
            try
            {
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/

        public async Task GetFolio()
        {
            try
            {
                this.Folio = await Repository.GetFolioCompra();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Compra> GuardarVenta(Guid IdCuentaUsuario, int IdSucursal)
        {
            Compra model = new Compra
            {
                ProveedorCompra = new Proveedor { IdProveedor = this.IdProveedor },
                Folio = this.Folio,
                SubTotal = this.SubTotal,
                Total = this.Total,
                PorcentajeIva = this.Iva,
                TablaProducto = TablaProducto,
                
            };
            return await Repository.AddWithIdSucursalAsync(model, IdCuentaUsuario, IdSucursal);
        }
        #endregion

        #region Binding

        private Guid _IdProveedor;

        public Guid IdProveedor
        {
            get { return _IdProveedor; }
            set
            {
                _IdProveedor = value;
                OnPropertyChanged(nameof(IdProveedor));
            }
        }
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

        private string _ClaveProveedor;

        public string ClaveProveedor
        {
            get { return _ClaveProveedor; }
            set
            {
                _ClaveProveedor = value;
                OnPropertyChanged(nameof(ClaveProveedor));
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
