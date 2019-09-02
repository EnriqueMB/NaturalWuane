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
    public class EstadoRepository : Repository, IEstadoRepository
    {
        public Task<Estado> AddAsync(Estado element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Estado>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Estado> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Estado>> GetComboEstado(int IdPais)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdPais", IdPais);
                    var result = await conexion.QueryAsync<Estado>("[General].[SPCID_Get_ComboEstador]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

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

        public Task<Estado> UpdateAsync(Estado element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
