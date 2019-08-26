using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using CIDFares.Spa.DataAccess.Contracts.Entities;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<string> ObtenerFoto(Guid IdCliente);
        Task<int> Elimnar(object id, int? IdUsuario);
        Task<IEnumerable<Cliente>> GetBusquedaAsync(string Busqueda);
    }
}
