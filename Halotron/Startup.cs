using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Halotron.Startup))]
namespace Halotron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
