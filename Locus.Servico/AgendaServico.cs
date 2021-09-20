using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Locus.Conexao.ServicoInterface;
using Locus.Dto;
using Locus.Dto.Agenda;
using Locus.Provider.Interface;
using Locus.Repositorio.Entidade;
using Locus.Repositorio.Interface;
using Locus.Servico.Interface;
using Locus.Servico.Regras.Agenda;

namespace Locus.Servico
{
    public class AgendaServico : BaseServico, IAgendaServico
    {
        private readonly IAgendaRepositorio _agendaRepositorio;

        public AgendaServico(IConexaoFactory conexaoFactory, IAgendaRepositorio agendaRepositorio, IProvedorUsuario provedorUsuario) : base(conexaoFactory, provedorUsuario)
        {
            this._agendaRepositorio = agendaRepositorio;
        }

        public AgendaDto BuscarAgendaPorCodigo(BaseDto baseDto)
        {
            return _agendaRepositorio.BuscarAgendaPorCodigo(baseDto);
        }

        public BaseDto InserirAgenda(AgendaDto agendaDto)
        {
            agendaDto.ValidarDataAgenda(_agendaRepositorio);
            var agendaEntity = Mapper.Map<Agenda>(agendaDto);
            var resultado = _agendaRepositorio.Inserir(agendaEntity);
            return resultado;
        }
    }
}
