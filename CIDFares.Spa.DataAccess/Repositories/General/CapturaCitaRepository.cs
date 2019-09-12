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
    public class CapturaCitaRepository : Repository, ICapturaCitaRepository
    {
        public Task<CapturaCita> AddAsync(CapturaCita element, object IdUsuario)
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

        public Task<IEnumerable<CapturaCita>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CapturaCita> GetAsync(object id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<BindingList<CapturaCita>> GetCitaXPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    //CapturaCita Item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@fechaInicio", fechaInicio);
                    dynamicParameters.Add("@fechaFin", fechaFin);
                    //dynamicParameters.Add("@estadoCita", 5);
                    //var mapeo = await conexion.QueryAsync<CapturaCita>
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitasXPeriodo]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CapturaCita>(dr.ToList());                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<BindingList<CapturaCita>> GetCitaDetalle(DateTime? fecha)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    //CapturaCita Item;
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@fechaCita", fecha);                    
                    //dynamicParameters.Add("@estadoCita", 5);
                    //var mapeo = await conexion.QueryAsync<CapturaCita>
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitaDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CapturaCita>(dr.ToList());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CapturaCita> AddCita(CapturaCita element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    //dynamicParameters.Add("@TablaFormaPago", element.TablaFormaPago, DbType.Object);
                    //dynamicParameters.Add("@TablaProducto", element.TablaProducto, DbType.Object);
                    //dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    //dynamicParameters.Add("@Folio", element.Folio);
                    //dynamicParameters.Add("@Subtotal", element.SubTotal);
                    //dynamicParameters.Add("@Iva", element.PorcentajeIva);
                    //dynamicParameters.Add("@Total", element.Total);
                    //dynamicParameters.Add("@Efectivo", element.Efectivo);
                    //dynamicParameters.Add("@Pagado", 1);
                    //dynamicParameters.Add("@IdCliente", element.ClienteVenta.IdCliente);
                    //dynamicParameters.Add("@IdUsuario", IdUsuario);
                    //dynamicParameters.Add("@IdSucursal", IdSucursal);
                    var result = await conexion.ExecuteScalarAsync<int>("[Venta].[spCID_A_Venta]", param: dynamicParameters, commandType: CommandType.StoredProcedure);                    
                    //element.Resultado = result;
                    return element;
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

        public Task<CapturaCita> UpdateAsync(CapturaCita element, object IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
