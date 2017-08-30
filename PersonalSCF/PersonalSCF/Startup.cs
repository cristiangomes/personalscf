using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalSCF.Startup))]
namespace PersonalSCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
