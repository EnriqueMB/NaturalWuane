using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ConsultaRepository : Repository, IConsultaRepository
    {
        #region Metodos
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

        public async Task<IEnumerable<Preguntas>> ObtenerEncuestaXId(Guid Idencuesta)
        {
            try
            {
                
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Preguntas> preguntas = new List<Preguntas>();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEncuesta", Idencuesta);                    
                    using (var dr = await conexion.QueryMultipleAsync("[Catalogo].[spCID_Get_PreguntaRspuesta]", param: dynamicParameters, commandType: CommandType.StoredProcedure))
                    {              
                        preguntas = dr.Read<Preguntas>().ToList();
                        List<Respuestas> respuestas = dr.Read<Respuestas>().ToList();
                        foreach (var pregunta in preguntas)
                        {
                            if(pregunta.TipoPregunta.Equals("MULTIPLE"))
                            {
                                pregunta.Respuesta.AddRange(respuestas.Where(x => x.IdPregunta.Equals(pregunta.IdPregunta)));
                            }
                        }
                    }
                    return preguntas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
