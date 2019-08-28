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
    public class VentasViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        #endregion

        #region Propiedades públicas
        public ClienteViewModel ModelCliente{ get; set; }
        //public BindingList<FormaPago> ListaFormaPago { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public VentasViewModel()
        {
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            //Repository = formaPagoRepository;
            //ListaFormaPago = new BindingList<FormaPago>();
            //GetAllAsync();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
