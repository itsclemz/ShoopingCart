using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Cart.Startup))]
namespace E_Cart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
