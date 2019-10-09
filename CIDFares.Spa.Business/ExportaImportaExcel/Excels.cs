using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Library.Code.Utilities.IBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;

namespace CIDFares.Spa.Business.ExportaImportaExcel
{
    public class Excels
    {
        #region propiedades publicas
        public string Ruta { get; set; }
        public string Nombre { get; set; }       
        public List<Producto> ListaProductos { get; set; }
        public InventarioFisicoViewModel Model { get; set; }
        #endregion

        #region propiedades Privadas
        private IExcel Ex { get; set; }
        private int idSucursal;
        private IEnumerable<Producto> Lista { get; set; }
        #endregion

        public Excels(IEnumerable<Producto> productos, string ruta, string nombre, IExcel ex)
        {
            Ex = ex;
            Lista = productos;
            Ruta = ruta;
            Nombre = nombre;
            GenerarArchivo();
        }

        public Excels(int idSucursal, IExcel ex, string nombre)
        {
            Model = ServiceLocator.Instance.Resolve<InventarioFisicoViewModel>();
            this.idSucursal = idSucursal;
            Ex = ex;
            Nombre = nombre;
            ListaProductos = new List<Producto>();
            Importar();
        }

        //-----------------------EXPORTAR ARCHIVIO----------------------------------------
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
                    Ex.EscribirCelda(Fila,5, "0");
                    Ex.EscribirCelda(Fila,6, item.Descripcion);
                    Fila++;                   
                }
                var NumeroColumnas = Convert.ToString(Lista.Count());
                Ex.EscribirCelda(2, 7, NumeroColumnas);
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
        // -------------------------------------------IMPORTAR ARCHIVO-----------------------------------
        public async void Importar()
        {
            try
            {
                int FilaInicio = 3;
                Ruta =   Ex.AbrirExcel();
                if (Ruta != null)
                {
                    Ex.AbrirArchivo(Ruta, Nombre);
                    int TotalProducto = Convert.ToInt32(Ex.LeerExcel(2, 7));
                    Producto model = new Producto();

                    for (int i = 1; i <= TotalProducto; i++)
                    {
                        model = new Producto();
                        model.IdProducto = Convert.ToInt32(Ex.LeerExcel(FilaInicio, 1));
                        model.CantidadProducto = Convert.ToInt32(Ex.LeerExcel(FilaInicio, 5));
                        FilaInicio++;
                        ListaProductos.Add(model);
                    }

                    var X = await Model.ActualizarProducto(ListaProductos, idSucursal);
                    if (X == 1)
                    {

                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Ruta != null)
                {
                    Ex.Cerrar();
                }
            }

        }
        
    }
    
}
