using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class TurnoPrincipalRepository : Repository
    {
        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            try
            {
                using(IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdTurno", id);
                    Parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_Turno]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Turno>> GetAllAsync()
        {
            //throw new NotImplementedException();
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var lista = await conexion.QueryAsync<Turno>("[Catalogo].[SPCID_Get_Turnos]", commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
