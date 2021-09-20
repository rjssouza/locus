using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Provider;
using Locus.Provider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Container.Instaladores
{
    public class InstaladorProviders : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IProvedorUsuario>()
                         .ImplementedBy<ProvedorUsuario>()
                         .LifestyleScoped());
        }
    }
}
