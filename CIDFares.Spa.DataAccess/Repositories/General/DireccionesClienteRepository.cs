using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class DireccionesClienteRepository : Repository, IDireccionesClienteRepository
    {
        public async Task<DireccionesCliente> AddAsync(DireccionesCliente element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    element.IdDireccion = Guid.Empty;
                    var result = await conexion.QueryFirstOrDefaultAsync<DireccionesCliente>("[Cliente].[SPCID_A_DireccionesCliente]", param: element, commandType: CommandType.StoredProcedure);
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
                    var parametros = new DynamicParameters();
                    parametros.Add("@IdDireccion", id);
                    parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cliente].[SPCID_Delete_DireccionesCliente]", param: parametros, commandType: CommandType.StoredProcedure);
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

        public Task<IEnumerable<DireccionesCliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DireccionesCliente> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DireccionesClienteRequest>> GetDirecciones(object IdCliente)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var parametros = new DynamicParameters();
                    parametros.Add("IdCliente", IdCliente);
                    var result = await conexion.QueryAsync<DireccionesClienteRequest, Estado, Municipio, DireccionesClienteRequest>("[Cliente].[SPCID_Get_DireccionesCliente]",
                        (direcciones, estado, municipio) =>
                        {
                            direcciones.DatosEstado = estado;
                            direcciones.DatosMunicipio = municipio;
                            return direcciones;
                        },
                        splitOn: "IdDireccion, IdEstado, IdMunicipio", param: parametros, commandType: CommandType.StoredProcedure);
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

        public Task<DireccionesCliente> UpdateAsync(DireccionesCliente element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var result = conexion.QueryFirstOrDefaultAsync<DireccionesCliente>("[Cliente].[SPCID_A_DireccionesCliente]", param: element, commandType: CommandType.StoredProcedure);
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
