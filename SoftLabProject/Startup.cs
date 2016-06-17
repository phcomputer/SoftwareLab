using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftLabProject.Startup))]
namespace SoftLabProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
