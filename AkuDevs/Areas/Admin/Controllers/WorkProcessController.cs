using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkProcessController : Controller
    {
        private readonly AppDbContext _context;

        public WorkProcessController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var processes = await _context.WorkProcesses.OrderBy(x => x.OrderIndex).ToListAsync();
            return View(processes);
        }

        public IActionResult Create()
        {
            return View(new WorkProcess());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkProcess model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkProcesses.Add(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Süreç başarıyla eklendi.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var process = await _context.WorkProcesses.FindAsync(id);
            if (process == null) return NotFound();
            return View(process);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(WorkProcess model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkProcesses.Update(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Süreç başarıyla güncellendi.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var process = await _context.WorkProcesses.FindAsync(id);
            if (process != null)
            {
                _context.WorkProcesses.Remove(process);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Süreç başarıyla silindi.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
