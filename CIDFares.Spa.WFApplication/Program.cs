using CIDFares.Spa.Business.Dependencies;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.WFApplication.Forms.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeContainer();
            Application.Run(new FrmFormaPago());
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

        }

        private static void RegisterViewModelDependencies()
        {
            ServiceLocator.Instance.Register<LoginViewModel>();
            ServiceLocator.Instance.Register<FormaPagoViewModel>();
        }

    }
}
