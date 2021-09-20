using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Repositorio;
using Locus.Repositorio.Entidade;
using Locus.Dto;

namespace Locus.Container.Instaladores
{
    public class InstaladorRepositorio : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<BaseRepositorio<BaseEntidade>>()
                       .Where(Component.IsInNamespace("Locus.Repositorio"))
                       .WithService.DefaultInterfaces()
                       .LifestyleTransient());
        }
    }
}
