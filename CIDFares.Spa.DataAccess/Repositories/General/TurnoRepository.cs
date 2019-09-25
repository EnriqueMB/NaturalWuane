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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
