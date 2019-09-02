using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IServicioRepository : IBaseRepository<Servicio>
    {
        Task<IEnumerable<Servicio>> GetBusqServicioAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo);

        //Task<int> AddFotoProducto(Producto entity, object IdUsuario);
    }
}
