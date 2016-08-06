using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyJourney.Models;

namespace MyJourney.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Load(string id)
        {
            List<Category> categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Books" },
                new Category { Id = 2, Name = "Fashions and Beauty"},
                new Category { Id = 3, Name = "Toys and Trains" }
            };

            var result = categories.Find(p => p.Name == id.Replace("-", " "));

            return View(result);
        }
    }
}
