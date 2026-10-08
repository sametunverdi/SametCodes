using System.Diagnostics;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AkuDevs.DAL.AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AkuDevs.DAL.AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var hero = _context.HeroSections.FirstOrDefault();
            ViewBag.SocialMedias = _context.SocialMedias.Where(s => s.IsActive).OrderBy(s => s.OrderIndex).ToList();
            ViewBag.TechStacks = _context.TechStacks.Where(t => t.IsActive).OrderBy(t => t.OrderIndex).ToList();
            ViewBag.Skills = _context.Skills.Where(s => s.IsActive).OrderBy(s => s.OrderIndex).ToList();
            ViewBag.Services = _context.Services.Where(s => s.IsActive).OrderBy(s => s.OrderIndex).ToList();
            ViewBag.WorkProcesses = _context.WorkProcesses.Where(w => w.IsActive).OrderBy(w => w.OrderIndex).ToList();
            ViewBag.Statistics = _context.Statistics.Where(s => s.IsActive).OrderBy(s => s.OrderIndex).ToList();
            ViewBag.Testimonials = _context.Testimonials.Where(t => t.IsApproved).OrderByDescending(t => t.CreatedAt).ToList();
            ViewBag.Projects = _context.Projects.Where(p => p.IsActive && p.ShowOnHome).OrderBy(p => p.OrderIndex).ToList();
            return View(hero);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitTestimonial(string fullName, string title, string message, int rating, string avatarUrl)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(message))
            {
                return BadRequest("Ad Soyad ve Mesaj zorunludur.");
            }

            var testimonial = new Testimonial
            {
                FullName = fullName,
                Title = title ?? "",
                Message = message,
                Rating = rating,
                AvatarUrl = string.IsNullOrWhiteSpace(avatarUrl) ? "https://i.pravatar.cc/150?img=" + new Random().Next(1, 70) : avatarUrl,
                IsApproved = false,
                CreatedAt = DateTime.Now
            };

            _context.Testimonials.Add(testimonial);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
