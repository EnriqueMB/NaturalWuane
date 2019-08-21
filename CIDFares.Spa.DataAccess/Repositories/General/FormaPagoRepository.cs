using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class FormaPagoRepository : IFormaPagoRepository
    {
        public Task<FormaPago> AddAsync(FormaPago element)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FormaPago>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FormaPago> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FormaPago> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
