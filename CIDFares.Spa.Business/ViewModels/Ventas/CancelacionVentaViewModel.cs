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
    public class CancelacionVentaViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        public ICancelacionVentaRepository RepositoryCancelacionVenta{ get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<VentaDetalle> ListaVentaDetalle { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public CancelacionVentaViewModel(ICancelacionVentaRepository cancelacionVentaRepository)
        {
            RepositoryCancelacionVenta = cancelacionVentaRepository;
            ListaVentaDetalle = new BindingList<VentaDetalle>();
        }
        #endregion

        #region Metodo
        public async Task<VentasCancelaciones> GuardarCancelacion(Guid IdUsuario)
        {
            VentasCancelaciones model = new VentasCancelaciones
            {
                IdCancelacionVenta = this.IdCancelacionVenta,
                IdVenta = this.IdVenta,
                MotivoCancelacion = this.Motivo
            };
            return await RepositoryCancelacionVenta.AddAsync(model, IdUsuario);
        }

        public async Task GetAllxID()
        {
            try
            {
                var x = await RepositoryCancelacionVenta.GetAsync(this.IdVenta);
                ListaVentaDetalle.Clear();
                foreach (var item in x.ListaVentaDetalle)
                {
                    ListaVentaDetalle.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region Binding
        private Guid _IdCancelacionVenta;
        public Guid IdCancelacionVenta
        {
            get { return _IdCancelacionVenta; }
            set
            {
                _IdCancelacionVenta = value;
                OnPropertyChanged(nameof(IdCancelacionVenta));
            }
        }

        private Guid _IdVenta;
        public Guid IdVenta
        {
            get { return _IdVenta; }
            set
            {
                _IdVenta = value;
                OnPropertyChanged(nameof(IdVenta));
            }
        }

        private string _Motivo;
        public string Motivo
        {
            get { return _Motivo; }
            set
            {
                _Motivo = value;
                OnPropertyChanged(nameof(Motivo));
            }
        }

        private string _Folio;
        public string Folio
        {
            get { return _Folio; }
            set
            {
                _Folio = value;
                OnPropertyChanged(nameof(Folio));
            }
        }

        #region InotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}
