using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMgr.Startup))]
namespace CMgr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
