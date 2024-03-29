﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Guid>EsCuentaUnica(string Cuenta);
        Task<Guid> EsCuentaEmpleadoUnico(Guid Empleado);
        Task<Usuario> AddAsync(Usuario element);
    }
}
