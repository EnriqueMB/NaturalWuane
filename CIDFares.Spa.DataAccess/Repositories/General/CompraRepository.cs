using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using CIDFares.Library.Code.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class CompraRepository : Repository, ICompraRepository
    {
        #region Metodos Implementado        
        public async Task<Compra> AddWithIdSucursalAsync(Compra element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@IdProveedor", element.ProveedorCompra.IdProveedor);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Subtotal", element.SubTotal);
                    dynamicParameters.Add("@Total", element.Total);
                    dynamicParameters.Add("@Iva", element.PorcentajeIva);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Compra].[SPCID_A_Compra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> GetFolioCompra()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.ExecuteScalarAsync<string>("[Compra].[SPCID_Get_FolioCompra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Compra>> GetCompraCreadasAsync(object Clave, object IdSucursal, object FechaInicio, object FechaFin)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Compra> Lista = new List<Compra>();
                    Compra item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Clave", Clave);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@FechaInicio", FechaInicio);
                    dynamicParameters.Add("@FechaFin", FechaFin);
                    var dr = await conexion.ExecuteReaderAsync("[Compra].[SPCID_Get_Compras]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Compra();
                        item.IdCompra = dr.GetGuid(dr.GetOrdinal("IdCompra"));
                        item.Folio = dr.GetString(dr.GetOrdinal("Clave"));
                        item.FechaCompra = dr.GetDateTime(dr.GetOrdinal("FechaCompra"));
                        item.Total = dr.GetDecimal(dr.GetOrdinal("Total"));
                        item.ProveedorCompra.NombreComercial = dr.GetString(dr.GetOrdinal("NombreComercial"));
                        item.ProveedorCompra.Clave = dr.GetString(dr.GetOrdinal("ClaveProveedor"));
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
        public async Task<int> AddCancelacionAsync(object IdCompra, object Motivo, object IdSucursal, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCompra", IdCompra);
                    dynamicParameters.Add("@Motivo", Motivo);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Compra].[SPCID_A_CancelacionCompra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos No Implementados
        public Task<Compra> AddAsync(Compra element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Compra>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<Compra> GetAsync(object id)
        {
            try
            {
                Compra Comprarequ = new Compra();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCompra", id);
                    using (var dr = conexion.QueryMultipleAsync("[Compra].[SPCID_Get_ComprasDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
                    {
                        Comprarequ = dr.ReadFirstOrDefault<Compra>();
                        Comprarequ.ProveedorCompra = dr.ReadFirstOrDefault<Proveedor>();
                        List<Compra> compraDetalle = dr.Read<Compra>().ToList();
                        Comprarequ.TablaProducto = compraDetalle.ToDataTable();
                    }
                    return Comprarequ;
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
        public Task<Compra> UpdateAsync(Compra element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
