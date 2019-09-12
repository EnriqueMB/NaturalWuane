using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System.ComponentModel;
using CIDFares.Spa.Business.ValueObjects;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class PuestoViewModels : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IPuestoRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Puesto> ListaPuesto { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public PuestoViewModels(IPuestoRepository puestoRepository)
        {
            Repository = puestoRepository;
            ListaPuesto = new BindingList<Puesto>();
            GetAllAsync();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método asíncrono que obtiene todos los puestos en una lista.
        /// </summary>
        /// <returns></returns>
        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaPuesto.Clear();
                foreach (var item in x)
                {
                    ListaPuesto.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método asíncrono que agrega o actualiza un puesto.
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<Puesto> ACPuesto(Guid IdUsuario)
        {
            try
            {
                Puesto puesto = new Puesto
                {
                    IdPuesto = this.IdPuesto,
                    Nombre = this.Nombre,
                    Descripcion = this.Descripcion.Trim()
                };
                if (State == EntityState.Create)
                    return await Repository.AddAsync(puesto, IdUsuario);
                else if (State == EntityState.Update)
                    return await Repository.UpdateAsync(puesto, IdUsuario);
                return puesto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo asincrono que elimina un puesto.
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<int> DeletePuesto(Guid IdUsuario)
        {
            try
            {
                return await Repository.DeleteAsync(IdPuesto, IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
        #endregion


        #region Binding
      /// <summary>
      /// Bindeamos cada una de las propiedades.
      /// </summary>

        private int _IdPuesto;

        public int IdPuesto
        {
            get { return _IdPuesto; }
            set { _IdPuesto = value; OnPropertyChanged(nameof(IdPuesto)); }
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



        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
