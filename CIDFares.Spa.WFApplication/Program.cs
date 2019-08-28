using CIDFares.Spa.Business.Dependencies;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Validations;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Forms.Catalogos;
using CIDFares.Spa.WFApplication.Forms.Ventas;
using CIDFares.Spa.WFApplication.Forms.General;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Spa.WFApplication.Validations;
using FluentValidation;
using CIDFares.Spa.WFApplication.Forms.Usuarios;
using System;
using System.Windows.Forms;
using CIDFares.Spa.Business.ViewModels.Ventas;

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
            CurrentSession.IdCuentaUsuario = Guid.Empty;
            Application.Run(new FrmVenta());
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
        }
    }
}
