using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        /// <summary>
        /// Recupera todos los registros de Personal y los devuelve en una lista de tipo PersonalModel
        /// </summary>
        /// <returns>Retorna una lista de tipo PersonalModel</returns>
        Task<IEnumerable<Producto>> CargarDatos();

        /// <summary>
        /// Agrega el registro correspondiente a la foto del Personal registrado
        /// </summary>
        /// <param name="entity">De tipo PersonalModel encapsula todos los parametros que han de guardarse</param>
        /// <returns>Retorna un entero que representa el estado de la tarea</returns>
        Task<int> AddFotoPersonal(Producto entity);
    }
}
