using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LIMS.Startup))]
namespace LIMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
