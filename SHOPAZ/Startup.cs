using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SHOPAZ.Startup))]
namespace SHOPAZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
