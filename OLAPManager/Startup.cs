using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLAPManager.Startup))]
namespace OLAPManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
