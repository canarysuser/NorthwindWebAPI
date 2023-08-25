using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsReact.Startup))]
namespace WebFormsReact
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
