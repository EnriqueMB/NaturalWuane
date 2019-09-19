using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IRegistroEntradaSalidaRepository: IBaseRepository<RegistroEntradaSalida>
    {
        Task<RegistroEntradaSalida> VerificarCodigoBarra(RegistroEntradaSalida element);
        Task<int> VerificarPassword(object IdEmpleado, object Password);
        Task<int> Registrar(object IdEmpleado, object Tipo);
        Task<int> ValidarTurno(object CodigoBarra, object Tipo);
        Task<Guid> CodigoExista(string name);

    }
}
