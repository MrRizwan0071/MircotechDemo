using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deployement.Startup))]
namespace Deployement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
