using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Hello.Startup))]
namespace ASP_Hello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
