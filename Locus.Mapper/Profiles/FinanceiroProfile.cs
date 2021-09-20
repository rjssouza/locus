using AutoMapper;
using Locus.Dto.Financeiro;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class FinanceiroProfile : Profile
    {
        public FinanceiroProfile()
        {
            CreateMap<FinanceiroDto, Financeiro>();
            CreateMap<FinanceiroDto, Financeiro>().ReverseMap();
        }
    }
}
