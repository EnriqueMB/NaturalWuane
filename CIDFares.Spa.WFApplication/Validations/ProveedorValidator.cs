using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Validations
{
    public class ProveedorValidator: AbstractValidator<ProveedorViewModel>
    {
        public ProveedorValidator(IProveedorRepository proveedorService)
        {

            RuleFor(x => x.Clave)
                .NotEmpty()
                .WithMessage("INGRESE CLAVE.")
                .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 7 CARACTERES.")
                .MustAsync(async (x, y, context) =>
                {

                    Guid result = await proveedorService.EsClave(x.Clave);
                    if (result != Guid.Empty)
                    {
                        if (result == x.IdProveedor)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                })
                    .WithMessage("LA CLAVE YA EXISTE");

            RuleFor(x => x.NombreComercial)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE NOMBRE COMERCIAL VACIO")
            .MustAsync(async (x, y, context) =>
             {

                 Guid result = await proveedorService.NombreComercialUnico(x.NombreComercial);
                 if (result != Guid.Empty)
                 {
                     if (result == x.IdProveedor)
                         return true;
                     else
                         return false;
                 }
                 else
                     return true;
             })
                    .WithMessage("EL NOMBRE COMERCIAL YA EXISTE");

            RuleFor(x => x.RazonSocial)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE RAZON SOCIAL VACIO");

            RuleFor(x => x.Representante)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE REPRESENTANTE VACIO");

            RuleFor(x => x.RFC)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE RFC VACIO");

            RuleFor(x => x.Direccion)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE DIRECCION VACIO");

            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE TELEFONO VACIO");

            RuleFor(pass => pass.CorreoElectronico)
               .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO CORREO ELECTRONICO VACIO")
               .Matches("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*").WithMessage("NO TIENE FORMATO DE CORREO ELECTRONICO");


            RuleFor(X => X.CodigoPostal)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE CLAVE VACIO");


            RuleFor(x => x.IdPais)
                 .NotEqual(0)
                 .WithMessage("DEBE SELECCIONAR UN PAIS.");

            RuleFor(x => x.IdEstado)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN ESTADO.");

            RuleFor(x => x.IdMunicipio)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UN MUNICIPIO.");






        }
    }
}
