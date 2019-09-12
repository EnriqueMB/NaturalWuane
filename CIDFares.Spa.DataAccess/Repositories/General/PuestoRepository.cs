using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Windows.Forms;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class PuestoRepository : Repository, IPuestoRepository
    {
        

        #region Metodos Implementado
        
        /// <summary>
        /// Obtiene la lista de los puestos
        /// </summary>
        /// <returns>Retorna la lista de todos los puestos</returns>
        public async Task<IEnumerable<Puesto>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Puesto> ListaPusto = new List<Puesto>();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Puesto>("[Usuario].[SPCID_Get_Puesto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con soporte técnico.", "Contacte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            throw new NotImplementedException();
        } 
        
        /// <summary>
        /// Método asincrono para insertar un nuevo puesto en la base de datos.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<Puesto> AddAsync(Puesto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 1);
                    dynParameters.Add("@IdPuesto", element.IdPuesto);
                    dynParameters.Add("@Puesto", element.Nombre);
                    dynParameters.Add("@Descripcion", element.Descripcion);
                    dynParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Puesto]", param: dynParameters, commandType: CommandType.StoredProcedure);
                    element.IdPuesto = result;
                    return element;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Elimina un puesto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdPuesto", id);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_Delete_Puesto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
        /// <summary>
        /// Busca si un puesto existe por medio del nombre
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> NameExistAsync(string name)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(WebConnectionString))
                {
                    connection.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 11);
                    dynParameters.Add("@Nombre", name.Trim());
                    var result = await connection.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Actualiza el registro de un puesto
        /// </summary>
        /// <param name="element"></param>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<Puesto> UpdateAsync(Puesto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 2);
                    dynParameters.Add("@IdPuesto", element.IdPuesto);
                    dynParameters.Add("@Puesto", element.Nombre);
                    dynParameters.Add("@Descripcion", element.Descripcion);
                    dynParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Puesto]", param: dynParameters, commandType: CommandType.StoredProcedure);
                    element.IdPuesto = result;
                    return element;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Metodos No Implementados
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }
        public Task<Puesto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
