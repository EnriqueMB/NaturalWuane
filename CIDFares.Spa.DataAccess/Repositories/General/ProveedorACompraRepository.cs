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
    public class ProveedorACompraRepository : Repository,IProveedorACompraRepository
    {
        public Task<ProveedorACompra> AddAsync(ProveedorACompra element, object IdUsuario)
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

        public async Task<IEnumerable<ProveedorACompra>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<ProveedorACompra> Lista = new List<ProveedorACompra>();
                    ProveedorACompra item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Compra].[SPCID_GetProveedor]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new ProveedorACompra();
                        item.IdProveedor = !dr.IsDBNull(dr.GetOrdinal("IdProveedor")) ? dr.GetGuid(dr.GetOrdinal("IdProveedor")) : Guid.Empty;
                        item.Clave = !dr.IsDBNull(dr.GetOrdinal("Clave")) ? dr.GetString(dr.GetOrdinal("Clave")) : string.Empty;
                        item.NombreComercial = !dr.IsDBNull(dr.GetOrdinal("NombreComercial")) ? dr.GetString(dr.GetOrdinal("NombreComercial")) : string.Empty;
                        item.RazonSocial = !dr.IsDBNull(dr.GetOrdinal("RazonSocial")) ? dr.GetString(dr.GetOrdinal("RazonSocial")) : string.Empty;
                        item.Representante = !dr.IsDBNull(dr.GetOrdinal("Representante")) ? dr.GetString(dr.GetOrdinal("Representante")) : string.Empty;
                        item.Direccion = !dr.IsDBNull(dr.GetOrdinal("Direccion")) ? dr.GetString(dr.GetOrdinal("Direccion")) : string.Empty;
                        item.Telefono = !dr.IsDBNull(dr.GetOrdinal("Telefono")) ? dr.GetString(dr.GetOrdinal("Telefono")) : string.Empty;
                        item.CorreoElectronico = !dr.IsDBNull(dr.GetOrdinal("CorreoElectronico")) ? dr.GetString(dr.GetOrdinal("CorreoElectronico")) : string.Empty;
                        item.Pais = !dr.IsDBNull(dr.GetOrdinal("Pais")) ? dr.GetString(dr.GetOrdinal("Pais")) : string.Empty;
                        item.Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) ? dr.GetString(dr.GetOrdinal("Estado")) : string.Empty;
                        item.Municipio = !dr.IsDBNull(dr.GetOrdinal("Municipio")) ? dr.GetString(dr.GetOrdinal("Municipio")) : string.Empty;
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

        public Task<ProveedorACompra> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProveedorACompra>> GetBusquedaAsync(string Busqueda)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<ProveedorACompra> Lista = new List<ProveedorACompra>();
                    ProveedorACompra item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Busqueda", Busqueda);
                    var dr = await conexion.ExecuteReaderAsync("[Compra].[SPCID_Get_BusquedaProveedor]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new ProveedorACompra();
                        item.IdProveedor = !dr.IsDBNull(dr.GetOrdinal("IdProveedor")) ? dr.GetGuid(dr.GetOrdinal("IdProveedor")) : Guid.Empty;
                        item.Clave = !dr.IsDBNull(dr.GetOrdinal("Clave")) ? dr.GetString(dr.GetOrdinal("Clave")) : string.Empty;
                        item.NombreComercial = !dr.IsDBNull(dr.GetOrdinal("NombreComercial")) ? dr.GetString(dr.GetOrdinal("NombreComercial")) : string.Empty;
                        item.RazonSocial = !dr.IsDBNull(dr.GetOrdinal("RazonSocial")) ? dr.GetString(dr.GetOrdinal("RazonSocial")) : string.Empty;
                        item.Representante = !dr.IsDBNull(dr.GetOrdinal("Representante")) ? dr.GetString(dr.GetOrdinal("Representante")) : string.Empty;
                        item.Direccion = !dr.IsDBNull(dr.GetOrdinal("Direccion")) ? dr.GetString(dr.GetOrdinal("Direccion")) : string.Empty;
                        item.Telefono = !dr.IsDBNull(dr.GetOrdinal("Telefono")) ? dr.GetString(dr.GetOrdinal("Telefono")) : string.Empty;
                        item.CorreoElectronico = !dr.IsDBNull(dr.GetOrdinal("CorreoElectronico")) ? dr.GetString(dr.GetOrdinal("CorreoElectronico")) : string.Empty;
                        item.Pais = !dr.IsDBNull(dr.GetOrdinal("Pais")) ? dr.GetString(dr.GetOrdinal("Pais")) : string.Empty;
                        item.Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) ? dr.GetString(dr.GetOrdinal("Estado")) : string.Empty;
                        item.Municipio = !dr.IsDBNull(dr.GetOrdinal("Municipio")) ? dr.GetString(dr.GetOrdinal("Municipio")) : string.Empty;
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

        //public async Task<IEnumerable<string>> GetNombre(string id)
        //{
        //    try
        //    {
        //        using (IDbConnection conexion = new SqlConnection(WebConnectionString))
        //        {
        //            conexion.Open();
        //            var dynamicParameters = new DynamicParameters();

        //            dynamicParameters.Add("@IdProveedor", id);



        //            var result = await conexion.ExecuteScalarAsync<string>("[Catalogo].[SPCID_AC_Proveedores]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
        //            Entity.IdProveedor = result;
        //            return result;
        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ProveedorACompra> UpdateAsync(ProveedorACompra element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
