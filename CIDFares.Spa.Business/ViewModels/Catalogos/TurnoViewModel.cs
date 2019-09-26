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
        private ITurnoRepository TurnoPrincipalRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<TurnoDias> ListaTurno { get; set; }
        public bool ValidarValor { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Contructor
        public TurnoViewModel(ITurnoRepository turnoRepository)
        {
            TurnoPrincipalRepository = turnoRepository;
            ListaTurno = new BindingList<TurnoDias>();
            ValidarValor = false;
        }
        #endregion

        #region Metodos
        public async Task GetListaTurno()
        {
            try
            {
                Turno listaTurno;
                listaTurno = await TurnoPrincipalRepository.GetAsync(IdTurno);
                NombreTurno = listaTurno.NombreTurno;
                ListaTurno = new BindingList<TurnoDias>(listaTurno.DatosValor.ToList());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /*public async Task GetAll()
        {
            try
            {
                var x = await TurnoRepository.GetAllAsync();
                ListaTurno.Clear();
                foreach (var item in x)
                {
                    ListaTurno.Add(item);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }*/

        public async Task<Turno> GuardarCambios(Guid IdUsuario, DataTable TablaValores)
        {
            try
            {
                Turno turno = new Turno();
                turno.NombreTurno = NombreTurno;
                turno.TablaValores = TablaValores;
                turno.IdUsuario = IdUsuario;
                turno = await TurnoPrincipalRepository.AddAsync(turno, IdUsuario);
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
                return await TurnoPrincipalRepository.DeleteAsync(this.IdTurno, this.IdUsuario);
            }
            catch (Exception ex)
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
