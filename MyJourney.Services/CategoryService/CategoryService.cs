using System.Collections.Generic;
using MyJourney.Models;
using MyJourney.AppRepository;

namespace MyJourney.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category> categories;

        public CategoryService(IRepository<Category> _categories)
        {
            categories = _categories;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return categories.Get();
        }
    }
}
