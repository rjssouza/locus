using AutoMapper;
using Locus.MapperConfig.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.MapperConfig
{
    public static class Config
    {
        public static  void ConfigurarAutoMapper()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile(new AgendaProfile());
                cfg.AddProfile(new EspecialidadeProfile());
                cfg.AddProfile(new FinanceiroProfile());
                cfg.AddProfile(new PacienteProfile());
                cfg.AddProfile(new PerfilProfile());
                cfg.AddProfile(new ProfissionalProfile());
                cfg.AddProfile(new ServicoEmailProfile());
                cfg.AddProfile(new SessaoProfile());
                cfg.AddProfile(new UsuarioProfile());
            });
        }
    }
}
