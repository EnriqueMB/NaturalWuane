using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
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
    public class ConsultaViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades
        public IConsultaRepository _ConsultaRepository { get; set; }
        public BindingList<Consulta> _ListaTipoconsulta { get; set; }
        public List<Cuestionario> AplicarEncuestaLista { get; set; }

        public List<Respuestas> _listRespuestasMultiples{ get; set; }
        public List<Respuestas> _ListaRespuestasEncuesta { get; set; }
        #endregion

        #region Constructor
        public ConsultaViewModel(IConsultaRepository consultarepository)
        {
            _ConsultaRepository = consultarepository;
            _ListaTipoconsulta = new BindingList<Consulta>();
            AplicarEncuestaLista = new List<Cuestionario>();
            _listRespuestasMultiples = new List<Respuestas>();
            _ListaRespuestasEncuesta = new List<Respuestas>();
            listaTipoConsulta();
        }
        #endregion

        #region Metodos
        public async Task listaTipoConsulta()
        {
            try
            {
                var x = await _ConsultaRepository.LlenarComboTipoConsulta();
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
        public async Task cargarPreguntasEncuesta()
        {
            try
            {
                if (cuestionario != null)
                {
                    var x = await _ConsultaRepository.ObtenerEncuestaXId(cuestionario.IdEncuesta);
                    cuestionario.ListaPreguntas.Clear();
                    foreach (var item in x)
                    {
                        cuestionario.ListaPreguntas.Add(item);
                    }                 
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
            set { _NombreCompleto = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private int _IdTipoConsulta;
        public int IdTipoConsulta
        {
            get { return _IdTipoConsulta; }
            set { _IdTipoConsulta = value;
                OnPropertyChanged(nameof(IdTipoConsulta));
            }
        }

        private Cuestionario _cuestionario;
        public Cuestionario cuestionario
        {
            get { return _cuestionario; }
            set {
                _cuestionario = value;
                OnPropertyChanged(nameof(cuestionario));
            }
        }

        private string _NombreEncuesta;

        public string NombreEncuesta
        {
            get { return _NombreEncuesta; }
            set { _NombreEncuesta = value;
                OnPropertyChanged(nameof(NombreEncuesta));
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
