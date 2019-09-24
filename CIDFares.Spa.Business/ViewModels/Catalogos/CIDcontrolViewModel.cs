using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class CIDcontrolViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades
        #endregion

        #region Constructor
        public CIDcontrolViewModel()
        {
        }
        #endregion

        #region Metodos
        #endregion

        #region Databinding
        private string _respuestas;
        public string respuestas
        {
            get { return _respuestas; }
            set { _respuestas = value;
                OnPropertyChanged(respuestas);
            }
        }
        private object _ValueGroupRadioButton;

        public object ValueGroupRadioButton 
        {
            get { return _ValueGroupRadioButton; }
            set { _ValueGroupRadioButton = value;
                OnPropertyChanged(nameof(ValueGroupRadioButton));
            }
        }

  
        private bool _RdioBtonValue;

        public bool RdioBtonValue 
        {
            get { return _RdioBtonValue; }
            set { _RdioBtonValue = value;
                OnPropertyChanged(nameof(RdioBtonValue));
            }
        }

        private Guid _IDPre;

        public Guid IDPre
        {
            get { return _IDPre; }
            set { _IDPre = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _TipoPregunta;

        public string TipoPregunta
        {
            get { return _TipoPregunta; }
            set { _TipoPregunta = value;
                OnPropertyChanged(nameof(TipoPregunta));
            }
        }

        private List<Respuestas> _ListaOpciones;

        public List<Respuestas> ListaOpciones
        {
            get { return _ListaOpciones; }
            set { _ListaOpciones = value;
                OnPropertyChanged(nameof(ListaOpciones));
            }
        }
        private bool _respuestasMultiples;

        public bool respuestasMultiples 
        {
            get { return _respuestasMultiples; }
            set { _respuestasMultiples = value;
                OnPropertyChanged(nameof(respuestasMultiples));                    
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
