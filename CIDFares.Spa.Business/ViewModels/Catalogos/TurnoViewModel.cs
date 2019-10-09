using System;
using System.Linq;
using System.Threading.Tasks;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System.ComponentModel;
using System.Data;


namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class TurnoViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private ITurnoRepository TurnoRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<TurnoDias> ListaValores { get; set; }
        public bool ValidarValor { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Contructor
        public TurnoViewModel(ITurnoRepository turnoRepository)
        {
            TurnoRepository = turnoRepository;
            ListaValores = new BindingList<TurnoDias>();
            ValidarValor = false;
        }
        #endregion

        #region Metodos
        public async Task<Turno> GetListaTurno(int? IdTurno)
        {
            try
            {
                Turno listaTurno;
                listaTurno = await TurnoRepository.GetAsync(IdTurno);
                NombreTurno = listaTurno.NombreTurno;
                return listaTurno;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

         public async Task<Turno> GuardarCambios(Guid IdUsuario, DataTable TablaValores)
        {
            try
            {
                Turno turno = new Turno();
                if (State == EntityState.Create)
                { 
                    turno.NombreTurno = NombreTurno;
                    turno.TablaValores = TablaValores;
                    turno.IdUsuario = IdUsuario;
                    turno = await TurnoRepository.AddAsync(turno, IdUsuario);
                    return turno;
                }
                else if (State == EntityState.Update)
                {
                    turno.IdTurno = IdTurno;
                    turno.NombreTurno = NombreTurno;
                    turno.TablaValores = TablaValores;
                    turno.IdUsuario = IdUsuario;
                    turno = await TurnoRepository.UpdateAsync(turno, IdUsuario);
                    return turno;
                }
                return turno;
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
                return await TurnoRepository.DeleteAsync(this.IdTurno, this.IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetAsync()
        {
            try
            {
                Turno turno = new Turno();
                turno = await TurnoRepository.GetAsync(this.IdTurno);
                NombreTurno = turno.NombreTurno;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task CargarDatos()
        {
            try
            {

                /*var x = await IRepository.GetAllAsync();
                ListaEmpleado.Clear();
                foreach (var item in x)
                {

                    ListaEmpleado.Add(item);
                }*/
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Binding
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

        private string _NombreTurno;
        public string NombreTurno
        {
            get { return _NombreTurno; }
            set
            {
                _NombreTurno = value;
                OnPropertyChanged(nameof(NombreTurno));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
