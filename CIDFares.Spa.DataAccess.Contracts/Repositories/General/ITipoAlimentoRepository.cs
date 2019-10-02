using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ITipoAlimentoRepository: IBaseRepository<TipoAlimento>
    {
        Task<IEnumerable<TipoAlimento>> GetComboTipoAlimento();
    }
}
