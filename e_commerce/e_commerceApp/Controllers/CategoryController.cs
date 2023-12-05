using e_commerceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerceApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly RepositoryContext _context;

        public CategoryController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var model = _context.Products.First(p => p.CategoryID.Equals(id));
            return View(model);

        }
    }
}