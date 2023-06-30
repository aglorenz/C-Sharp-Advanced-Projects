using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBase.Startup))]
namespace RoleBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
