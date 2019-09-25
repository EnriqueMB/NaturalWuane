using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Paquete
{
    public class AbonoPaqueteDetalleViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IPaqueteRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<AbonoPaqueteDetalle> ListaPaquete { get; set; }
        #endregion

        #region Constructor

        public AbonoPaqueteDetalleViewModel(IPaqueteRepository paqueteRepository)
        {
            Repository = paqueteRepository;
            ListaPaquete = new BindingList<AbonoPaqueteDetalle>();
        }

        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllDetalleAsync(this.IdVentaPaquete);
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    item.Fecha = item.FechaPago.ToString("yyyy/MM/dd");
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        #endregion

        #region Binding(Variables)
        

        private Guid _IdVentaPaquete;

        public Guid IdVentaPaquete
        {
            get { return _IdVentaPaquete; }
            set
            {
                _IdVentaPaquete = value;
                OnPropertyChanged(nameof(IdVentaPaquete));
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
