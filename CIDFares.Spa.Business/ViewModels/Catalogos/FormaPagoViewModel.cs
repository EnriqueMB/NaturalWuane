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
    public class FormaPagoViewModel
    {
        #region Propiedades privadas
        private IFormaPagoRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<FormaPago> ListaFormaPago { get; set; }
        //public EntityState State { get; set; }
        #endregion

        #region Constructor
        public FormaPagoViewModel(IFormaPagoRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaFormaPago = new BindingList<FormaPago>();
            GetAll();
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaFormaPago.Clear();
                foreach (var item in x)
                {
                    ListaFormaPago.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
