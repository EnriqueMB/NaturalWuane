using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
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
                    return  await conexion.QueryAsync<Producto>("[Inventario].[SPCID_Get_InventarioFisico]", param: IdSucursal, commandType: CommandType.StoredProcedure);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
