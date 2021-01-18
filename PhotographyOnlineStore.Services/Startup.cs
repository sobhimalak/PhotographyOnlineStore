using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotographyOnlineStore.Services.Startup))]
namespace PhotographyOnlineStore.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
