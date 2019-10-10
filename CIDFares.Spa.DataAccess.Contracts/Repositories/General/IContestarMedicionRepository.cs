﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IContestarMedicionRepository
    {

        #region Metodos
        Task<IEnumerable<ValorLista>> llenarListaValorxId(int IdListaValor);
        #endregion
    }
}
