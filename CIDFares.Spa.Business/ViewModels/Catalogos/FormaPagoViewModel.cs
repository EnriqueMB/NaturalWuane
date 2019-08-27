using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class FormaPagoViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IFormaPagoRepository Repository { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<FormaPago> ListaFormaPago { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public FormaPagoViewModel(IFormaPagoRepository formaPagoRepository)
        {
            Repository = formaPagoRepository;
            ListaFormaPago = new BindingList<FormaPago>();
            GetAllAsync();
        }
        #endregion

        #region Metodos
        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaFormaPago.Clear();
                foreach (var item in x)
                {
                    ListaFormaPago.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<FormaPago> GuardarCambios()
        {
            try
            {
                FormaPago model = new FormaPago
                {
                    IdFormaPago = IdFormaPago,
                    Nombre = Nombre.Trim(),
                    Descripcion = Descripcion.Trim(),
                    Resultado = -2
                };
                if (State == EntityState.Create)
                {
                    return await Repository.AddAsync(model);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateAsync(model);
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
                return await Repository.DeleteAsync(IdFormaPago);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Binding
        private int _IdFormaPago;

        public int IdFormaPago         
        {
            get { return _IdFormaPago; }
            set
            {
                _IdFormaPago = value;
                OnPropertyChanged(nameof(IdFormaPago));
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
