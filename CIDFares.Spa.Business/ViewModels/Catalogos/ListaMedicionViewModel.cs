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

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ListaMedicionViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas

        private IListaMedicionRepository ListaMedicionRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<ValorLista> ListaValores { get; set; }
        public bool ValidasValor { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Contructor
        public ListaMedicionViewModel(IListaMedicionRepository listaMedicionRepository)
        {
            ListaMedicionRepository = listaMedicionRepository;
            ListaValores = new BindingList<ValorLista>();
            ValidasValor = false;
        }
        #endregion

        #region Metodos
        public async Task GetListaMedicion()
        {
            try
            {
                ListaMedicion listaMedicion;
                listaMedicion = await ListaMedicionRepository.GetAsync(IdListaMedicion);
                Nombre = listaMedicion.Nombre;
                Descripcion = listaMedicion.Descripcion;
                ListaValores = new  BindingList<ValorLista>(listaMedicion.DatosValor.ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ListaMedicion> GuardarCambios(Guid Id, DataTable TablaValores)
        {
            try
            {
                ListaMedicion listaMedicion = new ListaMedicion();
                if (State == EntityState.Create)
                {
                    listaMedicion.IdListaMedicion = 0;
                    listaMedicion.Nombre = Nombre;
                    listaMedicion.Descripcion = Descripcion;
                    listaMedicion.TablaValores = TablaValores;
                    listaMedicion.IdUsuario = Id;
                    listaMedicion = await ListaMedicionRepository.AddAsync(listaMedicion, Id);
                }
                else if(State == EntityState.Update)
                {
                    listaMedicion.IdListaMedicion = IdListaMedicion;
                    listaMedicion.Nombre = Nombre;
                    listaMedicion.Descripcion = Descripcion;
                    listaMedicion.TablaValores = TablaValores;
                    listaMedicion.IdUsuario = Id;
                    listaMedicion = await ListaMedicionRepository.UpdateAsync(listaMedicion, Id);
                }
                
                return listaMedicion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ValidarNombre()
        {
            try
            {
                var result = await ListaMedicionRepository.NameExistAsync(Nombre.Trim());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Biding

        private int _IdListaMedicion;

        public int IdListaMedicion
        {
            get { return _IdListaMedicion; }
            set { _IdListaMedicion = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged(nameof(Nombre)); }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; OnPropertyChanged(nameof(Descripcion)); }
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
