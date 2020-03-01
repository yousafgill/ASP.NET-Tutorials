using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YousafGill.Tutorials.IdentityUserCustomFields.Startup))]
namespace YousafGill.Tutorials.IdentityUserCustomFields
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
