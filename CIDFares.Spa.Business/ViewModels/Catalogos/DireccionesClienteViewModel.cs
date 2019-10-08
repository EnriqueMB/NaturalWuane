using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
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
    public class DireccionesClienteViewModel: Validable, INotifyPropertyChanged
    {

        #region Propiedades privadas
        private IDireccionesClienteRepository Repository { get; set; }
        private IEstadoRepository EstadoRepository { get; set; }
        private IMunicipioRepository MunicipioRepository { get; set; }
        #endregion

        #region Propiedades publicas
        public BindingList<DireccionesClienteRequest> ListaDirecciones { get; set; }
        public BindingList<Estado> ListaEstados { get; set; }
        public BindingList<Municipio> ListaMunicipios { get; set; }
        public EntityState State { get; set; }

        public DireccionesClienteViewModel(IDireccionesClienteRepository repository, IEstadoRepository estadoRepository, IMunicipioRepository municipioRepository)
        {
            Repository = repository;
            EstadoRepository = estadoRepository;
            MunicipioRepository = municipioRepository;
            ListaDirecciones = new BindingList<DireccionesClienteRequest>();
            ListaEstados = new BindingList<Estado>();
            ListaMunicipios = new BindingList<Municipio>();
        }

        #endregion

        #region Constructor        

        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var result = await Repository.GetDirecciones(IdCliente);
                ListaDirecciones.Clear();
                foreach (var item in result)
                {
                    ListaDirecciones.Add(item);
                }
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
                var lista = await EstadoRepository.GetComboEstado(143);
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

        public async Task<int> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                if (State == EntityState.Create)
                {
                    DireccionesCliente direccionesCliente = new DireccionesCliente
                    {
                        IdCliente = IdCliente,
                        IdDireccion = Guid.Empty,
                        Calle = Calle,
                        EntreCalles = EntreCalles,
                        Referencias = Referencias,
                        NumeroInterior = NumeroInterior,
                        NumeroExterior = NumeroExterior,
                        Colonia = Colonia,
                        CodigoPostal = CodigoPostal,
                        IdEstado = IdEstado,
                        IdMunicipio = IdMunicipio,
                        Contacto = Contacto,
                        TelefonoContacto = TelefonoContacto,
                        IdUsuario = IdUsuario
                    };
                    var result = await Repository.AddAsync(direccionesCliente, IdUsuario);
                    return (result.IdDireccion != Guid.Empty) ? 1 : 0;
                }
                else if (State == EntityState.Update)
                {
                    DireccionesCliente direccionesCliente = new DireccionesCliente()
                    {
                        IdCliente = IdCliente,
                        IdDireccion = IdDireccion,
                        Calle = Calle,
                        EntreCalles = EntreCalles,
                        Referencias = Referencias,
                        NumeroInterior = NumeroInterior,
                        NumeroExterior = NumeroExterior,
                        Colonia = Colonia,
                        CodigoPostal = CodigoPostal,
                        IdEstado = IdEstado,
                        IdMunicipio = IdMunicipio,
                        Contacto = Contacto,
                        TelefonoContacto = TelefonoContacto,
                        IdUsuario = IdUsuario
                    };
                    var result = await Repository.UpdateAsync(direccionesCliente, IdUsuario);
                    return (result.IdDireccion != Guid.Empty) ? 1 : 0;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteDireccion(Guid IdUsuario)
        {
            try
            {
                var result = await Repository.DeleteAsync(IdDireccion, IdUsuario);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private Guid _IdCliente;

        public Guid IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private Guid _IdDireccion;

        public Guid IdDireccion
        {
            get { return _IdDireccion; }
            set { _IdDireccion = value; }
        }


        private string _Calle;

        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; OnPropertyChanged(nameof(Calle)); }
        }

        private string _EntreCalles;    

        public string EntreCalles
        {
            get { return _EntreCalles; }
            set { _EntreCalles = value; OnPropertyChanged(nameof(EntreCalles)); }
        }

        private string _Referencias;

        public string Referencias
        {
            get { return _Referencias; }
            set { _Referencias = value; OnPropertyChanged(nameof(Referencias)); }
        }

        private string _Colonia;

        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; OnPropertyChanged(nameof(Colonia)); }
        }

        private string _CodigoPostal;

        public string CodigoPostal
        {
            get { return _CodigoPostal; }
            set { _CodigoPostal = value; OnPropertyChanged(nameof(CodigoPostal)); }
        }

        private string _Contacto;

        public string Contacto
        {
            get { return _Contacto; }
            set { _Contacto = value; }
        }

        private string _TelefonoContacto;

        public string TelefonoContacto
        {
            get { return _TelefonoContacto; }
            set { _TelefonoContacto = value; }
        }

        private int _IdEstado;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }

        private int _IdMunicipio;

        public int IdMunicipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value; }
        }

        private int _NumeroInterior;

        public int NumeroInterior
        {
            get { return _NumeroInterior; }
            set { _NumeroInterior = value; }
        }

        private int _NumeroExterior;

        public int NumeroExterior
        {
            get { return _NumeroExterior; }
            set { _NumeroExterior = value; }
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
