using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using CIDFares.Library.Code.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class InventarioFisicoRepository : Repository, IInventarioFisicoRepository
    {
        #region no implemanetados
        public Task<Producto> AddAsync(Producto element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }



        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> UpdateAsync(Producto element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
        #endregion

        public async Task<IEnumerable<Producto>> GetProductos(object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    DynamicParameters Parametros = new DynamicParameters();
                    Parametros.Add("@IdSucursal", IdSucursal);
                    return await conexion.QueryAsync<Producto>("[Inventario].[SPCID_Get_InventarioFisico]", param: Parametros, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ActualizarProducto(List<Producto> ListA, List<Producto> ListB, int IdSucursal, decimal CantidadA, decimal PorcetajeIvaTotalA, decimal TotalA, decimal SubA, decimal CantidadB, decimal PorcetajeIvaTotalB, decimal TotalB, decimal SubB, Guid usuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    DynamicParameters Parametros = new DynamicParameters();
                    Parametros.Add("@IdSucursal", IdSucursal);
                    Parametros.Add("@TablaAlta", ListA.ToDataTable(new List<string> { "IdProducto", "CantidadProducto" }), DbType.Object);
                    Parametros.Add("@@TablaBaja", ListB.ToDataTable(new List<string> { "IdProducto", "CantidadProducto" }), DbType.Object);
                    Parametros.Add("@CantidadAlta", CantidadA);
                    Parametros.Add("@@IvaA", PorcetajeIvaTotalA);
                    Parametros.Add("@TotalA", TotalA);
                    Parametros.Add("@SubA", SubA);
                    Parametros.Add("@CantidadBaja", CantidadB);
                    Parametros.Add("@Usuario", usuario);
                    Parametros.Add("@@IvaB", PorcetajeIvaTotalB);
                    Parametros.Add("@TotalB", TotalB);
                    Parametros.Add("@SubB", SubB);
                    var x = await conexion.ExecuteScalarAsync<int>("[Inventario].[SPCID_A_InventarioProducto]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return x;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Producto>> GetCantidadProductos(object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    DynamicParameters Parametros = new DynamicParameters();
                    Parametros.Add("@IdSucursal", IdSucursal);
                    var x= await conexion.QueryAsync<Producto>("[Inventario].[SPCID_Get_CantidadProducto]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return x;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}