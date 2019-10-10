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
        private string _Respuesta;
        public string Respuesta
        {
            get { return _Respuesta; }
            set {_Respuesta = value;
                OnPropertyChanged(Respuesta);
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
  
        private bool? _RdioBtonValue;

        public bool? RdioBtonValue 
        {
            get { return _RdioBtonValue; }
            set {
                _RdioBtonValue = value;
                //RadioBtnValueNo = !_RdioBtonValue ?? false;
                OnPropertyChanged(nameof(RdioBtonValue));
                OnPropertyChanged(nameof(RadioBtnValueNo));
            }
        }

        public bool RadioBtnValueNo
        {
            get { return RdioBtonValue is null ? false : (bool)!RdioBtonValue; }

            set { _RdioBtonValue = !value; }
        }

        //private bool _RadioBtnValueNo;

        //public bool RadioBtnValueNo
        //{
        //    get { return _RadioBtnValueNo; }
        //    set {

        //            _RadioBtnValueNo = value;
        //            if(RdioBtonValue is null )
        //                RdioBtonValue = !_RadioBtnValueNo;
        //            OnPropertyChanged(nameof(RadioBtnValueNo));

        //    }
        //}


        public string Pregunta { get; set; }
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
