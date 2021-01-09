using Alltech.BackOfiice.Models;
using Alltech.DataAccess.DataAcces;
using Alltech.DataAccess.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Alltech.BackOfiice.Controllers
{
    public class SecurityController : Controller
    {

        private SiginManager _signInManager;
        private ApplicationUserManager _userManager;

        public SiginManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<SiginManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        // GET: Security
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Si l'utilisateur n'existe pas
                    var user = await UserManager.FindByNameAsync(model.UserName);
                    if (user != null)
                    {
                        ModelState.AddModelError(string.Empty, "Utilisateur existe déjà");

                        return View(model);
                    }
                    user = new User
                    {
                        Email = model.UserName,
                        UserName = model.UserName,
                    };

                    var result = await UserManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    string message = string.Format("<b>Message:</b> {0}<br /><br />", ex.Message);
                    ModelState.AddModelError(string.Empty, message);
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Si l'utilisateur n'existe pas
                var user = await UserManager.FindByNameAsync(model.Login);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");

                    return View(model);
                }

                //Si le mot de passe est incorrect
                if (await UserManager.CheckPasswordAsync(user, model.Password))
                {
                    if (await UserManager.IsLockedOutAsync(user.Id))
                    {
                        ModelState.AddModelError(string.Empty, "Compte bloqué");
                        return View(model);
                    }

                    //Vérification du login pwd
                    var signInStatus = await SignInManager.PasswordSignInAsync(model.Login, model.Password, false, true);

                    switch (signInStatus)
                    {
                        case SignInStatus.Success:
                            Session["User"] = user;
                            return RedirectToAction("Index", "Home");

                        //Si l'utilisateur n'est pas reconnu
                        default:
                            ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");
                            return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");
                    return View(model);
                }
            }

            return View(model);
        }

        public ActionResult LogOut()
        {
            Signout();

            return RedirectToAction("Login");
        }

        private void Signout()
        {
            Session.Clear();

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie,
                DefaultAuthenticationTypes.ExternalCookie);
        }
    }
}