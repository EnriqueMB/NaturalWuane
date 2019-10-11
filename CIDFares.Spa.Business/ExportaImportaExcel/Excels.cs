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
        public Guid Usuario { get; set; }

        public List<Producto> listaAlta { get; set; }
        public List<Producto> listaBaja { get; set; }
        int cantidadAux = 0;
        bool ValidarExcel=false;
        decimal PrecioCostoA = 0;
        decimal TotalA = 0;
        decimal PrecioCostoB = 0;
        decimal TotalB = 0;
        decimal SubA = 0;
        decimal SubB = 0;
        decimal PorcetajeIvaTotalA = 0;
        decimal PorcetajeIvaTotalB = 0;
        int CantidadA = 0;
        int CantidadB = 0;
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

        public Excels(int idSucursal, IExcel ex, string nombre, Guid usuario)
        {
            Model = ServiceLocator.Instance.Resolve<InventarioFisicoViewModel>();
            this.idSucursal = idSucursal;
            Ex = ex;
            Usuario = usuario;
            Nombre = nombre;
            ListaProductos = new List<Producto>();
            listaAlta = new List<Producto>();
            listaBaja = new List<Producto>();
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
        public  void Importar()
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

                    GetListaProductos(ListaProductos);
                    }
                }
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

        public async void GetListaProductos(List<Producto> ListaExcel)
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
                                CantidadA += item.CantidadProducto - cantidadAux;
                                //PrecioCostoA += u.CostoProducto - (u.CostoProducto * (u.Porcentaje / 100));
                                PorcetajeIvaTotalA += CantidadA * (u.CostoProducto * (u.Porcentaje / 100));
                                TotalA += CantidadA * u.CostoProducto;
                                SubA += CantidadA * u.CostoProducto - (u.CostoProducto * (u.Porcentaje / 100));
                                listaAlta.Add(item);
                            }
                            else if(item.CantidadProducto < cantidadAux)
                            {
                                CantidadB += cantidadAux - item.CantidadProducto;
                                PorcetajeIvaTotalB += CantidadB *(u.CostoProducto * (u.Porcentaje / 100));
                                TotalB += CantidadB * u.CostoProducto;
                                SubB += CantidadB * u.CostoProducto - (u.CostoProducto * (u.Porcentaje / 100));
                                listaBaja.Add(item);
                            }
                            return u;
                            }).ToList();

                   
                }
                await Model.ActualizarProducto(listaAlta, listaBaja, idSucursal, CantidadA, PorcetajeIvaTotalA, TotalA, SubA, CantidadB, PorcetajeIvaTotalB, TotalB, SubB, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}