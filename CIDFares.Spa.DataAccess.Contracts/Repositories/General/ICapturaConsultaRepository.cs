using CIDFares.Spa.DataAccess.Contracts.DTOs;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.DataAccess.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ICapturaConsultaRepository 
    {
        Task<IEnumerable<CapturaConsulta>> GetAll(string valor);

        Task<ConsultaDto> ObtenerConsultaXId(Guid IdConsulta, Guid IdUsuario);
    }
}
