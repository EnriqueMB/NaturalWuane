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
    public class ProveedorRepository : Repository, IProveedorRepository
    {
        public async Task<Proveedor> AddAsync(Proveedor element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@IdProveedor", element.IdProveedor);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@NombreComercial", element.NombreComercial);
                    dynamicParameters.Add("@RazonSocial", element.RazonSocial);
                    dynamicParameters.Add("@Representante", element.Representante);
                    dynamicParameters.Add("@RFC", element.RFC);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@CorreoElectronico", element.CorreoElectronico);
                    dynamicParameters.Add("@CodigoPostal", element.CodigoPostal);
                    dynamicParameters.Add("@IdPais", element.IdPais);
                    dynamicParameters.Add("@IdEstado", element.IdEstado);
                    dynamicParameters.Add("@IdMunicipio", element.IdMunicipio);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    

                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Proveedores]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
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
                    dynamicParameters.Add("@IdProveedor", id);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_Delete_Proveedor]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

                    return result;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> EsClave(string Clave)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Proveedor> ListaProveedor = new List<Proveedor>();
                    Proveedor item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_Proveedor]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Proveedor();
                        item.IdProveedor = dr.GetGuid(dr.GetOrdinal("IdProveedor"));
                        item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        item.RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"));
                        item.Representante = dr.GetString(dr.GetOrdinal("Representante"));
                        item.RFC = dr.GetString(dr.GetOrdinal("RFC"));
                        item.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
                        item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                        item.CorreoElectronico = dr.GetString(dr.GetOrdinal("CorreoElectronico"));
                        item.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
                 
                        item.IdPais = dr.GetInt32(dr.GetOrdinal("IdPais"));
                        item.Pais = dr.GetString(dr.GetOrdinal("Pais"));
                        item.IdEstado = dr.GetInt32(dr.GetOrdinal("IdEstado"));
                        item.Estado = dr.GetString(dr.GetOrdinal("Estado"));
                        item.IdMunicipio = dr.GetInt32(dr.GetOrdinal("IdMunicipio"));
                        item.Municipio = dr.GetString(dr.GetOrdinal("Municipio"));


                        ListaProveedor.Add(item);
                    }
                    return ListaProveedor;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<Proveedor> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NombreComercialUnico(string NombreComercial)
        {
            throw new NotImplementedException();
        }

        public async Task<Proveedor> UpdateAsync(Proveedor element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("Opcion", 2);
                    dynamicParameters.Add("@IdProveedor", element.IdProveedor);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@NombreComercial", element.NombreComercial);
                    dynamicParameters.Add("@RazonSocial", element.RazonSocial);
                    dynamicParameters.Add("@Representante", element.Representante);
                    dynamicParameters.Add("@RFC", element.RFC);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@CorreoElectronico", element.CorreoElectronico);
                    dynamicParameters.Add("@CodigoPostal", element.CodigoPostal);
                    dynamicParameters.Add("@IdPais", element.IdPais);
                    dynamicParameters.Add("@IdEstado", element.IdEstado);
                    dynamicParameters.Add("@IdMunicipio", element.IdMunicipio);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);

                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Proveedores]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
