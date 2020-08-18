using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicHub.Startup))]
namespace TicHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
