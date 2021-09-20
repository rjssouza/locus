using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Comando;
using System.Reflection;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System.Threading;
using System.Security.Claims;

namespace Locus.Container.Instaladores
{
    public class InstaladorComandos : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<BaseComando<BaseEntidade>>()
                                 .Where(new Predicate<Type>((t) => { return true; }))
                                 .WithService.DefaultInterfaces()
                                 .LifestyleTransient());
        }
    }
}
