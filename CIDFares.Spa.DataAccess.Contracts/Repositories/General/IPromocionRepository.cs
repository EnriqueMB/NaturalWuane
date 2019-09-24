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
    public interface IPromocionRepository : IBaseRepository<Promocion>
    {
        Task<BindingList<TipoPromocion>> LlenarComboTipoPromocion();
        Task<PromocionDescuento> AddPromocionDescuento(PromocionDescuento model, Guid idUsuario);
        Task<PromocionNxN> AddPromocionNxN(PromocionNxN model, Guid idUsuario);
        Task<PromocionMxN> AddPromocionMxN(PromocionMxN model, Guid idUsuario);
    }
}
