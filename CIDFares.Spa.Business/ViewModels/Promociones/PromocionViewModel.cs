using System;
using System.Collections.Generic;
using System.ComponentModel;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System.Data;

namespace CIDFares.Spa.Business.ViewModels.Promociones
{
    public class PromocionViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IPromocionRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Promocion> ListaPromocion { get; set; }
        public BindingList<PromocionMxN> ListaPromocionMxN { get; set; }
        public BindingList<TipoPromocion> ListaTipoPromocion { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public PromocionViewModel(IPromocionRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaPromocion = new BindingList<Promocion>();
            ListaTipoPromocion = new BindingList<TipoPromocion>();
            ListaPromocionMxN = new BindingList<PromocionMxN>();
            GetAllAsync();
        }
        #endregion

        #region Metodos
        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaPromocion.Clear();
                foreach (var item in x)
                {
                    ListaPromocion.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<PromocionDescuento> GuardarPromocionDescuento(Guid IdUsuario)
        {
            try
            {
                PromocionDescuento model = new PromocionDescuento();
                model.Promocion.IdTipoPromocion = this.IdTipoPromocion;
                model.Promocion.IdGenerico = this.IdGenerico;
                model.Promocion.EsProducto = this.EsProducto;
                model.EsMonto = this.EsMonto;
                model.Descuento = this.Descuento;
                model.PromocionDias.EsPeriodo = this.EsPeriodo;
                model.PromocionDias.FechaFinal = this.FechaInicio;
                model.PromocionDias.FechaInicio = this.FechaInicio;
                model.PromocionDias.Lunes = this.Lunes;
                model.PromocionDias.Martes = this.Martes;
                model.PromocionDias.Miercoles = this.Miercoles;
                model.PromocionDias.Jueves = this.Jueves;
                model.PromocionDias.Viernes = this.Viernes;
                model.PromocionDias.Sabado = this.Sabado;
                model.PromocionDias.Domingo = this.Domingo;
                model.PromocionDias.Limite = this.Limite;
                if (State == EntityState.Create)
                {
                    return await Repository.AddPromocionDescuento(model, IdUsuario);
                }
                //else if (State == EntityState.Update)
                //{
                //    return await Repository.UpdateAsync(model, IdUsuario);
                //}
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PromocionNxN> GuardarPromocionNxN(Guid IdUsuario)
        {
            try
            {
                PromocionNxN model = new PromocionNxN();
                model.Promocion.IdTipoPromocion = this.IdTipoPromocion;
                model.Promocion.IdGenerico = this.IdGenerico;
                model.Promocion.EsProducto = this.EsProducto;
                model.Cantidad = this.Cantidad;
                model.CantidadGratis = this.CantidadGratis;
                model.PromocionDias.EsPeriodo = this.EsPeriodo;
                model.PromocionDias.FechaFinal = this.FechaInicio;
                model.PromocionDias.FechaInicio = this.FechaInicio;
                model.PromocionDias.Lunes = this.Lunes;
                model.PromocionDias.Martes = this.Martes;
                model.PromocionDias.Miercoles = this.Miercoles;
                model.PromocionDias.Jueves = this.Jueves;
                model.PromocionDias.Viernes = this.Viernes;
                model.PromocionDias.Sabado = this.Sabado;
                model.PromocionDias.Domingo = this.Domingo;
                model.PromocionDias.Limite = this.Limite;
                if (State == EntityState.Create)
                {
                    return await Repository.AddPromocionNxN(model, IdUsuario);
                }
                //else if (State == EntityState.Update)
                //{
                //    return await Repository.UpdateAsync(model, IdUsuario);
                //}
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PromocionMxN> GuardarPromocionMxN(Guid IdUsuario)
        {
            try
            {
                PromocionMxN model = new PromocionMxN();
                model.Promocion.IdTipoPromocion = this.IdTipoPromocion;
                model.Promocion.IdGenerico = this.IdGenerico;
                model.Promocion.EsProducto = this.EsProducto;
                model.Cantidad = this.Cantidad;
                model.TablaProducto = this.TablaProducto;
                model.TablaServicio = this.TablaServicio;
                model.PromocionDias.EsPeriodo = this.EsPeriodo;
                model.PromocionDias.FechaFinal = this.FechaInicio;
                model.PromocionDias.FechaInicio = this.FechaInicio;
                model.PromocionDias.Lunes = this.Lunes;
                model.PromocionDias.Martes = this.Martes;
                model.PromocionDias.Miercoles = this.Miercoles;
                model.PromocionDias.Jueves = this.Jueves;
                model.PromocionDias.Viernes = this.Viernes;
                model.PromocionDias.Sabado = this.Sabado;
                model.PromocionDias.Domingo = this.Domingo;
                model.PromocionDias.Limite = this.Limite;
                if (State == EntityState.Create)
                {
                    return await Repository.AddPromocionMxN(model, IdUsuario);
                }
                //else if (State == EntityState.Update)
                //{
                //    return await Repository.UpdateAsync(model, IdUsuario);
                //}
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region combo tipo promoción 

        public void LlenarTipoPromocion(IEnumerable<TipoPromocion> tipoPromocions)
        {
            ListaTipoPromocion.Clear();
            foreach (var item in tipoPromocions)
            {
                ListaTipoPromocion.Add(item);
            }
        }

        public async Task<IEnumerable<TipoPromocion>> GetListaTipoPromocion()
        {
            try
            {
                var tipoPromocion = await Repository.LlenarComboTipoPromocion();
                return tipoPromocion;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Binding
        private int _IdTipoPromocion;

        public int IdTipoPromocion
        {
            get { return _IdTipoPromocion; }
            set { _IdTipoPromocion = value; OnPropertyChanged("IdTipoPromocion"); }
        }

        private bool _EsProducto;

        public bool EsProducto
        {
            get { return _EsProducto; }
            set
            {
                _EsProducto = value;
                OnPropertyChanged(nameof(EsProducto));
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

        private BusqueProducto _Producto;

        public BusqueProducto Producto
        {
            get { return _Producto; }
            set {
                _Producto = value;
                OnPropertyChanged(nameof(Producto));
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

        private bool _EsMonto;

        public bool EsMonto
        {
            get { return _EsMonto; }
            set
            {
                _EsMonto = value;
                OnPropertyChanged(nameof(EsMonto));
            }
        }

        private decimal _Descuento;

        public decimal Descuento
        {
            get { return _Descuento; }
            set
            {
                _Descuento = value;
                OnPropertyChanged(nameof(Descuento));
            }

        }

        private bool _EsPeriodo;

        public bool EsPeriodo
        {
            get { return _EsPeriodo; }
            set
            {
                _EsPeriodo = value;
                OnPropertyChanged(nameof(EsPeriodo));
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

        private bool _Lunes;

        public bool Lunes
        {
            get { return _Lunes; }
            set
            {
                _Lunes = value;
                OnPropertyChanged(nameof(Lunes));
            }
        }

        private bool _Martes;

        public bool Martes
        {
            get { return _Martes; }
            set
            {
                _Martes = value;
                OnPropertyChanged(nameof(Martes));
            }
        }

        private bool _Miercoles;

        public bool Miercoles
        {
            get { return _Miercoles; }
            set
            {
                _Miercoles = value;
                OnPropertyChanged(nameof(Miercoles));
            }
        }

        private bool _Jueves;

        public bool Jueves
        {
            get { return _Jueves; }
            set
            {
                _Jueves = value;
                OnPropertyChanged(nameof(Jueves));
            }
        }

        private bool _Viernes;

        public bool Viernes
        {
            get { return _Viernes; }
            set
            {
                _Viernes = value;
                OnPropertyChanged(nameof(Viernes));
            }
        }

        private bool _Sabado;

        public bool Sabado
        {
            get { return _Sabado; }
            set
            {
                _Sabado = value;
                OnPropertyChanged(nameof(Sabado));
            }
        }

        private bool _Domingo;

        public bool Domingo
        {
            get { return _Domingo; }
            set
            {
                _Domingo = value;
                OnPropertyChanged(nameof(Domingo));
            }
        }

        private int _IdGenerico;

        public int IdGenerico
        {
            get { return _IdGenerico; }
            set
            {
                _IdGenerico = value;
                OnPropertyChanged(nameof(IdGenerico));
            }
        }

        private int _Limite;

        public int Limite
        {
            get { return _Limite; }
            set
            {
                _Limite = value;
                OnPropertyChanged(nameof(Limite));
            }
        }

        //Promocion N * N
        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set
            {
                _Cantidad = value;
                OnPropertyChanged(nameof(Cantidad));
            }
        }

        private int _CantidadGratis;

        public int CantidadGratis
        {
            get { return _CantidadGratis; }
            set
            {
                _CantidadGratis = value;
                OnPropertyChanged(nameof(CantidadGratis));
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
