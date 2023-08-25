using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactWebformsCustomized.Startup))]
namespace ReactWebformsCustomized
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
