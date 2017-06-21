using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TonaWeb.Startup))]
namespace TonaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
