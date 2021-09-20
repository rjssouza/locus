using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Locus.Conexao.Factory;
using Locus.Conexao.Factory.Interface;
using Locus.Conexao.ServicoInterface;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Container.Instaladores
{
    public class InstaladorConexaoFactory : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var connString = ConfigurationManager.ConnectionStrings["LocusDB"].ConnectionString;

            container.Register(
                Component.For<IConexaoFactory>()
                         .Forward<IConexaoFactoryExecutor>()
                         .ImplementedBy<ConexaoFactory>()
                         .LifestyleScoped()
                         .DependsOn(Dependency.OnValue("connString", connString)));
        }
    }
}
