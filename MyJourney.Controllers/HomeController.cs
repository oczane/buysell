using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyJourney.Models;

namespace MyJourney.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Category ct = new Category();
            ct.Id = 1;
            ct.Name = "Books";

            List<Category> categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Books" },
                new Category { Id = 2, Name = "Fashions and Beauty"},
                new Category { Id = 3, Name = "Toys and Trains" }
            };
                
            return View(categories);
        }

        [ActionName("WebsiteAbout")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}