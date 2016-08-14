using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MyJourney.Services;
using MyJourney.Models;

namespace MyJourney.Controllers
{
    public class SessionController : BaseController
    {
        Services.UserService.Interface.IRegisterService registerService;

        public SessionController(Services.UserService.Interface.IRegisterService _registerService)
        {
            registerService = _registerService;
        }


        public PartialViewResult Register()
        {
            User model = new User();
            return PartialView("_Register", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                registerService.Register(model);

                System.Web.Security.FormsAuthentication.SetAuthCookie(model.FirstName + "|" + model.LastName + "|" + model.Email, false); //Encrypt cookie

                //to-do Url hacking using filter

                //if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                //    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                //{
                //    return Redirect(returnUrl);
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Home");
                //}

                return RedirectToRoute(new
                {
                    Controller = "Home",
                    Action = "Index"
                }
                );
            }
            
            return View("_Register", model);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            //System.Web.Security.FormsAuthentication.SetAuthCookie(null, false);

            return RedirectToRoute(new
            {
                Controller = "Home",
                Action = "Index"
            }
            );
        }
    }
}
