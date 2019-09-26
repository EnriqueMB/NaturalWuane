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
using System.Reflection;
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
            this.FechaCompra = DateTime.Now;
            //GetFolio();
        }
        #endregion

        #region Metodos
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
            try
            {
                Compra model = new Compra
                {
                    ProveedorCompra = new Proveedor { IdProveedor = this.IdProveedor },
                    Folio = this.Folio,
                    SubTotal = this.SubTotal,
                    Total = this.Total,
                    PorcentajeIva = this.Iva,
                    TablaProducto = TablaProducto,
                    IdEstatus = this.IdEstatus,
                };
                return await Repository.AddWithIdSucursalAsync(model, IdCuentaUsuario, IdSucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public async Task<Compra> ModificarCompra(Guid IdUsuario)
        {
            try
            {
                Compra C = new Compra
                {
                    ProveedorCompra = new Proveedor { IdProveedor = this.IdProveedor },
                    IdCompra = this.IdCompra,
                    SubTotal = this.SubTotal,
                    Total = this.Total,
                    PorcentajeIva = this.Iva,
                    TablaProducto = TablaProducto,
                    IdSucursal = this.IdSucursal,
                    IdEstatus = this.IdEstatus,
                };
                return await Repository.UpdateAsync(C, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public async Task ObtenerComprasCreadas(int IdSucursal)
        {
            try
            {
                var x = await Repository.GetCompraCreadasAsync(this.Folio, IdSucursal, this.FechaInicio, this.FechaFin);
                ListaCompra.Clear();
                foreach (var item in x)
                {
                    ListaCompra.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        public async Task<int> GuardaCancelacionCompra(string Motivo, int IdSucursal, Guid IdCuentaUsuario)
        {
            try
            {
                return await Repository.AddCancelacionAsync(this.IdCompra, Motivo, IdSucursal, IdCuentaUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public async Task<int> ProcesarCompra(int IdSucursal, Guid IdCuentaUsuario)
        {
            try
            {
                Compra P = new Compra
                {
                    ProveedorCompra = new Proveedor { IdProveedor = this.IdProveedor },
                    IdCompra = this.IdCompra,
                    SubTotal = this.SubTotal,
                    Total = this.Total,
                    PorcentajeIva = this.Iva,
                    TablaProducto = TablaProducto,
                    IdSucursal = this.IdSucursal,
                };
                return await Repository.ProcesarAsync(P, IdSucursal, IdCuentaUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetDetalle()
        {
            try
            {
                var x = Repository.GetAsync(this.IdCompra);
                ListaCompra.Clear();
                if (x.Result.ProveedorCompra.IdProveedor != Guid.Empty)
                {
                    this.IdProveedor = x.Result.ProveedorCompra.IdProveedor;
                    ModelProveedor.NombreComercial = x.Result.ProveedorCompra.NombreComercial;
                    ModelProveedor.Clave = x.Result.ProveedorCompra.Clave;
                    ModelProveedor.Telefono = x.Result.ProveedorCompra.Telefono;
                    ModelProveedor.Representante = x.Result.ProveedorCompra.Representante;
                    ModelProveedor.Direccion = x.Result.ProveedorCompra.Direccion;
                }
                if (x.Result.IdCompra != Guid.Empty)
                {
                    this.IdCompra = x.Result.IdCompra;
                    this.Folio = x.Result.Folio;
                    this.FechaCompra = x.Result.FechaCompra;
                    this.Iva = x.Result.Iva;
                    this.Total = x.Result.Total;
                    this.SubTotal = x.Result.SubTotal;
                }
                for (int i = 0; i < x.Result.TablaProducto.Rows.Count; i++)
                {
                    Compra C = new Compra();
                    C.IdCompra = Guid.Parse(x.Result.TablaProducto.Rows[i]["IdCompra"].ToString());
                    C.IdCompraProducto = Guid.Parse(x.Result.TablaProducto.Rows[i]["IdCompraProducto"].ToString());
                    C.IdProducto = int.Parse(x.Result.TablaProducto.Rows[i]["IdProducto"].ToString());
                    C.Cantidad = decimal.Parse(x.Result.TablaProducto.Rows[i]["Cantidad"].ToString());
                    C.Nombre = x.Result.TablaProducto.Rows[i]["Nombre"].ToString();
                    C.PrecioCosto = decimal.Parse(x.Result.TablaProducto.Rows[i]["PrecioCosto"].ToString());
                    C.PorcentajeIva = decimal.Parse(x.Result.TablaProducto.Rows[i]["PorcentajeIva"].ToString());
                    ListaCompra.Add(C);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }        
        #endregion

        #region Binding
        private Guid _IdCompra;
        public Guid IdCompra
        {
            get { return _IdCompra; }
            set
            {
                _IdCompra = value;
                OnPropertyChanged(nameof(IdCompra));
            }
        }
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
        private DateTime _FechaFin;
        public DateTime FechaFin
        {
            get { return _FechaFin; }
            set
            {
                _FechaFin = value;
                OnPropertyChanged(nameof(FechaFin));
            }
        }
        private DateTime _FechaCompra;
        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set
            {
                _FechaCompra = value;
                OnPropertyChanged(nameof(FechaCompra));
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
        private int _IdEstatus;
        public int IdEstatus
        {
            get { return _IdEstatus; }
            set
            {
                _IdEstatus = value;
                OnPropertyChanged(nameof(IdEstatus));
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
