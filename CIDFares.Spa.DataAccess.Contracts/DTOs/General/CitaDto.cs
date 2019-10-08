using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.DTOs.General
{
    public class CitaDto
    {
        public Cliente dtoCliente { get; set; }
        public Paquetes dtoPaquete { get; set; }
        public Servicio dtoServicio { get; set; }
    }
}
