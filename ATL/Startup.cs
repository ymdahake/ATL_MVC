using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATL.Startup))]
namespace ATL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
