using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class SeleccionarPagoViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        #endregion

        #region Propiedades públicas
        public FormaPagoViewModel ModelFormaPago { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public SeleccionarPagoViewModel()
        {
            ModelFormaPago = ServiceLocator.Instance.Resolve<FormaPagoViewModel>();
        }
        #endregion
        private void GetAllAsync()
        {
            ModelFormaPago.GetAllAsync();
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
