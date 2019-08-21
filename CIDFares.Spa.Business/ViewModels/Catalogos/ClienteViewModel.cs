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
    public class ClienteViewModel
    {
        #region Propiedades privadas
        private IClienteRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Cliente> ListaCliente { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ClienteViewModel(IClienteRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaCliente = new BindingList<Cliente>();
            GetAll();
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaCliente.Clear();
                foreach (var item in x)
                {
                    ListaCliente.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)

        #endregion
    }
}
