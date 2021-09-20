using AutoMapper;
using Locus.Dto.Especialidade;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class EspecialidadeProfile : Profile
    {
        public EspecialidadeProfile()
        {
            CreateMap<EspecialidadeDto, Especialidade>();
            CreateMap<EspecialidadeDto, Especialidade>().ReverseMap();
        }
    }
}
