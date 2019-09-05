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
    public class PaqueteRepository : Repository, IPaqueteRepository
    {
        #region Metodos Implementados

        public async Task<Paquetes> AddAsync(Paquetes element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", element.NuevoRegistro);
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@NPersona", element.NPersona);
                    dynamicParameters.Add("@NPago", element.NPago);
                    dynamicParameters.Add("@MontoPaquete", element.MontoPaquete);
                    dynamicParameters.Add("@FechaVencimiento", element.FechaVencimiento);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Paquete].[spCID_AC_Paquete]s", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Result = Resultado;
                    return element;
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
                    dynamicParameters.Add("@IdPaquete", id);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Paquete].[SPCID_Delete_Paquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Paquetes>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Paquetes> Lista = new List<Paquetes>();
                    Paquetes item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Paquete].[SPCID_Get_Paquete]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Paquetes();
                        item.IdPaquete = dr.GetInt32(dr.GetOrdinal("IdPaquete"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        item.NPersona = dr.GetString(dr.GetOrdinal("NumeroPersona"));
                        item.NPago = dr.GetString(dr.GetOrdinal("NumeroPago"));
                        item.FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        item.MontoPaquete = dr.GetDecimal(dr.GetOrdinal("MontoPaquete"));
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

        #region Metodos No Implementado

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Paquetes> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Paquetes> UpdateAsync(Paquetes element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
