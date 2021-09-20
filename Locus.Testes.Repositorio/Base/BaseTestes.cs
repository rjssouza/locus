using AutoMapper;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Locus.Container.Instaladores;
using Locus.MapperConfig;
using Locus.UI.Api.WindsorContainer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace Locus.Testes.Repositorio
{
    public abstract class BaseTestes : IDisposable
    {
        protected IWindsorContainer _container;
        private IDependencyResolver _dependencyResolver;

        [TestInitialize]
        public void SetUp()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.Containing<InstaladorComandos>());
            _dependencyResolver = new DependencyResolver(_container.Kernel);
            _dependencyResolver.BeginScope();

            Config.ConfigurarAutoMapper();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _dependencyResolver.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool dispose)
        {
            _container.Dispose();
            _dependencyResolver.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
