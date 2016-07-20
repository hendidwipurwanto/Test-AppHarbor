using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_AppHarbor.Startup))]
namespace Test_AppHarbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
