using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class RolRepository : Repository, IRolRepository
    {
        public Task<Rol> AddAsync(Rol element)
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

        public Task<IEnumerable<Rol>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Rol> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Rol>> GetComboRol()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Rol>("[Usuario].[SPCID_Get_ComboRol]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Rol> UpdateAsync(Rol element)
        {
            throw new NotImplementedException();
        }
    }
}
