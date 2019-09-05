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

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class SucursalViewModel : Validable
    {

        #region Propiedades Privadas
        private ISucursalRepository SucursalRepository { get; set; }
        private IPaisRepository PaisRepository { get; set; }
        private IEstadoRepository EstadoRepository { get; set; }
        private IMunicipioRepository MunicipioRepository { get; set; }
        private ITipoSucursalRepository TipoSucursalRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Sucursal> ListaSucursales { get; set; }
        public BindingList<Pais> ListaPais { get; set; }
        public BindingList<Estado> ListaEstados { get; set; }
        public BindingList<Municipio> ListaMunicipios { get; set; }
        public BindingList<TipoSucursal> ListaTipoSucursal { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public SucursalViewModel(ITipoSucursalRepository tipoSucursalRepository, IPaisRepository paisRepository, IEstadoRepository estadoRepository, IMunicipioRepository municipioRepository, ISucursalRepository sucursalRepository)
        {
            SucursalRepository = sucursalRepository;
            TipoSucursalRepository = tipoSucursalRepository;
            PaisRepository = paisRepository;
            EstadoRepository = estadoRepository;
            MunicipioRepository = municipioRepository;
            ListaSucursales = new BindingList<Sucursal>();
            ListaTipoSucursal = new BindingList<TipoSucursal>();
            ListaPais = new BindingList<Pais>();
            ListaMunicipios = new BindingList<Municipio>();
            ListaEstados = new BindingList<Estado>();
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await SucursalRepository.GetAllAsync();
                ListaSucursales.Clear();
                foreach (var item in x)
                {
                    ListaSucursales.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaTipoSucursal(IEnumerable<TipoSucursal> tipoSucursals)
        {
            foreach (var item in tipoSucursals)
            {
                ListaTipoSucursal.Add(item);
            }
        }

        public async Task<IEnumerable<TipoSucursal>> GetListaTipoSucursal()
        {
            try
            {
                var lista = await TipoSucursalRepository.GetComboTipoSucursal();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaPaises(IEnumerable<Pais> pais)
        {
            foreach (var item in pais)
            {
                ListaPais.Add(item);
            }
        }

        public async Task<IEnumerable<Pais>> GetListaPaises()
        {
            try
            {
                var lista = await PaisRepository.GetComboPais();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaEstado(IEnumerable<Estado> estados)
        {
            ListaEstados.Clear();
            foreach (var item in estados)
            {
                ListaEstados.Add(item);
            }
        }

        public async Task<IEnumerable<Estado>> GetListaEstados()
        {
            try
            {
                var lista = await EstadoRepository.GetComboEstado(IdPais);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaMunicipios(IEnumerable<Municipio> municipios)
        {
            ListaMunicipios.Clear();
            foreach (var item in municipios)
            {
                ListaMunicipios.Add(item);
            }
        }

        public async Task<IEnumerable<Municipio>> GetListaMunicipios()
        {
            try
            {
                var lista = await MunicipioRepository.GetComboMunicipio(IdEstado);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetSucursal()
        {
            try
            {
                Sucursal sucursal;
                sucursal = await SucursalRepository.GetAsync(IdSucursal);
                Nombre = sucursal.Nombre;
                Direccion = sucursal.Direccion;
                Telefono = sucursal.Telefono;
                IdMunicipio = sucursal.IdMunicipio;
                IdTipoSucursal = sucursal.IdTipoSucursal;
                IdEstado = sucursal.IdEstado;
                IdPais = sucursal.IdPais;
                CodigoPostal = sucursal.CodigoPostal;
                Rfc = sucursal.Rfc;
                NombreRepresentante = sucursal.NombreRepresentante;
                RegimenFiscal = sucursal.RegimenFiscal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Sucursal> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Sucursal sucursal = new Sucursal();
                sucursal.Result = 0;
                if (State == EntityState.Create)
                {
                    sucursal.IdSucursal = 0;
                    sucursal.IdTipoSucursal = IdTipoSucursal;
                    sucursal.Nombre = Nombre;
                    sucursal.Direccion = Direccion;
                    sucursal.Telefono = Telefono;
                    sucursal.IdPais = IdPais;
                    sucursal.IdEstado = IdEstado;
                    sucursal.IdMunicipio = IdMunicipio;
                    sucursal.CodigoPostal = CodigoPostal;
                    sucursal.Rfc = Rfc;
                    sucursal.NombreRepresentante = NombreRepresentante;
                    sucursal.RegimenFiscal = RegimenFiscal;
                    sucursal = await SucursalRepository.AddAsync(sucursal,IdUsuario);
                }
                else if(State == EntityState.Update)
                {
                    sucursal.IdSucursal = IdSucursal;
                    sucursal.IdTipoSucursal = IdTipoSucursal;
                    sucursal.Nombre = Nombre;
                    sucursal.Direccion = Direccion;
                    sucursal.Telefono = Telefono;
                    sucursal.IdPais = IdPais;
                    sucursal.IdEstado = IdEstado;
                    sucursal.IdMunicipio = IdMunicipio;
                    sucursal.CodigoPostal = CodigoPostal;
                    sucursal.Rfc = Rfc;
                    sucursal.NombreRepresentante = NombreRepresentante;
                    sucursal.RegimenFiscal = RegimenFiscal;
                    sucursal = await SucursalRepository.UpdateAsync(sucursal, IdUsuario);
                }
                return sucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete(Guid IdUsuario)
        {
            try
            {
                var result = await SucursalRepository.DeleteAsync(IdSucursal, IdUsuario);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Propiedades Binding
        private int? _IdSucursal;

        public int? IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; }
        }
        private int? _IdTipoSucursal;

        public int? IdTipoSucursal
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
            set { _CodigoPostal = value; OnPropertyChanged(nameof(CodigoPostal)); }
        }
        private string _Rfc;

        public string Rfc
        {
            get { return _Rfc; }
            set { _Rfc = value; OnPropertyChanged(nameof(Rfc)); }
        }
        private string _NombreRepresentante;

        public string NombreRepresentante
        {
            get { return _NombreRepresentante; }
            set { _NombreRepresentante = value; OnPropertyChanged(nameof(NombreRepresentante)); }
        }
        private string _RegimenFiscal;

        public string RegimenFiscal
        {
            get { return _RegimenFiscal; }
            set { _RegimenFiscal = value; OnPropertyChanged(nameof(RegimenFiscal)); }
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
