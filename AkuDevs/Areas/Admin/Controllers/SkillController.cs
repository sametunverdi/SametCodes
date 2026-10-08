using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Skills.OrderBy(x => x.OrderIndex).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            int nextIndex = (_context.Skills.Max(x => (int?)x.OrderIndex) ?? -1) + 1;
            return View(new Skill { OrderIndex = nextIndex });
        }

        [HttpPost]
        public IActionResult Create(Skill model)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Add(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji baÅŸarÄ±yla eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Skills.Find(id);
            if (model == null) return NotFound();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Skill model)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Update(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji baÅŸarÄ±yla gÃ¼ncellendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _context.Skills.Find(id);
            if (model != null)
            {
                _context.Skills.Remove(model);
                _context.SaveChanges();
                TempData["Success"] = "Teknoloji silindi!";
            }
            return RedirectToAction("Index");
        }
    }
}

