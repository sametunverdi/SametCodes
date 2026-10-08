using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly AppDbContext _context;

        public SocialMediaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.SocialMedias.OrderBy(x => x.OrderIndex).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            int nextIndex = (_context.SocialMedias.Max(x => (int?)x.OrderIndex) ?? -1) + 1;
            return View(new SocialMedia { OrderIndex = nextIndex });
        }

        [HttpPost]
        public IActionResult Create(SocialMedia model)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Add(model);
                _context.SaveChanges();
                TempData["Success"] = "Sosyal medya hesabı başarıyla eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.SocialMedias.Find(id);
            if (model == null) return NotFound();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(SocialMedia model)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Update(model);
                _context.SaveChanges();
                TempData["Success"] = "Sosyal medya başarıyla güncellendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _context.SocialMedias.Find(id);
            if (model != null)
            {
                _context.SocialMedias.Remove(model);
                _context.SaveChanges();
                TempData["Success"] = "Hesap başarıyla silindi!";
            }
            return RedirectToAction("Index");
        }
    }
}
