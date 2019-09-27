using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IAlimentoRepository: IBaseRepository<Alimento>
    {
        Task<IEnumerable<Alimento>> GetBusquedaAlimentoAsync(string BusquedaAlimento);
        Task<IEnumerable<Alimento>> GetAllAsync(int Page, int Opcion);
    }
}
