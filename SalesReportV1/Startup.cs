using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesReportV1.Startup))]
namespace SalesReportV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
