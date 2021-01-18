using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoographyOnlineStore.Startup))]
namespace PhotoographyOnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
