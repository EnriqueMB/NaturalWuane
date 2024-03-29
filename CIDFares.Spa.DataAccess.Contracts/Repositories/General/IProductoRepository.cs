﻿using CIDFares.Spa.DataAccess.Contracts.Entities;
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
        Task<int> AddFotoProducto(Producto entity, object IdUsuario);

        /// <summary>
        /// Este metodo agrega un nuevo registro de Personal
        /// </summary>
        /// <param name="entity">De tipo PersonalModel encapsula todos los parametros del registro nuevo</param>
        /// <returns>Retorna un string que representa la clave del Personal registrado</returns>
        Task<string> AddWitClave(Producto entity, object IdUsuario);

        Task<string> Update(Producto element, object IdUsuario);

        Task<Producto> GetProductoXid(int IdProducto);
        Task<int> NameExistAsync2(string name);

        Task<IEnumerable<Producto>> GetBusquedaAsync(string Busqueda);

        Task<int> ClaveExistAsync(string name);
    }
}
