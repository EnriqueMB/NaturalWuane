using CIDFares.Library.Code.Utilities.IBase;
using CIDFares.Spa.Business.ExportaImportaExcel;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class InventarioFisicoViewModel : Validable, INotifyPropertyChanged
    {
        #region propiedades privadas
        public IInventarioFisicoRepository IRepository { get; set; }
        private IExcel Ex { get; set; }
        #endregion

        #region propiedades publicas
        public BindingList<Producto> ListaProducto { get; set; }
        public Producto TablaProducto { get; set; }
        #endregion

        #region constructor
        public InventarioFisicoViewModel(IInventarioFisicoRepository Repo, IExcel excel)
        {
            Ex = excel;
            IRepository = Repo;
            TablaProducto = new Producto();
        }
        #endregion

        #region Metodos
        public async Task GetProducto(object Idsucursal, string Ruta, string Nombre)
        {
            try
            {
                var Productos = await IRepository.GetProductos(Idsucursal);
                Excels ExportarProductos = new Excels(Productos, Ruta, Nombre, Ex);



            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        public  void Importar(object IdSucursal,  string Nombre)
        {
            try
            {
                Excels Importar = new Excels(IdSucursal,Ex,  Nombre);
                //var x = Importar.GenerarArchivo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Binding
        
        #endregion
        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
