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
    public class UsuarioRepository : Repository, IUsuarioRepository
    {
        public Task<Usuario> AddAsync(Usuario element)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> AddAsync(Usuario element, object IdUsuario)
        {
            
             try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@IdCuentaUsuario", element.IdCuentaUsuario);
                    dynamicParameters.Add("@Cuenta", element.Cuenta);
                    dynamicParameters.Add("@Password", element.PasswordHash);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@IdRol", element.IdRol);
                    dynamicParameters.Add("@IdEmpleado", element.IdEmpleado);
                  
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Usuario2]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<int> DeleteAsync(object id )
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
           
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCuentaUsuario", id);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_Delete_Usuario]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

                    return result;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Guid> EsCuentaUnica(string Cuenta)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 5);
                    dynamicParameters.Add("@Nombre", Cuenta);
                    var dr = await conexion.ExecuteScalarAsync<Guid>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Usuario> ListaUsuario = new List<Usuario>();
                    Usuario item;
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_Usuario]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Usuario();
                        item.IdCuentaUsuario = dr.GetGuid(dr.GetOrdinal("IdCuentaUsuario"));                    
                        item.Cuenta = dr.GetString(dr.GetOrdinal("Cuenta"));
                        item.IdRol = dr.GetInt32(dr.GetOrdinal("IdRol"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        item.IdEmpleado = dr.GetGuid(dr.GetOrdinal("IdEmpleado"));
                        item.Nombres = dr.GetString(dr.GetOrdinal("Nombres"));


                        ListaUsuario.Add(item);
                    }
                    return ListaUsuario;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<Usuario> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateAsync(Usuario element)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> UpdateAsync(Usuario element, object IdUsuario)
        {
            

            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("Opcion", 2);
                    dynamicParameters.Add("@IdCuentaUsuario", element.IdCuentaUsuario);
                    dynamicParameters.Add("@Cuenta", element.Cuenta);
                    dynamicParameters.Add("@Password", element.PasswordHash);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@IdRol", element.IdRol);
                    dynamicParameters.Add("@IdEmpleado", element.IdEmpleado);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Usuario2]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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
