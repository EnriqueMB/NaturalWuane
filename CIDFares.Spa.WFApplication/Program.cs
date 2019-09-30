using CIDFares.Spa.Business.Dependencies;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Forms.Catalogos;
using CIDFares.Spa.WFApplication.Forms.General;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Spa.WFApplication.Validations;
using FluentValidation;
using CIDFares.Spa.WFApplication.Forms.Usuarios;
using System;
using System.Windows.Forms;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.WFApplication.Forms.Compras;
using CIDFares.Spa.WFApplication.Forms.Cuestionarios;
using CIDFares.Spa.Business.ViewModels.Usuarios;
using CIDFares.Spa.Business.ViewModels.Compras;
using CIDFares.Spa.Business.ViewModels.Paquete;

namespace CIDFares.Spa.WFApplication
{
    static class Program
    {
        /// <summary
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeContainer();
            Application.Run(new FrmLogin());
            //Application.Run(new FrmTurno());
        }

        public static void InitializeContainer()
        {
            RegisterDependencies();
            if (!ServiceLocator.ContainerIsBuild)
                ServiceLocator.Instance.Build();
        }

        public static void RegisterDependencies()
        {
            Registrar.RegisterDependencies();
            RegisterViewModelDependencies();
            RegisterValidationDependencies();
        }

        private static void RegisterValidationDependencies()
        {
            ServiceLocator.Instance.Register<LoginValidator, IValidator<LoginViewModel>>();
            ServiceLocator.Instance.Register<FormaPagoValidator, IValidator<FormaPagoViewModel>>();
            ServiceLocator.Instance.Register<ClienteValidator, IValidator<ClienteViewModel>>();
            ServiceLocator.Instance.Register<CategoriaProductoValidator, IValidator<CategoriaProductoViewModel>>();
            ServiceLocator.Instance.Register<ServicioValidator, IValidator<ServicioViewModel>>();
            ServiceLocator.Instance.Register<UsuarioValidator, IValidator<UsuarioViewModel>>();
            ServiceLocator.Instance.Register<ProveedorValidator, IValidator<ProveedorViewModel>>();
            ServiceLocator.Instance.Register<ProductoValidator, IValidator<ProductoViewModel>>();
            ServiceLocator.Instance.Register<SucursalValidator, IValidator<SucursalViewModel>>();
            ServiceLocator.Instance.Register<VentaValidator, IValidator<VentasViewModel>>();
            ServiceLocator.Instance.Register<VentaValidator, IValidator<VentasViewModel>>();
            ServiceLocator.Instance.Register<EncuestaValidator, IValidator<EncuestasViewModel>>();
            ServiceLocator.Instance.Register<EmpleadoValidator, IValidator<EmpleadoViewModel>>();
            ServiceLocator.Instance.Register<ReglaValidator, IValidator<ReglaPerfilViewModel>>();
            ServiceLocator.Instance.Register<PaqueteValidator, IValidator<PaqueteViewModel>>();
            ServiceLocator.Instance.Register<RegistroEntradaSalidaValidator, IValidator<RegistroEntradaSalidaViewModel>>();
            ServiceLocator.Instance.Register<CompraValidator, IValidator<ComprasViewModel>>();
            ServiceLocator.Instance.Register<CapturaCitaValidator, IValidator<CapturaCitaViewModel>>();
            ServiceLocator.Instance.Register<ProductosMonederoValidator, IValidator<ProductosMonederoViewModel>>();
            ServiceLocator.Instance.Register<EntradaSalidaAlmacenValidator, IValidator<EntradaSalidaAlmacenViewModel>>();
            ServiceLocator.Instance.Register<AlimentoValidator, IValidator<AlimentoViewModels>>();
            ServiceLocator.Instance.Register<CambioVentaValidator, IValidator<CambioVentaViewModel>>();
            ServiceLocator.Instance.Register<CancelacionVentaValidator, IValidator<CancelacionVentaViewModel>>();
            ServiceLocator.Instance.Register<ListaMedicionValidator, IValidator<ListaMedicionViewModel>>();
            ServiceLocator.Instance.Register<MedicionValidator, IValidator<MedicionViewModel>>();
            ServiceLocator.Instance.Register<AbonoPaqueteValidator, IValidator < PaqueteViewModel >> ();
            ServiceLocator.Instance.Register<AbonoPaqueteValidator, IValidator < PaqueteViewModel >>();
        }

        private static void RegisterViewModelDependencies()
        {
            ServiceLocator.Instance.Register<ValidatorFactory>();
            ServiceLocator.Instance.Register<LoginViewModel>();
            ServiceLocator.Instance.Register<FormaPagoViewModel>();
            ServiceLocator.Instance.Register<ProductoViewModel>();
            ServiceLocator.Instance.Register<ClienteViewModel>();
            ServiceLocator.Instance.Register<VentasViewModel>();
            ServiceLocator.Instance.Register<BusquedaProductoViewModel>();
            ServiceLocator.Instance.Register<CategoriaProductoViewModel>();
            ServiceLocator.Instance.Register<UsuarioViewModel>();
            ServiceLocator.Instance.Register<ServicioViewModel>();
            ServiceLocator.Instance.Register<SeleccionarPagoViewModel>();
            ServiceLocator.Instance.Register<ProveedorViewModel>();
            ServiceLocator.Instance.Register<SucursalViewModel>();
            ServiceLocator.Instance.Register<ProveedorACompraViewModel>();
            ServiceLocator.Instance.Register<CapturaCitaViewModel>();
            ServiceLocator.Instance.Register<EncuestasViewModel>();
            ServiceLocator.Instance.Register<EmpleadoViewModel>();
            ServiceLocator.Instance.Register<ReglaPerfilViewModel>();
            ServiceLocator.Instance.Register<PaqueteViewModel>();
            ServiceLocator.Instance.Register<RegistroEntradaSalidaViewModel>();
            ServiceLocator.Instance.Register<ComprasViewModel>();
            ServiceLocator.Instance.Register<ProductosMonederoViewModel>();
            ServiceLocator.Instance.Register<EntradaSalidaAlmacenViewModel>();
            ServiceLocator.Instance.Register<InventarioFisicoViewModel>();
            ServiceLocator.Instance.Register<AlimentoViewModels>();
            ServiceLocator.Instance.Register<CambioVentaViewModel>();
            ServiceLocator.Instance.Register<TurnoViewModel>();
            ServiceLocator.Instance.Register<CancelacionVentaViewModel>();
            ServiceLocator.Instance.Register<MedicionViewModel>();
            ServiceLocator.Instance.Register<ListaMedicionViewModel>();
            ServiceLocator.Instance.Register<AbonoPaqueteDetalleViewModel>();
        }
    }
}
