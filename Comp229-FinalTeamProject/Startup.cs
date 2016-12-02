using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp229_FinalTeamProject.Startup))]
namespace Comp229_FinalTeamProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
