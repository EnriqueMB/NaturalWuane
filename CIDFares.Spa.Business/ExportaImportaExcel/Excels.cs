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
        public EntradaSalidaAlmacenViewModel Model { get; set; }
        public Guid Usuario { get; set; }

        public List<Producto> listaAlta { get; set; }
        public List<Producto> listaBaja { get; set; }
        int cantidadAux = 0;
        bool ValidarExcel = false;
        int Ret = 0;
        decimal TotalA = 0;
        int ret2 = 0;
        decimal TotalB = 0;
        decimal SubA = 0;
        decimal SubB = 0;
        decimal PorcetajeIvaTotalA = 0;
        decimal PorcetajeIvaTotalB = 0;
        int CantidadTotalA = 0;
        int CantidadTotalB = 0;
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
        }

        public Excels(int idSucursal, IExcel ex, string nombre, Guid usuario)
        {
            Model = ServiceLocator.Instance.Resolve<EntradaSalidaAlmacenViewModel>();
            this.idSucursal = idSucursal;
            Ex = ex;
            Usuario = usuario;
            Nombre = nombre;
            ListaProductos = new List<Producto>();
            listaAlta = new List<Producto>();
            listaBaja = new List<Producto>();
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
                    Ex.EscribirCelda(Fila, 1, item.IdProducto.ToString());
                    Ex.EscribirCelda(Fila, 2, item.Clave.ToString());
                    Ex.EscribirCelda(Fila, 3, item.CodigoBarras.ToString());
                    Ex.EscribirCelda(Fila, 4, item.Nombre);
                    Ex.EscribirCelda(Fila, 5, "0");
                    Ex.EscribirCelda(Fila, 6, item.Descripcion);
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
        public async Task<int> Importar()
        {
            try
            {
                int FilaInicio = 3;
                Ruta = Ex.AbrirExcel();
                if (Ruta != null)
                {
                    ValidarExcel = Ex.AbrirArchivo(Ruta, Nombre);
                    if (ValidarExcel == true)
                    {

                    
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

                         Ret= await GetListaProductos(ListaProductos);
                        
                    }
                }
                if (Ret==1)
                {
                    ret2 = 2;//se guardo
                }
                else if (Ruta==null)
                {
                    ret2 = 1;//no se abrio ningun archivo
                }
                else if (ValidarExcel == false)
                {
                    ret2 = 0;//no tiene el formato correcto
                }
                return ret2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ValidarExcel==true)
                {
                    if (Ruta != null)
                    {
                        Ex.Cerrar();
                    }
                }
            }
        }

        public async Task<int> GetListaProductos(List<Producto> ListaExcel)
        {
            try
            {
             
                var GetListaProducto =  await Model.GetListaProducto(idSucursal);
                foreach (var item in ListaExcel)
                {
                    var x = GetListaProducto.Where(p => p.IdProducto == item.IdProducto).Select(
                        u => {
                            cantidadAux = u.CantidadProducto;
                            if(item.CantidadProducto > cantidadAux)//item excel, aux es de la base
                            {
                                CantidadTotalA += item.CantidadProducto - cantidadAux;
                                int CantidadA = item.CantidadProducto - cantidadAux;
                                PorcetajeIvaTotalA += (CantidadA * u.PrecioPublico * (u.Porcentaje /100));
                                TotalA += CantidadA * u.PrecioPublico;
                                SubA += CantidadA * u.PrecioPublico - (CantidadA * (u.PrecioPublico * (u.Porcentaje / 100)));
                                listaAlta.Add(item);
                            }
                            else if(item.CantidadProducto < cantidadAux)
                            {
                                CantidadTotalB += cantidadAux - item.CantidadProducto;
                                int CantidadB = cantidadAux - item.CantidadProducto;
                                PorcetajeIvaTotalB += (CantidadB * u.PrecioPublico * (u.Porcentaje / 100));
                                TotalB += CantidadB * u.PrecioPublico;
                                SubB += CantidadB * u.PrecioPublico - (CantidadB * (u.PrecioPublico * (u.Porcentaje / 100)));
                                listaBaja.Add(item);
                            }
                            return u;
                            }).ToList();

                   
                }
                await Model.ActualizarProducto(listaAlta, listaBaja, idSucursal, CantidadTotalA, PorcetajeIvaTotalA, TotalA, SubA, CantidadTotalB, PorcetajeIvaTotalB, TotalB, SubB, Usuario);
                return 1;//datos guardados
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}