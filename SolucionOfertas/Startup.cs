using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolucionOfertas.Startup))]
namespace SolucionOfertas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
