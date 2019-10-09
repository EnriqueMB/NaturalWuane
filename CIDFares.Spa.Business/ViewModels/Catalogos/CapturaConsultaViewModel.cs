using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.DTOs;
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
    public class CapturaConsultaViewModel : INotifyPropertyChanged
    {
        #region Propiedades
        public ICapturaConsultaRepository _repository { get; set; }
        public BindingList<CapturaConsulta> _listaConsulta { get; set; }
        public Guid IdConsulta { get; set; }
        public Guid IdUsuario { get; set; }
        public EntityState State { get; set; }

        #region lstDTO
        public BindingList<OpcionCuestionario> dtoEncuestas { get; set; }
        public BindingList<OpcionMedicion> dtoMediciones { get; set; }
        public BindingList<Respuestas> dtoEncuestaOpciones { get; set; }
        public BindingList<Respuestas> dtoRespuestasMultiples { get; set; }
        public BindingList<ComentariosConsulta> dtoComentarios { get; set; }
        #endregion

        #endregion

        #region Constructor
        public CapturaConsultaViewModel(ICapturaConsultaRepository repository)
        {
            _repository = repository;
            _listaConsulta = new BindingList<CapturaConsulta>();

            dtoEncuestas = new BindingList<OpcionCuestionario>();
            dtoMediciones = new BindingList<OpcionMedicion>();
            dtoEncuestaOpciones = new BindingList<Respuestas>();
            dtoRespuestasMultiples = new BindingList<Respuestas>();
            dtoComentarios = new BindingList<ComentariosConsulta>();
        }
        #endregion       

        #region Metodos
        public async Task llenarListaConsultas(string value)
        {
            try
            {
                var x = await _repository.GetAll(value);
                _listaConsulta.Clear();
                foreach (var item in x)
                {
                    _listaConsulta.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ConsultaDto> ObtenerConsultaXId()
        {
            try
            {
                var x = await _repository.ObtenerConsultaXId(IdConsulta, IdUsuario);
                dtoEncuestas.Clear();
                dtoMediciones.Clear();
                dtoEncuestaOpciones.Clear();
                dtoRespuestasMultiples.Clear();
                dtoComentarios.Clear();

                foreach (var item in x.dtoEncuestaConsulta)
                {
                    dtoEncuestas.Add(item);
                }

                foreach (var item in x.dtoMedicionesConsulta)
                {
                    dtoMediciones.Add(item);
                }

                foreach (var item in x.dtoEncuestaConsultaOpciones)
                {
                    dtoEncuestaOpciones.Add(item);
                }
                foreach (var item in x.dtoRespuestaMultiple)
                {
                    dtoRespuestasMultiples.Add(item);
                }
                foreach (var item in x.dtoComentariosConsulta)
                {
                    dtoComentarios.Add(item);
                }
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        #endregion

        #region Binding  

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
