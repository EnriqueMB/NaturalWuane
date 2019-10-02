using CIDFares.Spa.DataAccess.Contracts.DTOs.General;
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
    public interface IPromocionRepository : IBaseRepository<PromocionGeneral>
    {
        Task<BindingList<TipoPromocion>> LlenarComboTipoPromocion();
        Task<PromocionDescuento> AddPromocionDescuento(PromocionDescuento model, Guid idUsuario, int Opcion);
        Task<PromocionDescuento> UpdatePromocionDescuento(PromocionDescuento model, Guid idUsuario);
        Task<PromocionNxN> AddPromocionNxN(PromocionNxN model, Guid idUsuario, int Opcion);
        Task<PromocionMxN> AddPromocionMxN(PromocionMxN model, Guid idUsuario, int Opcion);
        Task<IEnumerable<PromocionGeneral>> GetAllPromocionAsync();
        Task<PromocionDescuento> GetDetalleAsync(Guid IdPromocion, int  idTipoPromocion);
        Task<PromocionNxN> GetDetalleNxNAsync(Guid IdPromocion, int idTipoPromocion);
        Task<PromocionMxN> GetDetalleMxNAsync(Guid IdPromocion, int idTipoPromocion);
        Task<PromocionDias> GetDiasAsync(Guid idPromocion);
    }
}
