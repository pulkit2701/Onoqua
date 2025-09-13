using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Onoqua.Web.Startup))]
namespace Onoqua.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
