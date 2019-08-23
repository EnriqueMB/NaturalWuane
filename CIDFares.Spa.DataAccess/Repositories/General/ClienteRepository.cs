using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ClienteRepository : Repository, IClienteRepository
    {
        public async Task<Cliente> AddAsync(Cliente element)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", element.NuevoRegistro);
                    dynamicParameters.Add("@IdCliente", element.IdCliente);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@NombreCompleto", element.NombreCompleto);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@FechaNacimiento", element.FechaNacimiento);
                    dynamicParameters.Add("@Sexo", element.Sexo);
                    dynamicParameters.Add("@Foto", element.Foto);
                    dynamicParameters.Add("@Rfc", element.Rfc);
                    dynamicParameters.Add("@IdUsuarioL", element.IdUsuarioL);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Cliente].[SPCID_AC_Cliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Cliente> Lista = new List<Cliente>();
                    Cliente item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Cliente].[SPCID_Get_Cliente]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Cliente();
                        item.IdCliente = dr.GetGuid(dr.GetOrdinal("IdCliente"));
                        item.LocalId = dr.GetInt32(dr.GetOrdinal("LocalId"));
                        item.NombreCompleto = dr.GetString(dr.GetOrdinal("NombreCompleto"));
                        if (!dr.IsDBNull(dr.GetOrdinal("FechaNacimiento")))
                        {
                            DateTime date = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                            item.Edad = DateTime.Today.AddTicks(-date.Ticks).Year - 1;
                        }
                        else
                            item.Edad = 0;
                        item.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
                        item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                        item.Rfc = dr.GetString(dr.GetOrdinal("Rfc"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo")));
                        Lista.Add(item);
                    }
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Cliente> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> ObtenerFoto(Guid IdCliente)
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@IdCliente", IdCliente);
                var dr = await conexion.ExecuteScalarAsync<string>("[Cliente].[SPCID_Get_ObtenerFotoCliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                return dr.ToString();
            }
        }
        public Task<Cliente> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> UpdateAsync(Cliente element)
        {
            throw new NotImplementedException();
        }

    }
}
