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
    public class ProductoValidator :AbstractValidator<ProductoViewModel>
    {
        public ProductoValidator(IProductoRepository productoservice)
        {
            RuleFor(producto => producto.Nombre)
                    .NotEmpty()
                .WithMessage("INGRESE EL NOMBRE DEL PRODUCTO.")
                .MaximumLength(200).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 200 CARACTERES.")
                .MustAsync(async (producto, x, context) =>
                {

                    int result = await productoservice.NameExistAsync(producto.Nombre);
                    if (result > 0)
                    {
                        if (result == producto.IdProducto)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                })
                .WithMessage("EL NOMBRE DEL PRODUCTO YA EXISTE");

            RuleFor(producto => producto.IdCategoria)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UNA CATEGORIA.");

            RuleFor(producto => producto.Clave)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE CLAVE VACIO");

            RuleFor(producto => producto.PrecioPublico)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE PRECIO PUBLICO VACIO");



            RuleFor(producto => producto.Descripcion)
              .MaximumLength(300).WithMessage("LA DESCRIPCIÓN NO PUEDE SER MAYOR A 300 CARACTERES.");

            RuleFor(producto => producto.PrecioPublico)
              .NotEmpty()
              .WithMessage("NO PUEDE DEJAR VACIO EL CAMPO DE PRECIO.");
              


        }
    }
}
