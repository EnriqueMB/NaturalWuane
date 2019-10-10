using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                    dynamicParameters.Add("@IdTurno", element.IdTurno);
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

        public async Task<Venta> AddWithIdSucursalAsync(Venta element, object IdUsuario, object IdSucursal)
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
                    dynamicParameters.Add("@TablaPaquete", element.TablaPaquete, DbType.Object);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Subtotal", element.SubTotal);
                    dynamicParameters.Add("@Iva", element.PorcentajeIva);
                    dynamicParameters.Add("@Total", element.Total);
                    dynamicParameters.Add("@Efectivo", element.Efectivo);
                    dynamicParameters.Add("@Pagado", 1);
                    dynamicParameters.Add("@IdCliente", element.ClienteVenta.IdCliente);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@IdTurno", element.IdTurno);
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

        public async Task<Venta> GetAsync(object id)
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

        public async Task<int> CheckCantidadProducto(object IdProducto, int Cantidad, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    DynamicParameters parametros = new DynamicParameters();
                    parametros.Add("@IdProducto", IdProducto);
                    parametros.Add("@IdSucursal", IdSucursal);
                    parametros.Add("@Cantidad", Cantidad);
                    var result = await conexion.ExecuteScalarAsync<int>("[Venta].[SPCID_CheckCantidadProducto]", param: parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Venta>> GetVentaDiasSucursalActiva(object FechaActual, object IdSucursal, object Folio)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Venta> Lista = new List<Venta>();
                    Venta item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Folio", Folio);
                    dynamicParameters.Add("@FECHA", FechaActual);
                    dynamicParameters.Add("IdSucursal", IdSucursal);
                    var dr = await conexion.ExecuteReaderAsync("[Venta].[SPCID_Get_VentasDias]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Venta();
                        item.IdVenta = dr.GetGuid(dr.GetOrdinal("IdVenta"));
                        item.LocalId = dr.GetInt32(dr.GetOrdinal("LocalId"));
                        item.Folio = dr.GetString(dr.GetOrdinal("Clave"));
                        item.FechaVenta = dr.GetDateTime(dr.GetOrdinal("FechaVenta"));
                        item.SubTotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                        item.PorcentajeIva = dr.GetDecimal(dr.GetOrdinal("Iva"));
                        item.Total = dr.GetDecimal(dr.GetOrdinal("Total"));
                        item.ClienteVenta.NombreCompleto = dr.GetString(dr.GetOrdinal("NombreCompleto"));
                        item.SucursalDatos.Nombre = dr.GetString(dr.GetOrdinal("NombreSucursal"));
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

        

        public async Task<Guid> ObtenerIdVenta(object IdSucursal, object IdEmpleado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@UsuarioAlta", IdEmpleado);
                    Guid result = await conexion.ExecuteScalarAsync<Guid>("[Venta].[SPCID_Get_IdVenta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<VentaTicketRequest> GetTicket(object id)
        {
            try
            {
                VentaTicketRequest venta = new VentaTicketRequest();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdVenta", id);

                    venta.dtoVenta = (await conexion.QueryAsync<Venta, Cliente, Venta>("[Venta].[SPCID_Get_DatosVentaDetalle]",
                        (x, cliente) =>
                        {
                            x.ClienteVenta = cliente;
                            return x;
                        },
                        splitOn: "IdVenta,IdCliente",
                        param: dynamicParameters, commandType: CommandType.StoredProcedure)).FirstOrDefault();

                    using (var dr = conexion.QueryMultipleAsync("[Venta].[SPCID_Get_VentaDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
                    {
                        //venta.dtoVenta = dr.ReadFirstOrDefault<Venta>
                        //venta.dtoVenta = new BindingList<Venta>(dr.Read<Venta>(new[] { typeof(Venta), typeof(Cliente) },
                        //    (result) =>
                        //    {
                        //        var opcion = (result[0] as Venta);
                        //        opcion.ClienteVenta = (result[1] as Cliente);
                        //        return opcion;
                        //    },
                        //    splitOn: "IdVenta,IdCliente").ToList());
                            

                        venta.dtoProducto = dr.Read<Producto>(new[] { typeof(Producto),typeof(DetalleProducto)},
                            (result) =>
                            {
                                var opcion = (result[0] as Producto);
                                opcion.datoProducto = (result[1] as DetalleProducto);
                                return opcion;
                            },
                            splitOn: "IdProducto,IdVentaProducto").ToList();

                        //venta.dtoPaquete = dr.Read<Paquetes>(new[] { typeof(Paquetes), typeof(DetallesPaquete)},
                        //    (result) =>
                        //    {
                        //       var opcion = (result[0] as Paquetes);
                        //        opcion.datoPaquete = (result[1] as DetallesPaquete);
                        //        return opcion;
                        //    },
                        //    splitOn: "IdPaquete,IdVentaPaquete").ToList();

                        venta.dtoServicio = dr.Read<Servicio>(new[] { typeof(Servicio), typeof(DetalleServicio) },
                            (result) =>
                            {
                                var opcion = (result[0] as Servicio);
                                opcion.datoServicio = (result[1] as DetalleServicio);
                                return opcion;
                            },
                            splitOn: "IdServicio, IdVentaServicio").ToList();
                        //venta.dtoServicio = dr.Read<Servicio>().ToList();
                    }
                    return venta;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
