using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<Cliente> AddAsync(Cliente element)
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

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
