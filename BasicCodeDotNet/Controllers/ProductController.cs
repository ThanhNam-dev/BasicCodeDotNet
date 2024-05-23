using BasicCodeDotNet.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicCodeDotNet.Controllers
{
    public class ProductController : Controller
    {
        private readonly BaseCodeContext _context;

        public ProductController(BaseCodeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Products.Include(i => i.CategoryNavigation).ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            var data = _context.Categories.ToList();
            ViewData["Category"] = data;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Created(Product model)
        {
            if (ModelState.IsValid)
            {
                Product newItem = new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    Category = model.Category,
                };
                _context.Products.Add(newItem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
