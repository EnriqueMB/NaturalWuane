using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ProductoRepository : Repository, IFormaPagoRepository
    {
        public Task<FormaPago> AddAsync(FormaPago element)
        {
            throw new NotImplementedException();
        }

        public Task <int>DeleteAsync(object id)
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

        public Task<FormaPago> UpdateAsync(FormaPago element)
        {
            throw new NotImplementedException();
        }
    }
}
