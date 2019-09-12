using CIDFares.Spa.Business.ValueObjects;
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
    public class ProveedorViewModel : Validable
    {
        #region propiedades privadas
        private IProveedorRepository Repository { get; set; }
        private IPaisRepository PaisRepository { get; set; }
        private IEstadoRepository EstadoRepository { get; set; }
        private IMunicipioRepository MunicipioRepository { get; set; }
        #endregion

        #region Propiedades públicas

        public BindingList<Proveedor> ListaProveedor { get; set; }
        public BindingList<Proveedor> ListaBuscarProveedor { get; set; }
        public BindingList<Pais> ListaPais { get; set; }
        public BindingList<Estado> ListaEstado { get; set; }
        public BindingList<Municipio> ListaMunicipio { get; set; }
        public ProveedorViewModel PDatos { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ProveedorViewModel(IProveedorRepository proveedorRepository, IPaisRepository paisRepository, IEstadoRepository estadoRepository, IMunicipioRepository municipioRepository)
        {

            Clave = string.Empty;
            NombreComercial = string.Empty;
            RazonSocial = string.Empty;
            Representante = string.Empty;
            RFC = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            CorreoElectronico = string.Empty;
            CodigoPostal = string.Empty;
            IdPais = 0;
            IdEstado = 0;
            IdMunicipio = 0;
            
            Repository = proveedorRepository;
            ListaProveedor = new BindingList<Proveedor>();
            ListaBuscarProveedor = new BindingList<Proveedor>();


            PaisRepository = paisRepository;
            ListaPais = new BindingList<Pais>();

            EstadoRepository = estadoRepository;
            ListaEstado = new BindingList<Estado>();

            MunicipioRepository = municipioRepository;
            ListaMunicipio = new BindingList<Municipio>();

            GetAll();
        }

        #endregion

        #region Metodos

        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaBuscarProveedor.Clear();
                foreach (var item in x)
                {
                    ListaBuscarProveedor.Add(item);
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
                var x = await Repository.GetBusquedaProveedorAsync(this.Buscar);
                ListaBuscarProveedor.Clear();
                foreach (var item in x)
                {
                    ListaBuscarProveedor.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
        
        #region Combo pais
        public void GetListaPais(IEnumerable<Pais> pais)
        {
            foreach (var item in pais)
            {
                ListaPais.Add(item);
            }
        }

        public async Task<IEnumerable<Pais>> GetListaPais()
        {
            try
            {
                var pais = await PaisRepository.GetComboPais();
                return pais;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Combo estado
        public void GetListaEstado(IEnumerable<Estado> estado)
        {
            ListaEstado.Clear();
            foreach (var item in estado)
            {
                ListaEstado.Add(item);
            }
        }

        public async Task<IEnumerable<Estado>> GetListaEstado()
        {
            try
            {
                var estado = await EstadoRepository.GetComboEstado(IdPais);
                return estado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Combo municipio
        public void GetListaMunicipio(IEnumerable<Municipio> municipio)
        {
            ListaMunicipio.Clear();
            foreach (var item in municipio)
            {
                ListaMunicipio.Add(item);
            }
        }

        public async Task<IEnumerable<Municipio>> GetListaMunicipio()
        {
            try
            {
                var municipio = await MunicipioRepository.GetComboMunicipio(IdEstado);
                return municipio;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        
        public async Task<int> Remove(Guid IdUsuario)
        {
            try
            {
                return await Repository.DeleteAsync(IdProveedor, IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public async Task CargarDatos()
        {
            try
            {
                Proveedor proveedor;
                proveedor = await Repository.GetAsync(IdProveedor);
                Clave = proveedor.Clave;
                NombreComercial = proveedor.NombreComercial;
                RazonSocial = proveedor.RazonSocial;
                Representante = proveedor.Representante;
                RFC = proveedor.RFC;
                Direccion = proveedor.Direccion;
                Telefono = proveedor.Telefono;
                CorreoElectronico = proveedor.CorreoElectronico;
                CodigoPostal =  proveedor.CodigoPostal;
                IdPais = proveedor.IdPais;
                IdEstado = proveedor.IdEstado;
                IdMunicipio = proveedor.IdMunicipio;
           
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<Proveedor> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Proveedor model = new Proveedor
                {
                    IdProveedor = IdProveedor,
                    Clave = Clave,
                    NombreComercial = NombreComercial,
                    RazonSocial = RazonSocial,
                    Representante = Representante,
                    RFC = RFC,
                    Direccion = Direccion,
                    Telefono = Telefono,
                    CorreoElectronico = CorreoElectronico,
                    CodigoPostal = CodigoPostal,
                    IdPais = IdPais,
                    IdEstado = IdEstado,
                    IdMunicipio = IdMunicipio


                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)

        private Guid _IdProveedor;

        public Guid IdProveedor
        {
            get {
                return _IdProveedor; }
            set { _IdProveedor = value;
                OnPropertyChanged(nameof(IdProveedor));
            }
        }

        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set {
                _Clave = value;
                OnPropertyChanged(nameof(Clave));
            }
        }

        private string _NombreComercial;

        public string NombreComercial
        {
            get { return _NombreComercial; }
            set {
                _NombreComercial = value;
                OnPropertyChanged(nameof(NombreComercial));
            }
        }

        private string _Razonsocial;

        public string RazonSocial
        {
            get { return _Razonsocial; }
            set {
                _Razonsocial = value;
                OnPropertyChanged(nameof(RazonSocial));
            }
        }

        private string _Representante;

        public string  Representante
        {
            get { return _Representante; }
            set {
                _Representante = value;
                OnPropertyChanged(nameof(Representante));
            }
        }

        private string _RFC;

        public string RFC
        {
            get { return _RFC; }
            set {
                _RFC = value;
                OnPropertyChanged(nameof(RFC));
            }
        }

        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value;
                OnPropertyChanged(nameof(Direccion));
            }
        }

        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value;
            OnPropertyChanged(nameof(Telefono));
            }
        }

        private string _CorreoElectronico;

        public string CorreoElectronico
        {
            get { return _CorreoElectronico; }
            set { _CorreoElectronico = value;
            OnPropertyChanged(nameof(CorreoElectronico));
            }
        }

        private string _CodigoPostal;

        public string CodigoPostal
        {
            get { return _CodigoPostal; }
            set {
                _CodigoPostal = value;
                OnPropertyChanged(nameof(CodigoPostal));
            }
        }


        private int _IdPais;

        public int IdPais
        {
            get { return _IdPais; }
            set {
                _IdPais = value;
                OnPropertyChanged(nameof(IdPais));
            }
        }

        private string _Pais;

        public string Pais
        {
            get { return _Pais; }
            set { _Pais = value;
                OnPropertyChanged(nameof(Pais));
            }
        }



        private int _IdEstado;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value;
                OnPropertyChanged(nameof(IdEstado));
            }
        }

        private string _Estado;

        public  string Estado
        {
            get { return _Estado; }
            set { _Estado = value;
                OnPropertyChanged(nameof(Estado));
            }
        }



        private int _IdMunicipio;

        public int IdMunicipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value;
                OnPropertyChanged(nameof(IdMunicipio));
            }
        }

        private string _Municipio;

        public string Municipio
        {
            get { return _Municipio; }
            set { _Municipio = value;
                OnPropertyChanged(nameof(Municipio));
            }
        }


        private string _Buscar;

        public string Buscar
        {
            get { return _Buscar; }
            set { _Buscar = value;
                OnPropertyChanged(nameof(Buscar));
            }
        }


        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #endregion

    }

}

