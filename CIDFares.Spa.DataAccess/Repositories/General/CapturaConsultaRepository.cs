using CIDFares.Spa.DataAccess.Contracts.DTOs;
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
    public class CapturaConsultaRepository : Repository, ICapturaConsultaRepository
    {
        public async Task<IEnumerable<CapturaConsulta>> GetAll(string valor)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Value", valor);
                    var result = await conexion.QueryAsync<CapturaConsulta,Cliente,CapturaConsulta>("[Catalogo].[SPCID_GET_Consulta]",
                        (Consulta,Cliente) =>
                        {
                            Consulta.datosCliente = Cliente;
                            return Consulta;
                        },
                        splitOn: "IdConsulta,IdCliente",
                        param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ConsultaDto> ObtenerConsultaXId(Guid IdConsulta,Guid IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    ConsultaDto dto = new ConsultaDto();                 
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdConsulta", IdConsulta);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);

                    dto.dtoConsulta = (await conexion.QueryAsync<CapturaConsulta, Cliente, CapturaConsulta>("[Catalogo].[SPCID_C_ConsultaXID]",
                         (Consulta, Cliente) =>
                         {
                             Consulta.datosCliente = Cliente;
                             return Consulta;
                         },
                         splitOn: "IdConsulta,IdCliente",
                         param: dynamicParameters, commandType: CommandType.StoredProcedure)).FirstOrDefault();

                    using (var dr = conexion.QueryMultipleAsync("[Catalogo].[SPCID_C_Consulta]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
                    {
                                                         
                        dto.dtoEncuestaConsulta = new BindingList<OpcionCuestionario>(dr.Read<OpcionCuestionario>(new[] { typeof(OpcionCuestionario), typeof(Cuestionario) },
                            (result) =>
                            {
                                var x = (result[0] as OpcionCuestionario);
                                x.datos = (result[1] as Cuestionario);
                                //var opcion = new OpcionCuestionario
                                //{
                                //    asignar = (result[0] as OpcionCuestionario).asignar,
                                //    datos = (result[1] as Cuestionario)
                                //};
                                return x;
                            },
                            splitOn: "asignar,IdEncuesta").ToList());
                        
                        dto.dtoMedicionesConsulta =  new BindingList<OpcionMedicion>( dr.Read<OpcionMedicion>(new [] {typeof(OpcionMedicion), typeof(Medicion) }, 
                            (x) =>
                            {                               
                                var opcion = new OpcionMedicion
                                {       
                                    asignar = (x[0] as OpcionMedicion).asignar,
                                    dato = (x[1] as Medicion)
                                };
                                return opcion;                               
                            },
                            splitOn: "asignar,IdMedicion").ToList());

                        dto.dtoEncuestaConsultaOpciones = new BindingList<Respuestas>(dr.Read<Respuestas>().ToList());
                        dto.dtoRespuestaMultiple = new BindingList<Respuestas>(dr.Read<Respuestas>().ToList());
                        dto.dtoComentariosConsulta = new BindingList<ComentariosConsulta>(dr.Read<ComentariosConsulta>().ToList());
                    }
                    return dto;                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
