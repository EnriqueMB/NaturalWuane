using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System.Data;
using System.Data.SqlClient;
using CIDFares.Library.Code.Extensions;
using Dapper;
using System.Linq;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class SucursalRepository : Repository, ISucursalRepository
    {
        #region Metodos Implementado
        public async Task<Sucursal> AddAsync(Sucursal element, object IdUsuario)
        {
            try
            {
                Sucursal sucursal = new Sucursal();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {

                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", 1);
                    dynamicParameters.Add("@IdSucursal", 0);//element.IdSucursal, DbType.Int32, direction: ParameterDirection.InputOutput
                    dynamicParameters.Add("@IdTipoSucursal", element.IdTipoSucursal);
                    dynamicParameters.Add("@NombreSucursal", element.Nombre);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@IdMunicipio", element.IdMunicipio);
                    dynamicParameters.Add("@IdEstado", element.IdEstado);
                    dynamicParameters.Add("@IdPais", element.IdPais);
                    dynamicParameters.Add("@CodigoPostal", element.CodigoPostal);
                    dynamicParameters.Add("@RFC", element.Rfc);
                    dynamicParameters.Add("@NombreRepresentante", element.NombreRepresentante);
                    dynamicParameters.Add("@RegimenFiscal", element.RegimenFiscal);
                    dynamicParameters.Add("@TablaHorario", ObtenerTabla(element.ListaHorario), DbType.Object);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_AC_Sucursales]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    sucursal.Result = result;
                }
                return sucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdSucursal", id);
                    dynamicParameters.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_Delete_Sucursal]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Sucursal>> GetAllAsync()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<Sucursal> sucursals = new List<Sucursal>();
                    Sucursal item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Todo", 1);
                    dynamicParameters.Add("@IdSucursal", 0);
                    var dr = await conexion.ExecuteReaderAsync("[General].[SPCID_Get_Sucursales]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        item = new Sucursal();
                        item.IdSucursal = !dr.IsDBNull(dr.GetOrdinal("IdSucursal")) ? dr.GetInt32(dr.GetOrdinal("IdSucursal")) : 0;
                        //item.IdTipoSucursal = !dr.IsDBNull(dr.GetOrdinal("IdTipoSucursal")) ? dr.GetInt32(dr.GetOrdinal("IdTipoSucursal")) : 0;
                        item.NombreTipoSucursal = dr.GetString(dr.GetOrdinal("TipoSucursal"));
                        item.NumSucursal = dr.GetInt32(dr.GetOrdinal("NumSucursal"));
                        item.Nombre = dr.GetString(dr.GetOrdinal("NombreSucursal"));
                        item.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
                        item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                        item.NombreMunicipio = dr.GetString(dr.GetOrdinal("Municipio"));
                        item.NombreEstado = dr.GetString(dr.GetOrdinal("Estado")); ;
                        item.NombrePais = dr.GetString(dr.GetOrdinal("Pais"));
                        item.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
                        item.Rfc = dr.GetString(dr.GetOrdinal("RFC"));
                        item.NombreRepresentante = dr.GetString(dr.GetOrdinal("NombreRepresentante"));
                        item.RegimenFiscal = dr.GetString(dr.GetOrdinal("RegimenFiscal"));
                        sucursals.Add(item);
                    }
                    dr.Close();
                    return sucursals;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Sucursal> GetAsync(object id)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    Sucursal item = new Sucursal();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Todo", 0);
                    dynamicParameters.Add("@IdSucursal", id);
                    using (var dr = conexion.QueryMultipleAsync("[General].[SPCID_Get_Sucursales]", param: dynamicParameters, commandType: CommandType.StoredProcedure).Result)
                    {
                        item = dr.ReadFirstOrDefault<Sucursal>();                        
                        item.ListaHorario = dr.Read<HorarioSucursal>().ToList();    
                        
                    }
                    //var dr = await conexion.ExecuteReaderAsync("[General].[SPCID_Get_Sucursales]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    //while (dr.Read())
                    //{
                    //    item.IdTipoSucursal = !dr.IsDBNull(dr.GetOrdinal("IdTipoSucursal")) ? dr.GetInt32(dr.GetOrdinal("IdTipoSucursal")) : 0;
                    //    item.NumSucursal = dr.GetInt32(dr.GetOrdinal("NumSucursal"));
                    //    item.Nombre = dr.GetString(dr.GetOrdinal("NombreSucursal"));
                    //    item.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
                    //    item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                    //    item.IdMunicipio = !dr.IsDBNull(dr.GetOrdinal("IdMunicipio")) ? dr.GetInt32(dr.GetOrdinal("IdMunicipio")) : 0;
                    //    item.IdEstado = !dr.IsDBNull(dr.GetOrdinal("IdEstado")) ? dr.GetInt32(dr.GetOrdinal("IdEstado")) : 0;
                    //    item.IdPais = !dr.IsDBNull(dr.GetOrdinal("IdPais")) ? dr.GetInt32(dr.GetOrdinal("IdPais")) : 0;
                    //    item.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
                    //    item.Rfc = dr.GetString(dr.GetOrdinal("RFC"));
                    //    item.NombreRepresentante = dr.GetString(dr.GetOrdinal("NombreRepresentante"));
                    //    item.RegimenFiscal = dr.GetString(dr.GetOrdinal("RegimenFiscal"));

                    //}
                    return item;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Sucursal> UpdateAsync(Sucursal element, object IdUsuario)
        {
            try
            {
                Sucursal sucursal = new Sucursal();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", 0);
                    dynamicParameters.Add("@IdSucursal", element.IdSucursal);
                    dynamicParameters.Add("@IdTipoSucursal", element.IdTipoSucursal);
                    dynamicParameters.Add("@NombreSucursal", element.Nombre);
                    dynamicParameters.Add("@Direccion", element.Direccion);
                    dynamicParameters.Add("@Telefono", element.Telefono);
                    dynamicParameters.Add("@IdMunicipio", element.IdMunicipio);
                    dynamicParameters.Add("@IdEstado", element.IdEstado);
                    dynamicParameters.Add("@IdPais", element.IdPais);
                    dynamicParameters.Add("@CodigoPostal", element.CodigoPostal);
                    dynamicParameters.Add("@RFC", element.Rfc);
                    dynamicParameters.Add("@NombreRepresentante", element.NombreRepresentante);
                    dynamicParameters.Add("@RegimenFiscal", element.RegimenFiscal);
                    dynamicParameters.Add("@TablaHorario", ObtenerTabla(element.ListaHorario), DbType.Object);
                    dynamicParameters.Add("@IdUsuarioL", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_AC_Sucursales]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    sucursal.Result = result;
                }
                return sucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerTabla(List<HorarioSucursal> Lista)
        {
            DataTable TablaDatos = new DataTable();
            TablaDatos.Columns.Add("Dia", typeof(int));
            TablaDatos.Columns.Add("HoraEntrada", typeof(TimeSpan));
            TablaDatos.Columns.Add("HoraSalida", typeof(TimeSpan));
            foreach (var item in Lista)
            {
                TablaDatos.Rows.Add(new object[] { item.Dia, item.HoraEntrada.TimeOfDay, item.HoraSalida.TimeOfDay });      
            }
            return TablaDatos;
        }
        #endregion
        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }
        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }       
    }
}
