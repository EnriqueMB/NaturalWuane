﻿using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ServicioViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IServicioRepository Repository { get; set; }
        private IIvaRepository Repositoryiva { get; set; }
        private ITipoServicioRepository RepositoryTipoServicio { get; set; }
        private IPaqueteRepository RepositoryPaquete { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Servicio> ListaServicio { get; set; }
        public BindingList<Iva> ListaIva { get; set; }
        public BindingList<TipoServicio> ListaTipoServicio { get; set; }
        public EntityState State { get; set; }
        #endregion

        public ServicioViewModel(IServicioRepository servicioRepository, IIvaRepository ivaRepository, ITipoServicioRepository tipoServicioRepository, IPaqueteRepository paqueteRepository)
        {
            Repository = servicioRepository;
            RepositoryPaquete = paqueteRepository;
            Repositoryiva = ivaRepository;
            RepositoryTipoServicio = tipoServicioRepository;
            ListaServicio = new BindingList<Servicio>();            
            ListaIva = new BindingList<Iva>();
            ListaTipoServicio = new BindingList<TipoServicio>();
            this.Cantidad = 1;
           // GetAllAsync();
        }

        #region Metodos
        //public async Task GetFoto(Guid IdCliente)
        //{
        //    try
        //    {
        //        var x = await Repository.ObtenerFoto(IdCliente);
        //        this.FotoBase64 = x;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public async Task GetAllServicioPaquete(Paquetes paquete)
        {
            try
            {
                var x = await RepositoryPaquete.GetAsync(paquete.IdPaquete);
                ListaServicio.Clear();
                foreach (var item in x.ListaDetallePaquete)
                {
                    if (item.IdTipo == 2)
                    {
                        Servicio servicio = new Servicio();
                        servicio.Nombre = item.Nombre;
                        servicio.IdServicio = item.IdGenerico;
                        ListaServicio.Add(servicio);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Servicio> GuardarCambios(Guid IdUsuario)
        {
            try
            {                
                Servicio model = new Servicio
                {
                    IdServicio = IdServicio,
                    IdTipoServicio = IdTipoServicio,
                    IdTipoIva = IdTipoIva,
                    Clave = Clave,
                    Nombre = Nombre,
                    Precio = Precio,
                    Duracion = Duracion,                    
                    Descripcion = Descripcion,
                    AplicaIEPS = AplicaIEPS,
                    IEPSMonto = IEPSMonto,
                    IEPS = IEPS,
                    UpdateFoto = UpdateFoto,
                    FotoBase64 = FotoBase64,
                    UrlFoto = ImageLocation,
                    PorcentajePaquete = this.PorcentajeP
                //Base64String = new Bitmap(Foto).ToBase64String(Formato),
                //UrlFoto = UrlFoto
                //Resultado = -2
            };
                if (State == EntityState.Create)
                {
                    return await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    return await Repository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(Guid idUsuario)
        {
            try
            {
                return await Repository.DeleteAsync(IdServicio, idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region ComboIva
        public void LlenarListaTI(IEnumerable<Iva> iva)
        {
            try
            {
                foreach (var item in iva)
                {
                    ListaIva.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
        public async Task<IEnumerable<Iva>> GetListaTipoIva()
        {
            try
            {
                var iva = await Repositoryiva.LlenarComboIva();
                return iva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ComoboTipoServicio
        public void LlenarListaTServicio(IEnumerable<TipoServicio> TipoServicio)
        {
            try
            {
                foreach (var item in TipoServicio)
                {
                    ListaTipoServicio.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public async Task<IEnumerable<TipoServicio>> GetListaTipoServicio()
        {
            try
            {
                var TipoServicio = await RepositoryTipoServicio.LlenarComboTipoServicio();
                return TipoServicio;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }           
        #endregion
        #endregion

        public async Task GetAllAsync()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaServicio.Clear();
                foreach (var item in x)
                {                  
                    //item.DuracionStr = item.Duracion.ToLongTimeString();
                    item.AplicaIvaStr = item.IdTipoIva == 2 ? "SI" : "NO";
                    item.Porcentaje100 = item.Porcentaje == 16 ? item.Porcentaje/100 : item.Porcentaje;                        
                    ListaServicio.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetFoto(int IdServicio)
        {
            try
            {
                var x = await Repository.ObtenerFoto(IdServicio);
                this.FotoBase64 = x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task BusquedaServicio()
        {
            try
            {
                var x = await Repository.GetBusqServicioAsync(this.BandNombre, this.Nombre, this.BandClave, this.Clave);
                ListaServicio.Clear();
                foreach (var item in x)
                {
                    ListaServicio.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        #region Binding(Variables)
        private int _IdServicio = 0;
        public int IdServicio
        {
            get { return _IdServicio; }
            set
            {
                _IdServicio = value;
                OnPropertyChanged(nameof(IdServicio));
            }
        }

        private int _IdTipoServicio;
        public int IdTipoServicio
        {
            get { return _IdTipoServicio; }
            set
            {
                _IdTipoServicio = value;
                OnPropertyChanged(nameof(IdTipoServicio));
            }
        }

        private int _IdTipoIva;
        public int IdTipoIva
        {
            get { return _IdTipoIva; }
            set
            {
                _IdTipoIva = value;
                OnPropertyChanged(nameof(IdTipoIva));
            }
        }       

        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set
            {
                _Clave = value;
                OnPropertyChanged(nameof(Clave));
            }
        }

        //private string _TipoServicio;

        //public string TipoServicio
        //{
        //    get { return _TipoServicio; }
        //    set
        //    {
        //        _TipoServicio = value;

        //        OnPropertyChanged(nameof(TipoServicio));
        //    }
        //}

        private string _Nombre = "";
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private decimal _Precio;
        public decimal Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private DateTime _Duracion;

        public DateTime Duracion
        {
            get { return _Duracion; }
            set
            {
                _Duracion = value;
                OnPropertyChanged(nameof(Duracion));
            }
        }


        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }
        private decimal _Porcentaje100;
        public decimal Porcentaje100
        {
            get { return _Porcentaje/100; }
            set
            {
                _Porcentaje100 = value;
                OnPropertyChanged(nameof(Porcentaje100));
            }
        }
        private decimal _Porcentaje;
        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set
            {
                _Porcentaje = value;
                OnPropertyChanged(nameof(Porcentaje));
            }
        }
        

        private string _DescIva;
        public string DescIva
        {
            get { return _DescIva; }
            set
            {
                _DescIva = value;
                OnPropertyChanged(nameof(DescIva));
            }
        }

        private bool _AplicaIva;
        public bool AplicaIva
        {
            get { return _AplicaIva; }
            set
            {
                _AplicaIva = value;
                OnPropertyChanged(nameof(AplicaIva));
            }
        }

        private bool _AplicaIEPS;
        public bool AplicaIEPS
        {
            get { return _AplicaIEPS; }
            set
            {
                _AplicaIEPS = value;
                OnPropertyChanged(nameof(AplicaIEPS));
            }
        }

        private bool _IEPSMonto;
        public bool IEPSMonto
        {
            get { return _IEPSMonto; }
            set
            {
                _IEPSMonto = value;
                OnPropertyChanged(nameof(IEPSMonto));
            }
        }

        private decimal _IEPS;
        public decimal IEPS
        {
            get { return _IEPS; }
            set
            {
                _IEPS = value;
                OnPropertyChanged(nameof(IEPS));
            }
        }

        private bool _BandNombre;
        public bool BandNombre
        {
            get { return _BandNombre; }
            set
            {
                _BandNombre = value;
                OnPropertyChanged(nameof(BandNombre));
            }
        }

        private bool _BandClave;
        public bool BandClave
        {
            get { return _BandClave; }
            set
            {
                _BandClave = value;
                OnPropertyChanged(nameof(BandClave));
            }
        }

        private decimal _PorcentajeP;

        public decimal PorcentajeP
        {
            get { return _PorcentajeP; }
            set
            {
                _PorcentajeP = value;
                OnPropertyChanged(nameof(PorcentajeP));
            }
        }


        #region FOTO        
        private string _FotoBase64 = "";
        public string FotoBase64
        {
            get { return _FotoBase64; }
            set
            {
                _FotoBase64 = value;
                OnPropertyChanged(nameof(FotoBase64));
            }
        }

        //private string _BaseString64;

        //public string BaseString64
        //{
        //    get { return _BaseString64; }
        //    set { _BaseString64 = value; OnPropertyChanged("BaseString64"); }
        //}

        private bool _UpdateFoto;
        public bool UpdateFoto
        {
            get { return _UpdateFoto; }
            set
            {
                _UpdateFoto = value;
                OnPropertyChanged(nameof(UpdateFoto));
            }
        }

        private string _ImageLocation = "";
        public string ImageLocation
        {
            get { return _ImageLocation; }
            set
            {
                _ImageLocation = value; OnPropertyChanged(nameof(ImageLocation));
                if (ImageLocation != string.Empty)
                {
                    try
                    {
                        Foto = Image.FromFile(_ImageLocation);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private string _Extencion;
        public string Extencion
        {
            get { return _Extencion; }
            set
            {
                _Extencion = value;
                OnPropertyChanged(nameof(Extencion));
            }
        }

        private ImageFormat _FormatoImg;

        public ImageFormat FormatoImg
        {
            get { return _FormatoImg; }
            set
            {
                _FormatoImg = value;
                OnPropertyChanged(nameof(FormatoImg));
            }
        }

        private Image _Foto;
        public Image Foto
        {
            get { return _Foto; }
            set
            {
                _Foto = value;
                OnPropertyChanged(nameof(Foto));
            }
        }

        #endregion
        private decimal _Cantidad;
        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
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
