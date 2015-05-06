using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgileMVC.Startup))]
namespace AgileMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
