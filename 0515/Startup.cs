using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0515.Startup))]
namespace _0515
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
