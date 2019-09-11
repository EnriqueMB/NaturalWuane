using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class ProductosMonederoViewModel : Validable
    {
        #region Propiedades Privadas
        private IProductosMonederoRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        #endregion

        #region Constructor
        public ProductosMonederoViewModel(IProductosMonederoRepository repository)
        {
            Repository = repository;
        }
        #endregion
        private int _IdProducto;

        #region Metodos
        public async Task GetPuntosMonedero()
        {
            try
            {
                var result = await Repository.GetAsync(IdProducto);
                if(result != null)
                {
                    PuntosMonedero = result.PuntosMonedero;
                    AplicaDescuento = result.AplicaDescuento;
                    EsMonto = result.EsMonto;
                    PuntosDescuento = result.PuntosDescuento;
                    Monto = result.Monto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> AddPuntosProducto(Guid IdUsuario)
        {
            try
            {
                ProductosMonedero productosMonedero = new ProductosMonedero
                {
                    IdProducto = IdProducto,
                    PuntosMonedero = PuntosMonedero,
                    AplicaDescuento = AplicaDescuento,
                    EsMonto = EsMonto,
                    PuntosDescuento = PuntosDescuento,
                    Monto = Monto
                };
                var result = await Repository.AddAsync(productosMonedero, IdUsuario);
                if (result != null)
                {
                    return result.IdProducto;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        private int _PuntoMonedero;

        public int PuntosMonedero
        {
            get { return _PuntoMonedero; }
            set { _PuntoMonedero = value; OnPropertyChanged(nameof(PuntosDescuento)); }
        }

        private bool _AplicaDescuento;

        public bool AplicaDescuento
        {
            get { return _AplicaDescuento; }
            set { _AplicaDescuento = value; OnPropertyChanged(nameof(AplicaDescuento)); }
        }

        private bool _EsMonto;

        public bool EsMonto
        {
            get { return _EsMonto; }
            set { _EsMonto = value; OnPropertyChanged(nameof(EsMonto)); }
        }

        private int _PuntosDescuento;

        public int PuntosDescuento
        {
            get { return _PuntosDescuento; }
            set { _PuntosDescuento = value; OnPropertyChanged(nameof(PuntosDescuento)); }
        }

        private decimal _Monto;

        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; OnPropertyChanged(nameof(Monto)); }
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
