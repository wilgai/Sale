using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sale.Backend.Startup))]
namespace Sale.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
