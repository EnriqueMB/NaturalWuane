using CIDFares.Library.Code.Utilities.Implements;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Forms.Ventas.TicketVenta
{
    public class ImprimirVenta
    {
        public ImprimirVenta(VentaTicketRequest datos)
        {
            //Creamos una intancia de la clase CrearTicket
            ImpresoraTicket ticket = new ImpresoraTicket();
            //Ya podemos usar todos sus metodos
            //ticket.AbreCajon();//Para abrir el cajon de dinero 

            //Diseño ticket

            //Datos de la cabecera del ticket

            ticket.TextoCentro("NOMBRE:" + CurrentSession.NombreSucursal);
            ticket.TextoIzquierda("DIREC:" + CurrentSession.Direccion);
            ticket.TextoIzquierda("TELEF:" + CurrentSession.Telefono);
            ticket.TextoIzquierda("R.F.C." + CurrentSession.RFC);


            ticket.lineasAsteriscos();

            //Sub cabecera
            ticket.TextoIzquierda("FOLIO:" + datos.dtoVenta.Folio);
            //ticket.TextoIzquierda("TURNO:" + datos.dtoVenta.IdTurno);
            ticket.TextoIzquierda("ATENDIO:" + CurrentSession.Nombres);
            ticket.TextoIzquierda("CLIENTE:" + datos.dtoVenta.ClienteVenta.NombreCompleto);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA:" + DateTime.Now.ToShortTimeString());

            ticket.lineasAsteriscos();

            //Articulos a vender
            ticket.EncabezadoVenta();//Nombre de 
            ticket.lineasAsteriscos();
            
            foreach (var item in datos.dtoProducto)
            {
                ticket.AgregarArticulos(item.Nombre, item.datoProducto.Cantidad,item.PrecioPublico,item.datoProducto.Total);

            }

            //foreach (var item in datos.dtoPaquete)
            //{
            //    ticket.AgregarArticulos(item.Nombre, item.datoPaquete.Cantidad, item.MontoPaquete, item.datoPaquete.Total );
            //}

            foreach (var item in datos.dtoServicio)
            {
                ticket.AgregarArticulos(item.Nombre, item.datoServicio.Cantidad, item.Precio, item.datoServicio.Total);
            }

            ticket.lineasAsteriscos();
            //Resumen de la venta

            ticket.AgregarTotales("SUBTOTAL......$", datos.dtoVenta.SubTotal);
            ticket.AgregarTotales("IVA...........$", datos.dtoVenta.PorcentajeIva);
            ticket.AgregarTotales("TOTAL.........$", datos.dtoVenta.PrecioConIva);
            ticket.TextoIzquierda("");
          
            //Texto final del ticket
            ticket.TextoIzquierda("");
   
            ticket.TextoCentro("GRACIAS POR SU COMPRA");
            //ticket.CortaTicket();
            ticket.ImprimirTicket("BIXOLON SRP-350plus");
        }
    }     
    
}
