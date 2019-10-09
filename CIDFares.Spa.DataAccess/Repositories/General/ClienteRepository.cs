using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.DataAccess.Contracts.DTOs;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ClienteRepository : Repository, IClienteRepository
    {
        #region Metodos Implementado

        public async Task<Cliente> AddAsync(Cliente element, object IdUsuario)
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
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@FechaNacimiento", element.FechaNacimiento);
                    dynamicParameters.Add("@Sexo", element.Sexo);
                    dynamicParameters.Add("@UrlFoto", element.UrlFoto);
                    dynamicParameters.Add("@Rfc", element.Rfc);
                    dynamicParameters.Add("@email", element.Email);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
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
                        item.UrlFoto = dr.GetString(dr.GetOrdinal("UrlFoto"));
                        if (!dr.IsDBNull(dr.GetOrdinal("FechaNacimiento")))
                        {
                            DateTime date = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                            item.Edad = DateTime.Today.AddTicks(-date.Ticks).Year - 1;
                        }
                        else
                            item.Edad = 0;
                        item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                        item.Email = dr.GetString(dr.GetOrdinal("Email"));
                        item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                        item.Rfc = dr.GetString(dr.GetOrdinal("Rfc"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo")));
                        item.TieneTarjeta = dr.GetBoolean(dr.GetOrdinal("TieneMonedero"));
                        if (!dr.IsDBNull(dr.GetOrdinal("PuntosMonedero")))
                            item.PuntosMonedero = dr.GetInt32(dr.GetOrdinal("PuntosMonedero"));
                        //item.PuntosMonedero = !dr.IsDBNull(dr.GetOrdinal("PuntosMonedero")) ? dr.GetDecimal(dr.GetOrdinal("PuntosMonedero")) : Decimal.Zero;
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
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCliente", IdCliente);
                    var dr = await conexion.ExecuteScalarAsync<string>("[Cliente].[SPCID_Get_ObtenerFotoCliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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


        public async Task<int> DeleteAsync(object id, object IdUsuario)
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
                        item.UrlFoto = dr.GetString(dr.GetOrdinal("UrlFoto"));
                        if (!dr.IsDBNull(dr.GetOrdinal("FechaNacimiento")))
                        {
                            DateTime date = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                            item.Edad = DateTime.Today.AddTicks(-date.Ticks).Year - 1;
                        }
                        else
                            item.Edad = 0;
                        item.Email = dr.GetString(dr.GetOrdinal("Email"));
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

        public async Task<int> SetMonederoCliente(object IdCliente, object IdUsuario, string ClaveTarjeta, int Opcion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    DynamicParameters parametros = new DynamicParameters();
                    parametros.Add("@ClaveTarjeta", ClaveTarjeta);
                    parametros.Add("@IdCliente", IdCliente);
                    parametros.Add("@IdUsuario", IdUsuario);
                    parametros.Add("@Opcion", Opcion);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cliente].[SPCID_A_TarjetaMonederoCliente]", param: parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> AddWithDTO(DTOCliente element, string extencion)
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@NuevoRegistro", element.DatosCliente.NuevoRegistro);
                dynamicParameters.Add("@IdCliente", element.DatosCliente.IdCliente);
                dynamicParameters.Add("@Clave", element.DatosCliente.Clave);
                dynamicParameters.Add("@NombreCompleto", element.DatosCliente.NombreCompleto);
                dynamicParameters.Add("@Telefono", element.DatosCliente.Telefono);
                dynamicParameters.Add("@FechaNacimiento", element.DatosCliente.FechaNacimiento);
                dynamicParameters.Add("@Sexo", element.DatosCliente.Sexo);
                dynamicParameters.Add("@UrlFoto", element.DatosCliente.UrlFoto);
                dynamicParameters.Add("@Ext", extencion);
                dynamicParameters.Add("@Rfc", element.DatosCliente.Rfc);
                dynamicParameters.Add("@email", element.DatosCliente.Email);
                dynamicParameters.Add("@IdUsuarioL", element.DatosCliente.IdUsuarioL);
                dynamicParameters.Add("@TablaDirecciones", element.ListaDireciones.ToDataTable(), DbType.Object);
                var Resultado = await conexion.ExecuteScalarAsync<string>("[Cliente].[SPCID_AC_Cliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                return Resultado;
            }
        }

        public async Task<List<Cliente>> GetAllAsync(int Pagina, int Opcion)
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                List<Cliente> Lista = new List<Cliente>();
                Cliente item;
                var parametros = new DynamicParameters();
                parametros.Add("@Pagina", Pagina);
                parametros.Add("@Cantidad", 50);
                parametros.Add("@Opcion", Opcion);
                var dr = await conexion.ExecuteReaderAsync("[Cliente].[SPCID_Get_Cliente]", param: parametros, commandType: CommandType.StoredProcedure);
                while (dr.Read())
                {
                    item = new Cliente();
                    item.IdCliente = dr.GetGuid(dr.GetOrdinal("IdCliente"));
                    item.LocalId = dr.GetInt32(dr.GetOrdinal("LocalId"));
                    item.NombreCompleto = dr.GetString(dr.GetOrdinal("NombreCompleto"));
                    item.UrlFoto = dr.GetString(dr.GetOrdinal("UrlFoto"));
                    if (!dr.IsDBNull(dr.GetOrdinal("FechaNacimiento")))
                    {
                        DateTime date = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                        item.Edad = DateTime.Today.AddTicks(-date.Ticks).Year - 1;
                    }
                    else
                        item.Edad = 0;
                    item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                    item.Email = dr.GetString(dr.GetOrdinal("Email"));
                    item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                    item.Rfc = dr.GetString(dr.GetOrdinal("Rfc"));
                    item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                    item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo")));
                    item.TieneTarjeta = dr.GetBoolean(dr.GetOrdinal("TieneMonedero"));
                    if (!dr.IsDBNull(dr.GetOrdinal("PuntosMonedero")))
                        item.PuntosMonedero = dr.GetInt32(dr.GetOrdinal("PuntosMonedero"));
                    //item.PuntosMonedero = !dr.IsDBNull(dr.GetOrdinal("PuntosMonedero")) ? dr.GetDecimal(dr.GetOrdinal("PuntosMonedero")) : Decimal.Zero;
                    Lista.Add(item);
                }
                return Lista;
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
        
        public Task<Cliente> UpdateAsync(Cliente element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
