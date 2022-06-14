using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rubik.Startup))]
namespace Rubik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
