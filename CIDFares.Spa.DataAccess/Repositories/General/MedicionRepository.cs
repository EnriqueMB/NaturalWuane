using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class MedicionRepository : Repository, IMedicionRepository
    {
        public async Task<Medicion> AddAsync(Medicion element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var result = await conexion.QueryFirstOrDefaultAsync<Medicion>("[Catalogo].[SPCID_A_MedicionPaciente]", param: element, commandType: CommandType.StoredProcedure);
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
                    Parametros.Add("@IdMedicion", id);
                    Parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_MedicionPaciente]", param: Parametros, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<Medicion>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var lista = await conexion.QueryAsync<Medicion>("[Catalogo].[SPCID_Get_MedicionPaciente]", commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Medicion> GetAsync(object id)
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                var objeto = await conexion.QueryFirstOrDefaultAsync<Medicion>("[Catalogo].[SPCID_Get_MedicionPacienteXId]", param: id, commandType: CommandType.StoredProcedure);
                return objeto;
            }
        }

        public async Task<int> NameExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@Opcion", 17);
                    Parametros.Add("@Nombre", name);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public async Task<Medicion> UpdateAsync(Medicion element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var result = await conexion.QueryFirstOrDefaultAsync<Medicion>("[Catalogo].[SPCID_C_MedicionPaciente]", param: element, commandType: CommandType.StoredProcedure);
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
