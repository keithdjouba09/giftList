using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(giftList.Startup))]
namespace giftList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
