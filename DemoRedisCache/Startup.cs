using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoRedisCache.Startup))]
namespace DemoRedisCache
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
