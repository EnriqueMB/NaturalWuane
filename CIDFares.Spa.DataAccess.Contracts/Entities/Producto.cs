using System;
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
        public int Categoria { get; set; }
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Stock { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }
        public float PrecioPublico { get; set; }
        public float PrecioMayoreo { get; set; }
        public float PrecioMenudeo { get; set; }
        public int CodigoBarras { get; set; }
        public string UnidadMedida { get; set; }
        public int ClaveSat { get; set; }
        public bool AplicaIva { get; set; }
        public int Usuario { get; set; }
        //foto
        public string Base64String { get; set; }
        public string UrlFoto { get; set; }
        public bool UpdateFoto { get; set; }
        #endregion

    }
}
