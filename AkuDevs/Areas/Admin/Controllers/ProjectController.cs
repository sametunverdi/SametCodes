using AkuDevs.DAL;
using AkuDevs.Models;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

namespace AkuDevs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProjectController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var list = _context.Projects.OrderBy(x => x.OrderIndex).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            int nextIndex = (_context.Projects.Max(x => (int?)x.OrderIndex) ?? -1) + 1;
            return View(new Project { OrderIndex = nextIndex });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    model.ImageUrl = await ProcessAndSaveImageAsync(model.ImageFile);
                }

                _context.Projects.Add(model);
                await _context.SaveChangesAsync();

                if (model.GalleryFiles != null && model.GalleryFiles.Any())
                {
                    foreach (var file in model.GalleryFiles)
                    {
                        if (file.Length > 0)
                        {
                            var imgUrl = await ProcessAndSaveImageAsync(file);
                            _context.ProjectImages.Add(new ProjectImage
                            {
                                ProjectId = model.Id,
                                ImageUrl = imgUrl
                            });
                        }
                    }
                    await _context.SaveChangesAsync();
                }

                TempData["Success"] = "Proje başarıyla eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Projects.Find(id);
            if (model == null) return NotFound();
            
            // Load existing gallery images
            _context.Entry(model).Collection(p => p.Gallery).Load();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Project model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    model.ImageUrl = await ProcessAndSaveImageAsync(model.ImageFile);
                }

                _context.Projects.Update(model);
                await _context.SaveChangesAsync();

                if (model.GalleryFiles != null && model.GalleryFiles.Any())
                {
                    foreach (var file in model.GalleryFiles)
                    {
                        if (file.Length > 0)
                        {
                            var imgUrl = await ProcessAndSaveImageAsync(file);
                            _context.ProjectImages.Add(new ProjectImage
                            {
                                ProjectId = model.Id,
                                ImageUrl = imgUrl
                            });
                        }
                    }
                    await _context.SaveChangesAsync();
                }

                TempData["Success"] = "Proje başarıyla güncellendi!";
                return RedirectToAction("Index");
            }
            // If invalid, reload gallery to show in view
            _context.Entry(model).Collection(p => p.Gallery).Load();
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteGalleryImage(int id, int projectId)
        {
            var img = _context.ProjectImages.Find(id);
            if (img != null)
            {
                _context.ProjectImages.Remove(img);
                _context.SaveChanges();
            }
            return RedirectToAction("Edit", new { id = projectId });
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _context.Projects.Find(id);
            if (model != null)
            {
                _context.Projects.Remove(model);
                _context.SaveChanges();
                TempData["Success"] = "Proje başarıyla silindi!";
            }
            return RedirectToAction("Index");
        }

        private async Task<string> ProcessAndSaveImageAsync(IFormFile file)
        {
            string uploadsFolder = Path.Combine(_env.WebRootPath, "images", "projects");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string uniqueFileName = Guid.NewGuid().ToString() + ".webp";
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var image = await Image.LoadAsync(file.OpenReadStream()))
            {
                if (image.Width > 1200)
                {
                    image.Mutate(x => x.Resize(1200, 0));
                }

                var encoder = new WebpEncoder { Quality = 80 };
                await image.SaveAsWebpAsync(filePath, encoder);
            }

            return "/images/projects/" + uniqueFileName;
        }
    }
}
