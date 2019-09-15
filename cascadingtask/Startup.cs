using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cascadingtask.Startup))]
namespace cascadingtask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
