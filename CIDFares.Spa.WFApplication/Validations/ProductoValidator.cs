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
                .MaximumLength(80).WithMessage("EL NOMBRE NO PUEDE SER MAYOR A 80 CARACTERES.")
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


            RuleFor(producto => producto.CodigoBarras)
                    .NotEmpty()
                .WithMessage("INGRESE EL CODIGO DE BARRA.")
                .MustAsync(async (producto, x, context) =>
                {

                    int result = await productoservice.NameExistAsync2(producto.CodigoBarras);
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
                .WithMessage("EL CODIGO DE BARRAS  YA EXISTE");

            RuleFor(producto => producto.IdCategoriaProducto)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UNA CATEGORIA.");


            RuleFor(producto => producto.IdUnidadMedida)
                .NotEqual(0)
                .WithMessage("DEBE SELECCIONAR UNA CATEGORIA.");

            //RuleFor(producto => producto.IdAplicaIva)
            //   .NotEqual(0) .When(prodc)
            //   .WithMessage("DEBE SELECCIONAR UNA CATEGORIA.");


            RuleFor(producto => producto.Clave)
                .NotEmpty().WithMessage("NO DEBE DEJAR EL CAMPO DE CLAVE VACIO");



            RuleFor(producto => producto.PrecioPublico)
                .NotEqual(0).WithMessage("NO DEBE DEJAR EL CAMPO DE PRECIO PUBLICO VACIO");

            RuleFor(producto => producto.PrecioMayoreo)
                .NotEqual(0).WithMessage("NO DEBE DEJAR EL CAMPO DE PRECIO  MAYOREO VACIO");

            RuleFor(producto => producto.PrecioMenudeo)
                .NotEqual(0).WithMessage("NO DEBE DEJAR EL CAMPO DE PRECIO MENUDEO VACIO");



            RuleFor(producto => producto.Descripcion)
              .MaximumLength(300).WithMessage("LA DESCRIPCIÓN NO PUEDE SER MAYOR A 300 CARACTERES.");




            RuleFor(producto => producto.StockMax)
              .Must((producto, x, context) =>
              {
                  if (producto.StockMax<=producto.StockMin)
                  {
                      if (producto.StockMin==0)
                      {
                          return true;
                      }
                      return false;
                  }
                  else
                      return true;
              }).WithMessage("EL STOCK MAXIMO DEBE SER MAYOR AL STOCK MINIMO.");










        }
    }
}
