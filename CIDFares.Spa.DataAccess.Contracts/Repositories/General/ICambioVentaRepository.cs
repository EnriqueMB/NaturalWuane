using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ICambioVentaRepository: IBaseRepository<CambioVenta>
    {
        Task<int> ObtenerCambio(int IdSucursal, Guid IdEmpleado, int IdTurnoEmpleado);
        Task<CambioVenta>UpdateCambioWithIdSucursalAsync(CambioVenta element, object IdSucursal, object IdEmpleado, object IdTurnoEmpleado);
    }
}
