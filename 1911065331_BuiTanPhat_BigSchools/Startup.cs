using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065331_BuiTanPhat_BigSchools.Startup))]
namespace _1911065331_BuiTanPhat_BigSchools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
