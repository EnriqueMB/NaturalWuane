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
                    if(loginRequests.IsValid == 1)
                    {
                        loginRequests.IdCuentaUsuario = !dr.IsDBNull(dr.GetOrdinal("IdCuentaUsuario")) ? dr.GetInt32(dr.GetOrdinal("IdCuentaUsuario")) : 0;
                        loginRequests.IdRol = !dr.IsDBNull(dr.GetOrdinal("IdRol")) ? dr.GetInt32(dr.GetOrdinal("IdRol")) : 0;
                        loginRequests.IdEmpleado = dr.GetGuid(dr.GetOrdinal("IdEmpleado"));
                        loginRequests.Nombres = dr.GetString(dr.GetOrdinal("Nombres"));
                    }
                }
                return loginRequests;
            }
        }

    }
}
