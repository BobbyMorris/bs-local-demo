using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSdemo.Startup))]
namespace BSdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
