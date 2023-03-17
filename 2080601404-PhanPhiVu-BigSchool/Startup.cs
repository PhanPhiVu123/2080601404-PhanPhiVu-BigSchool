using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080601404_PhanPhiVu_BigSchool.Startup))]
namespace _2080601404_PhanPhiVu_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
