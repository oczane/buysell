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

        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                registerService.Register(model);
                return RedirectToRoute(new
                {
                    Controller = "Home",
                    Action = "Index"
                }
                );
            }
            
            return View(model);
        }
    }
}
