using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webTemplate.Startup))]
namespace webTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
