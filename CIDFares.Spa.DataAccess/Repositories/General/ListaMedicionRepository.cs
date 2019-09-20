using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ListaMedicionRepository : Repository, IListaMedicionRepository
    {
        public async Task<ListaMedicion> AddAsync(ListaMedicion element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var result = await conexion.QueryFirstOrDefaultAsync<ListaMedicion>("[Catalogo].[SPCID_A_ListaMedicion]", param: element, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdListaMedicion", id);
                    Parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_ListaMedicion]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ListaMedicion>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var lista = await conexion.QueryAsync<ListaMedicion>("[Catalogo].[SPCID_Get_ListaMedicion]", commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ListaMedicion> GetAsync(object id)
        {
            try
            {
                ListaMedicion medicion = new ListaMedicion();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var lista = await conexion.QueryAsync<ValorLista>("[Catalogo].[SPCID_Get_ValoresListaMedicion]", commandType: CommandType.StoredProcedure);
                    medicion.DatosValor = lista;
                    return medicion;
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

        public async Task<ListaMedicion> UpdateAsync(ListaMedicion element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var result = await conexion.QueryFirstOrDefaultAsync<ListaMedicion>("[Catalogo].[SPCID_C_ListaMedicion]", param: element, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
