﻿using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class PaqueteViewModel : Validable, INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private IPaqueteRepository Repository { get; set; }
        #endregion

        #region Propiedades Publicas
        public ClienteViewModel ModelCliente { get; set; }
        public BindingList<Paquetes> ListaPaquete { get; set; }
        public BindingList<Paquetes> ListaPaqueteAgendada { get; set; }
        public BindingList<PaqueteDetalle> ListaDetallePaquete { get; set; }
        public BindingList<AbonoPaquete> ListaAbonoPaquete { get; set; }
        public BindingList<AbonoPaquete> ListaEspera { get; set; }
        public EntityState State { get; set; }
        public DataTable TablaProducto { get; set; }
        public DataTable TablaServicio { get; set; }


        public DataTable TablaAbonoPaquete { get; set; }
        #endregion

        #region Constructor

        public PaqueteViewModel(IPaqueteRepository paqueteRepository)
        {
            ModelCliente = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            Repository = paqueteRepository;
            ListaPaquete = new BindingList<Paquetes>();
            ListaDetallePaquete = new BindingList<PaqueteDetalle>();
            ListaAbonoPaquete = new BindingList<AbonoPaquete>();
            ListaEspera = new BindingList<AbonoPaquete>();
            ListaPaqueteAgendada = new BindingList<Paquetes>();
            this.Cantidad = 1;
            this.FolioCliente = string.Empty;
            this.TablaAbonoPaquete = new DataTable();
        }

        #endregion

        #region Metodos
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync();
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetAllAgendada(int idSucursal)
        {
            try
            {
                var x = await Repository.GetAllAgendaAsync(this.IdCliente, idSucursal);
                ListaPaqueteAgendada.Clear();
                foreach (var item in x)
                {
                    ListaPaqueteAgendada.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GetAllAbonoPaquete(int idSucursal)
        {
            try
            {
                var x = await Repository.GetAllAbonoPaqueteAsync(this.IdCliente, idSucursal);
                ListaAbonoPaquete.Clear();
                foreach (var item in x)
                {
                    item.Fecha = item.FechaVenta.ToString("yyyy/MM/dd");
                    ListaAbonoPaquete.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ListaDetalle()
        {
            try
            {
                var x = await Repository.GetAsync(this.IdPaquete);
                ListaDetallePaquete.Clear();
                foreach (var item in x.ListaDetallePaquete)
                {
                    ListaDetallePaquete.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Paquetes> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                Paquetes model = new Paquetes();               
                model.IdPaquete = this.IdPaquete;
                model.Clave = this.Clave;
                model.Nombre = this.Nombre;
                model.Descripcion = this.Descripcion;
                model.NPersona = this.NPersonal;
                model.NPago = this.NPago;
                model.MontoPaquete = this.MontoPaquete;
                model.FechaVencimiento = this.FechaVencimiento;
                model.TablaProducto = this.TablaProducto;
                model.TablaServicio = this.TablaServicio;
                model.UrlImagen = this.UrlImagen;
                if (State == EntityState.Create)
                {
                    model = await Repository.AddAsync(model, IdUsuario);
                }
                else if (State == EntityState.Update)
                {
                    model = await Repository.UpdateAsync(model, IdUsuario);
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync()
        {
            try
            {
                return await Repository.DeleteAsync(this.IdPaquete, this.IdUsuarioL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task BusquedaPaquete()
        {
            try
            {
                var x = await Repository.GetBusqPaqueteAsync(this.BandNombre, this.Nombre, this.BandClave, this.Clave);
                ListaPaquete.Clear();
                foreach (var item in x)
                {
                    ListaPaquete.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Método para subir la imagen al Servidor FTP
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="RemotePath"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<bool> UploadFTP(string FilePath, string RemotePath, string Login, string Password)
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    UrlImagen = RemotePath;
                    FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlImagen);
                    ftp.Credentials = new NetworkCredential(Login, Password);
                    ftp.Method = WebRequestMethods.Ftp.UploadFile;
                    ftp.KeepAlive = false;
                    ftp.UseBinary = true;
                    ftp.ContentLength = fs.Length;
                    ftp.Proxy = null;
                    fs.Position = 0;
                    int buffLength = 2048;
                    byte[] buff = new byte[buffLength];
                    int contentLen;
                    using (Stream strm = ftp.GetRequestStream())
                    {
                        contentLen = fs.Read(buff, 0, buffLength);
                        while (contentLen != 0)
                        {
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //LogError.AddExcFileTxt(ex, "UtilFtp ~ UploadFTP");
                //return false;
                throw ex;
            }
        }

        /// <summary>
        /// Método para descargar la imagen del Servidor FTP
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="RemotePath"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<bool> DownloadFile(string FilePath, string RemotePath, string Login, string Password)
        {
            try
            {
                //string url = Path.Combine(RemotePath, Path.GetFileName(FilePath));
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlImagen);
                ftp.Credentials = new NetworkCredential(Login, Password);
                ftp.Method = WebRequestMethods.Ftp.DownloadFile;
                ftp.KeepAlive = false;
                ftp.UseBinary = true;
                ftp.Proxy = null;
                FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream fs = new FileStream(FilePath, FileMode.Create);
                int ReadCount = stream.Read(buffer, 0, buffer.Length);
                while (ReadCount > 0)
                {
                    fs.Write(buffer, 0, ReadCount);
                    ReadCount = stream.Read(buffer, 0, buffer.Length);
                }
                fs.Close();
                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                //LogError.AddExcFileTxt(ex, "UtilFtp ~ DownloadFile");
                //return false;
                throw ex;
            }
        }

        /// <summary>
        /// Método para convertir de Bytes a Imagen
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        /// <summary>
        /// Método para convertir de Imagen a Bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
        #endregion

        #region Binding(Variables)
        private int _IdPaquete;
        public int IdPaquete
        {
            get { return _IdPaquete; }
            set
            {
                _IdPaquete = value;
                OnPropertyChanged(nameof(IdPaquete));
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

        private string _NPersonal;
        public string NPersonal
        {
            get { return _NPersonal; }
            set
            {
                _NPersonal = value;
                OnPropertyChanged(nameof(NPersonal));
            }
        }

        private string _NPago;
        public string NPago
        {
            get { return _NPago; }
            set
            {
                _NPago = value;
                OnPropertyChanged(nameof(NPago));
            }
        }

        private decimal _MontoPaquete;
        public decimal MontoPaquete
        {
            get { return _MontoPaquete; }
            set
            {
                _MontoPaquete = value;
                OnPropertyChanged(nameof(MontoPaquete));
            }
        }

        private DateTime _FechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set
            {
                _FechaVencimiento = value;
                OnPropertyChanged(nameof(FechaVencimiento));
            }
        }

        private Guid _IdUsuarioL;
        public Guid IdUsuarioL
        {
            get { return _IdUsuarioL; }
            set
            {
                _IdUsuarioL = value;
                OnPropertyChanged(nameof(IdUsuarioL));
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

        private int _Cantidad;
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        private Guid _IdCliente;
        public Guid IdCliente
        {
            get { return _IdCliente; }
            set
            {
                _IdCliente = value;
                OnPropertyChanged(nameof(IdCliente));
            }
        }

        private string _FolioCliente;
        public string FolioCliente
        {
            get { return _FolioCliente; }
            set
            {
                _FolioCliente = value;
                OnPropertyChanged(nameof(FolioCliente));
            }
        }

        private decimal _PagoPaquete;
        public decimal PagoPaquete
        {
            get { return _PagoPaquete; }
            set
            {
                _PagoPaquete = value;
                OnPropertyChanged(nameof(PagoPaquete));
            }
        }

        private decimal _Adeudo;

        public decimal Adeudo
        {
            get { return _Adeudo; }
            set
            {
                _Adeudo = value;
                OnPropertyChanged(nameof(Adeudo));
            }
        }

        private decimal _Total ;

        public decimal Total 
        {
            get { return _Total ; }
            set
            {
                _Total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        #endregion
        #region Binding Imagen
        /// <summary>
        /// Variable para almacenar la url de la imagen(urlFTP)
        /// </summary>
        private string _UrlImagen;

        public string UrlImagen
        {
            get { return _UrlImagen; }
            set
            {
                _UrlImagen = value;
                OnPropertyChanged(nameof(UrlImagen));
            }
        }

        /// <summary>
        /// Propiedad para almacenar la imagen y mostrarlo en el Formulario
        /// </summary>
        private Image _Imagen;

        public Image Imagen
        {
            get { return _Imagen; }
            set
            {
                _Imagen = value;
                OnPropertyChanged(nameof(Imagen));
            }
        }

        /// <summary>
        /// Propiedad Booleana para saber cuando el usuario modificó la imagen
        /// </summary>
        public bool UpdateImagen { get; set; }
        /// <summary>
        /// Propiedad para almacenar la extensión de la imagen
        /// </summary>
        public string Extencion { get; set; }
        /// <summary>
        /// Propiedad para almacenar la ruta de la imagen en Resources
        /// </summary>
        public string RutaAux { get; set; }

        /// <summary>
        /// Propiedad para almacenar la ruta de la imagen a subir
        /// </summary>
        private string _RutaImagen;
        
        public string RutaImagen
        {
            get { return _RutaImagen; }
            set { _RutaImagen = value;
                OnPropertyChanged(nameof(RutaImagen));
            }
        }
        #endregion
    }
}
