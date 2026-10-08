using AkuDevs.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Skills = _context.Skills.Where(s => s.IsActive).OrderBy(s => s.OrderIndex).ToList();
            ViewBag.TechStacks = _context.TechStacks.Where(t => t.IsActive).OrderBy(t => t.OrderIndex).ToList();
            ViewBag.Features = _context.AboutFeatures.Where(f => f.IsActive).OrderBy(f => f.OrderIndex).ToList();
            return View();
        }
    }
}

