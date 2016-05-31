using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBuff_ASP_MVC.Startup))]
namespace MovieBuff_ASP_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
