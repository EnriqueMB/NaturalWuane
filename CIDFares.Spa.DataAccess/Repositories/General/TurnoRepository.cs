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
    public class TurnoRepository : Repository, ITurnoRepository
    {

        #region metodos no implementados

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> NameExistAsync(string name)
        {
            throw new NotImplementedException();
        }
        #endregion

        public async Task<IEnumerable<Turno>> GetComboTurno()
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();

                    List<Turno> Lista = new List<Turno>();
                    Turno Item;
                    var dr = await conexion.ExecuteReaderAsync("[Usuario].[SPCID_Combo_Turno]", commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new Turno();
                        Item.IdTurno = dr.GetInt32(dr.GetOrdinal("IdTurno"));
                        Item.NombreTurno = dr.GetString(dr.GetOrdinal("Turno"));
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

        public async Task<Turno> AddAsync(Turno element, object IdUsuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@NombreTurno", element.NombreTurno);
                    Parametros.Add("@turnoDias", element.TablaValores, DbType.Object);
                    Parametros.Add("@IdUsuario", element.IdUsuario);
                    var result = await conexion.QueryFirstOrDefaultAsync<Turno> ("[Catalogo].[SPCID_A_Turnos]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(object id, object IdUsuario)
        {
            //throw new NotImplementedException();
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdTurno", id);
                    Parametros.Add("@IdUsuario", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Catalogo].[SPCID_Delete_Turno]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Turno>> GetAllAsync()
        {
            //throw new NotImplementedException();
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var lista = await conexion.QueryAsync<Turno>("[Catalogo].[SPCID_Get_Turnos]", commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Turno> GetAsync(object id)
        {
            //throw new NotImplementedException();
            try
            {
                Turno turno = new Turno();
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("@IdTurno", id);
                    
                    using (var lista2 = conexion.QueryMultipleAsync("[Catalogo].[SPCID_Get_TurnosXId]", param: Parametros, commandType: CommandType.StoredProcedure).Result)
                    {
                        turno = lista2.ReadFirstOrDefault<Turno>();
                        turno.DatosValor = lista2.Read<TurnoDias>();
                    }
                    return turno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Turno> UpdateAsync(Turno element, object IdUsuario)
        {
            //throw new NotImplementedException();
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var Parametros = new DynamicParameters();
                    Parametros.Add("IdTurno", element.IdTurno);
                    Parametros.Add("@NombreTurno", element.NombreTurno);
                    Parametros.Add("@TurnoDias", element.TablaValores, DbType.Object);
                    Parametros.Add("@IdUsuario", element.IdUsuario);
                    var result = await conexion.QueryFirstOrDefaultAsync<Turno>("[Catalogo].[SPCID_C_Turnos]", param: Parametros, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
