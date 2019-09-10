using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ICuestionarioRepository : IBaseRepository<Cuestionario>
    {
        #region Metodos
        Task<IEnumerable<Cuestionario>> LlenarComboTipoEncuesta();

        Task<int> GuardarEncuesta(string NombreEncuesta, int TipoEncuesta,Guid IdUsuario, DataTable tblPregunta, DataTable tblRespuesta);
        #endregion
    }
}
