using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class AlimentoViewModels : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IAlimentoRepository IAlimento { get; set; }
        private ITipoAlimentoRepository ITipoAlimento { get; set; }
        #endregion

        #region Propiedades Publicas
        public BindingList<Alimento> ListaAlimentos { get; set; }
        public BindingList<TipoAlimento> ListaTipoAlimentos { get; set; }
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
        public AlimentoViewModels(IAlimentoRepository alimentoRepository, ITipoAlimentoRepository tipoAlimentoRepository)
        {
            IAlimento = alimentoRepository;
            ITipoAlimento = tipoAlimentoRepository;
            ListaAlimentos = new BindingList<Alimento>();
            ListaTipoAlimentos = new BindingList<TipoAlimento>();
            Busqueda = string.Empty;
            //GetAllAsync();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método que manda a llamar el GetAllAsync de la clase
        /// repositorio para obtener la lista de los alimentos y guardarlos
        /// en una lista
        /// </summary>
        /// <returns></returns>
        public async Task GetAllAsync()
        {
            try
            {
                var x = await IAlimento.GetAllAsync(Page, Opcion);
                if(x.Count == 0)
                {
                    PaginaMaxima = true;
                }
                else
                {
                    if (Opcion > 1)
                        ListaAlimentos.Clear();
                    foreach (var item in x)
                    {
                        ListaAlimentos.Add(item);
                    }
                    PaginaMaxima = false;//Reseteamos el bit para que cada vez que se agrege un nuevo registro, podamos actualizar la vista.
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los datos de un registro de alimento según su IdAlimento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task GetAllAsyncXId(int id)
        {
            try
            {
                var x = await IAlimento.GetAsync(id);
                Nombre = x.Nombre;
                IdAlimento = x.IdAlimento;
                IdTipoAlimento = x.IdTipoAlimento;
                Calorias = x.Calorias;
                HidratosCarbono = x.HidratosCarbono;
                Proteina = x.Proteina;
                Grasa = x.Grasa;
                Fibra = x.Fibra;
                //return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Busca un registro con el nombre que se le pase como parámetro
        /// </summary>
        /// <param name="Busqueda"></param>
        /// <returns></returns>
        public async Task GetBusqueda(string Busqueda)
        {
            try
            {
                var x = await IAlimento.GetBusquedaAlimentoAsync(Busqueda);
                ListaAlimentos.Clear();
                foreach (var item in x)
                {

                    ListaAlimentos.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Método que manda a llamar el método para crear o actulizar un alimento
        /// según sea el caso.
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<Alimento> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Alimento model = new Alimento
                {
                    IdAlimento = this.IdAlimento,
                    IdTipoAlimento = this.IdTipoAlimento,
                    Nombre = this.Nombre,
                    Calorias = this.Calorias,
                    HidratosCarbono = this.HidratosCarbono,
                    Proteina = this.Proteina,
                    Grasa = this.Grasa,
                    Fibra = this.Fibra,
                    IdUsuario = this.IdUsuario
                };
                if (State == EntityState.Create)
                {
                    return await IAlimento.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    return await IAlimento.UpdateAsync(model, IdUsuario);
                }

                return model;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Método que manda a llamar el método de eliminar del de la clase repositorio
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(Guid IdUsuario)
        {
            try
            {
                return await IAlimento.DeleteAsync(IdAlimento , IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método donde de llena la lista de tipoAlimento
        /// </summary>
        /// <param name="tipo"></param>
        #region Combo Tipo de Alimento
        public void LlenarTipoAlimento(IEnumerable<TipoAlimento> tipo)
        {
            ListaTipoAlimentos.Clear();
            foreach (var item in tipo)
            {
                ListaTipoAlimentos.Add(item);
            }
        }

        /// <summary>
        /// Método donde se manda a llamar el metodo de obtener la lista de tipos de alimentos
        /// desde el repositorio
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TipoAlimento>> GetListaTipo()
        {
            try
            {
                var tipo = await ITipoAlimento.GetComboTipoAlimento();
                return tipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion

        #region Binding
        /// <summary>
        /// Id del alimento
        /// </summary>
        private int _IdAlimento;

        public int IdAlimento
        {
            get { return _IdAlimento; }
            set { _IdAlimento = value;
                OnPropertyChanged(nameof(IdAlimento));
            }
        }

        /// <summary>
        /// Id del tipo de alimento que corresponde dicho alimento
        /// </summary>
        private int _IdTipoAlimento;

        public int IdTipoAlimento
        {
            get { return _IdTipoAlimento; }
            set { _IdTipoAlimento = value;
                OnPropertyChanged(nameof(IdTipoAlimento));
            }
        }

        /// <summary>
        /// Nombre del alimento
        /// </summary>
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        /// <summary>
        /// Cantidad de calorias que aporta el alimento
        /// </summary>
        private decimal _Calorias;

        public decimal Calorias
        {
            get { return _Calorias; }
            set
            {
                _Calorias = value; 
                OnPropertyChanged(nameof(Calorias));
            }
        }

        /// <summary>
        /// Cantidad de Hidratos de carbono que aporta
        /// el alimento
        /// </summary>
        private decimal _HidratosCarbono;

        public decimal HidratosCarbono
        {
            get { return _HidratosCarbono; }
            set
            {
                _HidratosCarbono = value;
                OnPropertyChanged(nameof(HidratosCarbono));
            }
        }

        /// <summary>
        /// Cantidad de proteina que aporta el alimento
        /// </summary>
        private decimal _Proteina;

        public decimal Proteina
        {
            get { return _Proteina; }
            set
            {
                _Proteina = value;
                OnPropertyChanged(nameof(Proteina));
            }
        }

        /// <summary>
        /// Cantidad de grasa que aporta el alimento
        /// </summary>
        private decimal _Grasa;

        public decimal Grasa
        {
            get { return _Grasa; }
            set
            {
                _Grasa = value;
                OnPropertyChanged(nameof(Grasa));
            }
        }

        /// <summary>
        /// Cantidad de fibra que aporta el alimento
        /// </summary>
        private decimal _Fibra;

        public decimal Fibra
        {
            get { return _Fibra; }
            set { _Fibra = value;
                OnPropertyChanged(nameof(Fibra));
            }
        }

        /// <summary>
        /// Id del usuario, se usa para cuando se
        /// inserta o modifica un alimento para saber
        /// el responsable de dicha acción.
        /// </summary>
        private Guid? _IdUsuario;

        public Guid? IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value;
                OnPropertyChanged(nameof(IdUsuario));
            }
        }

        /// <summary>
        /// Cadena que almacena el nombre del alimento a buscar
        /// </summary>
        private string _Busqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set { _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
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
