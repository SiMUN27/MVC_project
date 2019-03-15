using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjektRWA.Startup))]
namespace MVCProjektRWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
