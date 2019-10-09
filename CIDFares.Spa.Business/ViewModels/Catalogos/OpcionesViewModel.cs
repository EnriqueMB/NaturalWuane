using CIDFares.Spa.Business.ValueObjects;
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
    public class OpcionesViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades
        public IopcionesRepository _repository { get; set; }
        public BindingList<OpcionCuestionario> _listaCuestionario { get; set; }
        public BindingList<OpcionMedicion> _ListaMediciones { get; set; }
        public BindingList<Consulta> _ListaTipoconsulta { get; set; }
        public BindingList<ComentariosConsulta> _listaComentario { get; set; }
        public BindingList<Cliente> ListaCliente { get; set; }
        #region Tablas
        public DataTable _tablaMedicion { get; set; }
        public DataTable _tablaRespuestasMultiple { get; set; }
        public DataTable _tablaRespuestas { get; set; }
        public DataTable _tablaComentario { get; set; }
        public DataTable _tablaCuestionario { get; set; }

        #endregion
        public Guid IdCliente { get; set; }
        public Guid idUsuario { get; set; }
        public Guid IdConsulta { get; set; }
        public EntityState State { get; set; }
        
        #endregion

        #region Constructor
        public OpcionesViewModel(IopcionesRepository repository)
        {
            _repository = repository;
            _listaCuestionario = new BindingList<OpcionCuestionario>();
            _ListaMediciones = new BindingList<OpcionMedicion>();
            _ListaTipoconsulta = new BindingList<Consulta>();
            _listaComentario = new BindingList<ComentariosConsulta>();
            ListaCliente = new BindingList<Cliente>();
            //llenarListaEncuesta();
            //llenarListaMediciones();
            //listaTipoConsulta();        
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await _repository.GetCliente();
                ListaCliente.Clear();
                foreach (var item in x)
                {
                    ListaCliente.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
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
        
        public async Task<int> GuardarConsulta()
        {
            try
            {
                CapturaConsulta model = new CapturaConsulta();
                model.Observaciones = Observaciones;
                model.Recomendaciones = Recomendaciones;
                model.Diagnostico = Diagnostico;
                model.IdCliente = IdCliente;
                model.Fecha = FechaConsulta;// DateTime.Now;
                if (State == EntityState.Create)
                {            
                    return await _repository.GuardarEncuesta(idUsuario, IdTipoConsulta, model, _tablaRespuestas, _tablaRespuestasMultiple, _tablaMedicion, _tablaComentario, _tablaCuestionario);
                }
                else if (State == EntityState.Update)
                {     
                    return await _repository.UpdateEncuesta(IdConsulta, idUsuario, IdTipoConsulta, model, _tablaRespuestas, _tablaRespuestasMultiple, _tablaMedicion, _tablaComentario, _tablaCuestionario);
                }
                return -1;
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
        private string _Observaciones;

        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value;
                OnPropertyChanged(nameof(Observaciones));
            }
        }
        private string _Recomendaciones;

        public string Recomendaciones
        {
            get { return _Recomendaciones; }
            set { _Recomendaciones = value;
                OnPropertyChanged(nameof(Recomendaciones));
            }
        }
        private string _Diagnostico;

        public string Diagnostico
        {
            get { return _Diagnostico; }
            set { _Diagnostico = value;
                OnPropertyChanged(nameof(Diagnostico));
            }
        }
        private string _comentarios;

        public string comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value;
                OnPropertyChanged(nameof(comentarios));
            }
        }
        private DateTime _FechaConsulta;

        public DateTime FechaConsulta
        {
            get { return _FechaConsulta; }
            set { _FechaConsulta = value;
                OnPropertyChanged(nameof(FechaConsulta));
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
