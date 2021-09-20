using AutoMapper;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig
{
    internal class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>()
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(dest => dest.Ativo ? 1 : 0));

            CreateMap<UsuarioDto, Usuario>()
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(dest => dest.Ativo ? 1 : 0)).ReverseMap();
        }
    }
}
