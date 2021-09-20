using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Servico;
using Locus.Dto;
using System.Threading;
using System.Security.Claims;

namespace Locus.Container.Instaladores
{
    public class InstaladorServicos : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var principal = Thread.CurrentPrincipal as ClaimsPrincipal;


            container.Register(Classes.FromAssemblyContaining<BaseServico>()
                       .Where(Component.IsInNamespace("Locus.Servico"))
                       .WithService.DefaultInterfaces()
                       .LifestyleTransient());
        }
    }
}
