using Locus.Dto.Agenda;
using Locus.Dto.Excecao;
using Locus.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico.Regras.Agenda
{
    public static class AgendaExt
    {
        public static AgendaDto ValidarDataAgenda(this AgendaDto agenda, IAgendaRepositorio repositorio)
        {
            var resultado = repositorio.BuscarPorData(new FiltroAgendaDataDto()
            {
                DataAgenda = agenda.DataInicio
            });
            if (resultado.Any())
                throw new ExcecaoValidacao(new KeyValuePair<string, string>("Data Agenda", "Data invalida"));

            return agenda;
        }
    }
}
