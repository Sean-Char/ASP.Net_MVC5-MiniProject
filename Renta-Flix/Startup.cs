using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Renta_Flix.Startup))]
namespace Renta_Flix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
