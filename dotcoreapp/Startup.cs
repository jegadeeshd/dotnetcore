using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotcoreapp.Startup))]
namespace dotcoreapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
