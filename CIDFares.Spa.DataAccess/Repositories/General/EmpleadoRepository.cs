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
    public class EmpleadoRepository : Repository, IEmpleadoRepository
    {
        public Task<Empleado> AddAsync(Empleado element)
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

        public Task<IEnumerable<Empleado>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Empleado>> GetComboEmpleado()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Empleado>("[Usuario].[SPCID_Get_ComboEmpleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

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

        public Task<Empleado> UpdateAsync(Empleado element)
        {
            throw new NotImplementedException();
        }
    }
}
