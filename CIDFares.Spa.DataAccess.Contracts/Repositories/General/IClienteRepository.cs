using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.DTOs;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<string> ObtenerFoto(Guid IdCliente);
        Task<IEnumerable<Cliente>> GetBusquedaAsync(string Busqueda);
        Task<int> SetMonederoCliente(object IdCliente, object IdUsuario, string ClaveTarjeta, int Opcion);
        Task<string> AddWithDTO(DTOCliente element, string extencion);
        Task<List<Cliente>> GetAllAsync(int Pagina, int Opcion);
    }
}
