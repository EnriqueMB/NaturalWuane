using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class PaquetesClienteViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ICapturaCitaRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public EntityState State { get; set; }
        public BindingList<OrdenServicio> ListaOrdenServicio { get; set; }
        #endregion

        #region Constructor
        public PaquetesClienteViewModel(ICapturaCitaRepository capturaCitaRepository)
        {
            Repository = capturaCitaRepository;
            ListaOrdenServicio = new BindingList<OrdenServicio>();
        }
        #endregion
        public async void GetAllAsync(int IdSucursal)
        {
            try
            {
                var x = await Repository.GetCitasSinPagar(IdCliente, IdSucursal);
                ListaOrdenServicio.Clear();
                foreach (var item in x)
                {
                    ListaOrdenServicio.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #region Binding

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

        #region InotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}