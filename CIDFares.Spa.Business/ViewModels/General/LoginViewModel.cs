﻿using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class LoginViewModel : Validable
    {
        #region Propiedades Binding

        private string _UserAccount;

        public string UserAccount
        {
            get { return _UserAccount; }
            set { _UserAccount = value; OnPropertyChanged(nameof(UserAccount)); }
        }

        private string _UserPassword;

        public string UserPassword
        {
            get { return _UserPassword; }
            set { _UserPassword = value; OnPropertyChanged(nameof(UserPassword)); }
        }

        #endregion

        #region Propiedades Publicas
        public Guid IdCuentaUsuario { get; set; }

        public int IdRol { get; set; }

        public Guid IdEmpleado { get; set; }

        public string Nombres { get; set; }

        public int IdTurnoEmpleado { get; set; }

        public string[] ReglaUsuario { get; set; }

        public int IdSucursal { get; set; }

        public string NombreSucursal { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string RFC { get; set; }
        #endregion

        #region Propiedades Privadas
        private ILoginRepository Repository { get; set; }
        #endregion

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Constructor
        public LoginViewModel(ILoginRepository repository)
        {
            _UserAccount = "";
            _UserPassword = "";
            Repository = repository;
        }

        #endregion

        #region Metodos
        public async Task<int?> Login()
        {
            try
            {
                LoginRequests x  = await Repository.Login(UserAccount, UserPassword);
                IdCuentaUsuario = x.IdCuentaUsuario;
                IdRol = x.IdRol;
                IdEmpleado = x.IdEmpleado;
                Nombres = x.Nombres;
                IdTurnoEmpleado = x.IdTurnoEmpleado;
                ReglaUsuario = x.ReglaUsuario;
                IdSucursal = x.IdSucursal;
                NombreSucursal = x.NombreSucursal;
                Direccion = x.Direccion;
                Telefono = x.Telefono;
                RFC = x.RFC;
                
                return x.IsValid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
