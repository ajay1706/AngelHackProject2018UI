using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AH2018.Startup))]
namespace AH2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
