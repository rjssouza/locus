using Locus.Dto;
using Locus.Dto.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico.Interface
{
    public interface IAgendaServico : IBaseServico
    {
        BaseDto InserirAgenda(AgendaDto agendaDto);
        AgendaDto BuscarAgendaPorCodigo(BaseDto baseDto);
    }
}
