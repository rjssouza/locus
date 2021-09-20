﻿using Locus.Dto.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Interface.Agenda
{
    public interface IBuscaPorData : IBaseConsulta<FiltroAgendaDataDto, IEnumerable<AgendaDto>>
    {
    }
}
