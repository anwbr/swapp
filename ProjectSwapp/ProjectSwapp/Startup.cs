using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSwapp.Startup))]
namespace ProjectSwapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
