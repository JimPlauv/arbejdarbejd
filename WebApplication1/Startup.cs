using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arbejdarbejd.Startup))]
namespace Arbejdarbejd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
