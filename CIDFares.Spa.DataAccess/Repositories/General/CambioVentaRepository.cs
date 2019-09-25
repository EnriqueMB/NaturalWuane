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
    public class CambioVentaRepository : Repository, ICambioVentaRepository
    {
        public Task<CambioVenta> AddAsync(CambioVenta element, object IdUsuario)
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

        public Task<IEnumerable<CambioVenta>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CambioVenta> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> ObtenerCambio(int IdSucursal, Guid IdEmpleado, int IdTurnoEmpleado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    dynamicParameters.Add("@IdEmpleado", IdEmpleado);
                    dynamicParameters.Add("@IdTurnoEmpleado", IdTurnoEmpleado);
                    var dr = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_Get_CambioTurno]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<CambioVenta> UpdateAsync(CambioVenta element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<CambioVenta> UpdateCambioWithIdSucursalAsync(CambioVenta element, object IdSucursal, object IdEmpleado, object IdTurnoEmpleado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                   
                    dynamicParameters.Add("@IdSucursal", element.IdSucursal);
                    dynamicParameters.Add("@IdEmpleado", element.IdEmpleado);
                    dynamicParameters.Add("@IdTurnoEmpleado", element.IdTurnoEmpleado);
                    dynamicParameters.Add("@CambioTurno", element.CambioTurno);
                  
                    var result = await conexion.ExecuteScalarAsync<int>("[Venta].[SPCID_A_CambioVenta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
