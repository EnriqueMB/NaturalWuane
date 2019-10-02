using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System.ComponentModel;
using System.Data;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class TurnoPrincipalViewModel : Validable, INotifyPropertyChanged
    {
        private ITurnoPrincipalRepository TurnoPrincipalRepository { get; set; }

        public EntityState State { get; set; }

        public TurnoPrincipalViewModel(ITurnoPrincipalRepository turnoPrincipalRepository)
        {
            TurnoPrincipalRepository = turnoPrincipalRepository;
        }

        public async Task GetListaTurno()
        {
            try
            {
                Turno listaTurno;
                listaTurno = await TurnoPrincipalRepository.GetAsync(IdTurno);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await TurnoPrincipalRepository.DeleteAsync(this.IdTurno, this.IdUsuario);
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
