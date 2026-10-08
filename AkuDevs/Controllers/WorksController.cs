using AkuDevs.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AkuDevs.Controllers
{
    public class WorksController : Controller
    {
        private readonly AppDbContext _context;

        public WorksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Projects.Where(p => p.IsActive).OrderBy(p => p.OrderIndex).ToList();
            return View(list);
        }

        public IActionResult Detail(int id)
        {
            var project = _context.Projects.Find(id);
            if(project == null || !project.IsActive) return NotFound();
            
            _context.Entry(project).Collection(p => p.Gallery).Load();
            
            return View(project);
        }
    }
}
