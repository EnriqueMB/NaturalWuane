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
    public class EmpleadoRepository : Repository, IEmpleadoRepository
    {
        public Task<Empleado> AddAsync(Empleado element)
        {
            throw new NotImplementedException();
        }
        public async Task<Empleado> AddAsync(Empleado element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@IdEmpleado", element.IdEmpleado);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@ApellidoPat", element.ApellidoPat);
                    dynamicParameters.Add("@ApellidoMat", element.ApellidoMat);
                    dynamicParameters.Add("@Edad", element.FechaNacimiento); //que se hace
                    dynamicParameters.Add("@Sexo", element.Sexo);
                    dynamicParameters.Add("@IdTurno", element.IdTurno);
                    dynamicParameters.Add("@IdPuesto", element.IdPuesto);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@Correo", element.Correo);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Foto", element.FotoBase64);
                    dynamicParameters.Add("@Contraseña", element.Contraseña);
                    dynamicParameters.Add("@IdSucursal", /*element.IdSucursal*/ 1);
                    

                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Empleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Guid> ClaveExistAsync(string name)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 10);
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

        public Task<int> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {

            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEmpleado", id);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_Delete_Empleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Empleado> Lista = new List<Empleado>();
                    Empleado item;
                    //var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_Empleado]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Empleado();
                        item.IdEmpleado = !dr.IsDBNull(dr.GetOrdinal("IdEmpleado")) ? dr.GetGuid(dr.GetOrdinal("IdEmpleado")) : Guid.Empty;
                        item.Clave = !dr.IsDBNull(dr.GetOrdinal("Clave")) ? dr.GetString(dr.GetOrdinal("Clave")) : string.Empty;
                        item.NombreCompleto = !dr.IsDBNull(dr.GetOrdinal("NombreCompleto")) ? dr.GetString(dr.GetOrdinal("NombreCompleto")) : string.Empty;
                        item.Edad = !dr.IsDBNull(dr.GetOrdinal("Edad")) ? dr.GetInt32(dr.GetOrdinal("Edad")) : 0;
                        item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo"))); 
                        
                        item.Turno = !dr.IsDBNull(dr.GetOrdinal("Turno")) ? dr.GetString(dr.GetOrdinal("Turno")) : string.Empty;
                       
                        item.Puesto = !dr.IsDBNull(dr.GetOrdinal("Puesto")) ? dr.GetString(dr.GetOrdinal("Puesto")) : string.Empty;
                        item.Telefono = !dr.IsDBNull(dr.GetOrdinal("Telefono")) ? dr.GetString(dr.GetOrdinal("Telefono")) : string.Empty;
                        item.Correo = !dr.IsDBNull(dr.GetOrdinal("Correo")) ? dr.GetString(dr.GetOrdinal("Correo")) : string.Empty;
                        item.Direccion = !dr.IsDBNull(dr.GetOrdinal("Direccion")) ? dr.GetString(dr.GetOrdinal("Direccion")) : string.Empty;
                        item.CodigoBarra = !dr.IsDBNull(dr.GetOrdinal("CodigoBarra")) ? dr.GetString(dr.GetOrdinal("CodigoBarra")) : string.Empty;
                        Lista.Add(item);
                    }
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task<Empleado> GetAsync(object id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Empleado>> GetComboEmpleado()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var result = await conexion.QueryAsync<Empleado>("[Usuario].[SPCID_Get_ComboEmpleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);

                    return result;
                }

            }
            catch (Exception ex)
            { 
            
                throw ex;
            }
        }
        public async Task<Empleado> GetEmpleadoXid(Guid IdEmpleado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    Empleado item = new Empleado();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEmpleado", IdEmpleado);
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_EmpleadoXId]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Empleado();
                        item.IdEmpleado = !dr.IsDBNull(dr.GetOrdinal("IdEmpleado")) ? dr.GetGuid(dr.GetOrdinal("IdEmpleado")) : Guid.Empty;
                        item.Clave = !dr.IsDBNull(dr.GetOrdinal("Clave")) ? dr.GetString(dr.GetOrdinal("Clave")) : string.Empty;
                        item.Nombre = !dr.IsDBNull(dr.GetOrdinal("Nombre")) ? dr.GetString(dr.GetOrdinal("Nombre")) : string.Empty;
                        item.ApellidoPat = !dr.IsDBNull(dr.GetOrdinal("ApellidoPat")) ? dr.GetString(dr.GetOrdinal("ApellidoPat")) : string.Empty;
                        item.ApellidoMat = !dr.IsDBNull(dr.GetOrdinal("ApellidoMat")) ? dr.GetString(dr.GetOrdinal("ApellidoMat")) : string.Empty;
                        item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
                        item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo")));
                        item.IdTurno = !dr.IsDBNull(dr.GetOrdinal("IdTurno")) ? dr.GetInt32(dr.GetOrdinal("IdTurno")) : 0;
                        item.IdPuesto = !dr.IsDBNull(dr.GetOrdinal("IdPuesto")) ? dr.GetInt32(dr.GetOrdinal("IdPuesto")) : 0;
                        item.Telefono = !dr.IsDBNull(dr.GetOrdinal("Telefono")) ? dr.GetString(dr.GetOrdinal("Telefono")) : string.Empty;
                        item.Correo = !dr.IsDBNull(dr.GetOrdinal("Correo")) ? dr.GetString(dr.GetOrdinal("Correo")) : string.Empty;
                        item.Direccion = !dr.IsDBNull(dr.GetOrdinal("Direccion")) ? dr.GetString(dr.GetOrdinal("Direccion")) : string.Empty;
                    }
                    return item;
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
        public Task<Empleado> UpdateAsync(Empleado element)
        {
            throw new NotImplementedException();
        }
        public async Task<Empleado> UpdateAsync(Empleado element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@IdEmpleado", element.IdEmpleado);
                    dynamicParameters.Add("@Clave", element.Clave);
                    dynamicParameters.Add("@Nombre", element.Nombre);
                    dynamicParameters.Add("@ApellidoPat", element.ApellidoPat);
                    dynamicParameters.Add("@ApellidoMat", element.ApellidoMat);
                    dynamicParameters.Add("@Edad", element.FechaNacimiento); //que se hace
                    dynamicParameters.Add("@Sexo", element.Sexo);
                    dynamicParameters.Add("@IdTurno", element.IdTurno);
                    dynamicParameters.Add("@IdPuesto", element.IdPuesto);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@Correo", element.Correo);
                    dynamicParameters.Add("@Usuario", IdUsuario);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Foto", element.FotoBase64);
                    dynamicParameters.Add("@Contraseña", element.Contraseña);
                    dynamicParameters.Add("@IdSucursal", /*element.IdSucursal*/ 1);
                    var Resultado = await conexion.ExecuteScalarAsync<int>("[Usuario].[SPCID_AC_Empleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = Resultado;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> ObtenerFoto(Guid IdEmpelado)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdEmpleado", IdEmpelado);
                    var dr = await conexion.ExecuteScalarAsync<string>("[Usuario].[SPCID_Get_ObtenerFotoEmpleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Empleado>> GetBusquedaAsync(string Busqueda)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Empleado> Lista = new List<Empleado>();
                    Empleado item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Busqueda", Busqueda);
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Get_BusquedaEmpleado]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Empleado();
                        item.IdEmpleado = !dr.IsDBNull(dr.GetOrdinal("IdEmpleado")) ? dr.GetGuid(dr.GetOrdinal("IdEmpleado")) : Guid.Empty;
                        item.Clave = !dr.IsDBNull(dr.GetOrdinal("Clave")) ? dr.GetString(dr.GetOrdinal("Clave")) : string.Empty;
                        item.NombreCompleto = !dr.IsDBNull(dr.GetOrdinal("NombreCompleto")) ? dr.GetString(dr.GetOrdinal("NombreCompleto")) : string.Empty;
                        item.Edad = !dr.IsDBNull(dr.GetOrdinal("Edad")) ? dr.GetInt32(dr.GetOrdinal("Edad")) : 0;
                        item.Sexo = Convert.ToChar(dr.GetString(dr.GetOrdinal("Sexo")));
                        item.Turno = !dr.IsDBNull(dr.GetOrdinal("Turno")) ? dr.GetString(dr.GetOrdinal("Turno")) : string.Empty;
                        item.Puesto = !dr.IsDBNull(dr.GetOrdinal("Puesto")) ? dr.GetString(dr.GetOrdinal("Puesto")) : string.Empty;
                        item.Telefono = !dr.IsDBNull(dr.GetOrdinal("Telefono")) ? dr.GetString(dr.GetOrdinal("Telefono")) : string.Empty;
                        item.Correo = !dr.IsDBNull(dr.GetOrdinal("Correo")) ? dr.GetString(dr.GetOrdinal("Correo")) : string.Empty;
                        item.Direccion = !dr.IsDBNull(dr.GetOrdinal("Direccion")) ? dr.GetString(dr.GetOrdinal("Direccion")) : string.Empty;
                        item.CodigoBarra = !dr.IsDBNull(dr.GetOrdinal("CodigoBarra")) ? dr.GetString(dr.GetOrdinal("CodigoBarra")) : string.Empty;
                        Lista.Add(item);
                    }
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async  Task<Guid> NombreCompletoExistAsync(string name, string ApellidoPat, string ApellidoMat)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Nombre", name.Trim());
                    dynamicParameters.Add("@ApellidoPat", ApellidoPat.Trim());
                    dynamicParameters.Add("@ApellidoMat", ApellidoMat.Trim());
                    var dr = await conexion.ExecuteScalarAsync<Guid>("[Usuario].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
