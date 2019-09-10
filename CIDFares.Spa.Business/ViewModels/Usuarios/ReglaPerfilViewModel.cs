using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Usuarios
{
    public class ReglaPerfilViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IReglaPerfilRepository Repository { get; set; }
        private IRolRepository RepositoryRol { get; set; }
        #endregion

        #region Propiedades públicas
        public DataTable TablaGRegla { get; set; }
        public BindingList<Rol> ListaRol { get; set; }
        public BindingList<ReglasRol> ListaReglas { get; set; }
        public EntityState State { get; set; }
        #endregion
        
        #region Constructor
        public ReglaPerfilViewModel(IReglaPerfilRepository reglaPerfilRepository, IRolRepository rolRepository)
        {
            Repository = reglaPerfilRepository;
            RepositoryRol = rolRepository;
            ListaRol = new BindingList<Rol>();
            ListaReglas = new BindingList<ReglasRol>();
        }
        #endregion

        #region Metodos
        public void LlenarListaRol(IEnumerable<Rol> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    ListaRol.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Rol>> ObtenerListaRol()
        {
            try
            {
                var lista = await RepositoryRol.GetComboRol();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void LlenarListaRegla(int id)
        {
            try
            {
                var ListaAux = await Repository.LLenarGridXID(IdRol);
                ListaReglas.Clear();
                foreach (var item in ListaAux)
                {
                    ListaReglas.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ReglasRol> GuardarCambios(Guid idCuentaUsuario)
        {
            try
            {
                ReglasRol model = new ReglasRol
                {
                    TablaRegla = TablaGRegla,
                    IdRol = IdRol,
                    Resultado = -1
                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddAsync(model, idCuentaUsuario);
                }
                else
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Binding(Variables)

        private int _IdRol;

        public int IdRol
        {
            get { return _IdRol; }
            set
            {
                _IdRol = value;
                OnPropertyChanged("IdRol");
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
