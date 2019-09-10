using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class ReglasRol
    {
        public ReglasRol()
        {
            ReglasLogin = new LoginRequests();
        }
        public bool ReglaAsignada { get; set; }
        public int IdRegla { get; set; }
        public string NombrePermiso { get; set; }
        public string NombreRegla { get; set; }
        public string Descripcion { get; set; }
        public DataTable TablaRegla { get; set; }
        public int IdRol { get; set; }
        public int Resultado { get; set; }

        public LoginRequests ReglasLogin { get; set; }
    }
}
