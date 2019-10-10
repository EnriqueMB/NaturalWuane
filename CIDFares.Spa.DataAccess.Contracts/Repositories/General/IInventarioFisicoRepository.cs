﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IInventarioFisicoRepository : IBaseRepository<Producto>
    {
        Task<IEnumerable<Producto>> GetProductos(object IdSucursal);
        Task<int> ActualizarProducto(List<Producto> List, object IdSucursal);
        Task<IEnumerable<Producto>> GetCantidadProductos(object IdSucursal);
    }
}
