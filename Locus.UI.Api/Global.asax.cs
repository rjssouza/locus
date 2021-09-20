using AutoMapper;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Locus.Container.Instaladores;
using Locus.Dto.Agenda;
using Locus.MapperConfig;
using Locus.UI.Api.CustomFilter;
using Locus.UI.Api.WindsorContainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Filters;
using System.Web.Routing;

namespace Locus.UI.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer _container;

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ConfigurarContainer();
            ConfigurarFiltros();
            ConfigurarContainerController();
            Config.ConfigurarAutoMapper();
        }

        private void ConfigurarContainer()
        {
            _container = new Castle.Windsor.WindsorContainer();
            _container.Install(FromAssembly.This(), FromAssembly.Containing<InstaladorComandos>());
            GlobalConfiguration.Configuration.DependencyResolver = new DependencyResolver(_container.Kernel);
        }

        private void ConfigurarFiltros()
        {
            GlobalConfiguration.Configuration.Filters.Add(new UsuarioAuth());
            GlobalConfiguration.Configuration.Filters.Add(new TratamentoExcecao());
        }

        private void ConfigurarContainerController()
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorCompositionRoot());
        }
    }
}
