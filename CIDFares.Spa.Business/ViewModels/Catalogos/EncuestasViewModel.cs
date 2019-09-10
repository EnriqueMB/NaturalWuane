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
    public class EncuestasViewModel : Validable, INotifyPropertyChanged
    {     
        #region Propiedades
        private ICuestionarioRepository _cuestionarioRepository { get; set; }
        public BindingList<Cuestionario> _ListaTipoEncuesta { get; set; }

        public DataTable TblPregunta { get; set; }
        public DataTable TblRespuesta { get; set; }
        #endregion

        #region Constructor
        public EncuestasViewModel(ICuestionarioRepository cuestionarioRepository)
        {
            _cuestionarioRepository = cuestionarioRepository;
            _ListaTipoEncuesta = new BindingList<Cuestionario>();          
        }
        #endregion

        #region Metodos
        public async Task InitComboTipoEncuesta()
        {
            try
            {
                var x = await _cuestionarioRepository.LlenarComboTipoEncuesta();
                _ListaTipoEncuesta.Clear();
                foreach (var item in x)
                {
                    _ListaTipoEncuesta.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> GuardarEncuesta(Guid idUsuario)
        {
            try
            {
               return await _cuestionarioRepository.GuardarEncuesta(NombreEncuesta,IdTipoEncuesta,idUsuario,TblPregunta,TblRespuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private int _IdTipoEncuesta;

        public int IdTipoEncuesta
        {
            get { return _IdTipoEncuesta; }
            set { _IdTipoEncuesta = value;
                OnPropertyChanged(nameof(IdTipoEncuesta));
            }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        private string _Pregunta;

        public string Pregunta
        {
            get { return _Pregunta; }
            set { _Pregunta = value;
                OnPropertyChanged(nameof(Pregunta));
            }
        }

        private Guid _IdPregunta;

        public Guid IdPregunta
        {
            get { return _IdPregunta; }
            set { _IdPregunta = value;
                OnPropertyChanged(nameof(IdPregunta));
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

        private string _Respuesta;
        public string Respuesta
        {
            get { return _Respuesta; }
            set { _Respuesta = value; }
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
