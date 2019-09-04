using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class VentaRepository : Repository, IVentaRepository
    {
        public async Task<Venta> AddAsync(Venta element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaFormaPago", element.TablaFormaPago, DbType.Object);
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Subtotal", element.SubTotal);
                    dynamicParameters.Add("@Iva", element.PorcentajeIva);
                    dynamicParameters.Add("@Total", element.Total);
                    dynamicParameters.Add("@Efectivo", element.Efectivo);
                    dynamicParameters.Add("@Pagado", 1);
                    dynamicParameters.Add("@IdCliente", element.ClienteVenta.IdCliente);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Venta].[spCID_A_Venta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GetFolio()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.ExecuteScalarAsync<string>("[Venta].[spCID_Get_Folio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
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

        public Task<IEnumerable<Venta>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Venta> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Venta> UpdateAsync(Venta element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
