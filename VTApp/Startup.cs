using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VTApp.Startup))]
namespace VTApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
