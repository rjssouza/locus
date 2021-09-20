using AutoMapper;
using Locus.Dto.ServicoEmail;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class ServicoEmailProfile : Profile
    {
        public ServicoEmailProfile()
        {
            CreateMap<ServicoEmailDto, ServicoEmail>();
            CreateMap<ServicoEmailDto, ServicoEmail>().ReverseMap();
        }
    }
}
