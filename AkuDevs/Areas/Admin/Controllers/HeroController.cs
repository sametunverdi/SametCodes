using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeroController : Controller
    {
        private readonly AppDbContext _context;

        public HeroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hero = _context.HeroSections.FirstOrDefault();
            if (hero == null)
            {
                hero = new HeroSection(); // Veritabanı boşsa boş form döner
            }
            return View(hero);
        }

        [HttpPost]
        public IActionResult Index(HeroSection model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    _context.HeroSections.Add(model);
                }
                else
                {
                    _context.HeroSections.Update(model);
                }
                _context.SaveChanges();
                TempData["Success"] = "Hero (Giriş) alanı başarıyla güncellendi kankam!";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
