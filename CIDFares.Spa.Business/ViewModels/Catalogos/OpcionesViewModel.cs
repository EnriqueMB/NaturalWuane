using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class OpcionesViewModel : INotifyPropertyChanged
    {
        #region Propiedades
        public IopcionesRepository _repository { get; set; }
        public BindingList<OpcionCuestionario> _listaCuestionario { get; set; }
        #endregion

        #region Constructor
        public OpcionesViewModel(IopcionesRepository repository)
        {
            _repository = repository;
            _listaCuestionario = new BindingList<OpcionCuestionario>();
            llenarListaEncuesta();
        }
        #endregion

        #region Metodos
        public async Task llenarListaEncuesta()
        {
            try
            {
                var x = await _repository.GetAllAsync();
                _listaCuestionario.Clear();
                foreach (var item in x)
                {
                    _listaCuestionario.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
