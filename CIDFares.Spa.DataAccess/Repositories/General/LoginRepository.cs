using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class LoginRepository : Repository, ILoginRepository
    {
        public async Task<LoginRequests> Login(string Account, string Password)
        {
            try
            {
                LoginRequests loginRequests = new LoginRequests();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Cuenta", Account);
                    dynamicParameters.Add("@Password", Password);
                    var dr = await conexion.ExecuteReaderAsync("SPCID_Login", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        loginRequests.IsValid = !dr.IsDBNull(dr.GetOrdinal("IsValid")) ? dr.GetInt32(dr.GetOrdinal("IsValid")) : 0;
                        if (loginRequests.IsValid == 1)
                        {
                            loginRequests.IdCuentaUsuario = !dr.IsDBNull(dr.GetOrdinal("IdCuentaUsuario")) ? dr.GetGuid(dr.GetOrdinal("IdCuentaUsuario")) : Guid.Empty;
                            loginRequests.IdRol = !dr.IsDBNull(dr.GetOrdinal("IdRol")) ? dr.GetInt32(dr.GetOrdinal("IdRol")) : 0;
                            loginRequests.IdTurnoEmpleado = dr.GetInt32(dr.GetOrdinal("IdTurnoEmpleado"));
                            loginRequests.IdEmpleado = !dr.IsDBNull(dr.GetOrdinal("IdEmpleado")) ? dr.GetGuid(dr.GetOrdinal("IdEmpleado")) : Guid.Empty;
                            loginRequests.Nombres = dr.GetString(dr.GetOrdinal("Nombre"));
                            loginRequests.IdSucursal = !dr.IsDBNull(dr.GetOrdinal("IdSucursal")) ? dr.GetInt32(dr.GetOrdinal("IdSucursal")) : 0;
                            loginRequests.ReglaUsuario = dr.GetString(dr.GetOrdinal("IdReglas")).Split(',');
                        }
                    }
                    dr.Close();
                }
                return loginRequests;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
