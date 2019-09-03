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

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class VentasViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas

        #endregion

        #region Propiedades públicas
        public ClienteViewModel ModelCliente{ get; set; }
        public BindingList<Venta> Listaventa { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public VentasViewModel()
        {
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            //Repository = formaPagoRepository;
            Listaventa = new BindingList<Venta>();
            //GetAllAsync();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
