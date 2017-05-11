using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomapperExample.Startup))]
namespace AutomapperExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
