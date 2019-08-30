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
    public class IvaRepository : Repository, IIvaRepository
    {
        public Task<Iva> AddAsync(Iva element, object IdUsuario)
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

        public Task<IEnumerable<Iva>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Iva> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Iva>> LlenarComboIva()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                   
                    List<Iva> Lista = new List<Iva>();
                    Iva Item;
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_ComboIva]",  commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Iva();
                        Item.IdTipoIva = dr.GetInt32(dr.GetOrdinal("IdTipoIva"));
                        Item.Porcentaje = dr.GetDecimal(dr.GetOrdinal("Porcentaje"));
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

        public Task<Iva> UpdateAsync(Iva element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
