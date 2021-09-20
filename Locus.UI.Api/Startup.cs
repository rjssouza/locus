using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Locus.UI.Api.Startup))]

namespace Locus.UI.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            ConfigureOAuth(appBuilder);
        }
    }
}