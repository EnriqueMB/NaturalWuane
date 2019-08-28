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
    public interface ICategoriaProductoRepository : IBaseRepository<CategoriaProducto>
    {
        //Task<BindingList<CategoriaProducto>> LlenarComboCategoria();
       // Task<IEnumerable<CategoriaProducto>> LlenarComboCategoria();
        Task<BindingList<CategoriaProducto>> LlenarComboCategoria();
    }
}
