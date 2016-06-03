using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BOE.Web.Startup))]
namespace BOE.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
