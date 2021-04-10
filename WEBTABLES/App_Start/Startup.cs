using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using static WEBTABLES.App_Start.NinjectWebCommon;

[assembly: OwinStartup(typeof(WEBTABLES.App_Start.Startup))]

namespace WEBTABLES.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.DependencyResolver = new NinjectResolver(NinjectWebCommon.CreateKernel());


            app.Use(config);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
