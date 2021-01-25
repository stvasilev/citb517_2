using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(citb517_2.Startup))]
namespace citb517_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
