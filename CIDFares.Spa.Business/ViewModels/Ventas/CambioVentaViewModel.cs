using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Ventas
{
    public class CambioVentaViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ICambioVentaRepository Repository { get; set; }
        #endregion
        #region Propiedades publicas
        public BindingList<CambioVenta> ListaTurnoEmpleado { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CambioVentaViewModel(ICambioVentaRepository repository)
        {
            CambioTurno = 0;
            Repository = repository;
            ListaTurnoEmpleado = new BindingList<CambioVenta>();
        }
        #endregion

        #region Metodos

        public async Task<int> CargarDatos(int IdSucursal, Guid IdEmpleado, int IdTurnoEmpleado)
        {
            try
            {
                var cambio = await Repository.ObtenerCambio(IdSucursal, IdEmpleado, IdTurnoEmpleado);
                return cambio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CambioVenta> GuardarCambios(Guid IdUsuario, int IdSucursal, Guid IdEmpleado, int IdTurnoEmpleado)
        {
            try
            {
                CambioVenta model = new CambioVenta
                {

                    IdSucursal = IdSucursal,
                    IdEmpleado = IdEmpleado,
                    IdTurnoEmpleado = IdTurnoEmpleado,
                   CambioTurno = CambioTurno
                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateCambioWithIdSucursalAsync(model, IdSucursal, IdEmpleado, IdTurnoEmpleado);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private int _IdTurnoEmpleado;

        public int IdTurnoEmpleado
        {
            get { return _IdTurnoEmpleado; }
            set {
                _IdTurnoEmpleado = value;
                OnPropertyChanged(nameof(IdTurnoEmpleado));
            }
        }

        private Guid _IdEmpleado;

        public Guid IdEmpleado
        {
            get { return _IdEmpleado; }
            set {
                _IdEmpleado = value;
                OnPropertyChanged(nameof(IdEmpleado));
            }
        }

        private int _IdSucursal;

        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value;
                OnPropertyChanged(nameof(IdSucursal));
            }
        }

        private decimal _CambioTurno;

        public decimal CambioTurno
        {
            get { return _CambioTurno; }
            set { _CambioTurno = value;
                OnPropertyChanged(nameof(CambioTurno));
            }
        }

        #endregion

        #region InotityPropertyChanged Member
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
