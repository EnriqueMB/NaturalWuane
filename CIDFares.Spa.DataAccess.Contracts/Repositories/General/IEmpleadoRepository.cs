using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IEmpleadoRepository : IBaseRepository<Empleado>
    {
        Task<IEnumerable<Empleado>> GetComboEmpleado();
        
        
        Task<Empleado> GetEmpleadoXid(Guid IdEmpleado);

        Task<string> ObtenerFoto(Guid IdEmpleado);

        Task<IEnumerable<Empleado>> GetBusquedaAsync(string Busqueda);

        Task<int> ClaveExistAsync(string name);
    }
}
