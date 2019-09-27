using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ContestarMedicionViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades
        public List<Medicion> _listaMedicion { get; set; }
        public IContestarMedicionRepository _repsitory { get; set; }

        public BindingList<ValorLista> listaValor { get; set; }
        #endregion

        #region Constructor
        public ContestarMedicionViewModel(IContestarMedicionRepository repository)
        {
            _listaMedicion = new List<Medicion>();
            listaValor = new BindingList<ValorLista>();
            _repsitory = repository;
        }
        #endregion

        #region Metodos
        public async Task<IEnumerable<ValorLista>> llenarlistaValor(int IdListaMedicion)
        {
            try
            {
                var x = await _repsitory.llenarListaValorxId(IdListaMedicion);
                return x;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private string _txtValor;

        public string txtValor
        {
            get { return _txtValor; }
            set { _txtValor = value; }
        }

        //private List<> _lstValor;

        //public List<> lstValor
        //{
        //    get { return _lstValor; }
        //    set { _lstValor = value; }
        //}

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
