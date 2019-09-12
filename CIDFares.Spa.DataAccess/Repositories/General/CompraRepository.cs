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
    public class CompraRepository : Repository, ICompraRepository
    {
        public Task<Compra> AddAsync(Compra element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Compra> AddWithIdSucursalAsync(Compra element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    dynamicParameters.Add("@IdProveedor", element.ProveedorCompra.IdProveedor);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Subtotal", element.SubTotal);
                    dynamicParameters.Add("@Total", element.Total);
                    dynamicParameters.Add("@Iva", element.PorcentajeIva);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);  
                    var result = await conexion.ExecuteScalarAsync<int>("[Compra].[SPCID_A_Compra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
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

        public Task<IEnumerable<Compra>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Compra> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetFolioCompra()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.ExecuteScalarAsync<string>("[Compra].[SPCID_Get_FolioCompra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public Task<Compra> UpdateAsync(Compra element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
