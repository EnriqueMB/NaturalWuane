﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IopcionesRepository : IBaseRepository<OpcionCuestionario>
    {
        #region Metodos
        Task<IEnumerable<OpcionMedicion>> CargarGridMediciones();
        Task<IEnumerable<Consulta>> LlenarComboTipoConsulta();
        #endregion
    }
}
