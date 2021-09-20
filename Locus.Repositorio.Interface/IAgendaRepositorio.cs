using Locus.Dto;
using Locus.Dto.Agenda;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Interface
{
    public interface IAgendaRepositorio : IBaseRepositorio<Agenda>
    {
        IEnumerable<AgendaDto> BuscarPorData(FiltroAgendaDataDto filtroAgendaDataDto);
        AgendaDto BuscarAgendaPorCodigo(BaseDto baseDto);
    }
}
