﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Respuestas
    {
        public Guid IdEncuesta { get; set; }
        public Guid IdPregunta { get; set; }
        public Guid IdRespuesta { get; set; }
        public string Respuesta { get; set; }
        public string pregunta { get; set; }
        public bool Seleccionado { get; set; }
        public bool? RespuestaSINO { get; set; }
    }
}
