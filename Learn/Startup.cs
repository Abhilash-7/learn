using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learn.Startup))]
namespace Learn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
