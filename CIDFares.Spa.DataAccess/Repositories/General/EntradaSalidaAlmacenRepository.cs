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
    public class EntradaSalidaAlmacenRepository : Repository, IEntradaSalidaAlmacenRepository
    {
        public async Task<EntradaSalidaAlmacen> AddAsync(EntradaSalidaAlmacen element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@TablaProductoEntrada", element.TablaEntradaAlmacen, DbType.Object);
                    dynamicParameters.Add("@TablaProductoSalida", element.TablaSalidaAlmacen, DbType.Object);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Tipo", element.Tipo);
                    dynamicParameters.Add("@FechaAlta", element.Fecha);
                    dynamicParameters.Add("@UsuarioAlta", IdUsuario);
                    dynamicParameters.Add("@IdSucursal", 1);
                    dynamicParameters.Add("@Cantidad", element.Cantidad);
                    var result = await conexion.ExecuteScalarAsync<int>("[Venta].[spCID_A_Venta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public Task<IEnumerable<EntradaSalidaAlmacen>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntradaSalidaAlmacen> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<EntradaSalidaAlmacen> UpdateAsync(EntradaSalidaAlmacen element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
