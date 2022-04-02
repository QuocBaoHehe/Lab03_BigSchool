using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab03_BigSchool.Startup))]
namespace Lab03_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
