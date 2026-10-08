using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.Testimonials.OrderByDescending(t => t.CreatedAt).ToListAsync();
            return View(items);
        }

        public async Task<IActionResult> Approve(int id)
        {
            var item = await _context.Testimonials.FindAsync(id);
            if (item != null)
            {
                item.IsApproved = !item.IsApproved;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Testimonials.FindAsync(id);
            if (item != null)
            {
                _context.Testimonials.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
