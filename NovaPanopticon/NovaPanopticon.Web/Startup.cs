using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovaPanopticon.Web.Startup))]
namespace NovaPanopticon.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
