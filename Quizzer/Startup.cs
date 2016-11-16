using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quizzer.Startup))]
namespace Quizzer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
