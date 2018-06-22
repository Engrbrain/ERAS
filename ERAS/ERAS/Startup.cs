using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERAS.Startup))]
namespace ERAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
