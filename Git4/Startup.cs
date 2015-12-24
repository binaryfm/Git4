using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git4.Startup))]
namespace Git4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
