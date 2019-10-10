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
        public async Task<CapturaCita> AddAsync(CapturaCita element, object IdUsuario)
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
                    dynamicParameters.Add("@idAgendaCita", id);
                    dynamicParameters.Add("@idEstadoCita", 8);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cita].[SPCID_Delete_Cita]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
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

        public Task<IEnumerable<CapturaCita>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CapturaCita> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<BindingList<CapturaCita>> GetCitaXPeriodo(DateTime fechaInicio, DateTime fechaFin, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@fechaInicio", fechaInicio);
                    dynamicParameters.Add("@fechaFin", fechaFin);
                    dynamicParameters.Add("@estadoCita", 5);
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitasXPeriodo]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CapturaCita>(dr.ToList());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CapturaCita>> GetCitaDetalle(DateTime? fecha, object IdSucursal)
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
                    dynamicParameters.Add("@estadoCita", 5);
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    var lista = await conexion.QueryAsync<CapturaCita, Cliente, Servicio, OrdenServicio, Paquetes, OrdenPaquete, CapturaCita> ("[Cita].[SPCID_Get_CitaDetalle]",
                    (cita, cliente, serv, os, p, op) =>
                    {
                        cita.OrdenServicio = os;
                        cita.OrdenServicio.OrdenPaquete = op;
                        cita.OrdenServicio.OrdenPaquete.Paquete = p;
                        cita.OrdenServicio.Servicio = serv;
                        cita.OrdenServicio.Cliente = cliente;
                        return cita;
                    },
                    splitOn: "IdAgendaCita, IdCliente, IdServicio, IdOrdenServicio, IdPaquete, IdOrdenPaquete", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return lista;                                     
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task<BindingList<CapturaCita>> ValidarFechaServicio(DateTime? fecha)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();                    
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@fechaCita", fecha);                                        
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitaDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CapturaCita>(dr.ToList());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<BindingList<CapturaCita>> GetCitaDetalleServicio(Guid idCita)
        //{
        //    try
        //    {
        //        using (IDbConnection conexion = new SqlConnection(WebConnectionString))
        //        {
        //            conexion.Open();
        //            List<CapturaCita> Lista = new List<CapturaCita>();                    
        //            var dynamicParameters = new DynamicParameters();
        //            dynamicParameters.Add("@idCita", idCita);                    
        //            var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitaDetalleServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
        //            return new BindingList<CapturaCita>(dr.ToList());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}       

        public async Task<CapturaCita> AddCita(CapturaCita element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();                                                             
                    dynamicParameters.Add("@opcion", 1);
                    dynamicParameters.Add("@idAgendaCita", element.IdAgendaCita);
                    dynamicParameters.Add("@idOrdenServicio", element.OrdenServicio.IdOrdenServicio);
                    dynamicParameters.Add("@idOrdenPaquete", element.OrdenServicio.OrdenPaquete.IdOrdenPaquete);
                    dynamicParameters.Add("@idServicio", element.OrdenServicio.Servicio.IdServicio);
                    dynamicParameters.Add("@aplicado", false);
                    dynamicParameters.Add("@pagado", false);
                    dynamicParameters.Add("@fechaInicio", element.FechaInicio);
                    dynamicParameters.Add("@fechaFinal", element.FechaFinal);                                       
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    dynamicParameters.Add("@idCliente", element.OrdenServicio.Cliente.IdCliente);
                    dynamicParameters.Add("@idEstadoCita", 5);                
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cita].[SPCID_AC_Cita]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
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

        public async Task<CapturaCita> UpdateCita(CapturaCita element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@opcion", 2);
                    dynamicParameters.Add("@idAgendaCita", element.IdAgendaCita);
                    dynamicParameters.Add("@idOrdenServicio", element.OrdenServicio.IdOrdenServicio);
                    dynamicParameters.Add("@idPaquete", element.OrdenServicio.OrdenPaquete.Paquete.IdPaquete);
                    dynamicParameters.Add("@idServicio", element.OrdenServicio.Servicio.IdServicio);
                    dynamicParameters.Add("@aplicado", false);
                    dynamicParameters.Add("@pagado", false);
                    dynamicParameters.Add("@fechaInicio", element.FechaInicio);
                    dynamicParameters.Add("@fechaFinal", element.FechaFinal);                    
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    dynamicParameters.Add("@idCliente", element.OrdenServicio.Cliente.IdCliente);
                    dynamicParameters.Add("@idEstadoCita", 5);
                    dynamicParameters.Add("@user", IdUsuario);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cita].[SPCID_AC_Cita]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    element.Resultado = result;
                    return element;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> BusyService(CapturaCita element, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idAgendaCita", element.IdAgendaCita);
                    dynamicParameters.Add("@idServicio", element.OrdenServicio.Servicio.IdServicio);
                    dynamicParameters.Add("@fechaInicio", element.FechaInicio);                                                            
                    dynamicParameters.Add("@estadoCita", 5);
                    dynamicParameters.Add("@idSucursal", IdSucursal);                                        
                    var result = await conexion.ExecuteScalarAsync<int>("[Cita].[SPCID_Validar_CitaXHorarioServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<CapturaCita> UpdateAsync(CapturaCita element, object IdUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CapturaCita>> LlenarComboHorarioSucursal(object Dias, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {                 
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Dia", Dias);
                    dynamicParameters.Add("@IdSucursal", IdSucursal);
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_ComboHorasSucursal]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return dr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> BusyService2(Guid idAgendaCita, int idServicio, DateTime fechaInicio, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idAgendaCita", idAgendaCita);
                    dynamicParameters.Add("@idServicio", idServicio);
                    dynamicParameters.Add("@fechaInicio", fechaInicio);
                    dynamicParameters.Add("@estadoCita", 5);
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    var result = await conexion.ExecuteScalarAsync<int>("[Cita].[SPCID_Validar_CitaXHorarioServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<OrdenPaquete> AgendarPaquete(int IdPaquete, Guid idCliente, Guid idUsuario, int idSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idPaquete", IdPaquete);
                    dynamicParameters.Add("@idCliente", idCliente);
                    dynamicParameters.Add("@idSucursal", idSucursal);
                    dynamicParameters.Add("@user", idUsuario);
                    var result = await conexion.QuerySingleAsync<OrdenPaquete>("[Cita].[SPCID_A_ServicioPaquete]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       

        public async Task<IEnumerable<OrdenServicio>> GetCitasSinAgendar(string nombreCompleto, object IdSucursal)
        {
            try{
                //CapturaCita Item;
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@nombreCompleto", nombreCompleto);
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    //var lista = await conexion.QueryAsync<CapturaCita, Cliente, Servicio, OrdenServicio, Paquetes, OrdenPaquete, CapturaCita>("[Cita].[SPCID_Get_CitaSinAgendar]",
                    var lista = await conexion.QueryAsync<OrdenServicio, Cliente, Paquetes, OrdenPaquete, OrdenServicio>("[Cita].[SPCID_Get_CitaSinAgendar]",
                    (os, cliente, p, op) =>
                    {
                        os.Cliente = cliente;
                        os.OrdenPaquete = op;
                        os.OrdenPaquete.Paquete = p;                        
                        return os;
                    },
                    splitOn: "IdOrdenServicio, IdCliente, IdPaquete, IdOrdenPaquete", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return lista;                    
                }
            }         
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<OrdenServicio>> GetCitasSinPagar(Guid idCliente, int idSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@IdCliente", idCliente);
                    dynamicParameters.Add("@IdSucursal", idSucursal);
                    //var result = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitaSinPagar]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    var lista = await conexion.QueryAsync<OrdenServicio, Cliente, Paquetes, OrdenPaquete, OrdenServicio>("[Cita].[SPCID_Get_CitaSinPagar]",
                    (os, cliente, p, op) =>
                    {
                        os.Cliente = cliente;
                        os.OrdenPaquete = op;
                        os.OrdenPaquete.Paquete = p;
                        return os;
                    },
                    splitOn: "IdOrdenServicio, IdCliente, IdPaquete, IdOrdenPaquete", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
