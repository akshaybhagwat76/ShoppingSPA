using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaimWebApplication.Startup))]
namespace ClaimWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
