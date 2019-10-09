using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IPaqueteRepository : IBaseRepository<Paquetes>
    {
        Task<IEnumerable<Paquetes>> GetBusqPaqueteAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo);
        Task<IEnumerable<AbonoPaquete>> GetAllAbonoPaqueteAsync(Guid idCliente, int idSucursal);
        Task<IEnumerable<Paquetes>> GetAllAgendaAsync(Guid idCliente, int idSucursal);
        Task<int> AddAbonoAsync(AbonoPaquete element, object IdUsuario);
        Task<IEnumerable<AbonoPaqueteDetalle>> GetAllDetalleAsync(Guid IdVentaPaquete);
        Task<IEnumerable<Servicio>> ComboServicios(Guid idOrdenPaquete);
    }
}
