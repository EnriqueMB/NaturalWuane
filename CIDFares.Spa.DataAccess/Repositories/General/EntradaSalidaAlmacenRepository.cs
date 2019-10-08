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
                    dynamicParameters.Add("@TablaProductoEntradaSalida", element.TablaEntradaSalidaAlmacen, DbType.Object);
                    dynamicParameters.Add("@Folio", element.Folio);
                    dynamicParameters.Add("@Tipo", element.Tipo);
                    dynamicParameters.Add("@FechaAlta", element.Fecha);
                    dynamicParameters.Add("@UsuarioAlta", IdUsuario);
                    dynamicParameters.Add("@IdSucursal", 1);
                    dynamicParameters.Add("@Cantidad", element.Cantidad);
                    dynamicParameters.Add("@Motivo", element.Motivo);
                    dynamicParameters.Add("@SubTotal", element.SubTotal);
                    dynamicParameters.Add("@Iva", element.Iva);
                    dynamicParameters.Add("@Total", element.Total);
                    var result = await conexion.ExecuteScalarAsync<int>("[Inventario].[SPCID_A_EntradaSalida]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public async  Task<string> GetFolio()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.ExecuteScalarAsync<string>("[Inventario].[SPCID_Get_FolioEntradaSalida]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public Task<EntradaSalidaAlmacen> UpdateAsync(EntradaSalidaAlmacen element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
