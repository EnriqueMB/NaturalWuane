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
using System.Xml;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class ServicioRepository : Repository, IServicioRepository
    {
        #region Interfaces Implementadas

        public async Task<IEnumerable<Servicio>> GetBusqServicioAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Servicio> Lista = new List<Servicio>();
                    Servicio item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@BitNombre", BitNombre);
                    dynamicParameters.Add("@BusquedaNombre", BusqNombre);
                    dynamicParameters.Add("@BitCodigo", BitClaveCodigo);
                    dynamicParameters.Add("@BusquedaCodigo", BusqClaveCodigo);
                    var dr = await conexion.ExecuteReaderAsync("[Venta].[SPCID_Get_ObtenerBusquedaProducto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Servicio();
                        //item.Id = dr.GetInt32(dr.GetOrdinal("IdProducto"));
                        //item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
                        //item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        //item.NombreCategoria = dr.GetString(dr.GetOrdinal("NombreCategoria"));
                        //item.UnidadMedida = dr.GetString(dr.GetOrdinal("UnidadMedidad"));
                        //item.PrecioPublico = dr.GetDecimal(dr.GetOrdinal("PrecioPublico"));
                        //item.PrecioMayoreo = dr.GetDecimal(dr.GetOrdinal("PrecioMayoreo"));
                        //item.PrecioMenudeo = dr.GetDecimal(dr.GetOrdinal("PrecioMenudeo"));
                        //item.ProcentajeIva = dr.GetDecimal(dr.GetOrdinal("PorcentajeIva"));
                        //XmlConvert.ToTimeSpan(dr.GetString("hola"));
                        Lista.Add(item);
                    }
                    return Lista;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
        public Task<Servicio> AddAsync(Servicio element)
        {
            throw new NotImplementedException();
        }

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

        public Task<IEnumerable<Servicio>> GetAllAsync()
        {
            throw new NotImplementedException();
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

        public Task<Servicio> UpdateAsync(Servicio element)
        {
            throw new NotImplementedException();
        }

        public Task<Servicio> UpdateAsync(Servicio element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
