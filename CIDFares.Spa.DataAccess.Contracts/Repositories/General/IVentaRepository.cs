using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IVentaRepository : IBaseRepository<Venta>
    {
        Task<string> GetFolio();
        Task<Venta> AddWithIdSucursalAsync(Venta element, object IdUsuario, object IdSucursal);
        Task<int> CheckCantidadProducto(object IdProducto, int Cantidad);
        Task<IEnumerable<Venta>> GetVentaDiasSucursalActiva(object FechaActual, object IdSucursal, object Folio);
    }
}
