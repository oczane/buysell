using System.Web.Mvc;
using MyJourney.Controllers.Filters;

namespace MyJourney.Controllers
{
    [TrackVisitor]
    public class HomeController : BaseController
    {
        MyJourney.Services.AdvertisementService.IAdvertisementService _advertisement;

        public HomeController(MyJourney.Services.AdvertisementService.IAdvertisementService advertisement)
        {
            _advertisement = advertisement;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_advertisement.GetTop10Adveetisements());
        }

        [HttpGet]
        [ActionName("WebsiteAbout")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}