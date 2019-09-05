using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Compras
{
    public class ComprasViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas

        #endregion

        #region Propiedades públicas
       
        public BindingList<Compra> ListaCompra { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ComprasViewModel()
        {
            //ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            //Repository = formaPagoRepository;
            ListaCompra = new BindingList<Compra>();
            //GetAllAsync();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
