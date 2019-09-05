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
    public class PuestoRepository : Repository, IPuestoRepository
    {
        public async Task<Puesto> AddAsync(Puesto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@Puesto", element.NombrePuesto);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@Usuario", IdUsuario);


                    var Resultado = await conexion.ExecuteScalarAsync<int>(" [Usuario].[SPCID_AC_Empleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
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

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Puesto>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Puesto> Lista = new List<Puesto>();
                    Puesto item;
                    //var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_Empleado]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Puesto();
                        item.IdPuesto = !dr.IsDBNull(dr.GetOrdinal("IdPuesto")) ? dr.GetInt32(dr.GetOrdinal("IdPuesto")) : 0;
                        item.NombrePuesto = !dr.IsDBNull(dr.GetOrdinal("Puesto")) ? dr.GetString(dr.GetOrdinal("Puesto")) : string.Empty;
                        item.Descripcion = !dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? dr.GetString(dr.GetOrdinal("Descripcion")) : string.Empty;
                       
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

        public  Task<Puesto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Puesto>> GetComboPuesto()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();

                    List<Puesto> Lista = new List<Puesto>();
                    Puesto Item;
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Combo_Puesto]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Puesto();
                        Item.IdPuesto = dr.GetInt32(dr.GetOrdinal("IdTipoIva"));
                        Item.NombrePuesto = dr.GetString(dr.GetOrdinal("Porcentaje"));
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
        }

        public async Task<Puesto> GetPuestoXid(int IdPuesto)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    Puesto item = new Puesto();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdPuesto", IdPuesto);
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_GetPuestoXId]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Puesto();
                        item.IdPuesto = !dr.IsDBNull(dr.GetOrdinal("IdPuesto")) ? dr.GetInt32(dr.GetOrdinal("IdPuesto")) : 0;
                        item.NombrePuesto = !dr.IsDBNull(dr.GetOrdinal("Puesto")) ? dr.GetString(dr.GetOrdinal("Puesto")) : string.Empty;
                        item.Descripcion = !dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? dr.GetString(dr.GetOrdinal("Descripcion")) : string.Empty;
                 ;
                    }
                    return item;
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
                    dynamicParameters.Add("@Opcion", 11);
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

        public async Task<Puesto> UpdateAsync(Puesto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@IdPuesto", element.IdPuesto);
                    dynamicParameters.Add("@Puesto", element.NombrePuesto);
                    dynamicParameters.Add("@Descripcion", element.Descripcion);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                   


                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Puesto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
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
