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
    public class ServicioRepository : Repository, IServicioRepository
    {
        public Task<Servicio> AddAsync(Servicio element)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Servicio>> GetAllAsync()
        {
            throw new NotImplementedException();
            //[Catalogo].[SPCID_Get_Servicio]
        }

        public Task<Servicio> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Servicio> UpdateAsync(Servicio element)
        {
            throw new NotImplementedException();
        }
    }
}
