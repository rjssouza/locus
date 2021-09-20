using AutoMapper;
using Locus.Dto.Paciente;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class PacienteProfile : Profile
    {
        public PacienteProfile()
        {
            CreateMap<PacienteDto, Paciente>()
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo ? 1 : 0));
            CreateMap<PacienteDto, Paciente>()
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo ? 1 : 0))
                .ReverseMap();
        }
    }
}
