using System.Collections.Generic;
using System.Linq;
using MyJourney.Models;
using MyJourney.Services.CategoryService;
using System.Web.Mvc;

namespace MyJourney.Controllers.Helper
{
    public class MenuHelper
    {
        private static MyJourney.Services.CategoryService.ICategoryService _service;

        public static List<Category> GetMenu()
        {
            _service = DependencyResolver.Current.GetService<ICategoryService>();
            IEnumerable<Category> categories = _service.GetAllCategories();
            return categories.ToList();
        }
    }
}
