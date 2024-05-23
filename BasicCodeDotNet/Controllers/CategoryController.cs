using BasicCodeDotNet.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BasicCodeDotNet.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BaseCodeContext _context;

        public CategoryController(BaseCodeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Categories.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Created(Category model)
        {
            if (ModelState.IsValid)
            {
                Category newItem = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                };
                _context.Categories.Add(newItem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(Guid id)
        {
            var data = _context.Categories.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Editd(Category model, Guid id)
        {
            if (ModelState.IsValid)
            {
                var data = _context.Categories.FirstOrDefault(x => x.Id == id);
                data.Name = model.Name;
                _context.Categories.Update(data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var data = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
