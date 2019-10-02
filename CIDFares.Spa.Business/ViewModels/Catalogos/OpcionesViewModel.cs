using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public BindingList<OpcionMedicion> _ListaMediciones { get; set; }

        public BindingList<Consulta> _ListaTipoconsulta { get; set; }

        public DataTable _tablaMedicion { get; set; }
        #endregion

        #region Constructor
        public OpcionesViewModel(IopcionesRepository repository)
        {
            _repository = repository;
            _listaCuestionario = new BindingList<OpcionCuestionario>();
            _ListaMediciones = new BindingList<OpcionMedicion>();
            _ListaTipoconsulta = new BindingList<Consulta>();
            llenarListaEncuesta();
            listaTipoConsulta();
        }
        #endregion

        #region Metodos
        public async Task listaTipoConsulta()
        {
            try
            {
                var x = await _repository.LlenarComboTipoConsulta();
                _ListaTipoconsulta.Clear();
                foreach (var item in x)
                {
                    _ListaTipoconsulta.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public async Task llenarListaMediciones()
        {
            try
            {
                var x = await _repository.CargarGridMediciones();
                _ListaMediciones.Clear();
                foreach (var item in x)
                {
                    _ListaMediciones.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private string _NombreCompleto;
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set
            {
                _NombreCompleto = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private int _IdTipoConsulta;
        public int IdTipoConsulta
        {
            get { return _IdTipoConsulta; }
            set
            {
                _IdTipoConsulta = value;
                OnPropertyChanged(nameof(IdTipoConsulta));
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
