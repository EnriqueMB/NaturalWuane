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
    public class PaqueteViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IPaqueteRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Paquetes> ListaPaquete { get; set; }
        public EntityState State { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }
        #endregion

        #region Constructor

        public PaqueteViewModel(IPaqueteRepository paqueteRepository)
        {
            Repository = paqueteRepository;
            ListaPaquete = new BindingList<Paquetes>();
        }

        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Paquetes> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Paquetes model = new Paquetes();               
                model.IdPaquete = this.IdPaquete;
                model.Clave = this.Clave;
                model.Nombre = this.Nombre;
                model.Descripcion = this.Descripcion;
                model.NPersona = this.NPersona;
                model.NPago = this.NPago;
                model.FechaVencimiento = this.FechaVencimiento;
                model.TablaProducto = this.TablaProducto;
                model.TablaServicio = this.TablaServicio;
                if (State == EntityState.Create)
                {
                    model.NuevoRegistro = true;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    model.NuevoRegistro = false;
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await Repository.DeleteAsync(this.IdPaquete, this.IdUsuarioL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)
        private int _IdPaquete;
        public int IdPaquete
        {
            get { return _IdPaquete; }
            set
            {
                _IdPaquete = value;
                OnPropertyChanged(nameof(IdPaquete));
            }
        }

        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set
            {
                _Clave = value;
                OnPropertyChanged(nameof(Clave));
            }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        private string _NPersona;
        public string NPersona
        {
            get { return _NPersona; }
            set
            {
                _NPersona = value;
                OnPropertyChanged(nameof(NPersona));
            }
        }

        private string _NPago;
        public string NPago
        {
            get { return _NPago; }
            set
            {
                _NPago = value;
                OnPropertyChanged(nameof(NPago));
            }
        }

        private decimal _MontoPaquete;
        public decimal MontoPaquete
        {
            get { return _MontoPaquete; }
            set
            {
                _MontoPaquete = value;
                OnPropertyChanged(nameof(MontoPaquete));
            }
        }

        private DateTime _FechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set
            {
                _FechaVencimiento = value;
                OnPropertyChanged(nameof(FechaVencimiento));
            }
        }

        private Guid _IdUsuarioL;
        public Guid IdUsuarioL
        {
            get { return _IdUsuarioL; }
            set
            {
                _IdUsuarioL = value;
                OnPropertyChanged(nameof(IdUsuarioL));
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
