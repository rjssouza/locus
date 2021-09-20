using Castle.MicroKernel;
using Castle.MicroKernel.Lifestyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace Locus.UI.Api.WindsorContainer
{
    public class DependencyScope : IDependencyScope
    {
        private readonly IKernel kernel;
        private readonly IDisposable _scope;

        public DependencyScope(IKernel kernel)
        {
            this.kernel = kernel;
            _scope = kernel.BeginScope();
        }

        public object GetService(Type serviceType)
        {
            return kernel.HasComponent(serviceType) ? kernel.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool dispose)
        {
            _scope.Dispose();
        }
    }
}