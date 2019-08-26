
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;
using CIDFares.Spa.DataAccess.Repositories.General;

namespace CIDFares.Spa.Business.Dependencies
{
    public static class Registrar
    {
        public static void RegisterDependencies()
        {
            ServiceLocator.Instance.Register<LoginRepository, ILoginRepository>();
            ServiceLocator.Instance.Register<FormaPagoRepository, IFormaPagoRepository>();
            ServiceLocator.Instance.Register<ClienteRepository, IClienteRepository>();
            ServiceLocator.Instance.Register<ProductoRepository, IProductoRepository>();
            ServiceLocator.Instance.Register<CategoriaProductoRepository, ICategoriaProductoRepository>();
        }
    }
}
