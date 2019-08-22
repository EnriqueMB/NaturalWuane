using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class FormaPagoRepository : Repository, IFormaPagoRepository
    {
        public Task<FormaPago> AddAsync(FormaPago element)
        {
            throw new NotImplementedException();
        }
        
        public Task<int> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FormaPago>> GetAllAsync()
        {
            using (IDbConnection conexion = new SqlConnection(WebConnectionString))
            {
                conexion.Open();
                var dynamicParameters = new DynamicParameters();
                List<FormaPago> Lista = new List<FormaPago>();
                FormaPago Item;
                var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_FormaPago]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                while (dr.Read())
                {
                    Item = new FormaPago();
                    Item.IdFormaPago = dr.GetInt32(dr.GetOrdinal("IdFormaPago"));
                    Item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    Lista.Add(Item);
                }
                dr.Close();
                return Lista;
            }
        }

        public Task<FormaPago> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FormaPago> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FormaPago> UpdateAsync(FormaPago element)
        {
            throw new NotImplementedException();
        }
    }
}
