using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.DTOs;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ClienteViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IClienteRepository Repository { get; set; }
        private IDireccionesClienteRepository RepositoryDirecciones { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Cliente> ListaCliente { get; set; }
        public List<DireccionesCliente> ListaDirecciones { get; set; }
        public List<DireccionesClienteRequest> ListaDireccionesR { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ClienteViewModel(IClienteRepository clienteRepository, IDireccionesClienteRepository direccionesClienteRepository)
        {
            Repository = clienteRepository;
            RepositoryDirecciones = direccionesClienteRepository;
            ListaCliente = new BindingList<Cliente>();
            ListaDirecciones = new List<DireccionesCliente>();
            ListaDireccionesR = new List<DireccionesClienteRequest>();
        }
        #endregion

        #region Metodos
        public List<DireccionesCliente> GuardarLista()
        {
            try
            {
                List<DireccionesCliente> listaDirecciones = new List<DireccionesCliente>();
                DireccionesCliente direcciones;
                foreach (var item in ListaDireccionesR)
                {
                    direcciones = new DireccionesCliente();
                    direcciones.Calle = item.Calle;
                    direcciones.EntreCalles = item.EntreCalles;
                    direcciones.Colonia = item.Colonia;
                    direcciones.Referencias = item.Referencias;
                    direcciones.CodigoPostal = item.CodigoPostal;
                    direcciones.NumeroInterior = item.NumeroInterior;
                    direcciones.NumeroExterior = item.NumeroExterior;
                    direcciones.Contacto = item.Contacto;
                    direcciones.TelefonoContacto = item.TelefonoContacto;
                    direcciones.IdEstado = item.DatosEstado.IdEstado;
                    direcciones.IdMunicipio = item.DatosMunicipio.IdMunicipio;
                    listaDirecciones.Add(direcciones);
                }
                return listaDirecciones;
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
                var x = await Repository.GetAllAsync();
                ListaCliente.Clear();
                foreach (var item in x)
                {
                    ListaCliente.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetDireciones()
        {
            try
            {
                var list = await RepositoryDirecciones.GetDirecciones(IdCliente);
                ListaDireccionesR.Clear();
                foreach (var item in list)
                {
                    ListaDireccionesR.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task GetFoto(Guid IdCliente)
        {
            try
            {
                var x = await Repository.ObtenerFoto(IdCliente);
                this.FotoBase64 = x;
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
                DTOCliente model = new DTOCliente();
                if (State == EntityState.Create)
                {
                    model.DatosCliente.NuevoRegistro = true;
                    model.DatosCliente.UpdateFoto = this.UpdateFoto;
                    model.DatosCliente.IdCliente = Guid.Empty;
                    model.DatosCliente.Clave = this.Clave;
                    model.DatosCliente.NombreCompleto = this.NombreCompleto;
                    model.DatosCliente.Telefono = this.Telefono;
                    model.DatosCliente.FechaNacimiento = this.FechaNacimiento;
                    model.DatosCliente.Sexo = this.Sexo;
                    model.DatosCliente.FotoBase64 = this.FotoBase64;
                    model.DatosCliente.Rfc = this.Rfc;
                    model.DatosCliente.Email = this.Email;
                    model.ListaDireciones = GuardarLista();

                    var result = await Repository.AddWithDTO(model);
                    return result;
                }
                else if (State == EntityState.Update)
                {
                    model.DatosCliente.NuevoRegistro = false;
                    model.DatosCliente.UpdateFoto = this.UpdateFoto;
                    model.DatosCliente.IdCliente = this.IdCliente;
                    model.DatosCliente.Clave = this.Clave;
                    model.DatosCliente.NombreCompleto = this.NombreCompleto;
                    model.DatosCliente.Telefono = this.Telefono;
                    model.DatosCliente.FechaNacimiento = this.FechaNacimiento;
                    model.DatosCliente.Sexo = this.Sexo;
                    model.DatosCliente.FotoBase64 = this.FotoBase64;
                    model.DatosCliente.Rfc = this.Rfc;
                    model.DatosCliente.Email = this.Email;
                    model.ListaDireciones = GuardarLista();
                    var result = await Repository.AddWithDTO(model);
                    return result;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await Repository.DeleteAsync(this.IdCliente, this.IdUsuarioL);
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
                var x = await Repository.GetBusquedaAsync(this.Busqueda);
                ListaCliente.Clear();
                foreach (var item in x)
                {
                    ListaCliente.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> SetMonedero(Guid IdUsuario, string ClaveTarjeta, int Opcion)
        {
            try
            {
                return await Repository.SetMonederoCliente(IdCliente, IdUsuario, ClaveTarjeta, Opcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)
        private Guid _IdCliente;  
        public Guid IdCliente
        {
            get { return _IdCliente; }
            set
            {
                _IdCliente = value;
                OnPropertyChanged(nameof(IdCliente));
            }
        }


        private string _NombreCompleto;
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set
            {
                _NombreCompleto = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set
            {
                _Clave = value;
                OnPropertyChanged(nameof(Clave));
            }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set
            {
                _Direccion = value;
                OnPropertyChanged(nameof(Direccion));
            }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set
            {
                _Telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set
            {
                _FechaNacimiento = value;
                OnPropertyChanged(nameof(FechaNacimiento));
            }
        }

        private string _Rfc;
        public string Rfc
        {
            get { return _Rfc; }
            set
            {
                _Rfc = value;
                OnPropertyChanged(nameof(Rfc));
            }
        }

        private char _Sexo;
        public char Sexo
        {
            get { return _Sexo; }
            set
            {
                _Sexo = value;
                OnPropertyChanged(nameof(Sexo));
            }
        }

        private Image _Foto;
        public Image Foto
        {
            get { return _Foto; }
            set
            {
                _Foto = value;
                OnPropertyChanged(nameof(Foto));
            }
        }

        private Guid _IdUsuarioL;
        public Guid IdUsuarioL
        {
            get { return _IdUsuarioL; }
            set
            {
                _IdUsuarioL = value;
                OnPropertyChanged(nameof(IdUsuarioL));
            }
        }

        private string _FotoBase64;
        public string FotoBase64
        {
            get { return _FotoBase64; }
            set
            {
                _FotoBase64 = value;
                OnPropertyChanged(nameof(FotoBase64));
            }
        }

        private bool _UpdateFoto;
        public bool UpdateFoto
        {
            get { return _UpdateFoto; }
            set
            {
                _UpdateFoto = value;
                OnPropertyChanged(nameof(UpdateFoto));
            }
        }

        private string _ImageLocation;
        public string ImageLocation
        {
            get { return _ImageLocation; }
            set
            {
                _ImageLocation = value; OnPropertyChanged(nameof(ImageLocation));
                if (ImageLocation != string.Empty)
                {
                    try
                    {
                        Foto = Image.FromFile(_ImageLocation);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private string _Extencion;
        public string Extencion
        {
            get { return _Extencion; }
            set
            {
                _Extencion = value;
                OnPropertyChanged(nameof(Extencion));
            }
        }

        private ImageFormat _FormatoImg;

        public ImageFormat FormatoImg
        {
            get { return _FormatoImg; }
            set
            {
                _FormatoImg = value;
                OnPropertyChanged(nameof(FormatoImg));
            }
        }

        private string _Busqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set
            {
                _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }
        private bool _BuscarCliente;
        public bool BuscarCliente
        {
            get { return _BuscarCliente; }
            set
            {
                _BuscarCliente = value;
                OnPropertyChanged(nameof(BuscarCliente));
            }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged(nameof(Email)); }
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
