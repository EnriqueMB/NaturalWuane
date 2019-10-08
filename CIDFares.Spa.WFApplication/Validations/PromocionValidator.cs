using CIDFares.Spa.Business.ViewModels.Promociones;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class PromocionValidator : AbstractValidator<PromocionViewModel>
    {
        public PromocionValidator(IPromocionRepository promocionService)
        {

            RuleFor(promocion => promocion.Descuento)
                .GreaterThan(0).When(x => x.EsDescuento).WithMessage("Debe ser mayor a cero");

            RuleFor(promocion => promocion.Cantidad)
                .GreaterThan(0).When(x => x.EsPromocionNxN).WithMessage("Debe ser mayor a cero");

            RuleFor(promocion => promocion.CantidadGratis)
                .GreaterThan(0).When(x => x.EsPromocionNxN).WithMessage("Debe ser mayor a cero");

            RuleFor(promocion => promocion.Cantidad)
                .GreaterThan(0).When(x => x.EsPromocionMxN).WithMessage("Debe ser mayor a cero");

            RuleFor(promocion => promocion.FechaFin)
                .MustAsync(async (promocion, x, context) =>
                {
                    int value = DateTime.Compare(promocion.FechaFin, promocion.FechaInicio);
                    if (value > 0)
                    {
                        return true;
                    }
                    else if (value < 0)
                    {
                        return false;
                    }
                    else
                        return true;
                })
                .When(x => x.EsPeriodo)
                .WithMessage("LA FECHA FINAL DEBE SER MAYOR A LA FECHA DE INICIO.");

            RuleFor(promocion => promocion.Domingo)
                .MustAsync(async (p, x, context) =>
                {
                    if (!p.Lunes && !p.Martes && !p.Miercoles && !p.Jueves && !p.Viernes && !p.Sabado && !p.Domingo)
                        return false;
                    else
                        return true;
                })
                .When(x => !x.EsPeriodo && x.EsCapturaFecha)
                .WithMessage("Seleccione al menos un dia.");

        }
    }
}
