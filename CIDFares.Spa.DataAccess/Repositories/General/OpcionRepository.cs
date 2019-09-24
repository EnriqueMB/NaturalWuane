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
    public class OpcionRepository : Repository, IopcionesRepository
    {      
        public Task<OpcionCuestionario> AddAsync(OpcionCuestionario element, object IdUsuario)
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

        public async Task<IEnumerable<OpcionCuestionario>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    List<OpcionCuestionario> Lista = new List<OpcionCuestionario>();
                    OpcionCuestionario Item;

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[spCID_Get_Encuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new OpcionCuestionario();
                        Item.datos.IdEncuesta = dr.GetGuid(dr.GetOrdinal("IdEncuesta"));
                        Item.datos.NombreEncuesta = dr.GetString(dr.GetOrdinal("NombreEncuesta"));
                        Item.datos.IdTipoEncuesta = dr.GetInt32(dr.GetOrdinal("IdTipoEncuesta"));
                        Item.datos.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        Lista.Add(Item);
                    }
                    dr.Close();
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<OpcionCuestionario> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<OpcionCuestionario> UpdateAsync(OpcionCuestionario element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
