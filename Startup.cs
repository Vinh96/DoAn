using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebThueXe.Startup))]
namespace WebThueXe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
