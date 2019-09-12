using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class BusquedaProductoViewModel
    {
        #region Propiedades privadas
        private IBusqProductoRepository Repository { get; set; }
        #endregion
        #region Propiedades públicas
        public BindingList<BusqueProducto> ListaBusquedaProducto { get; set; }
        #endregion

        #region Constructor
        public BusquedaProductoViewModel(IBusqProductoRepository busqProductoRepository)
        {
            Repository = busqProductoRepository;
            ListaBusquedaProducto = new BindingList<BusqueProducto>();
            this.CantidadProducto = 1;
        }
        #endregion

        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetBusquedaProductoAsync(this.BuscarNombre, this.BusquedaNombre, this.BuscaClaveCodigo, this.BusquedaClaveCodigo);
                ListaBusquedaProducto.Clear();
                foreach (var item in x)
                {
                    ListaBusquedaProducto.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetAllProducto()
        {
            try
            {
                var x = await Repository.GetBusquedaProductoCompraAsync(this.BuscarNombre, this.BusquedaNombre, this.BuscaClaveCodigo, this.BusquedaClaveCodigo);
                ListaBusquedaProducto.Clear();
                foreach (var item in x)
                {
                    ListaBusquedaProducto.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Binding(Variables)

        private string _BusquedaNombre;
        public string BusquedaNombre
        {
            get { return _BusquedaNombre; }
            set
            {
                _BusquedaNombre = value;
                OnPropertyChanged(nameof(BusquedaNombre));
            }
        }

        private bool _BuscarNombre;
        public bool BuscarNombre
        {
            get { return _BuscarNombre; }
            set
            {
                _BuscarNombre = value;
                OnPropertyChanged(nameof(BuscarNombre));
            }
        }

        private bool _BuscarClaveCodigo;
        public bool BuscaClaveCodigo
        {
            get { return _BuscarClaveCodigo; }
            set
            {
                _BuscarClaveCodigo = value;
                OnPropertyChanged(nameof(BuscaClaveCodigo));
            }
        }

        private string _BusquedaClaveCodigo;
        public string BusquedaClaveCodigo
        {
            get { return _BusquedaClaveCodigo; }
            set
            {
                _BusquedaClaveCodigo = value;
                OnPropertyChanged(nameof(BusquedaClaveCodigo));
            }
        }

        private decimal _CantidadProducto;
        public decimal CantidadProducto
        {
            get { return _CantidadProducto; }
            set
            {
                _CantidadProducto = value;
                OnPropertyChanged(nameof(CantidadProducto));
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
