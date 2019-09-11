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
    public class ProductosMonederoRepository : Repository, IProductosMonederoRepository
    {
        public async Task<ProductosMonedero> AddAsync(ProductosMonedero element, object IdUsuario)
        {
            try
            {
                using(IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var parametros = new DynamicParameters();
                    parametros.Add("@IdProducto", element.IdProducto);
                    parametros.Add("@PuntosMonedero", element.PuntosMonedero);
                    parametros.Add("@AplicaDescuento", element.AplicaDescuento);
                    parametros.Add("@EsMonto", element.EsMonto);
                    parametros.Add("@PuntosDescuento", element.PuntosDescuento);
                    parametros.Add("@Monto", element.Monto);
                    parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.QueryFirstOrDefaultAsync<ProductosMonedero>("[Monedero].[SPCID_A_ProductoMonedero]", param: parametros, commandType: CommandType.StoredProcedure);
                    return result;
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

        public Task<IEnumerable<ProductosMonedero>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductosMonedero> GetAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdProducto", id);
                    var result = await conexion.QueryFirstOrDefaultAsync<ProductosMonedero>("[Monedero].[SPCID_Get_ProductoMonedero]", param: Parametros, commandType: CommandType.StoredProcedure);
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

        public Task<ProductosMonedero> UpdateAsync(ProductosMonedero element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
