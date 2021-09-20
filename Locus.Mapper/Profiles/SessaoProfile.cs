using AutoMapper;
using Locus.Dto.Sessao;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            MapearSessao();
            MapearSessaoEspecialidade();
        }

        private void MapearSessao()
        {
            CreateMap<SessaoDto, Sessao>();
            CreateMap<SessaoDto, Sessao>().ReverseMap();
        }

        private void MapearSessaoEspecialidade()
        {
            CreateMap<SessaoEspecialidadeDto, SessaoEspecialidade>();
            CreateMap<SessaoEspecialidadeDto, SessaoEspecialidade>().ReverseMap();
        }
    }
}
