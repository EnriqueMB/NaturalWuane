﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
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
    public class ProductoRepository : Repository, IProductoRepository
    {
        #region interfaz
        public Task<Producto> UpdateAsync(Producto element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        public Task<Producto> AddAsync(Producto element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Producto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Producto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Producto> UpdateAsync(Producto element)
        {
            throw new NotImplementedException();
        }
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }
        public Task<Producto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }
        public Task<Producto> AddAsync(Producto element)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// Agrega el registro correspondiente a la foto del producto registrado
        /// </summary>
        /// <param name="entity">De tipo producto encapsula todos los parametros que han de guardarse</param>
        /// <returns>Retorna un entero que representa el estado de la tarea</returns>
        public async Task<int> AddFotoProducto(Producto entity, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Clave", entity.Clave);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@FotoBase64", entity.Base64String);
                    dynamicParameters.Add("@UrlLocalImagen", entity.UrlFoto);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_ProductoFoto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<String> AddWitClave(Producto entity, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@IdProducto", entity.IdProducto);
                    dynamicParameters.Add("@Categoria", entity.IdCategoriaProducto);
                    dynamicParameters.Add("@Clave", entity.Clave);
                    dynamicParameters.Add("@Nombre", entity.Nombre);
                    dynamicParameters.Add("@Descripcion", entity.Descripcion);
                    dynamicParameters.Add("@Stock", entity.Stock);
                    dynamicParameters.Add("@StockMax", entity.StockMax);
                    dynamicParameters.Add("@StockMin", entity.StockMin);
                    dynamicParameters.Add("@PrecioPublico", entity.PrecioPublico);
                    dynamicParameters.Add("@CodigoBarras", entity.CodigoBarras);
                    dynamicParameters.Add("@UnidadMedida", entity.IdUnidadMedida);
                    dynamicParameters.Add("@ClaveSat", entity.ClaveSat);
                    dynamicParameters.Add("@Usuario",  IdUsuario);
                    dynamicParameters.Add("@IdTipoIva", entity.IdAplicaIva);
                    dynamicParameters.Add("@CostoProducto", entity.CostoProducto);
                    dynamicParameters.Add("@PorcentajeP", entity.PorcentajeP);
                    dynamicParameters.Add("@UrlImagen", entity.UrlImagen);
                    var result = await conexion.ExecuteScalarAsync<String>("[Catalogo].[SPCID_AC_Producto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Producto>> CargarDatos()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Producto> Lista = new List<Producto>();
                    Producto item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_Producto]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Producto();
                        item.IdProducto = dr.GetInt32(dr.GetOrdinal("IdProducto"));
                        item.Categoria = dr.GetString(dr.GetOrdinal("Categoria"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Producto"));
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        item.Stock = dr.GetBoolean(dr.GetOrdinal("Stock"));
                        item.StockMax = dr.GetInt32(dr.GetOrdinal("StockMax"));
                        item.StockMin = dr.GetInt32(dr.GetOrdinal("StockMin"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Precio = dr.GetDecimal(dr.GetOrdinal("Precio"));
                        item.CodigoBarras = dr.GetString(dr.GetOrdinal("CodigoBarras"));
                        item.UnidadMedida = dr.GetString(dr.GetOrdinal("UnidadMedida"));
                        item.ClaveSat = dr.GetInt32(dr.GetOrdinal("ClaveSat"));
                        item.Porcentaje = !dr.IsDBNull(dr.GetOrdinal("Porcentaje")) ? dr.GetDecimal(dr.GetOrdinal("Porcentaje")) :0;
                        item.UrlImagen = dr.GetString(dr.GetOrdinal("UrlImagen"));
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
        /// <summary>
        /// Remueve un registro de producto 
        /// </summary>
        /// <param name="Id">De tipo object, representa el id del producto que se desea remover</param>
        /// <returns>Retorna un entero que indica el estado de la tarea</returns>
        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdProducto", id);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_Producto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Modifica los datos de un registro de producto especifico
        /// </summary>
        /// <param name="entity">De tipo producto encapsula todos los parametros que han de modificarse</param>
        /// <returns>Retorna un string que representa la clave del Personal modificado</returns>
        public async Task<String> Update(Producto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var item = new DynamicParameters();
                    item.Add("@Opcion", 2);
                    item.Add("@IdProducto", element.IdProducto);
                    item.Add("@Categoria", element.IdCategoriaProducto );
                    item.Add("@Clave", element.Clave);
                    item.Add("@Nombre", element.Nombre);
                    item.Add("@Descripcion", element.Descripcion);
                    item.Add("@Stock", element.Stock);
                    item.Add("@StockMax", element.StockMax);
                    item.Add("@StockMin", element.StockMin);
                    item.Add("@PrecioPublico", element.PrecioPublico);
                    item.Add("@CodigoBarras", element.CodigoBarras);
                    item.Add("@UnidadMedida", element.IdUnidadMedida);
                    item.Add("@ClaveSat", element.ClaveSat);
                    item.Add("@IdTipoIva", element.IdAplicaIva);
                    item.Add("@Usuario", IdUsuario);
                    item.Add("@CostoProducto", element.CostoProducto);
                    item.Add("@PorcentajeP", element.PorcentajeP);
                    item.Add("@UrlImagen", element.UrlImagen);
                    var result = await conexion.ExecuteScalarAsync<String>("[Catalogo].[SPCID_AC_Producto]", param: item, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Producto> GetProductoXid(int IdProducto)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    Producto producto = new Producto();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdProducto", IdProducto);
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_ProductoXId]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {     
                        producto.IdCategoriaProducto = dr.GetInt32(dr.GetOrdinal("IdCategoriaProducto"));
                        producto.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        producto.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        producto.IdAplicaIva = dr.GetInt32(dr.GetOrdinal("IdTipoIva"));
                        producto.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        producto.Stock = dr.GetBoolean(dr.GetOrdinal("Stock"));
                        producto.StockMax = dr.GetInt32(dr.GetOrdinal("StockMax"));
                        producto.StockMin = dr.GetInt32(dr.GetOrdinal("StockMin"));
                        producto.PrecioPublico = dr.GetDecimal(dr.GetOrdinal("PrecioPublico"));
                        producto.CodigoBarras = dr.GetString(dr.GetOrdinal("CodigoBarras"));
                        producto.IdUnidadMedida = dr.GetInt32(dr.GetOrdinal("IdUnidadMedida"));
                        producto.ClaveSat = dr.GetInt32(dr.GetOrdinal("ClaveSat"));
                        producto.Base64String = dr.GetString(dr.GetOrdinal("FotoBase64"));
                        producto.UrlFoto = dr.GetString(dr.GetOrdinal("UrlLocalImagen"));
                        producto.CostoProducto = dr.GetDecimal(dr.GetOrdinal("CostoProducto"));
                        producto.PorcentajeP = dr.GetDecimal(dr.GetOrdinal("PorcentajeP"));
                        producto.UrlImagen = dr.GetString(dr.GetOrdinal("UrlImagen"));
                    }
                    return producto;
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
                    dynamicParameters.Add("@Opcion", 2);
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
        public async Task<int> NameExistAsync2(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 6);
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
        public async Task<IEnumerable<Producto>> GetBusquedaAsync(string Busqueda)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Producto> Lista = new List<Producto>();
                    Producto item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Busqueda", Busqueda);
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_ObtenerBusquedaProducto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Producto();
                        item.IdProducto = dr.GetInt32(dr.GetOrdinal("IdProducto"));
                        item.Categoria = dr.GetString(dr.GetOrdinal("Categoria"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Producto"));
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        item.Stock = dr.GetBoolean(dr.GetOrdinal("Stock"));
                        item.StockMax = dr.GetInt32(dr.GetOrdinal("StockMax"));
                        item.StockMin = dr.GetInt32(dr.GetOrdinal("StockMin"));
                        item.Precio = dr.GetDecimal(dr.GetOrdinal("Precio"));
                        item.CodigoBarras = dr.GetString(dr.GetOrdinal("CodigoBarras"));
                        item.UnidadMedida = dr.GetString(dr.GetOrdinal("UnidadMedida"));
                        item.ClaveSat = dr.GetInt32(dr.GetOrdinal("ClaveSat"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Porcentaje = !dr.IsDBNull(dr.GetOrdinal("Porcentaje")) ? dr.GetDecimal(dr.GetOrdinal("Porcentaje")) : 0;
                        item.UrlImagen = dr.GetString(dr.GetOrdinal("UrlImagen"));
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
        public async Task<int> ClaveExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 3);
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
    }
}
