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
    public class RegistroEntradaSalidaRepository : Repository, IRegistroEntradaSalidaRepository
    {
       
        public async Task<RegistroEntradaSalida> VerificarCodigoBarra(RegistroEntradaSalida element)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@CodigoBarra", element.CodigoBarra);
                    var result = await conexion.ExecuteScalarAsync<Guid>("[General].[SPCID_VerificaCodigoBarra]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.IdEmpleado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> VerificarPassword(object IdEmpleado, object Password)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEmpleado", IdEmpleado);
                    dynamicParameters.Add("@Password", Password);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_VerifiarContraseña]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Registrar(object IdEmpleado, object Tipo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEmpleado", IdEmpleado);
                    dynamicParameters.Add("@Tipo", Tipo);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_RegistroEntradaSalida]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> CodigoExista(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 13);
                    dynamicParameters.Add("@Nombre", name.Trim());
                    var dr = await conexion.ExecuteScalarAsync<Guid>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region no implementados
        public Task<RegistroEntradaSalida> AddAsync(RegistroEntradaSalida element, object IdUsuario)
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

        public Task<IEnumerable<RegistroEntradaSalida>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegistroEntradaSalida> GetAsync(object id)
        {
            throw new NotImplementedException();
        }



        public  Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<RegistroEntradaSalida> UpdateAsync(RegistroEntradaSalida element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<int> ValidarTurno(object CodigoBarra, object Tipo)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@CodigoBarra", CodigoBarra);
                    dynamicParameters.Add("@Tipo", Tipo);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarTurno]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        #endregion


    }
}
