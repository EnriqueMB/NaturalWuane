using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class EmpleadoViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IEmpleadoRepository IRepository { get; set; }
        private IPuestoRepository IPuesto { get; set; }
        private ITurnoRepository ITurno { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Empleado> ListaEmpleado { get; set; }
        public BindingList<Puesto> ListaPuesto { get; set; }
        public BindingList<Turno> ListaTurno { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public EmpleadoViewModel(IEmpleadoRepository repository, IPuestoRepository Puesto, ITurnoRepository Turno )
        {
            IRepository = repository;
            IPuesto = Puesto;
            ITurno = Turno;
            ListaPuesto = new BindingList<Puesto>();
            ListaEmpleado = new BindingList<Empleado>();
            ListaTurno = new BindingList<Turno>();
        }
        #endregion

        #region Metodos
        public async Task CargarDatos()
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
        }

        public async Task GetEmpleadoXId()
        {
            try
            {
                Empleado empleado;
                empleado = await IRepository.GetEmpleadoXid(IdEmpleado);
                IdEmpleado = empleado.IdEmpleado;
                Clave = empleado.Clave;
                Nombre = empleado.Nombre;
                ApellidoPat = empleado.ApellidoPat;
                ApellidoMat = empleado.ApellidoMat;
                FechaNacimiento = empleado.FechaNacimiento;
                Sexo = empleado.Sexo;
                IdTurno = empleado.IdTurno;
                IdPuesto = empleado.IdPuesto;
                Telefono = empleado.Telefono;
                Correo = empleado.Correo;
                Direccion = empleado.Direccion;


                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(Guid IdUsuario)
        {
            try
            {
                return await IRepository.DeleteAsync(IdEmpleado, IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region combo TipoPuesto

        public void LlenaPuesta(IEnumerable<Puesto> Puesto)
        {
            ListaPuesto.Clear();
            foreach (var item in Puesto)
            {
                ListaPuesto.Add(item);
            }
        }

        public async Task<IEnumerable<Puesto>> GetListaPuesto()
        {
            try
            {
                var Puesto = await IPuesto.GetComboPuesto();
                return Puesto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region combo Turno

        public void LlenaTurno(IEnumerable<Turno> turno)
        {
            ListaTurno.Clear();
            foreach (var item in turno)
            {
                ListaTurno.Add(item);
            }
        }

        public async Task<IEnumerable<Turno>> GetListaTurno()
        {
            try
            {
                var turno = await ITurno.GetComboTurno();
                return turno;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public async Task GetBusqueda()
        {
            try
            {
                var x = await IRepository.GetBusquedaAsync(this.Busqueda);
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
        }


        public async Task<Empleado> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Empleado model = new Empleado();
                if (State == EntityState.Create)
                {
                    model.Clave = this.Clave;
                    model.Nombre = this.Nombre;
                    model.ApellidoPat = this.ApellidoPat;
                    model.ApellidoMat = this.ApellidoMat;
                    model.FechaNacimiento = this.FechaNacimiento;
                    model.Sexo = this.Sexo;
                    model.IdTurno = this.IdTurno;
                    model.IdPuesto = this.IdPuesto;
                    model.Telefono = this.Telefono;
                    model.Correo = this.Correo;
                    model.Direccion = this.Direccion;
                    model.FotoBase64 = this.FotoBase64;
                    model.Contraseña = this.Contraseña;
                    model.IdSucursal = this.IdSucursal;
                    model = await IRepository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    model.Clave = this.Clave;
                    model.Nombre = this.Nombre;
                    model.ApellidoPat = this.ApellidoPat;
                    model.ApellidoMat = this.ApellidoMat;
                    model.FechaNacimiento = this.FechaNacimiento;
                    model.UpdateFoto = this.UpdateFoto;
                    model.Sexo = this.Sexo;
                    model.IdTurno = this.IdTurno;
                    model.IdPuesto = this.IdPuesto;
                    model.Telefono = this.Telefono;
                    model.Correo = this.Correo;
                    model.Direccion = this.Direccion;
                    model.FotoBase64 = this.FotoBase64;
                    model.IdSucursal = this.IdSucursal;
                    model = await IRepository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetFoto(Guid IdEmpleado)
        {
            try
            {
                var x = await IRepository.ObtenerFoto(IdEmpleado);
                this.FotoBase64 = x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding

        private string _Busqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set
            {
                _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }

        private bool _UpdateFoto;
        public bool UpdateFoto
        {
            get { return _UpdateFoto; }
            set
            {
                _UpdateFoto = value;
                OnPropertyChanged(nameof(UpdateFoto));
            }
        }
        private Guid _IdEmpleado;

        public Guid IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; OnPropertyChanged("IdEmpleado"); }
        }

        private int _LocalId;

        public int LocalId
        {
            get { return _LocalId; }
            set { _LocalId = value; OnPropertyChanged("LocalId"); }
        }

        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; OnPropertyChanged("Clave"); }
        }


        private string _NombreCompleto;

        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; OnPropertyChanged("NombreCompleto"); }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged("Nombre"); }
        }


        private string _ApellidoPat;

        public string ApellidoPat
        {
            get { return _ApellidoPat; }
            set { _ApellidoPat = value; OnPropertyChanged("ApellidoPat"); }
        }


        private string _ApellidoMat;

        public string ApellidoMat
        {
            get { return _ApellidoMat; }
            set { _ApellidoMat = value; OnPropertyChanged("ApellidoMat"); }
        }


        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; OnPropertyChanged("Edad"); }
        }

        private DateTime _FechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; OnPropertyChanged("FechaNacimiento"); }
        }

        private char _Sexo;

        public char Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; OnPropertyChanged("Sexo"); }
        }

        private int _IdTurno;

        public int IdTurno
        {
            get { return _IdTurno; }
            set { _IdTurno = value; OnPropertyChanged("IdTurno"); }
        }

        private string _Turno;

        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; OnPropertyChanged("Turno"); }
        }

        private int _IdPuesto;

        public int IdPuesto
        {
            get { return _IdPuesto; }
            set { _IdPuesto = value; OnPropertyChanged("IdPuesto"); }
        }

        private string _Puesto;

        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; OnPropertyChanged("Puesto"); }
        }

        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; OnPropertyChanged("Telefono"); }
        }

        private string _Correo;

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; OnPropertyChanged("Correo"); }
        }

        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; OnPropertyChanged("Direccion"); }
        }

        private string _Contraseña;

        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; OnPropertyChanged("Contraseña"); }
        }

        private int _IdSucursal;

        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; OnPropertyChanged("IdSucursal"); }
        }

        private string _Sucursal;

        public string Sucursal
        {
            get { return _Sucursal; }
            set { _Sucursal = value; OnPropertyChanged("Sucursal"); }
        }

        private string _FotoBase64;

        public string FotoBase64
        {
            get { return _FotoBase64; }
            set { _FotoBase64 = value; OnPropertyChanged("FotoBase64"); }
        }

        private int _Resultado;

        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; OnPropertyChanged("Resultado"); }
        }

        private string _CodigoBarra;

        public string CodigoBarra
        {
            get { return _CodigoBarra; }
            set { _CodigoBarra = value; OnPropertyChanged("CodigoBarra"); }
        }

        //Foto
        private Image _Foto;
        public Image Foto
        {
            get { return _Foto; }
            set
            {
                _Foto = value;
                OnPropertyChanged(nameof(Foto));
            }
        }

        private string _ImageLocation;
        public string ImageLocation
        {
            get { return _ImageLocation; }
            set
            {
                _ImageLocation = value; OnPropertyChanged(nameof(ImageLocation));
                if (ImageLocation != string.Empty)
                {
                    try
                    {
                        Foto = Image.FromFile(_ImageLocation);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
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
