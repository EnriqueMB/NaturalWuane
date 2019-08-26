﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Producto
    {
        #region Constructor
        public Producto()
        {
            //la clvae que quiero tomar de categoria producto, juan
        }
        #endregion

        #region propiedades
        public int IdProducto { get; set; }
        public string Categoria { get; set; }
        public int? IdCategoria { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Stock { get; set; }
        public string StockStr { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PrecioMenudeo { get; set; }
        public int CodigoBarras { get; set; }
        public string UnidadMedida { get; set; }
        public int ClaveSat { get; set; }
        public bool AplicaIva { get; set; }
        public string AplicaIvaStr { get; set; }
        public int Usuario { get; set; }
        //foto
        public string Base64String { get; set; }
        public string UrlFoto { get; set; }
        public bool UpdateFoto { get; set; }
        #endregion

    }
}