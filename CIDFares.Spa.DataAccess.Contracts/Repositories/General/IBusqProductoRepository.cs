using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IBusqProductoRepository : IBaseRepository<BusqueProducto>
    {
        Task<IEnumerable<BusqueProducto>> GetBusquedaProductoAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo);

        Task<IEnumerable<BusqueProducto>> GetBusquedaProductoCompraAsync(bool BitNombre, string BusqNombre, bool BitClaveCodigo, string BusqClaveCodigo);
    }
}
