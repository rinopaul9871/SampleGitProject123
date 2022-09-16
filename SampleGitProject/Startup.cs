using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleGitProject.Startup))]
namespace SampleGitProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
