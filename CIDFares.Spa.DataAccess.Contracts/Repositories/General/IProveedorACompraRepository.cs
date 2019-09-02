using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IProveedorACompraRepository: IBaseRepository<ProveedorACompra>
    {
        Task<IEnumerable<ProveedorACompra>> GetBusquedaAsync(string Busqueda);

        //Task<IEnumerable<ProveedorACompra>> GetNombre(string id);
    }
}
