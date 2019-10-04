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
    public class OpcionRepository : Repository, IopcionesRepository
    {      
        public Task<OpcionCuestionario> AddAsync(OpcionCuestionario element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OpcionMedicion>> CargarGridMediciones()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    List<OpcionMedicion> Lista = new List<OpcionMedicion>();
                    OpcionMedicion Item;

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_MedicionPaciente]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new OpcionMedicion();
                        Item.dato.IdMedicion = dr.GetInt32(dr.GetOrdinal("IdMedicion"));
                        Item.dato.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        Item.dato.NombreUnidadMedida = dr.GetString(dr.GetOrdinal("NombreUnidadMedida"));
                        Item.dato.NombreLista = dr.GetString(dr.GetOrdinal("NombreLista"));
                        Item.dato.IdListaMedicion = dr.GetInt32(dr.GetOrdinal("IdListaMedicion"));
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

        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OpcionCuestionario>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    List<OpcionCuestionario> Lista = new List<OpcionCuestionario>();
                    OpcionCuestionario Item;

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[spCID_Get_Encuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new OpcionCuestionario();
                        Item.datos.IdEncuesta = dr.GetGuid(dr.GetOrdinal("IdEncuesta"));
                        Item.datos.NombreEncuesta = dr.GetString(dr.GetOrdinal("NombreEncuesta"));
                        Item.datos.IdTipoEncuesta = dr.GetInt32(dr.GetOrdinal("IdTipoEncuesta"));
                        Item.datos.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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

        public Task<OpcionCuestionario> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GuardarEncuesta(Guid idUsuario, int tipoConsulta, CapturaConsulta model, DataTable _tablaRespuestas, DataTable _tablaRespuestasMultiple, DataTable _tablaMedicion,DataTable _tablaComentario, DataTable _tablaCuestionario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdCliente", model.IdCliente);
                    Parametros.Add("@IdTipoConsulta", tipoConsulta);
                    Parametros.Add("@Fecha", model.Fecha);
                    Parametros.Add("@Observacion", model.Observaciones);
                    Parametros.Add("@Recomendacion", model.Recomendaciones);
                    Parametros.Add("@Diagnostico", model.Diagnostico);
                    Parametros.Add("@IdUsuario", idUsuario);
                    Parametros.Add("@TblRespuesta", _tablaRespuestas,DbType.Object);
                    Parametros.Add("@TblRespuestaMultiple", _tablaRespuestasMultiple,DbType.Object);
                    Parametros.Add("@TblMediciones", _tablaMedicion,DbType.Object);
                    Parametros.Add("@TblComentarios", _tablaComentario,DbType.Object);
                    Parametros.Add("@TblCuestionarios", _tablaCuestionario,DbType.Object);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[spCID_A_Consulta]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Consulta>> LlenarComboTipoConsulta()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Consulta>("[Catalogo].[SPCID_Get_ComboTipoConsulta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

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

        public Task<OpcionCuestionario> UpdateAsync(OpcionCuestionario element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
