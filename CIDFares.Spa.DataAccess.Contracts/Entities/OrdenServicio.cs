using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class OrdenServicio
    {
        public OrdenServicio()
        {
            OrdenPaquete = new OrdenPaquete();
            Cliente = new Cliente();
            Servicio = new Servicio();
        }
        public Guid IdOrdenServicio { get; set; }
        public OrdenPaquete OrdenPaquete { get; set; }
        public Cliente Cliente { get; set; }
        public Servicio Servicio { get; set; }
        public bool Aplicado { get; set; }
        public bool Pagado { get; set; }
        /*
            SELECT [IdOrdenServicio]
                  ,[IdOrdenPaquete]
                  ,[IdCliente]
                  ,[IdServicio]
                  ,[IdSucursal]
                  ,[LocalId]
                  ,[Aplicado]
                  ,[Pagado]
                  ,[FechaAlta]
                  ,[FechaModificacion]
                  ,[UsuarioAlta]
                  ,[UsuarioModifico]
                  ,[Activo]
              FROM [Cita].[TblOrdenServicio]
            GO


         */
    }
}
