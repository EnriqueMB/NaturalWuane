﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
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
using System.Xml;


namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ServicioRepository : Repository, IServicioRepository
    {
        #region Interfaces Implementadas
        public async Task<IEnumerable<Servicio>> GetBusqServicioAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Servicio> Lista = new List<Servicio>();
                    Servicio item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@BitNombre", BitNombre);
                    dynamicParameters.Add("@BusquedaNombre", BusqNombre);
                    dynamicParameters.Add("@BitCodigo", BitClaveCodigo);
                    dynamicParameters.Add("@BusquedaCodigo", BusqClaveCodigo);
                    var dr = await conexion.ExecuteReaderAsync("[General].[SPCID_Get_ObtenerBusquedaServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Servicio();
                        item.IdServicio = dr.GetInt32(dr.GetOrdinal("IdServicio"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        item.TipoServicio = dr.GetString(dr.GetOrdinal("TipoServicio"));
                        item.Precio = dr.GetDecimal(dr.GetOrdinal("PrecioPublico"));
                        item.Porcentaje = dr.GetDecimal(dr.GetOrdinal("PorcentajeIva"));
                        item.AplicaIEPS = dr.GetBoolean(dr.GetOrdinal("AplicaIEPS"));
                        item.IEPSMonto = dr.GetBoolean(dr.GetOrdinal("IEPSMonto"));
                        item.IEPS = dr.GetDecimal(dr.GetOrdinal("IEPS"));
                        //string cadena = dr.GetString(dr.GetOrdinal("Duracion"));
                        //item.Duracion = TimeSpan.Parse(cadena);
                        item.UrlImagen = dr.GetString(dr.GetOrdinal("UrlFoto"));
                        item.Duracion = dr.GetDateTime(dr.GetOrdinal("Duracion"));
                        item.PorcentajePaquete = dr.GetDecimal(dr.GetOrdinal("PorcentajePaquete"));
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
                    dynamicParameters.Add("@Opcion", 8);
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
        public async Task<Servicio> UpdateAsync(Servicio element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@idServicio", element.IdServicio);
                    dynamicParameters.Add("@idTipoServicio", element.IdTipoServicio);
                    dynamicParameters.Add("@idTipoIva", element.IdTipoIva);
                    dynamicParameters.Add("@clave", element.Clave);
                    dynamicParameters.Add("@nombre", element.Nombre);
                    dynamicParameters.Add("@desc", element.Descripcion);
                    dynamicParameters.Add("@precio", element.Precio);
                    dynamicParameters.Add("@duracion", element.Duracion);
                    dynamicParameters.Add("@aplicaIva", element.AplicaIva);
                    dynamicParameters.Add("@aplicaIEPS", element.AplicaIEPS);
                    dynamicParameters.Add("@iEPSMonto", element.IEPSMonto);
                    dynamicParameters.Add("@iEPS", element.IEPS);
                    dynamicParameters.Add("@user", IdUsuario);
                    //dynamicParameters.Add("@UpdateFoto", element.UpdateFoto);
                    //dynamicParameters.Add("@fotob64", element.FotoBase64);
                    dynamicParameters.Add("@UrlFoto", element.UrlImagen);
                    dynamicParameters.Add("@PorcentajeP", element.PorcentajePaquete);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Servicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Servicio> AddAsync(Servicio element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@idServicio", element.IdServicio);
                    dynamicParameters.Add("@idTipoServicio", element.IdTipoServicio);
                    dynamicParameters.Add("@idTipoIva", element.IdTipoIva);
                    dynamicParameters.Add("@clave", element.Clave);
                    dynamicParameters.Add("@nombre", element.Nombre);
                    dynamicParameters.Add("@desc", element.Descripcion);
                    dynamicParameters.Add("@precio", element.Precio);
                    dynamicParameters.Add("@duracion", element.Duracion);
                    dynamicParameters.Add("@aplicaIva", element.AplicaIva);
                    dynamicParameters.Add("@aplicaIEPS", element.AplicaIEPS);
                    dynamicParameters.Add("@iEPSMonto", element.IEPSMonto);
                    dynamicParameters.Add("@iEPS", element.IEPS);
                    dynamicParameters.Add("@user", IdUsuario);
                    //dynamicParameters.Add("@UpdateFoto", element.UpdateFoto);
                    //dynamicParameters.Add("@fotob64", element.FotoBase64);
                    dynamicParameters.Add("@UrlFoto", element.UrlImagen);
                    dynamicParameters.Add("@PorcentajeP", element.PorcentajePaquete);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Servicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> DeleteAsync(object idServicio, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idServicio", idServicio);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_Servicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> ObtenerFoto(int IdServicio)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idServicio", IdServicio);
                    var dr = await conexion.ExecuteScalarAsync<string>("[Catalogo].[SPCID_Get_ObtenerFotoServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<IEnumerable<Servicio>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Servicio> Lista = new List<Servicio>();
                    Servicio Item;
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_Servicio]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Servicio();
                        Item.IdServicio = dr.GetInt32(dr.GetOrdinal("IdServicio"));
                        Item.IdTipoServicio = dr.GetInt32(dr.GetOrdinal("IdTipoServicio"));
                        Item.IdTipoIva = dr.GetInt32(dr.GetOrdinal("IdTipoIva"));
                        Item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        Item.TipoServicio = dr.GetString(dr.GetOrdinal("TipoServicio"));
                        Item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        Item.Precio = dr.GetDecimal(dr.GetOrdinal("Precio"));
                        //string cadena = dr.GetString(dr.GetOrdinal("Duracion"));
                        //Item.Duracion = TimeSpan.Parse(cadena);
                        //string cadena = dr.GetString(dr.GetOrdinal("Duracion"));
                        //Item.Duracion = Convert.ToDateTime(cadena);                     
                        Item.Duracion = dr.GetDateTime(dr.GetOrdinal("Duracion"));
                        Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        Item.Porcentaje = dr.GetDecimal(dr.GetOrdinal("Porcentaje"));
                        Item.DescIva = dr.GetString(dr.GetOrdinal("DescIva"));
                        Item.AplicaIva = dr.GetBoolean(dr.GetOrdinal("AplicaIva"));
                        Item.AplicaIEPS = dr.GetBoolean(dr.GetOrdinal("AplicaIEPS"));
                        Item.IEPSMonto = dr.GetBoolean(dr.GetOrdinal("IEPSMonto"));
                        Item.IEPS = dr.GetDecimal(dr.GetOrdinal("IEPS"));
                        //Item.FotoBase64 = dr.GetString(dr.GetOrdinal("FotoBase64"));
                        // Item.UrlFoto = dr.GetString(dr.GetOrdinal("UrlLocalImagen"));
                        Item.UrlImagen = dr.GetString(dr.GetOrdinal("UrlFoto"));
                        Item.PorcentajePaquete = dr.GetDecimal(dr.GetOrdinal("PorcentajeP"));
                        Lista.Add(Item);
                    }
                    dr.Close();
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //[Catalogo].[SPCID_Get_Servicio]
        }
        public async Task<bool> ExistAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 8);
                    dynamicParameters.Add("@Nombre", id);
                    var dr = await conexion.ExecuteScalarAsync<bool>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ExisteClave(object Clave)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 14);
                    dynamicParameters.Add("@Nombre", Clave);
                    var dr = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        public Task<Servicio> GetAsync(object id)
        {
            throw new NotImplementedException();
        }        

        //public async Task<int> NameExistAsync(string name)
        //{
        //    try
        //    {
        //        using (IDbConnection conexion = new SqlConnection(WebConnectionString))
        //        {
        //            conexion.Open();
        //            var dynamicParameters = new DynamicParameters();
        //            dynamicParameters.Add("@Opcion", 8);
        //            dynamicParameters.Add("@Nombre", name.Trim());
        //            var dr = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
        //            return dr;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        
    }
}
