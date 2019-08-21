using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.General
{
    public class LoginViewModel
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
        public async Task<LoginRequests> Login()
        {
            try
            {
                LoginRequests x = new LoginRequests();
                x  = await Repository.Login(UserAccount, UserPassword);
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
