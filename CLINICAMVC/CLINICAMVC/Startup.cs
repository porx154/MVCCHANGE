using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CLINICAMVC.Startup))]
namespace CLINICAMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
