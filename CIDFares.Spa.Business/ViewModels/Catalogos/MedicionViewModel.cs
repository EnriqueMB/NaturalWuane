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

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class MedicionViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IMedicionRepository MedicionRepository { get; set; }
        private IListaMedicionRepository ListaMedicionRepository { get; set; }
        private IUnidadMedidaRepository UnidadMedidaRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Medicion> ListaMedicion { get; set; }
        public BindingList<ListaMedicion> ListaValoresMedicion { get; set; }
        public BindingList<UnidadMedida> ListaUnidadMedida { get; set; }
        public EntityState State { get; set; }
        /// <summary>
        /// Almacena el número de pagina siguiente o actual según el caso
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// Almacen si el el grid debe recargarse con los elementos actuales
        /// ó obtener los nuevos registros de l siguiente página
        /// </summary>
        public int Opcion { get; set; }
        /// <summary>
        /// Almacena un bit para saber si ya se llego a la pagina maxima
        /// o cuendo ya la lista viene vacia.
        /// </summary>
        public bool PaginaMaxima { get; set; }
        #endregion

        #region Constructor
        public MedicionViewModel(IMedicionRepository medicionRepository, IListaMedicionRepository listaMedicionRepository, IUnidadMedidaRepository unidadMedidaRepository)
        {
            MedicionRepository = medicionRepository;
            ListaMedicionRepository = listaMedicionRepository;
            UnidadMedidaRepository = unidadMedidaRepository;
            ListaMedicion = new BindingList<Medicion>(); 
            ListaValoresMedicion = new BindingList<ListaMedicion>();
            ListaUnidadMedida = new BindingList<UnidadMedida>();
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var list = await MedicionRepository.GetAllAsync(Page, Opcion);
                if (list.Count == 0)
                    PaginaMaxima = true;
                else
                {
                    if(Opcion > 1)
                        ListaMedicion.Clear();
                    foreach (var item in list)
                    {
                        ListaMedicion.Add(item);
                    }
                    PaginaMaxima = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ListaMedicion>> GetListaMedicionsAsync()
        {
            try
            {
                var lista = await ListaMedicionRepository.GetAllAsync();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void LlenarListaMedicion(IEnumerable<ListaMedicion> lista)
        {
            try
            {
                ListaValoresMedicion.Clear();
                foreach (var item in lista)
                {
                    ListaValoresMedicion.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<UnidadMedida>> GetListaUnidadMedida()
        {
            try
            {
                var lista = await UnidadMedidaRepository.LlenarComboUnidadMedida();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaUnidadMedida(IEnumerable<UnidadMedida> lista)
        {
            try
            {
                ListaUnidadMedida.Clear();
                foreach (var item in lista)
                {
                    ListaUnidadMedida.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Medicion> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Medicion medicion = new Medicion();
                if (State == EntityState.Create)
                {
                    medicion.Nombre = Nombre;
                    medicion.IdUnidaMedida = IdUnidaMedida;
                    medicion.EsAbierta = EsAbierta;
                    medicion.IdListaMedicion = (EsAbierta == true) ? 0 : IdListaMedicion;
                    medicion.IdUsuario = IdUsuario;
                    medicion = await MedicionRepository.AddAsync(medicion, IdUsuario);

                }else if(State == EntityState.Update)
                {
                    medicion.IdMedicion = IdMedicion;
                    medicion.Nombre = Nombre;
                    medicion.IdUnidaMedida = IdUnidaMedida;
                    medicion.EsAbierta = EsAbierta;
                    medicion.IdListaMedicion = (EsAbierta == true) ? 0 : IdListaMedicion;
                    medicion.IdUsuario = IdUsuario;
                    medicion = await MedicionRepository.UpdateAsync(medicion, IdUsuario);
                }
                return medicion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete(object IdUsuario)
        {
            try
            {
                var result = await MedicionRepository.DeleteAsync(IdMedicion, IdUsuario);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ValidarNombre()
        {
            try
            {
                var result = await MedicionRepository.NameExistAsync(Nombre.Trim());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteListaMedicion(object IdUsuario)
        {
            try
            {
                var result = await ListaMedicionRepository.DeleteAsync(IdListaMedicion, IdUsuario);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding
        private int _IdMedicion;

        public int IdMedicion
        {
            get { return _IdMedicion; }
            set { _IdMedicion = value; }
        }

        private int _IdUnidaMedida;

        public int IdUnidaMedida
        {
            get { return _IdUnidaMedida; }
            set { _IdUnidaMedida = value;  OnPropertyChanged(nameof(IdUnidaMedida)); }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged(nameof(Nombre)); }
        }

        private bool _EsAbierta;

        public bool EsAbierta
        {
            get { return _EsAbierta; }
            set { _EsAbierta = value; OnPropertyChanged(nameof(EsAbierta)); }
        }

        private int _IdListaMedicion;

        public int IdListaMedicion
        {
            get { return _IdListaMedicion; }
            set { _IdListaMedicion = value; }
        }

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}
