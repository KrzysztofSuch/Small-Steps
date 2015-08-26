using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFSmallSteps.Startup))]
namespace EFSmallSteps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
