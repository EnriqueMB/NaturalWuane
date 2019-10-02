using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.DataAccess.Contracts.DTOs.General;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
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
    public class PromocionRepository : Repository, IPromocionRepository
    {
        public Task<Promocion> AddAsync(Promocion element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<PromocionGeneral> AddAsync(PromocionGeneral element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<PromocionDescuento> AddPromocionDescuento(PromocionDescuento element, Guid idUsuario, int Opcion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", Opcion);
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.TipoPromocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
                    dynamicParameters.Add("@Nombre", element.Promocion.NombrePromocion);
                    dynamicParameters.Add("@EsMonto", element.EsMonto);
                    dynamicParameters.Add("@Descuento", element.Descuento);
                    dynamicParameters.Add("@EsPeriodo", element.PromocionDias.EsPeriodo);
                    dynamicParameters.Add("@FechaInicio", element.PromocionDias.FechaInicio);
                    dynamicParameters.Add("@FechaFinal", element.PromocionDias.FechaFinal);
                    dynamicParameters.Add("@Lunes", element.PromocionDias.Lunes);
                    dynamicParameters.Add("@Martes", element.PromocionDias.Martes);
                    dynamicParameters.Add("@Miercoles", element.PromocionDias.Miercoles);
                    dynamicParameters.Add("@Jueves", element.PromocionDias.Jueves);
                    dynamicParameters.Add("@Viernes", element.PromocionDias.Viernes);
                    dynamicParameters.Add("@Sabado", element.PromocionDias.Sabado);
                    dynamicParameters.Add("@Domingo", element.PromocionDias.Domingo);
                    dynamicParameters.Add("@Limite", element.PromocionDias.Limite);
                    dynamicParameters.Add("@Usuario", idUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Promocion].[SPCID_A_PromocionDescuento]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Promocion.Resultado = result;
                    return element;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<PromocionMxN> AddPromocionMxN(PromocionMxN element, Guid idUsuario, int Opcion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", Opcion);
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.TipoPromocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
                    dynamicParameters.Add("@Nombre", element.Promocion.NombrePromocion);
                    dynamicParameters.Add("@Cantidad", element.Cantidad);
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    dynamicParameters.Add("@EsPeriodo", element.PromocionDias.EsPeriodo);
                    dynamicParameters.Add("@FechaInicio", element.PromocionDias.FechaInicio);
                    dynamicParameters.Add("@FechaFinal", element.PromocionDias.FechaFinal);
                    dynamicParameters.Add("@Lunes", element.PromocionDias.Lunes);
                    dynamicParameters.Add("@Martes", element.PromocionDias.Martes);
                    dynamicParameters.Add("@Miercoles", element.PromocionDias.Miercoles);
                    dynamicParameters.Add("@Jueves", element.PromocionDias.Jueves);
                    dynamicParameters.Add("@Viernes", element.PromocionDias.Viernes);
                    dynamicParameters.Add("@Sabado", element.PromocionDias.Sabado);
                    dynamicParameters.Add("@Domingo", element.PromocionDias.Domingo);
                    dynamicParameters.Add("@Limite", element.PromocionDias.Limite);
                    dynamicParameters.Add("@Usuario", idUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Promocion].[SPCID_A_PromocionMxN]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Promocion.Resultado = result;
                    return element;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<PromocionNxN> AddPromocionNxN(PromocionNxN element, Guid idUsuario, int Opcion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", Opcion);
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.TipoPromocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
                    dynamicParameters.Add("@Nombre", element.Promocion.NombrePromocion);
                    dynamicParameters.Add("@Cantidad", element.Cantidad);
                    dynamicParameters.Add("@CantidadGratis", element.CantidadGratis);
                    dynamicParameters.Add("@EsPeriodo", element.PromocionDias.EsPeriodo);
                    dynamicParameters.Add("@FechaInicio", element.PromocionDias.FechaInicio);
                    dynamicParameters.Add("@FechaFinal", element.PromocionDias.FechaFinal);
                    dynamicParameters.Add("@Lunes", element.PromocionDias.Lunes);
                    dynamicParameters.Add("@Martes", element.PromocionDias.Martes);
                    dynamicParameters.Add("@Miercoles", element.PromocionDias.Miercoles);
                    dynamicParameters.Add("@Jueves", element.PromocionDias.Jueves);
                    dynamicParameters.Add("@Viernes", element.PromocionDias.Viernes);
                    dynamicParameters.Add("@Sabado", element.PromocionDias.Sabado);
                    dynamicParameters.Add("@Domingo", element.PromocionDias.Domingo);
                    dynamicParameters.Add("@Limite", element.PromocionDias.Limite);
                    dynamicParameters.Add("@Usuario", idUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Promocion].[SPCID_A_PromocionNxN]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Promocion.Resultado = result;
                    return element;
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

        public Task<IEnumerable<Promocion>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<BindingList<PromocionGeneral>> GetAllPromocionAsync()
        //{
        //    try
        //    {
        //        //PromocionDto item = new PromocionDto();
        //        using (IDbConnection conexion = new SqlConnection(WebConnectionString))
        //        {
        //            conexion.Open();
        //            var dynamicParameters = new DynamicParameters();
        //            //var dr = conexion.QueryMultipleAsync("[Promocion].[SPCID_Get_Promociones]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
        //            var dr = await conexion.QueryAsync<PromocionGeneral>("[Promocion].[SPCID_Get_Promociones]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
        //            return new BindingList<PromocionGeneral>(dr.ToList());
        //            //return item;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        /*
         public async Task<IEnumerable<PersonalModel>> GetPersonalByPage(int IndexStart, int Rows)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<PersonalModel> Lista = new List<PersonalModel>();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IndexStart", IndexStart);
                    dynamicParameters.Add("@Rows", Rows);
                    var lista = await conexion.QueryAsync<PersonalModel, AreaEmpresaModel, NacionalidadModel, ProcedenciaModel, PersonalModel>("[Nomina].[SPCID_Get_PersonalXPage]",
                        (personal, area, nacionaliad, procedencia) =>
                        {
                            personal.DatosAreaEmpresa = area;
                            personal.DatosNacionalidad = nacionaliad;
                            personal.DatosProcedencia = procedencia;
                            return personal;
                        },
                        splitOn: "IdAreaEmpresa, IdNacionalidad, IdProcedencia", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
         */
        public async Task<IEnumerable<PromocionGeneral>> GetAllPromocionAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<PromocionGeneral> Lista = new List<PromocionGeneral>();
                    var dynamicParameters = new DynamicParameters();
                    var lista = await conexion.QueryAsync<PromocionGeneral, TipoPromocion, PromocionGeneral>("[Promocion].[SPCID_Get_Promociones]",
                        (promocion, tipoPromocion) =>
                        {
                            promocion.TipoPromocion = tipoPromocion;
                            return promocion;
                        },
                        splitOn: "IdPromocion, IdTipoPromocion", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Task<Promocion> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<PromocionDescuento> GetDetalleAsync(Guid IdPromocion, int IdTipoPromocion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Tipo", IdTipoPromocion);
                    dynamicParameters.Add("@IdPromocion", IdPromocion);
                    var promocionDescuento = await conexion.QuerySingleAsync<PromocionDescuento>("[Promocion].[SPCID_Get_PromocionXIdPromocion]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return promocionDescuento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PromocionNxN> GetDetalleNxNAsync(Guid IdPromocion, int IdTipoPromocion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Tipo", IdTipoPromocion);
                    dynamicParameters.Add("@IdPromocion", IdPromocion);
                    var promocion = await conexion.QuerySingleAsync<PromocionNxN>("[Promocion].[SPCID_Get_PromocionXIdPromocion]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return promocion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<PromocionMxN> GetDetalleMxNAsync(Guid IdPromocion, int IdTipoPromocion)
        //{
        //    try
        //    {
        //        using (IDbConnection conexion = new SqlConnection(WebConnectionString))
        //        {
        //            conexion.Open();
        //            var dynamicParameters = new DynamicParameters();
        //            dynamicParameters.Add("@Tipo", IdTipoPromocion);
        //            dynamicParameters.Add("@IdPromocion", IdPromocion);
        //            var promocion = await conexion.QuerySingleAsync<PromocionMxN>("[Promocion].[SPCID_Get_PromocionXIdPromocion]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
        //            return promocion;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public async Task<PromocionMxN> GetDetalleMxNAsync(Guid IdPromocion, int idTipoPromocion)
        {
            try
            {
                PromocionMxN promocion = new PromocionMxN();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Tipo", idTipoPromocion);
                    dynamicParameters.Add("@IdPromocion", IdPromocion);
                    using (var dr = conexion.QueryMultipleAsync("[Promocion].[SPCID_Get_PromocionXIdPromocion]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
                    {
                        promocion = dr.ReadFirstOrDefault<PromocionMxN>();
                        List<PromocionMxN> promDetalle = dr.Read<PromocionMxN>().ToList();
                        promocion.TablaPromocion = promDetalle.ToDataTable();
                    }
                    return promocion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PromocionDias> GetDiasAsync(Guid idPromocion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdPromocion", idPromocion);
                    var promocionDescuento = await conexion.QuerySingleAsync<PromocionDias>("[Promocion].[SPCID_Get_PromocionDias]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return promocionDescuento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<BindingList<TipoPromocion>> LlenarComboTipoPromocion()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.QueryAsync<TipoPromocion>("[Promocion].[SPCID_Get_ComboTipoPromocion]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<TipoPromocion>(dr.ToList());
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

        public Task<Promocion> UpdateAsync(Promocion element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<PromocionGeneral> UpdateAsync(PromocionGeneral element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PromocionGeneral>> IBaseRepository<PromocionGeneral>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<PromocionGeneral> IBaseRepository<PromocionGeneral>.GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<PromocionDescuento> UpdatePromocionDescuento(PromocionDescuento element, Guid idUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.TipoPromocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
                    dynamicParameters.Add("@Nombre", element.Promocion.NombrePromocion);
                    dynamicParameters.Add("@EsMonto", element.EsMonto);
                    dynamicParameters.Add("@Descuento", element.Descuento);
                    dynamicParameters.Add("@EsPeriodo", element.PromocionDias.EsPeriodo);
                    dynamicParameters.Add("@FechaInicio", element.PromocionDias.FechaInicio);
                    dynamicParameters.Add("@FechaFinal", element.PromocionDias.FechaFinal);
                    dynamicParameters.Add("@Lunes", element.PromocionDias.Lunes);
                    dynamicParameters.Add("@Martes", element.PromocionDias.Martes);
                    dynamicParameters.Add("@Miercoles", element.PromocionDias.Miercoles);
                    dynamicParameters.Add("@Jueves", element.PromocionDias.Jueves);
                    dynamicParameters.Add("@Viernes", element.PromocionDias.Viernes);
                    dynamicParameters.Add("@Sabado", element.PromocionDias.Sabado);
                    dynamicParameters.Add("@Domingo", element.PromocionDias.Domingo);
                    dynamicParameters.Add("@Limite", element.PromocionDias.Limite);
                    dynamicParameters.Add("@Usuario", idUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Promocion].[SPCID_A_PromocionDescuento]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Promocion.Resultado = result;
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
