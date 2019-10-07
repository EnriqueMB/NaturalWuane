using CIDFares.Library.Code.Utilities.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Forms.Ventas.TicketVenta
{
    public class ImprimirVenta
    {
        public ImprimirVenta()
        {
             //Creamos una intancia de la clase CrearTicket
            ImpresoraTicket ticket = new ImpresoraTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero 

            //Diseño ticket

            //Datos de la cabecera del ticket

            ticket.TextoCentro("NOMBRE");
            ticket.TextoIzquierda("DIREC:");
            ticket.TextoIzquierda("TELEF:");
            ticket.TextoIzquierda("R.F.C.");
           
            ticket.lineasAsteriscos();

            //Sub cabecera
            ticket.TextoIzquierda("ATENDIO: VENDEDOR");
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA:" + DateTime.Now.ToShortTimeString());

            ticket.lineasAsteriscos();

            //Articulos a vender
            ticket.EncabezadoVenta();//Nombre de 
            ticket.lineasAsteriscos();
            //foreach(DataGridViewRow fila in .Rows)
            //{
            //    ticket.AgregarArticulos(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //    decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregarArticulos("Articulo A", 2, 20, 40);
            ticket.AgregarArticulos("Articulo B", 1, 10, 10);
            ticket.AgregarArticulos("Este es un nombre largo del articulo , para mostrar como se bajan las lineas", 1, 2, 2);

            //Resumen de la venta

            ticket.AgregarTotales("SUBTOTAL......$", 100);
            ticket.AgregarTotales("IVA...........$", 10.04M);
            ticket.AgregarTotales("TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("EFECTIVO......$", 200);
            ticket.AgregarTotales("CAMBIO........$", 200);

            //Texto final del ticket
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("ARTICULOS VENDIDOS:3 ");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("GRACIAS POR SU COMPRA");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");
        }
    }     
    
}
