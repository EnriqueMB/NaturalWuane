using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class FormaPagoRepository : Repository, IFormaPagoRepository
    {

        /// <summary>
        /// Obtiene todas las formas de pago activas
        /// </summary>
        /// <returns></returns>

        public async Task<IEnumerable<FormaPago>> GetAllAsync()
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                var dynamicParameters = new DynamicParameters();
                List<FormaPago> Lista = new List<FormaPago>();
                FormaPago Item;
                var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_FormaPago]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                while (dr.Read())
                {
                    Item = new FormaPago();
                    Item.IdFormaPago = dr.GetInt32(dr.GetOrdinal("IdFormaPago"));
                    Item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    Lista.Add(Item);
                }
                dr.Close();
                return Lista;
            }
        }

        /// <summary>
        /// Agrega una nueva forma de pago
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<FormaPago> AddAsync(FormaPago element)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdFormaPago", element.IdFormaPago);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@Usuario", 1 /*CurrentSession.IdUsuario*/);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_FormaPago]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Modifica una forma de pago
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<FormaPago> UpdateAsync(FormaPago element)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdFormaPago", element.IdFormaPago);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@Usuario", 1 /*CurrentSession.IdUsuario*/);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_FormaPago]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Elimina una forma de pago
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdFormaPago", id);
                    dynamicParameters.Add("@Usuario", 1);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_FormaPago]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Verifica si existe un nombre similar en la base de datos
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> NameExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
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

        #region Métodos no implementados
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<FormaPago> GetAsync(object id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
