using Locus.Dto;
using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locus.UI.Api.Controllers
{
    [RoutePrefix("api/default")]
    public class DefaultController : BaseController
    {
        private readonly IAgendaServico _agendaServico;

        public DefaultController(IAgendaServico agendaServico)
        {
            _agendaServico = agendaServico;
        }

        [HttpGet]
        //[AllowAnonymous]
        public string Get()
        {
            var retorno = _agendaServico.InserirAgenda(new Dto.Agenda.AgendaDto()
            {
                CodigoEspecialidade = 1,
                CodigoProfissional = 1,
                DataFim = DateTime.Now,
                DataInicio = DateTime.Now,
                Status = 'S'
            });

            return "meu querido teste coisa fina de osasco";
        } 
    }
}
