using CIDFares.Spa.Business.ValueObjects;
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
        #endregion

        #region Propiedades públicas
        public BindingList<Cliente> ListaCliente { get; set; }
        public BindingList<Cliente> ListaClienteVenta { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public ClienteViewModel(IClienteRepository clienteRepository)
        {
            Repository = clienteRepository;
            ListaCliente = new BindingList<Cliente>();
            ListaClienteVenta = new BindingList<Cliente>();
            GetAll();
        }
        #endregion

        #region Metodos
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

        public async Task<Cliente> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Cliente model = new Cliente();
                if (State == EntityState.Create)
                {
                    model.NuevoRegistro = true;
                    model.UpdateFoto = this.UpdateFoto;
                    model.IdCliente = Guid.Empty;
                    model.Clave = this.Clave;
                    model.NombreCompleto = this.NombreCompleto;
                    model.Direccion = this.Direccion;
                    model.Telefono = this.Telefono;
                    model.FechaNacimiento = this.FechaNacimiento;
                    model.Sexo = this.Sexo;
                    model.FotoBase64 = this.FotoBase64;
                    model.Rfc = this.Rfc;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    model.NuevoRegistro = false;
                    model.UpdateFoto = this.UpdateFoto;
                    model.IdCliente = this.IdCliente;
                    model.Clave = this.Clave;
                    model.NombreCompleto = this.NombreCompleto;
                    model.Direccion = this.Direccion;
                    model.Telefono = this.Telefono;
                    model.FechaNacimiento = this.FechaNacimiento;
                    model.Sexo = this.Sexo;
                    model.FotoBase64 = this.FotoBase64;
                    model.Rfc = this.Rfc;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                return model;
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
                ListaClienteVenta.Clear();
                foreach (var item in x)
                {
                    ListaClienteVenta.Add(item);
                }
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
