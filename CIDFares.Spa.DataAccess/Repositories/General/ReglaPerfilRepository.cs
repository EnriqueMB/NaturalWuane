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
    public class ReglaPerfilRepository : Repository, IReglaPerfilRepository
    {
        public async Task<ReglasRol> AddAsync(ReglasRol element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaRegla", element.TablaRegla, DbType.Object);
                    dynamicParameters.Add("@IdRol", element.IdRol);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_ReglasRol]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReglasRol>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReglasRol> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReglasRol>> LLenarGridXID(int? IdRol)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdRol", IdRol);
                    List<ReglasRol> Lista = new List<ReglasRol>();
                    ReglasRol Item;
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_ReglaRol]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new ReglasRol();
                        Item.ReglaAsignada = dr.GetBoolean(dr.GetOrdinal("ReglaAsignada"));
                        Item.IdRegla = dr.GetInt32(dr.GetOrdinal("IdRegla"));
                        Item.NombrePermiso = dr.GetString(dr.GetOrdinal("NombrePermiso"));
                        Item.NombreRegla = dr.GetString(dr.GetOrdinal("NombreRegla"));
                        Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ReglasRol> UpdateAsync(ReglasRol element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
