using AutoMapper;
using Locus.Dto.Perfil;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig.Profiles
{
    internal class PerfilProfile : Profile
    {
        public PerfilProfile()
        {
            MapearPerfil();
            MapearPerfilUsuario();
        }

        private void MapearPerfil()
        {
            CreateMap<PerfilDto, Perfil>();
            CreateMap<PerfilDto, Perfil>().ReverseMap();
        }

        private void MapearPerfilUsuario()
        {
            CreateMap<PerfilUsuarioDto, PerfilUsuario>();
            CreateMap<PerfilUsuarioDto, PerfilUsuario>().ReverseMap();
        }
    }
}
