using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDToolKit.Startup))]
namespace DDToolKit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
