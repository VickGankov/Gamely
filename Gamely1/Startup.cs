using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamely1.Startup))]
namespace Gamely1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
