using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var stats = await _context.Statistics.OrderBy(x => x.OrderIndex).ToListAsync();
            return View(stats);
        }

        public IActionResult Create()
        {
            return View(new Statistic());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Statistic model)
        {
            if (ModelState.IsValid)
            {
                _context.Statistics.Add(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "İstatistik başarıyla eklendi.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var stat = await _context.Statistics.FindAsync(id);
            if (stat == null) return NotFound();
            return View(stat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Statistic model)
        {
            if (ModelState.IsValid)
            {
                _context.Statistics.Update(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "İstatistik başarıyla güncellendi.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var stat = await _context.Statistics.FindAsync(id);
            if (stat != null)
            {
                _context.Statistics.Remove(stat);
                await _context.SaveChangesAsync();
                TempData["Success"] = "İstatistik başarıyla silindi.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
