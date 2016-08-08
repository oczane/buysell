using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Models;

namespace MyJourney.Services.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }
}
