using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMS1.Startup))]
namespace LMS1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
