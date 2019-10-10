using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.DataAccess.Contracts.DTOs;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.Business.ViewModels.Catalogos
{
    public class ClienteViewModel: Validable, INotifyPropertyChanged
    {
        #region Propiedades privadas
        private IClienteRepository Repository { get; set; }
        private IDireccionesClienteRepository RepositoryDirecciones { get; set; }
        #endregion

        #region Propiedades públicas
        public BindingList<Cliente> ListaCliente { get; set; }
        public List<DireccionesCliente> ListaDirecciones { get; set; }
        public List<DireccionesClienteRequest> ListaDireccionesR { get; set; }
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
        public ClienteViewModel(IClienteRepository clienteRepository, IDireccionesClienteRepository direccionesClienteRepository)
        {
            Repository = clienteRepository;
            RepositoryDirecciones = direccionesClienteRepository;
            ListaCliente = new BindingList<Cliente>();
            ListaDirecciones = new List<DireccionesCliente>();
            ListaDireccionesR = new List<DireccionesClienteRequest>();
        }
        #endregion

        #region Metodos
        public List<DireccionesCliente> GuardarLista()
        {
            try
            {
                List<DireccionesCliente> listaDirecciones = new List<DireccionesCliente>();
                DireccionesCliente direcciones;
                foreach (var item in ListaDireccionesR)
                {
                    direcciones = new DireccionesCliente();
                    direcciones.Calle = item.Calle;
                    direcciones.EntreCalles = item.EntreCalles;
                    direcciones.Colonia = item.Colonia;
                    direcciones.Referencias = item.Referencias;
                    direcciones.CodigoPostal = item.CodigoPostal;
                    direcciones.NumeroInterior = item.NumeroInterior;
                    direcciones.NumeroExterior = item.NumeroExterior;
                    direcciones.Contacto = item.Contacto;
                    direcciones.TelefonoContacto = item.TelefonoContacto;
                    direcciones.IdEstado = item.DatosEstado.IdEstado;
                    direcciones.IdMunicipio = item.DatosMunicipio.IdMunicipio;
                    listaDirecciones.Add(direcciones);
                }
                return listaDirecciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task GetAll()
        {
            try
            {
                var x = await Repository.GetAllAsync(Page, Opcion);
                if (x.Count == 0)
                    PaginaMaxima = true;
                else
                {
                    if(Opcion > 1)
                        ListaCliente.Clear();
                    foreach (var item in x)
                    {
                        ListaCliente.Add(item);
                    }
                    PaginaMaxima = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetDireciones()
        {
            try
            {
                var list = await RepositoryDirecciones.GetDirecciones(IdCliente);
                ListaDireccionesR.Clear();
                foreach (var item in list)
                {
                    ListaDireccionesR.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task GetFoto(Guid IdCliente)
        {
            try
            {
                var x = await Repository.ObtenerFoto(IdCliente);
                this.FotoBase64 = x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GuardarCambios(Guid IdUsuario)
        {
            try
            {
                DTOCliente model = new DTOCliente();
                if (State == EntityState.Create)
                {
                    model.DatosCliente.NuevoRegistro = true;
                    //model.DatosCliente.UpdateFoto = this.UpdateFoto;
                    model.DatosCliente.IdCliente = Guid.Empty;
                    model.DatosCliente.Clave = this.Clave;
                    model.DatosCliente.NombreCompleto = this.NombreCompleto;
                    model.DatosCliente.Telefono = this.Telefono;
                    model.DatosCliente.FechaNacimiento = this.FechaNacimiento;
                    model.DatosCliente.Sexo = this.Sexo;
                    //model.DatosCliente.FotoBase64 = this.FotoBase64;
                    model.DatosCliente.Rfc = this.Rfc;
                    model.DatosCliente.Email = this.Email;
                    if (!this.UpdateImagen)
                    {
                        model.DatosCliente.UrlFoto = "";
                        this.Extencion = "";
                    }
                    else
                    {
                        model.DatosCliente.UrlFoto = this.UrlFoto;
                    }
                    model.ListaDireciones = GuardarLista();

                    var result = await Repository.AddWithDTO(model, this.Extencion);
                    this.Clave = result;
                    return result;
                }
                else if (State == EntityState.Update)
                {
                    model.DatosCliente.NuevoRegistro = false;
                    //model.DatosCliente.UpdateFoto = this.UpdateFoto;
                    model.DatosCliente.IdCliente = this.IdCliente;
                    model.DatosCliente.Clave = this.Clave;
                    model.DatosCliente.NombreCompleto = this.NombreCompleto;
                    model.DatosCliente.Telefono = this.Telefono;
                    model.DatosCliente.FechaNacimiento = this.FechaNacimiento;
                    model.DatosCliente.Sexo = this.Sexo;
                    model.DatosCliente.UrlFoto = this.UrlFoto;
                    //model.DatosCliente.FotoBase64 = this.FotoBase64;
                    model.DatosCliente.Rfc = this.Rfc;
                    model.DatosCliente.Email = this.Email;
                    model.ListaDireciones = GuardarLista();
                    var result = await Repository.AddWithDTO(model, this.Extencion);
                    this.Clave = result;
                    return result;
                }
                return "0";
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
                return await Repository.DeleteAsync(this.IdCliente, this.IdUsuarioL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task GetBusqueda()
        {
            try
            {
                var x = await Repository.GetBusquedaAsync(this.Busqueda);
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

        public async Task<int> SetMonedero(Guid IdUsuario, string ClaveTarjeta, int Opcion)
        {
            try
            {
                return await Repository.SetMonederoCliente(IdCliente, IdUsuario, ClaveTarjeta, Opcion);
            }
            catch (Exception ex)
            {
                throw ex;
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
                    UrlFoto = RemotePath;
                    FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlFoto);
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
                return false;
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
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(UrlFoto);
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
                return false;
                throw ex;
            }
        }

        /// <summary>
        /// Método para convertir de Bytes a Imagen
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public async Task<Image> Convertir_Bytes_Imagen(byte[] bytes)
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Método para convertir de Imagen a Bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public async Task<byte[]> Convertir_Imagen_Bytes(Image img)
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Binding(Variables)
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

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set
            {
                _Direccion = value;
                OnPropertyChanged(nameof(Direccion));
            }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set
            {
                _Telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set
            {
                _FechaNacimiento = value;
                OnPropertyChanged(nameof(FechaNacimiento));
            }
        }

        private string _Rfc;
        public string Rfc
        {
            get { return _Rfc; }
            set
            {
                _Rfc = value;
                OnPropertyChanged(nameof(Rfc));
            }
        }

        private char _Sexo;
        public char Sexo
        {
            get { return _Sexo; }
            set
            {
                _Sexo = value;
                OnPropertyChanged(nameof(Sexo));
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

        private string _FotoBase64;
        public string FotoBase64
        {
            get { return _FotoBase64; }
            set
            {
                _FotoBase64 = value;
                OnPropertyChanged(nameof(FotoBase64));
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

        private string _Busqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set
            {
                _Busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }
        private bool _BuscarCliente;
        public bool BuscarCliente
        {
            get { return _BuscarCliente; }
            set
            {
                _BuscarCliente = value;
                OnPropertyChanged(nameof(BuscarCliente));
            }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged(nameof(Email)); }
        }
        #region Binding Imagen
        /// <summary>
        /// Variable para almacenar la url de la imagen(urlFTP)
        /// </summary>
        private string _UrlFoto;

        public string UrlFoto
        {
            get { return _UrlFoto; }
            set
            {
                _UrlFoto = value;
                OnPropertyChanged(nameof(UrlFoto));
            }
        }

        /// <summary>
        /// Propiedad para almacenar la imagen y mostrarlo en el Formulario
        /// </summary>
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
            set
            {
                _RutaImagen = value;
                OnPropertyChanged(nameof(RutaImagen));
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
        
        
        #endregion
    }
}
