using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeDeps.Startup))]
namespace EmployeeDeps
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
