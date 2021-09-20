using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.Configuration.Conventions;
using AutoMapper.Mappers;
using Locus.Dto.Agenda;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig
{
    internal class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<AgendaDto, Agenda>();
            CreateMap<AgendaDto, Agenda>().ReverseMap();
        }
    }
}
