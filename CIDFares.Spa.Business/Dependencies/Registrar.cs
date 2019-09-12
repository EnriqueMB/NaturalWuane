
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
            ServiceLocator.Instance.Register<BusquedaProductoRepository, IBusqProductoRepository>();
            ServiceLocator.Instance.Register<ProductoRepository, IProductoRepository>();
            ServiceLocator.Instance.Register<CategoriaProductoRepository, ICategoriaProductoRepository>();
            ServiceLocator.Instance.Register<UsuarioRepository, IUsuarioRepository>();
            ServiceLocator.Instance.Register<RolRepository, IRolRepository>();
            ServiceLocator.Instance.Register<EmpleadoRepository, IEmpleadoRepository>();
            ServiceLocator.Instance.Register<UnidadMedidaRepository, IUnidadMedidaRepository > ();
            ServiceLocator.Instance.Register<ServicioRepository, IServicioRepository>();
            ServiceLocator.Instance.Register<ProveedorRepository, IProveedorRepository>();
            ServiceLocator.Instance.Register<IvaRepository, IIvaRepository>();
            ServiceLocator.Instance.Register<VentaRepository, IVentaRepository>();
            ServiceLocator.Instance.Register<SucursalRepository, ISucursalRepository>();
            ServiceLocator.Instance.Register<TipoSucursalRepository, ITipoSucursalRepository>();
            ServiceLocator.Instance.Register<PaisRepository, IPaisRepository>();
            ServiceLocator.Instance.Register<EstadoRepository, IEstadoRepository>();
            ServiceLocator.Instance.Register<MunicipioRepository, IMunicipioRepository>();
            ServiceLocator.Instance.Register<ProveedorACompraRepository, IProveedorACompraRepository>();
            ServiceLocator.Instance.Register<TipoServicioRepository, ITipoServicioRepository>();
            ServiceLocator.Instance.Register<PuestoRepository, IPuestoRepository>();

        }
    }
}
