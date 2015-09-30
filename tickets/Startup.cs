using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tickets.Startup))]
namespace tickets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
