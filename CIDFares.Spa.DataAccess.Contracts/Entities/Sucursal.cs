﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class Sucursal
    {
        public Sucursal()
        {
            ListaHorario = new List<HorarioSucursal>();
        }
        public int? IdSucursal { get; set; }
        public int? IdTipoSucursal { get; set; }
        public int NumSucursal { get; set; }
        public string Nombre { get; set; }
        public string NombreTipoSucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public int IdPais { get; set; }
        public string NombrePais { get; set; }
        public string CodigoPostal { get; set; }
        public string Rfc { get; set; }
        public string NombreRepresentante { get; set; }
        public string RegimenFiscal { get; set; }
        public int Result { get; set; }
        public List<HorarioSucursal> ListaHorario { get; set; }
    }
}
    