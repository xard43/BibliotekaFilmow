using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_2.Startup))]
namespace Projekt_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
