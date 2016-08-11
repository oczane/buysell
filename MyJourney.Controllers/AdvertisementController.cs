using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Controllers.Filters;
using System.Web.Mvc;
using MyJourney.Models;

namespace MyJourney.Controllers
{
    [TrackVisitor]
    public class AdvertisementController : BaseController
    {
        MyJourney.Services.AdvertisementService.IAdvertisementService _advertisement;

        public AdvertisementController(MyJourney.Services.AdvertisementService.IAdvertisementService advertisement)
        {
            _advertisement = advertisement;
        }

        public ActionResult Detail(string id)
        {
            Advertisement adv = _advertisement.GetAdvertisementDetailByName(id.Replace("-", " "));
            return View(adv);
        }
    }
}
