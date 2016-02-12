using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GisCorp.Portal.Startup))]
namespace GisCorp.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
