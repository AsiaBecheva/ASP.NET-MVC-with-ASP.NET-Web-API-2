using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite.Web.Startup))]
namespace WebSite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
