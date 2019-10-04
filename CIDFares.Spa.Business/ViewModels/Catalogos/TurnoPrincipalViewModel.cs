using System;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System.ComponentModel;
using System.Collections.Generic;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class TurnoPrincipalViewModel : Validable, INotifyPropertyChanged
    {
        public BindingList<Turno> ListaTurno { get; set; }
        public BindingList<TurnoDias> ListaValoresDias { get; set; }
        public EntityState State { get; set; }

        private ITurnoPrincipalRepository TurnoPrincipalRepository { get; set; }

        public TurnoPrincipalViewModel(ITurnoPrincipalRepository turnoPrincipalRepository)
        {
            TurnoPrincipalRepository = turnoPrincipalRepository;
            ListaTurno = new BindingList<Turno>();
            ListaValoresDias = new BindingList<TurnoDias>();
        }

        public async Task GetListaTurno()
        {
            try
            {
                var list = await TurnoPrincipalRepository.GetAllAsync();
                ListaTurno.Clear();
                foreach(var item in list)
                {
                    ListaTurno.Add(item);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete(object IdUsuario)
        {
            try
            {
                var result = await TurnoPrincipalRepository.DeleteAsync(this.IdTurno, IdUsuario);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Turno> GetAsync()
        {
            try
            {
                return await TurnoPrincipalRepository.GetAsync(this.IdTurno);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /*public async Task CargarDatos()
        {
            try
            {

                var x = await IRepository.GetAllAsync();
                ListaEmpleado.Clear();
                foreach (var item in x)
                {

                    ListaEmpleado.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/

        private Guid _IdUsuario;
        public Guid IdUsuario
        {
            get { return _IdUsuario; }
            set
            {
                _IdUsuario = value;
                OnPropertyChanged(nameof(IdUsuario));
            }
        }

        private int _IdTurno;
        public int IdTurno
        {
            get { return _IdTurno; }
            set
            {
                _IdTurno = value;
                OnPropertyChanged(nameof(IdTurno));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
