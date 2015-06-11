using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HookedMedia.Startup))]
namespace HookedMedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
