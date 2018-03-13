using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookGoogleLogin.Startup))]
namespace FacebookGoogleLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
