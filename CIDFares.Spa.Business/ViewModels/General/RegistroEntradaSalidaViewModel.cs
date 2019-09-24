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
    public class RegistroEntradaSalidaViewModel : Validable, INotifyPropertyChanged
    {
        #region propiedades privadas
        public IRegistroEntradaSalidaRepository IRepository { get; set; }
        #endregion

        #region propiedades publicas

        #endregion

        #region constructor
        public RegistroEntradaSalidaViewModel(IRegistroEntradaSalidaRepository Repository)
        {
            IRepository = Repository;

            #region inicializar varibles Binding
            IdEmpleado = Guid.Empty;
            Tipo = "S";
            CodigoBarra = string.Empty;
            Password = string.Empty;
            Codigo = false;
            Pass = false;
            #endregion
        }
        #endregion

        #region metodos
       
        public async Task<int> Registrar()
        {
            try
            {
                RegistroEntradaSalida model = new RegistroEntradaSalida();
                model.IdEmpleado = this.IdEmpleado;
                model.Tipo = this.Tipo;
                return await IRepository.Registrar(IdEmpleado, Tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Guid> VerificarCodigoBarra()
        {
            try
            {
                RegistroEntradaSalida model = new RegistroEntradaSalida();
                
                model.CodigoBarra = this.CodigoBarra;
                model = await IRepository.VerificarCodigoBarra(model);
                //this.IdEmpleado = model.IdEmpleado;
                return model.IdEmpleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Binding
        private Guid _IdEmpleado;

        public Guid IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; OnPropertyChanged("IdEmpleado"); }
        }

        private string _Tipo;

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; OnPropertyChanged("Tipo"); }
        }

        private string _CodigoBarra;

        public string CodigoBarra
        {
            get { return _CodigoBarra; }
            set { _CodigoBarra = value; OnPropertyChanged("CodigoBarra"); }
        }

        private bool _Pass;

        public bool Pass
        {
            get { return _Pass; }
            set { _Pass = value; OnPropertyChanged("Pass"); }
        }

        private bool _Codigo;

        public bool Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; OnPropertyChanged("Codigo"); }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; OnPropertyChanged("Password"); }
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
