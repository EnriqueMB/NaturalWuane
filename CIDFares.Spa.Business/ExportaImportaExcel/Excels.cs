using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Library.Code.Utilities.IBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ExportaImportaExcel
{
    public class Excels
    {
        public string Ruta { get; set; }
        public string Nombre { get; set; }
        private IEnumerable<Producto> Lista { get; set; }
        private IExcel Ex { get; set; }
        public Excels(IEnumerable<Producto> productos, string ruta, string nombre, IExcel ex)
        {
            Ex = ex;
            Lista = productos;
            Ruta = ruta;
            Nombre = nombre;
            GenerarArchivo();
        }

        public void GenerarArchivo()
        {
            try
            {
                int Fila = 3;
                Ex.AbrirArchivo(Ruta, Nombre);


                foreach (var item in Lista)
                {
                    Ex.EscribirCelda(Fila,1, item.IdProducto.ToString());
                    Ex.EscribirCelda(Fila,2, item.Clave.ToString());
                    Ex.EscribirCelda(Fila,3, item.CodigoBarras.ToString());
                    Ex.EscribirCelda(Fila,4, item.Nombre);
                    Ex.EscribirCelda(Fila,5, " ");
                    Ex.EscribirCelda(Fila,6, item.Descripcion);
                    Fila++;
                    
                }
                Ex.GuardarArchivo();
            }
            catch (Exception ex)
            {
                throw ex;   
            } 
            finally
            {
                Ex.Cerrar();
            }
        }

       
    }
    
}
