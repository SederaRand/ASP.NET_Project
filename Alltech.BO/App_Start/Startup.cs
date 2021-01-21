using System;
using System.Threading.Tasks;
using Alltech.DataAccess;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Alltech.DataAccess.DataAcces;
using Alltech.DataAccess.Context;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(Alltech.BO.App_Start.Startup))]

namespace Alltech.BO.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        private void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(AlltechContext.Create);

            app.CreatePerOwinContext<DataAccess.DataAcces.ApplicationUserManager>(DataAccess.DataAcces.ApplicationUserManager.Create);

            app.CreatePerOwinContext<SiginManager>(SiginManager.Create);

            #region Cookie Configuration
            // Configuration du cookie de connexion
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Security/Login"),
            });
            #endregion Cookie Configuration
        }




    }
}