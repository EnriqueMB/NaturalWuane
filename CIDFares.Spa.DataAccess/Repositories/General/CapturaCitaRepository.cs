﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
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
                    dynamicParameters.Add("@idCitaUpd", id);
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
                    //var dr = await conexion.ExecuteReaderAsync("[Cita].[SPCID_Get_CitaDetalle]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    //while (dr.Read())
                    //{
                    //    Item = new CapturaCita();
                    //    Item.OrdenServicio.Cliente.NombreCompleto = dr.GetString(dr.GetOrdinal("NombreCompleto"));
                    //    Item.OrdenServicio.Servicio.Nombre = dr.GetString(dr.GetOrdinal("Servicio"));
                    //    Item.FechaFinal = dr.GetDateTime(dr.GetOrdinal("Fin"));
                    //    Item.FechaInicio = dr.GetDateTime(dr.GetOrdinal("Inicio"));
                    //    Item.OrdenServicio.OrdenPaquete.Paquete.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    //    //Item.IdAgendaCita = dr.GetGuid(dr.GetOrdinal("IdAgendaCita"));
                    //    Item.OrdenServicio.IdOrdenServicio = dr.GetGuid(dr.GetOrdinal("IdOrdenServicio"));
                    //    Item.OrdenServicio.Cliente.IdCliente = dr.GetGuid(dr.GetOrdinal("IdCliente"));
                    //    Item.OrdenServicio.Servicio.IdServicio = dr.GetInt32(dr.GetOrdinal("IdServicio"));
                    //    Lista.Add(Item);
                    //}
                    //dr.Close();
                    //return Lista;
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

        public async Task<BindingList<CapturaCita>> GetCitaDetalleServicio(Guid idCita)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    List<CapturaCita> Lista = new List<CapturaCita>();                    
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@idCita", idCita);                    
                    var dr = await conexion.QueryAsync<CapturaCita>("[Cita].[SPCID_Get_CitaDetalleServicio]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    return new BindingList<CapturaCita>(dr.ToList());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CapturaCita>> LlenarComboHoras(DateTime f, DateTime primeraHora)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    List<CapturaCita> Lista = new List<CapturaCita>();
                    CapturaCita Item;
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@dia", f);
                    dynamicParameters.Add("@horasAtencion", 10);
                    dynamicParameters.Add("@PrimeraHora", primeraHora);
                    
                    var dr = await conexion.ExecuteReaderAsync("[Cita].[SPCID_Get_ComboHoras]", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                    while (dr.Read())
                    {
                        Item = new CapturaCita();                       
                        string cadena = dr.GetString(dr.GetOrdinal("IdHora"));
                        Item.IdHora = TimeSpan.Parse(cadena);
                        Item.Hora = dr.GetString(dr.GetOrdinal("Hora"));                     
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

        public async Task<CapturaCita> AddCita(CapturaCita element, object IdUsuario, object IdSucursal)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(WebConnectionString))
                {
                    conexion.Open();
                    var dynamicParameters = new DynamicParameters();                                                             
                    dynamicParameters.Add("@opcion", 1);
                    dynamicParameters.Add("@idPaquete", element.OrdenServicio.OrdenPaquete.Paquete.IdPaquete);
                    dynamicParameters.Add("@idServicio", element.OrdenServicio.Servicio.IdServicio);
                    dynamicParameters.Add("@aplicado", false);
                    dynamicParameters.Add("@pagado", false);
                    dynamicParameters.Add("@fechaInicio", element.FechaInicio);
                    dynamicParameters.Add("@fechaFinal", element.FechaFinal);
                    dynamicParameters.Add("@idCitaUpd", Guid.Empty);
                    //dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);                    
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    dynamicParameters.Add("@idCliente", element.OrdenServicio.Cliente.IdCliente);// element.IdCliente);
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
                    //dynamicParameters.Add("@TablaServicio", element.TablaServicio, DbType.Object);
                    //dynamicParameters.Add("@idCitaUpd", element.IdCita);
                    dynamicParameters.Add("@idSucursal", IdSucursal);
                    dynamicParameters.Add("@idCliente", 1);//5 element.IdCliente);
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
    }
}
