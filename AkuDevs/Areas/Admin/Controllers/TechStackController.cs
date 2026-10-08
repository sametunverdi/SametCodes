using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TechStackController : Controller
    {
        private readonly AppDbContext _context;

        public TechStackController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.TechStacks.OrderBy(x => x.OrderIndex).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            int nextIndex = (_context.TechStacks.Max(x => (int?)x.OrderIndex) ?? -1) + 1;
            return View(new TechStack { OrderIndex = nextIndex });
        }

        [HttpPost]
        public IActionResult Create(TechStack model)
        {
            if (ModelState.IsValid)
            {
                _context.TechStacks.Add(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji başarıyla eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.TechStacks.Find(id);
            if (model == null) return NotFound();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TechStack model)
        {
            if (ModelState.IsValid)
            {
                _context.TechStacks.Update(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji başarıyla güncellendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _context.TechStacks.Find(id);
            if (model != null)
            {
                _context.TechStacks.Remove(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji silindi!";
            }
            return RedirectToAction("Index");
        }
    }
}
