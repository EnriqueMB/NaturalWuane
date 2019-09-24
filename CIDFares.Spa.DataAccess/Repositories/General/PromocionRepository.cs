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
    public class PromocionRepository : Repository, IPromocionRepository
    {
        public Task<Promocion> AddAsync(Promocion element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<PromocionDescuento> AddPromocionDescuento(PromocionDescuento element, Guid idUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
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

        public async Task<PromocionMxN> AddPromocionMxN(PromocionMxN element, Guid idUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
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

        public async Task<PromocionNxN> AddPromocionNxN(PromocionNxN element, Guid idUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdTipoPromocion", element.Promocion.IdTipoPromocion);
                    dynamicParameters.Add("@IdGenerico", element.Promocion.IdGenerico);
                    dynamicParameters.Add("@EsProducto", element.Promocion.EsProducto);
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

        public async Task<IEnumerable<Promocion>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Promocion>("[Promocion].[SPCID_Get_Promociones]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result.ToList();
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
    }
}
