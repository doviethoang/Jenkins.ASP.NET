using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NETCICD.Startup))]
namespace NETCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
