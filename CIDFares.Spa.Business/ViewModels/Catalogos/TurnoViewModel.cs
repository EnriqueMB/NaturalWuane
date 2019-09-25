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
using System.Drawing;
using System.Drawing.Imaging;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class TurnoViewModel : Validable, INotifyPropertyChanged
    {
        private ITurnoRepository Repository { get; set; }

        public BindingList<Turno> ListaTurno { get; set; }

        public EntityState State { get; set; }

        public TurnoViewModel(ITurnoRepository turnoRepository)
        {
            Repository = turnoRepository;
            ListaTurno = new BindingList<Turno>();
            HoraEntrada1 = new DateTime(2000, 01, 01, 07,00, 00);
            HoraSalida1 = new DateTime(2000, 01, 01, 07, 00, 00);
            HoraEntrada2 = new DateTime(2000, 01, 01, 07, 00, 00);
            HoraSalida2 = new DateTime(2000, 01, 01, 07, 00, 00);
        }

        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
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

        }

        public async Task<Turno> GuardarCambios(Guid IdUsuario, bool NumHorariosValue)
        {
            try
            {
                Turno model = new Turno();
                if (NumHorariosValue)
                {
                    model.NombreTurno = NombreTurno;
                    model.HoraEntrada1 = HoraEntrada1;
                    model.HoraSalida1 = HoraSalida1;
                    model.Lunes = Lunes;
                    model.Martes = Martes;
                    model.Miercoles = Miercoles;
                    model.Jueves = Jueves;
                    model.Viernes = Viernes;
                    model.Sabado = Sabado;
                    model.Domingo = Domingo;
                    model.NumHorarios = NumHorariosValue;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                else
                {
                    model.NombreTurno = NombreTurno;
                    model.HoraEntrada1 = HoraEntrada1;
                    model.HoraSalida1 = HoraSalida1;
                    model.HoraEntrada2 = HoraEntrada2;
                    model.HoraSalida2 = HoraSalida2;
                    model.Lunes = Lunes;
                    model.Martes = Martes;
                    model.Miercoles = Miercoles;
                    model.Jueves = Jueves;
                    model.Viernes = Viernes;
                    model.Sabado = Sabado;
                    model.Domingo = Domingo;
                    model.NumHorarios = NumHorariosValue;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                return model;
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
                return await Repository.DeleteAsync(this.IdTurno, this.IdUsuario);
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
                return await Repository.GetAsync(this.IdTurno);
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

        private DateTime _HoraEntrada1;
        public DateTime HoraEntrada1
        {
            get { return _HoraEntrada1; }
            set
            {
                _HoraEntrada1 = value;
                OnPropertyChanged(nameof(HoraEntrada1));
            }
        }

        private DateTime _HoraSalida1;
        public DateTime HoraSalida1
        {
            get { return _HoraSalida1; }
            set
            {
                _HoraSalida1 = value;
                OnPropertyChanged(nameof(HoraSalida1));
            }
        }
        
        private DateTime _HoraEntrada2;
        public DateTime HoraEntrada2
        {
            get { return _HoraEntrada2; }
            set
            {
                _HoraEntrada2 = value;
                OnPropertyChanged(nameof(HoraEntrada2));
            }
        }

        private DateTime _HoraSalida2;
        public DateTime HoraSalida2
        {
            get { return _HoraSalida2; }
            set
            {
                _HoraSalida2 = value;
                OnPropertyChanged(nameof(HoraSalida2));
            }
        }

        private bool _Lunes;
        public bool Lunes
        {
            get { return _Lunes; }
            set
            {
                _Lunes = value;
                OnPropertyChanged(nameof(Lunes));
            }
        }

        private bool _Martes;
        public bool Martes
        {
            get { return _Martes; }
            set
            {
                _Martes = value;
                OnPropertyChanged(nameof(Martes));
            }
        }

        private bool _Miercoles;
        public bool Miercoles
        {
            get { return _Miercoles; }
            set
            {
                _Miercoles = value;
                OnPropertyChanged(nameof(Miercoles));
            }
        }

        private bool _Jueves;
        public bool Jueves
        {
            get { return _Jueves; }
            set
            {
                _Jueves = value;
                OnPropertyChanged(nameof(Jueves));
            }
        }

        private bool _Viernes;
        public bool Viernes
        {
            get { return _Viernes; }
            set
            {
                _Viernes = value;
                OnPropertyChanged(nameof(Viernes));
            }
        }

        private bool _Sabado;
        public bool Sabado
        {
            get { return _Sabado; }
            set
            {
                _Sabado = value;
                OnPropertyChanged(nameof(Sabado));
            }
        }

        private bool _Domingo;
        public bool Domingo
        {
            get { return _Domingo; }
            set
            {
                _Domingo = value;
                OnPropertyChanged(nameof(Domingo));
            }
        }

        private bool _NumHorarios;
        public bool NumHorarios
        {
            get { return _NumHorarios; }
            set
            {
                _NumHorarios = value;
                OnPropertyChanged(nameof(NumHorarios));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
