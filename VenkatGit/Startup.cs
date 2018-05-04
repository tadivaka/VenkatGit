using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VenkatGit.Startup))]
namespace VenkatGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
