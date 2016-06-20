using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShoes.Apresentacao.Web.Startup))]
namespace WebShoes.Apresentacao.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
