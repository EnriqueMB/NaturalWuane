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
    public class ServicioRepository : Repository, IServicioRepository
    {        
        public Task<Servicio> AddAsync(Servicio element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(object id)
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

        public async Task<IEnumerable<Servicio>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();                    
                    List<Servicio> Lista = new List<Servicio>();
                    Servicio Item;
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_Servicio]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Servicio();
                        Item.IdServicio = dr.GetInt32(dr.GetOrdinal("IdServicio"));
                        Item.IdTipoServicio = dr.GetInt32(dr.GetOrdinal("IdTipoServicio"));
                        Item.IdTipoIva = dr.GetInt32(dr.GetOrdinal("IdTipoIva"));
                        Item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        Item.TipoServicio = dr.GetString(dr.GetOrdinal("TipoServicio"));
                        Item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        Item.Precio = dr.GetDecimal(dr.GetOrdinal("Precio"));
                        Item.Duracion = dr.GetDecimal(dr.GetOrdinal("Duracion"));
                        Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                        Item.Porcentaje = dr.GetDecimal(dr.GetOrdinal("Porcentaje"));
                        Item.DescIva = dr.GetString(dr.GetOrdinal("DescIva"));
                        Item.AplicaIva = dr.GetBoolean(dr.GetOrdinal("AplicaIva"));
                        Item.AplicaIEPS = dr.GetBoolean(dr.GetOrdinal("AplicaIEPS"));
                        Item.IEPSMonto = dr.GetBoolean(dr.GetOrdinal("IEPSMonto"));
                        Item.IEPS = dr.GetDecimal(dr.GetOrdinal("IEPS"));
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
            //[Catalogo].[SPCID_Get_Servicio]
        }

        public Task<Servicio> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }       

        public Task<Servicio> UpdateAsync(Servicio element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
