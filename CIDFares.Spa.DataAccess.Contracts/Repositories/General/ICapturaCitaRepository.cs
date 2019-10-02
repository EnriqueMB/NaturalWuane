using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ICapturaCitaRepository : IBaseRepository<CapturaCita>
    {                
        Task<BindingList<CapturaCita>> GetCitaXPeriodo(DateTime fechaInicio, DateTime fechaFin, object IdSucursal);
        Task<IEnumerable<CapturaCita>> GetCitaDetalle(DateTime? fecha, object IdSucursal);
        Task<BindingList<CapturaCita>> GetCitaDetalleServicio(Guid idCita);
        Task<CapturaCita> AddCita(CapturaCita element, object IdUsuario, object IdSucursal);
        Task<CapturaCita> UpdateCita(CapturaCita element, object IdUsuario, object IdSucursal);
        Task<BindingList<CapturaCita>> ValidarFechaServicio(DateTime? fecha);
        Task<IEnumerable<CapturaCita>> LlenarComboHoras(DateTime f, DateTime primeraHora);
        Task<int> BusyService(CapturaCita element, object IdSucursal);
        Task<IEnumerable<CapturaCita>> LlenarComboHorarioSucursal(object Dias, object IdSucursal);
    }
}
