using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterBox.Startup))]
namespace ChatterBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
