using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ProveedorACompraViewModel : Validable, INotifyPropertyChanged
    {

        #region Propiedases Privadas
        private IProveedorACompraRepository IRepository { get; set; }
        #endregion

        #region Propiedases Publicas
        public BindingList<ProveedorACompra> ListaProveedorACompra { get; set; }
        #endregion

        #region Constructor
        public ProveedorACompraViewModel(IProveedorACompraRepository Repository)
        {
            IRepository = Repository;
            ListaProveedorACompra = new BindingList<ProveedorACompra>();
        }
        #endregion

        #region Metodos
        public async Task CargarDatos()
        {
            try
            {
                var x = await IRepository.GetAllAsync();
                ListaProveedorACompra.Clear();
                foreach (var item in x)
                {

                    ListaProveedorACompra.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetBusqueda()
        {
            try
            {
                var x = await IRepository.GetBusquedaAsync(this.Busqueda);
                ListaProveedorACompra.Clear();
                foreach (var item in x)
                {
                    
                    ListaProveedorACompra.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public async Task<string> Proveedor(Guid id)
        //{
        //    try
        //    {
        //        return   await IRepository.GetNombre(id);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
           
        //}
        #endregion

        #region Binding
        private Guid _IdProveedor;

        public Guid IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; OnPropertyChanged("IdProveedor"); }
        }


        private Guid _IdProveedorTemp;

        public Guid IdProveedorTemp
        {
            get { return _IdProveedorTemp; }
            set { _IdProveedorTemp = value; OnPropertyChanged("IdProveedorTemp"); }
        }
        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; OnPropertyChanged("Clave"); }
        }

        private string _NombreComercial;

        public string NombreComercial
        {
            get { return _NombreComercial; }
            set { _NombreComercial = value; OnPropertyChanged("NombreComercial"); }
        }

        private string _NombreProveedor;

        public string NombreProveedor
        {
            get { return _NombreProveedor; }
            set { _NombreProveedor = value; OnPropertyChanged("NombreProveedor"); }
        }

        private string _RazonSocial;

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; OnPropertyChanged("RazonSocial"); }
        }

        private string _Representante;

        public string Representante
        {
            get { return _Representante; }
            set { _Representante = value; OnPropertyChanged("Representante"); }
        }


        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; OnPropertyChanged("Direccion"); }
        }

        private string _Telefono;

        public string Telefono
        {
            get { return _Direccion; }
            set { _Telefono = value; OnPropertyChanged("Telefono"); }
        }

        private string _CorreoElectronico;

        public string CorreoElectronico
        {
            get { return _CorreoElectronico; }
            set { _CorreoElectronico = value; OnPropertyChanged("CorreoElectronico"); }
        }


        private string _Pais;

        public string Pais
        {
            get { return _Pais; }
            set { _Pais = value; OnPropertyChanged("Pais"); }
        }


        private string _Estado;

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; OnPropertyChanged("Estado"); }
        }

        private string _Municipio;

        public string Municipio
        {
            get { return _Municipio; }
            set { _Municipio = value; OnPropertyChanged("Municipio"); }
        }

        public string _Busqueda;
        public string Busqueda
        {
            get { return _Busqueda; }
            set
            {
                _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }



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
