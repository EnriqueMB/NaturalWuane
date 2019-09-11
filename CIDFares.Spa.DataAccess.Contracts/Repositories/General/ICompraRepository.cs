using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ICompraRepository: IBaseRepository<Compra>
    {
        Task<string> GetFolioCompra();
        Task<Compra> AddWithIdSucursalAsync(Compra element, object IdUsuario, object IdSucursal);
    }
}
