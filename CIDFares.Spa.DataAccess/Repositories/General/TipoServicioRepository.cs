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
    public class TipoServicioRepository : Repository, ITipoServicioRepository
    {
        public Task<TipoServicio> AddAsync(TipoServicio element, object IdUsuario)
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

        public Task<IEnumerable<TipoServicio>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TipoServicio> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<TipoServicio>> LlenarComboTipoServicio()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();

                    List<TipoServicio> Lista = new List<TipoServicio>();
                    TipoServicio Item;
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_ComboTipoServicio]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new TipoServicio();
                        Item.IdTipoServicio = dr.GetInt32(dr.GetOrdinal("IdTipoServicio"));
                        Item.NombreTipoServicio = dr.GetString(dr.GetOrdinal("NombreTipoServicio"));
                        Lista.Add(Item);
                    }
                    dr.Close();
                    return Lista;
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

        public Task<TipoServicio> UpdateAsync(TipoServicio element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

      

            
    }
}
