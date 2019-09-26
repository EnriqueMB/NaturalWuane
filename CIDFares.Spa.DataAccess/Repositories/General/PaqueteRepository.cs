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
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    dynamicParameters.Add("@IdPaquete", element.IdPaquete);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@NPersona", element.NPersona);
                    dynamicParameters.Add("@NPago", element.NPago);
                    dynamicParameters.Add("@MontoPaquete", element.MontoPaquete);
                    dynamicParameters.Add("@FechaVencimiento", element.FechaVencimiento);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Paquete].[spCID_AC_Paquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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
        public async Task<int> NameExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 12);
                    dynamicParameters.Add("@Nombre", name.Trim());
                    var dr = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
        public async Task<Paquetes> GetAsync(object id)
        {
            try
            {
                PaqueteDetalle paqueteDetalle;
                List<PaqueteDetalle> Lista = new List<PaqueteDetalle>();
                Paquetes item;
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdPaquete", id);
                    var dr = await conexion.ExecuteReaderAsync("[Paquete].[SPCID_Get_ObtenerDetallePaquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        paqueteDetalle = new PaqueteDetalle();
                        paqueteDetalle.IdDetallePaquete = dr.GetInt32(dr.GetOrdinal("IdDetallePaquete"));
                        paqueteDetalle.IdGenerico = dr.GetInt32(dr.GetOrdinal("IdGenerico"));
                        paqueteDetalle.IdTipo = dr.GetInt32(dr.GetOrdinal("IdTipo"));
                        paqueteDetalle.Tipo = dr.GetString(dr.GetOrdinal("NombreTipo"));
                        paqueteDetalle.Cantidad = dr.GetDecimal(dr.GetOrdinal("CantidadProducto"));
                        paqueteDetalle.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        paqueteDetalle.Precios = dr.GetDecimal(dr.GetOrdinal("Precio"));
                        paqueteDetalle.PrecioSinDescuento = dr.GetDecimal(dr.GetOrdinal("PrecioSinDescuento"));
                        paqueteDetalle.PorcentajeDescuento = dr.GetDecimal(dr.GetOrdinal("PorcentajePaquete"));
                        paqueteDetalle.PrecioDescuento = dr.GetDecimal(dr.GetOrdinal("PrecioDescuento"));
                        Lista.Add(paqueteDetalle);
                    }
                    item = new Paquetes();
                    item.ListaDetallePaquete = Lista;
                    return item;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Paquetes> UpdateAsync(Paquetes element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    dynamicParameters.Add("@IdPaquete", element.IdPaquete);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@NPersona", element.NPersona);
                    dynamicParameters.Add("@NPago", element.NPago);
                    dynamicParameters.Add("@MontoPaquete", element.MontoPaquete);
                    dynamicParameters.Add("@FechaVencimiento", element.FechaVencimiento);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Paquete].[spCID_C_Paquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Result = Resultado;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Paquetes>> GetBusqPaqueteAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Paquetes> Lista = new List<Paquetes>();
                    Paquetes item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@BitNombre", BitNombre);
                    dynamicParameters.Add("@BusquedaNombre", BusqNombre);
                    dynamicParameters.Add("@BitCodigo", BitClaveCodigo);
                    dynamicParameters.Add("@BusquedaCodigo", BusqClaveCodigo);
                    var dr = await conexion.ExecuteReaderAsync("[Venta].[SPCID_Get_ObtenerBusquedaPaquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<AbonoPaquete>> GetAllAbonoPaqueteAsync(Guid idCliente, int idSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCliente", idCliente);
                    dynamicParameters.Add("@IdSucursal", idSucursal);
                    var result = await conexion.QueryAsync<AbonoPaquete>("[Paquete].[SPCID_Get_AbonoPaquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> AddAbonoAsync(AbonoPaquete element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaPaquete", element.TablaPaquete, DbType.Object);
                    dynamicParameters.Add("@TablaFormaPago", element.TablaFormaPago, DbType.Object);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@IdTurno", element.IdTurno);
                    var result = await conexion.ExecuteScalarAsync<int>("[Paquete].[SPCID_A_AbonoPaquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
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

        public async Task<IEnumerable<AbonoPaqueteDetalle>> GetAllDetalleAsync(Guid IdVentaPaquete)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdVentaPaquete", IdVentaPaquete);
                    var result = await conexion.QueryAsync<AbonoPaqueteDetalle>("[Paquete].[spCID_Get_AbonoPaqueteDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
