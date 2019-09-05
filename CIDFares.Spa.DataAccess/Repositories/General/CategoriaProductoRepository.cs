using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class CategoriaProductoRepository : Repository, ICategoriaProductoRepository
    {        

        public async Task<CategoriaProducto> AddAsync(CategoriaProducto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 1);
                    dynamicParameters.Add("@idCategoria", element.IdCategoriaProducto);
                    dynamicParameters.Add("@nombre", element.Nombre);
                    dynamicParameters.Add("@desc", element.Descripcion);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_CategoriaProducto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
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
                    dynamicParameters.Add("@idCategoria", id);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_CategoriaProducto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<CategoriaProducto>> GetAllAsync()
        {
            //throw new NotImplementedException();
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    //var dynamicParameters = new DynamicParameters();
                    List<CategoriaProducto> Lista = new List<CategoriaProducto>();
                    CategoriaProducto Item;
                    var dr = await conexion.ExecuteReaderAsync("[Catalogo].[SPCID_Get_CategoriaProducto]", /*param: dynamicParameters,*/ commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new CategoriaProducto();
                        Item.IdCategoriaProducto = dr.GetInt32(dr.GetOrdinal("IdCategoriaProducto"));
                        Item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        Item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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
        }

        public Task<CategoriaProducto> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        
        public async Task<BindingList<CategoriaProducto>> LlenarComboCategoria()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    var dr = await conexion.QueryAsync<CategoriaProducto>("[Catalogo].[SPCID_Get_ComboCategoria]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CategoriaProducto>(dr.ToList());
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
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 4);
                    dynamicParameters.Add("@Nombre", name.Trim());
                    var dr = await conexion.ExecuteScalarAsync<int>("[General].[SPCID_ValidarNombre]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task<CategoriaProducto> UpdateAsync(CategoriaProducto element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Opcion", 2);
                    dynamicParameters.Add("@idCategoria", element.IdCategoriaProducto);
                    dynamicParameters.Add("@nombre", element.Nombre);
                    dynamicParameters.Add("@desc", element.Descripcion);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_AC_CategoriaProducto]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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
