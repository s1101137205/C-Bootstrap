using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1040417.Startup))]
namespace _1040417
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
