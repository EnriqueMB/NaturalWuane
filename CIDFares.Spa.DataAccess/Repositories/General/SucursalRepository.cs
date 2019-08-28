using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Repositories.Base;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class SucursalRepository : Repository, ISucursalRepository
    {
        public async Task<Sucursal> AddAsync(Sucursal element)
        {
            try
            {
                Sucursal sucursal = new Sucursal();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@NuevoRegistro", 1);
                    dynamicParameters.Add("@IdSucursal", 0);
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
                    //dynamicParameters.Add("@IdUsuarioL", CurrentSession.IdCuentaUsuario);
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

        public Task<Sucursal> AddAsync(Sucursal element, object IdUsuario)
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

        public Task<IEnumerable<Sucursal>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Sucursal> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Sucursal> UpdateAsync(Sucursal element)
        {
            throw new NotImplementedException();
        }

        public Task<Sucursal> UpdateAsync(Sucursal element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
