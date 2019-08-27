using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class UnidadMedidaRepository : Repository, IUnidadMedidaRepository
    {
        public Task<UnidadMedida> AddAsync(UnidadMedida element)
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

        public Task<IEnumerable<UnidadMedida>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UnidadMedida> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<BindingList<UnidadMedida>> LlenarComboUnidadMedida()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.QueryAsync<UnidadMedida>("[Catalogo].[SPCID_Get_ComboUnidadMedida]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<UnidadMedida>(dr.ToList());
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

        public Task<UnidadMedida> UpdateAsync(UnidadMedida element)
        {
            throw new NotImplementedException();
        }
    }
}
