using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemeGenerator.Startup))]
namespace MemeGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
