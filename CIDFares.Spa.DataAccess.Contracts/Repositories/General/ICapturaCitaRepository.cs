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
        //Task<IEnumerable<CapturaCita>> GetCitaXPeriodo(DateTime fechaInicio, DateTime fechaFin);
        Task<BindingList<CapturaCita>> GetCitaXPeriodo(DateTime fechaInicio, DateTime fechaFin);
        Task<BindingList<CapturaCita>> GetCitaDetalle(DateTime? fecha);
        Task<BindingList<CapturaCita>> GetCitaDetalleServicio(Guid idCita);
        Task<CapturaCita> AddCita(CapturaCita element, object IdUsuario, object IdSucursal);
    }
}
