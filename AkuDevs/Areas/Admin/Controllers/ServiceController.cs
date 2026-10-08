using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ServiceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var list = _context.Services.OrderBy(x => x.OrderIndex).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            int nextIndex = (_context.Services.Max(x => (int?)x.OrderIndex) ?? -1) + 1;
            return View(new Service { OrderIndex = nextIndex });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Service model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    model.ImageUrl = await ProcessAndSaveImageAsync(model.ImageFile);
                }

                _context.Services.Add(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Hizmet başarıyla eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Services.Find(id);
            if (model == null) return NotFound();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Service model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    model.ImageUrl = await ProcessAndSaveImageAsync(model.ImageFile);
                }
                
                // If they didn't upload a new image, ImageUrl remains the same (bound from hidden field or fetched from DB)
                // Wait, if it's bound from hidden field, it will retain the old value. We need to ensure hidden field exists in Edit view.

                _context.Services.Update(model);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Hizmet başarıyla güncellendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _context.Services.Find(id);
            if (model != null)
            {
                _context.Services.Remove(model);
                _context.SaveChanges();
                TempData["Success"] = "Hizmet başarıyla silindi!";
            }
            return RedirectToAction("Index");
        }

        private async Task<string> ProcessAndSaveImageAsync(IFormFile file)
        {
            string uploadsFolder = Path.Combine(_env.WebRootPath, "images", "services");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string uniqueFileName = Guid.NewGuid().ToString() + ".webp";
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var image = await Image.LoadAsync(file.OpenReadStream()))
            {
                // Resize if it's too large, say width > 1200
                if (image.Width > 1200)
                {
                    image.Mutate(x => x.Resize(1200, 0)); // 0 height means auto-scale to keep aspect ratio
                }

                // Save as WebP with good quality but compressed
                var encoder = new WebpEncoder
                {
                    Quality = 80 // Excellent balance between quality and size
                };

                await image.SaveAsWebpAsync(filePath, encoder);
            }

            return "/images/services/" + uniqueFileName;
        }
    }
}
