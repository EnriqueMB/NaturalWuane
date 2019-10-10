using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Entities
{
    public class OpcionCuestionario
    {
        #region construcor
        public OpcionCuestionario()
        {
            datos = new Cuestionario();                 
        }
        #endregion

        #region Propiedades
        public bool asignar { get; set; }
        public Cuestionario datos { get; set; }
        #endregion
    }
}
