using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class SucursalViewModel : Validable
    {
        #region Propiedades Binding
        private int _IdSucursal;

        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; }
        }
        private int _IdTipoSucursal;

        public int IdTipoSucursal
        {
            get { return _IdTipoSucursal; }
            set { _IdTipoSucursal = value; OnPropertyChanged(nameof(IdTipoSucursal)); }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged(nameof(Nombre)); }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; OnPropertyChanged(nameof(Direccion)); }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; OnPropertyChanged(nameof(Telefono)); }
        }
        private int _IdMunicipio;

        public int IdMunicipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value; OnPropertyChanged(nameof(IdMunicipio)); }
        }
        private int _IdEstado;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; OnPropertyChanged(nameof(IdEstado)); }
        }
        private int _IdPais;

        public int IdPais
        {
            get { return _IdPais; }
            set { _IdPais = value; OnPropertyChanged(nameof(IdPais)); }
        }
        private string _CodigoPostal;

        public string CodigoPostal
        {
            get { return _CodigoPostal; }
            set { _CodigoPostal = value; }
        }
        private string _Rfc;

        public string Rfc
        {
            get { return _Rfc; }
            set { _Rfc = value; }
        }
        private string _NombreRepresentante;

        public string NombreRepresentante
        {
            get { return _NombreRepresentante; }
            set { _NombreRepresentante = value; }
        }
        private string _RegimenFiscal;

        public string RegimenFiscal
        {
            get { return _RegimenFiscal; }
            set { _RegimenFiscal = value; }
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
