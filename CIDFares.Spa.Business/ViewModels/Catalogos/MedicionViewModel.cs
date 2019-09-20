using CIDFares.Spa.Business.ValueObjects;
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
    public class MedicionViewModel
    {
        #region Propiedades Privadas
        private IMedicionRepository MedicionRepository { get; set; }
        private IListaMedicionRepository ListaMedicionRepository { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Medicion> ListaMedicion { get; set; }
        public BindingList<ListaMedicion> ListaValoresMedicion { get; set; }
        public EntityState State { get; set; }
        #endregion

        #region Constructor
        public MedicionViewModel(IMedicionRepository medicionRepository, IListaMedicionRepository listaMedicionRepository, BindingList<Medicion> listaMedicion, BindingList<ListaMedicion> listaValoresMedicion)
        {
            MedicionRepository = medicionRepository;
            ListaMedicionRepository = listaMedicionRepository;
            ListaMedicion = listaMedicion;
            ListaValoresMedicion = listaValoresMedicion;
        }
        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var list = await MedicionRepository.GetAllAsync();
                ListaMedicion.Clear();
                foreach (var item in list)
                {
                    ListaMedicion.Add(item);
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
        public async Task<Medicion> GuardarCambios(object IdUsuario)
        {
            try
            {
                Medicion medicion = new Medicion();
                if (State == EntityState.Create)
                {
                    medicion.Nombre = Nombre;
                    medicion.IdUnidaMedida = (EsAbierta == true) ? 0 : IdUnidaMedida;
                    medicion.EsAbierta = EsAbierta;
                    medicion.IdListaMedicion = IdListaMedicion;
                    medicion = await MedicionRepository.AddAsync(medicion, IdUsuario);

                }else if(State == EntityState.Update)
                {
                    medicion.IdMedicion = IdMedicion;
                    medicion.Nombre = Nombre;
                    medicion.IdUnidaMedida = (EsAbierta == true) ? 0 : IdUnidaMedida;
                    medicion.EsAbierta = EsAbierta;
                    medicion.IdListaMedicion = IdListaMedicion;
                    medicion = await MedicionRepository.AddAsync(medicion, IdUsuario);
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
