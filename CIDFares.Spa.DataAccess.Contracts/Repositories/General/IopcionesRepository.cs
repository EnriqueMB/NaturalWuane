using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface IopcionesRepository : IBaseRepository<OpcionCuestionario>
    {
        #region Metodos
        Task<IEnumerable<OpcionMedicion>> CargarGridMediciones();
        Task<IEnumerable<Consulta>> LlenarComboTipoConsulta();
        Task<int> GuardarEncuesta(Guid idUsuario,int tipoConsulta,CapturaConsulta model,DataTable _tablaRespuestas,DataTable _tablaRespuestasMultiple,DataTable _tablaMedicion,DataTable _tablaComentario,DataTable _tablaCuestionario);
        Task<int> UpdateEncuesta(Guid IdConsulta,Guid idUsuario,int tipoConsulta,CapturaConsulta model,DataTable _tablaRespuestas,DataTable _tablaRespuestasMultiple,DataTable _tablaMedicion,DataTable _tablaComentario,DataTable _tablaCuestionario);
        Task<IEnumerable<Cliente>> GetCliente();
        #endregion
    }
}
