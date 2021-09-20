using Castle.MicroKernel;
using Castle.Windsor;
using Locus.Dto;
using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Locus.UI.Api.WindsorContainer
{
    public class WindsorCompositionRoot : IHttpControllerActivator
    {
        public WindsorCompositionRoot()
        {
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var scope = GlobalConfiguration.Configuration.DependencyResolver.BeginScope();    
            var principal = Thread.CurrentPrincipal as ClaimsPrincipal;

            var controller = (IHttpController)scope.GetService(controllerType);
            request.RegisterForDispose(new Release(() => {
                scope.Dispose();
            }));

            return controller;
        }
    }

    class Release : IDisposable
    {
        private readonly Action release;

        public Release(Action release)
        {
            this.release = release;
        }

        public void Dispose()
        {
            this.release();
        }
    }
}