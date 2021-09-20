using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Repositorio.Entidade;
using Locus.Dto;
using Locus.Consulta;

namespace Locus.Container.Instaladores
{
    public class InstaladorConsultas : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<BaseConsulta<BaseDto, BaseDto>>()
                         .Where(new Predicate<Type>((t) => { return true; }))
                         .WithService.DefaultInterfaces()
                         .LifestyleTransient());
        }
    }
}
