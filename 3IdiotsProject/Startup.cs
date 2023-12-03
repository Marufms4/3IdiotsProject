using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3IdiotsProject.Startup))]
namespace _3IdiotsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
