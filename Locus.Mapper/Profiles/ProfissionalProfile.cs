using AutoMapper;
using Locus.Dto.Profissional;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class ProfissionalProfile : Profile
    {
        public ProfissionalProfile()
        {
            MapearProfissional();
            MapearValorHora();
        }

        private void MapearProfissional()
        {
            CreateMap<ProfissionalDto, Profissional>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status ? 1 : 0));

            CreateMap<ProfissionalDto, Profissional>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status ? 1 : 0))
                .ReverseMap();
        }

        private void MapearValorHora()
        {
            CreateMap<ValorHoraDto, ValorHora>();
            CreateMap<ValorHoraDto, ValorHora>().ReverseMap();
        }
    }
}
