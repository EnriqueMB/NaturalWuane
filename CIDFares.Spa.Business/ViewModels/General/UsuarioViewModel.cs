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
    public class UsuarioViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IUsuarioRepository Repository { get; set; } 
        private IRolRepository RolRepository { get; set; }
        private IEmpleadoRepository EmpleadoRepository { get; set; }
        #endregion

        #region Propiedades públicas
        
        public BindingList<Usuario> ListaUsuario { get; set; }
        public BindingList<Rol> ListaRol { get; set; }
        public BindingList<Empleado> ListaEmpleado { get; set; }
        public EntityState State { get; set; }
        #endregion


        #region Constructor
        public UsuarioViewModel(IUsuarioRepository usuarioRepository, IRolRepository rolRepository, IEmpleadoRepository empleadoRepository)
        {
            Modificar = false;
            Password = string.Empty;
            ContraseniaDos = string.Empty;
            IdCuentaUsuario = new Guid();
            Cuenta = string.Empty;
            IdRol = 0;
            IdEmpleado = new Guid();

            Repository = usuarioRepository;
            ListaUsuario = new BindingList<Usuario>();
            RolRepository = rolRepository;
            ListaRol = new BindingList<Rol>();
            EmpleadoRepository = empleadoRepository;
            ListaEmpleado = new BindingList<Empleado>();
            GetAll();
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaUsuario.Clear();
                foreach (var item in x)
                {
                    ListaUsuario.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LlenarListaRol()
        {
            try
            {
                var listaRol = await RolRepository.GetComboRol();
                foreach (var item in listaRol)
                {
                    ListaRol.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task LlenarListaEmpleado()
        {
            try
            {
                var listaEmpleado = await EmpleadoRepository.GetComboEmpleado();
                foreach (var item in listaEmpleado)
                {
                    ListaEmpleado.Add(item);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<int> Remove()
        {
            try
            {
                return await Repository.DeleteAsync(IdCuentaUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Usuario> GuardarCambios()
        {
            try
            {
                Usuario model = new Usuario
                {
                    IdCuentaUsuario = IdCuentaUsuario,
                    Cuenta = Cuenta,
                    PasswordHash = Password,
                    IdRol = IdRol,
                    IdEmpleado = IdEmpleado
                };
                if (State == EntityState.Create)
                {   
                    return await Repository.AddAsync(model);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateAsync(model);
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

        private Guid _IdCuentaUsuario;

        public  Guid IdCuentaUsuario
        {
            get { return _IdCuentaUsuario; }
            set {
                _IdCuentaUsuario = value;
                OnPropertyChanged(nameof(IdCuentaUsuario));
            }
        }


        private string _Cuenta;

        public string Cuenta
        {
            get { return _Cuenta; }

            set {
                   _Cuenta = value;
                   OnPropertyChanged(nameof(Cuenta));
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string _ContraseniaDos;

        public string ContraseniaDos
        {
            get { return _ContraseniaDos; }
            set {
                   _ContraseniaDos = value;
                   OnPropertyChanged(nameof(ContraseniaDos));
            }
        }


        private int _IdRol;

        public int IdRol
        {
            get { return _IdRol; }
            set {
                _IdRol = value;
                OnPropertyChanged(nameof(IdRol));

            }
        }

        private Guid _IdEmpleado;

        public Guid IdEmpleado
        {
            get { return _IdEmpleado; }
            set {
                _IdEmpleado = value;
                OnPropertyChanged(nameof(IdEmpleado));
            }
        }

        private bool _Modificar;

        public bool Modificar
        {
            get { return _Modificar; }
            set {
                _Modificar = value;
                OnPropertyChanged(nameof(Modificar));
            }
        }

        //public bool Modificar { get; set; }



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

