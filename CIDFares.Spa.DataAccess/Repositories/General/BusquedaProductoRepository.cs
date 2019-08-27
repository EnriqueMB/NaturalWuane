using CIDFares.Spa.DataAccess.Repositories.Base;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class BusquedaProductoRepository : Repository, IBusqProductoRepository
    {
        #region Metodo Implementado

        public async Task<IEnumerable<BusqueProducto>> GetBusquedaProductoAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<BusqueProducto> Lista = new List<BusqueProducto>();
                    BusqueProducto item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@BitNombre", BitNombre);
                    dynamicParameters.Add("@BusquedaNombre", BusqNombre);
                    dynamicParameters.Add("@BitClaveCodigo", BitClaveCodigo);
                    dynamicParameters.Add("@BusqClaveCodigo", BusqClaveCodigo);
                    var dr = await conexion.ExecuteReaderAsync("[Cliente].[SPCID_Get_ObtenerBusquedaCliente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new BusqueProducto();
                        item.IdProducto = dr.GetInt32(dr.GetOrdinal("IdProducto"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        item.NombreCategoria = dr.GetString(dr.GetOrdinal("NombreCategoria"));
                        item.PrecioPublico = dr.GetDecimal(dr.GetOrdinal("PrecioPublico"));
                        item.PrecioMayoreo = dr.GetDecimal(dr.GetOrdinal("PrecioMayoreo"));
                        item.PrecioMenudeo = dr.GetDecimal(dr.GetOrdinal("PrecioMenudeo"));
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
        public Task<IEnumerable<BusqueProducto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BusqueProducto> AddAsync(BusqueProducto element)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<BusqueProducto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<BusqueProducto> UpdateAsync(BusqueProducto element)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
