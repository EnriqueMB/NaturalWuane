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
        public DireccionesClienteRequest item { get; set; }
        public EntityState State { get; set; }

        public DireccionesClienteViewModel(IDireccionesClienteRepository repository, IEstadoRepository estadoRepository, IMunicipioRepository municipioRepository)
        {
            Repository = repository;
            EstadoRepository = estadoRepository;
            MunicipioRepository = municipioRepository;
            ListaDirecciones = new BindingList<DireccionesClienteRequest>();
            ListaEstados = new BindingList<Estado>();
            ListaMunicipios = new BindingList<Municipio>();
            item = new DireccionesClienteRequest();
        }

        #endregion

        #region Constructor        

        #endregion

        #region Metodos
        public void CargarLista(List<DireccionesClienteRequest> lista)
        {
            try
            {
                DireccionesClienteRequest direcciones;
                foreach (var item in lista)
                {
                    direcciones = new DireccionesClienteRequest();
                    direcciones.Calle = item.Calle;
                    direcciones.EntreCalles = item.EntreCalles;
                    direcciones.Colonia = item.Colonia;
                    direcciones.Referencias = item.Referencias;
                    direcciones.CodigoPostal = item.CodigoPostal;
                    direcciones.NumeroInterior = item.NumeroInterior;
                    direcciones.NumeroExterior = item.NumeroExterior;
                    direcciones.Contacto = item.Contacto;
                    direcciones.TelefonoContacto = item.TelefonoContacto;
                    direcciones.DatosEstado.IdEstado = item.DatosEstado.IdEstado;
                    direcciones.DatosEstado.Descripcion = item.DatosEstado.Descripcion;
                    direcciones.DatosMunicipio.IdMunicipio = item.DatosMunicipio.IdMunicipio;
                    direcciones.DatosMunicipio.Descripcion = item.DatosMunicipio.Descripcion;
                    ListaDirecciones.Add(direcciones);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task GetAll()
        {
            try
            {
                var list = await Repository.GetDirecciones(IdCliente);
                ListaDirecciones.Clear();
                foreach (var item in list)
                {
                    ListaDirecciones.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar()
        {
            try
            {
                if (State == EntityState.Update)
                {
                    ListaDirecciones.Remove(item);
                    DireccionesClienteRequest Newitem = new DireccionesClienteRequest();
                    Newitem.DatosEstado.IdEstado = IdEstado;
                    Newitem.DatosEstado.Descripcion = NombreEstado;
                    Newitem.DatosMunicipio.IdMunicipio = IdMunicipio;
                    Newitem.DatosMunicipio.Descripcion = NombreMunicipio;
                    Newitem.Calle = Calle;
                    Newitem.EntreCalles = EntreCalles;
                    Newitem.Colonia = Colonia;
                    Newitem.Referencias = Referencias;
                    Newitem.NumeroExterior = NumeroExterior;
                    Newitem.NumeroInterior = NumeroInterior;
                    Newitem.CodigoPostal = CodigoPostal;
                    Newitem.Contacto = Contacto;
                    Newitem.TelefonoContacto = TelefonoContacto;
                    ListaDirecciones.Add(Newitem);
                }
                else
                {
                    DireccionesClienteRequest item = new DireccionesClienteRequest();
                    item.DatosEstado.IdEstado = IdEstado;
                    item.DatosEstado.Descripcion = NombreEstado;
                    item.DatosMunicipio.IdMunicipio = IdMunicipio;
                    item.DatosMunicipio.Descripcion = NombreMunicipio;
                    item.Calle = Calle;
                    item.EntreCalles = EntreCalles;
                    item.Colonia = Colonia;
                    item.Referencias = Referencias;
                    item.NumeroExterior = NumeroExterior;
                    item.NumeroInterior = NumeroInterior;
                    item.CodigoPostal = CodigoPostal;
                    item.Contacto = Contacto;
                    item.TelefonoContacto = TelefonoContacto;
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
            set { _Contacto = value; OnPropertyChanged(nameof(Contacto)); }
        }

        private string _TelefonoContacto;

        public string TelefonoContacto
        {
            get { return _TelefonoContacto; }
            set { _TelefonoContacto = value; OnPropertyChanged(nameof(TelefonoContacto)); }
        }

        private int _IdEstado;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; OnPropertyChanged(nameof(IdEstado)); }
        }

        private int _IdMunicipio;

        public int IdMunicipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value; OnPropertyChanged(nameof(IdMunicipio)); }
        }

        private int _NumeroInterior;

        public int NumeroInterior
        {
            get { return _NumeroInterior; }
            set { _NumeroInterior = value; OnPropertyChanged(nameof(NumeroInterior)); }
        }

        private int _NumeroExterior;

        public int NumeroExterior
        {
            get { return _NumeroExterior; }
            set { _NumeroExterior = value; OnPropertyChanged(nameof(NumeroExterior)); }
        }

        private bool _SNInterior;

        public bool SNInterior
        {
            get { return _SNInterior; }
            set { _SNInterior = value; OnPropertyChanged(nameof(SNInterior)); }
        }

        private bool _SNExterior;

        public bool SNExterior
        {
            get { return _SNExterior; }
            set { _SNExterior = value; OnPropertyChanged(nameof(SNExterior)); }
        }

        public string NombreEstado { get; set; }

        public string NombreMunicipio { get; set; }

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
