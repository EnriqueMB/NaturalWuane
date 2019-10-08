using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class TipoAlimentoRepository: Repository, ITipoAlimentoRepository
    {
        #region Métodos No Implementados
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoAlimento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlimento> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlimento> UpdateAsync(TipoAlimento element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlimento> AddAsync(TipoAlimento element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Métodos Implementados

        /// <summary>
        /// Método para obtener la lista de los tipos de alimentos.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TipoAlimento>> GetComboTipoAlimento()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<TipoAlimento>("[Catalogo].[SPCID_Get_ComboTipoAlimento]", param: dynParameters,
                        commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            } 
        }
        #endregion
    }
}
