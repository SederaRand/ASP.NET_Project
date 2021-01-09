using Alltech.DataAccess.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.DataAcces
{
    public class SiginManager : SignInManager<User, string>
    {

        public SiginManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
                : base(userManager, authenticationManager)
        {
        }

        public static SiginManager Create(IdentityFactoryOptions<SiginManager> options, IOwinContext context)
        {
            return new SiginManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}
