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
        #region Metodos Implementado

        public async Task<Cliente> AddAsync(Cliente element)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", element.NuevoRegistro);
                    dynamicParameters.Add("@UpdateFoto", element.UpdateFoto);
                    dynamicParameters.Add("@IdCliente", element.IdCliente);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@NombreCompleto", element.NombreCompleto);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@FechaNacimiento", element.FechaNacimiento);
                    dynamicParameters.Add("@Sexo", element.Sexo);
                    dynamicParameters.Add("@Foto", element.FotoBase64);
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

<<<<<<< HEAD
        public async Task<IEnumerable<Cliente>> GetAllAsync()
=======
        public Task<int> DeleteAsync(Object id)
>>>>>>> Spa/Usuario
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
                        item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
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

        public async Task<int> DeleteAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCliente", id);
                    //dynamicParameters.Add("@IdUsuarioL", CurrrentSession.IdUS)
                    var result = await conexion.ExecuteScalarAsync<int>("[Nomina].[SPCID_Delete_Personal]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Elimnar(object id, int? IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCliente", id);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cliente].[SPCID_Delete_Cliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Cliente>> GetBusquedaAsync(string Busqueda)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Cliente> Lista = new List<Cliente>();
                    Cliente item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Busqueda", Busqueda);
                    var dr = await conexion.ExecuteReaderAsync("[Cliente].[SPCID_Get_ObtenerBusquedaCliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        #endregion

        #region Metodo No Implementado

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> UpdateAsync(Cliente element)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
