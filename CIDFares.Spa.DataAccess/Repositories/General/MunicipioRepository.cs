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
    public class MunicipioRepository : Repository, IMunicipioRepository
    {
        public Task<Municipio> AddAsync(Municipio element, object IdUsuario)
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

        public Task<IEnumerable<Municipio>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Municipio> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Municipio>> GetComboMunicipio(int IdEstado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEstado", IdEstado);
                    var result = await conexion.QueryAsync<Municipio>("[General].[SPCID_Get_ComboMunicipios]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

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

        public Task<Municipio> UpdateAsync(Municipio element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
