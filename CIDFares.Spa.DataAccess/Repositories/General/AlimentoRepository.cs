using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class AlimentoRepository : Repository, IAlimentoRepository
    {
        public async Task<Alimento> AddAsync(Alimento element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 1);
                    dynParameters.Add("@IdTipoAlimento", element.IdTipoAlimento);
                    dynParameters.Add("@IdAlimento", element.IdAlimento);
                    dynParameters.Add("@Nombre", element.Nombre.Trim());
                    dynParameters.Add("@Calorias", element.Calorias);
                    dynParameters.Add("@HidratosCarbono", element.HidratosCarbono);
                    dynParameters.Add("@Proteina", element.Proteina);
                    dynParameters.Add("@Grasa", element.Grasa);
                    dynParameters.Add("@Fibra", element.Fibra);
                    dynParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Alimento]", param: dynParameters, 
                        commandType: CommandType.StoredProcedure);
                    element.IdAlimento = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(object IdAlimento, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameter = new DynamicParameters();
                    dynParameter.Add("@IdAlimento", IdAlimento);
                    dynParameter.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_Alimento]", param: dynParameter, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Alimento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Alimento> GetAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@IdAlimento", id);
                    var result = await conexion.QueryFirstOrDefaultAsync<Alimento>("[Catalogo].[SPCID_Get_AlimentoXId]", param: dynParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> NameExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 15);
                    dynParameters.Add("@Nombre", name.Trim());
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynParameters,
                        commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Alimento> UpdateAsync(Alimento element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Opcion", 2);
                    dynParameters.Add("@IdTipoAlimento", element.IdTipoAlimento);
                    dynParameters.Add("@IdAlimento", element.IdAlimento);
                    dynParameters.Add("@Nombre", element.Nombre.Trim());
                    dynParameters.Add("@Calorias", element.Calorias);
                    dynParameters.Add("@HidratosCarbono", element.HidratosCarbono);
                    dynParameters.Add("@Proteina", element.Proteina);
                    dynParameters.Add("@Grasa", element.Grasa);
                    dynParameters.Add("@Fibra", element.Fibra);
                    dynParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_Alimento]", param: dynParameters,
                        commandType: CommandType.StoredProcedure);
                    element.IdAlimento = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public async Task<IEnumerable<Alimento>> GetBusquedaAlimentoAsync(string BusquedaAlimento)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@BusquedaAlimento", BusquedaAlimento);
                    var result = await conexion.QueryAsync<Alimento>("[Catalogo].[SPCID_Get_BusquedaAlimento]", param: dynParameters,
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

        public async Task<IEnumerable<Alimento>> GetAllAsync(int Page, int Opcion)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynParameters = new DynamicParameters();
                    dynParameters.Add("@Pagina", Page);
                    dynParameters.Add("@Cantidad", 50);
                    dynParameters.Add("@Opcion", Opcion);
                    var dr = await conexion.QueryAsync<Alimento>("[Catalogo].[SPCID_Get_Alimento]", param: dynParameters,
                        commandType: CommandType.StoredProcedure);
                    return dr.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
