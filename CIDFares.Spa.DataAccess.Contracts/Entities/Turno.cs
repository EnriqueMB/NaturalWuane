﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public string NombreTurno { get; set; }
        public string Descripcion { get; set; }
    }
}