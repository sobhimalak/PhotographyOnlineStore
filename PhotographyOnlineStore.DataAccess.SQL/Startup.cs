using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotographyOnlineStore.DataAccess.SQL.Startup))]
namespace PhotographyOnlineStore.DataAccess.SQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
