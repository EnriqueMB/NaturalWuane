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
    public class CuestionarioRepository : Repository, ICuestionarioRepository
    {
        #region Metodos
    
        public Task<Cuestionario> AddAsync(Cuestionario element, object IdUsuario)
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
                    dynamicParameters.Add("@IdEncuesta",id);
                    dynamicParameters.Add("@IdUsuario",IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[spCID_B_Encuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Cuestionario>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    List<Cuestionario> Lista = new List<Cuestionario>();
                    Cuestionario Item;

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();                  
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[spCID_Get_Encuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Cuestionario();
                        Item.IdEncuesta = dr.GetGuid(dr.GetOrdinal("IdEncuesta"));
                        Item.NombreEncuesta = dr.GetString(dr.GetOrdinal("NombreEncuesta"));
                        Item.IdTipoEncuesta = dr.GetInt32(dr.GetOrdinal("IdTipoEncuesta"));
                        Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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

        public Task<Cuestionario> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GuardarEncuesta(string NombreEncuesta, int TipoEncuesta, Guid IdUsuario, DataTable tblPregunta, DataTable tblRespuesta)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    dynamicParameters.Add("@NombreEncuesta", NombreEncuesta);
                    dynamicParameters.Add("@IdTipoEncuesta", TipoEncuesta);
                    dynamicParameters.Add("@TblPregunta", tblPregunta,DbType.Object);
                    dynamicParameters.Add("@TblRespuesta", tblRespuesta,DbType.Object);

                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[spCID_A_Encuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Cuestionario>> LlenarComboTipoEncuesta()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Cuestionario>("[Catalogo].[SPCID_Get_ComboTipoEncuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Cuestionario> UpdateAsync(Cuestionario element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
