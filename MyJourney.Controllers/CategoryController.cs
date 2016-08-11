using System.Linq;
using System.Web.Mvc;
using MyJourney.Models;

namespace MyJourney.Controllers
{
    public class CategoryController : BaseController
    {
        BuySellContext _context;

        public CategoryController()
        {
            _context = new BuySellContext();
        }

        public ActionResult Load()
        {
            var result = _context.Category.ToList();

            return View(result);
        }
    }

}
