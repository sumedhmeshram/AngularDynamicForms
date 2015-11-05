using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularDynamicForms.Startup))]
namespace AngularDynamicForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
