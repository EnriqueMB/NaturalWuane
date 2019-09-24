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
    public class CancelacionVentaRepository : Repository, ICancelacionVentaRepository
    {
        public async Task<VentasCancelaciones> AddAsync(VentasCancelaciones element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCancelacionVenta", element.IdCancelacionVenta);
                    dynamicParameters.Add("@IdVenta", element.IdVenta);
                    dynamicParameters.Add("@Motivo", element.MotivoCancelacion);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Venta].[SPCID_A_CancelacionVenta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
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

        public Task<IEnumerable<VentasCancelaciones>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<VentasCancelaciones> GetAsync(object id)
        {
            try
            {
                VentaDetalle ventaDetalle;
                List<VentaDetalle> Lista = new List<VentaDetalle>();
                VentasCancelaciones item;
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdVenta", id);
                    var dr = await conexion.ExecuteReaderAsync("[Venta].[SPCID_Get_ObtenerDetalleVenta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        ventaDetalle = new VentaDetalle();
                        ventaDetalle.IdTipo = dr.GetInt32(dr.GetOrdinal("Tipo"));
                        ventaDetalle.TipoVenta = dr.GetString(dr.GetOrdinal("TipoVenta"));
                        ventaDetalle.Cantidad = dr.GetInt32(dr.GetOrdinal("Cantidad"));
                        ventaDetalle.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        ventaDetalle.Total = dr.GetDecimal(dr.GetOrdinal("Total"));
                        Lista.Add(ventaDetalle);
                    }
                    item = new VentasCancelaciones();
                    item.ListaVentaDetalle = Lista;
                    return item;
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

        public Task<VentasCancelaciones> UpdateAsync(VentasCancelaciones element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
