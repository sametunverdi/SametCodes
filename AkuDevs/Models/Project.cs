using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkuDevs.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string TitleTr { get; set; } = string.Empty;
        public string TitleEn { get; set; } = string.Empty;
        
        [Required]
        public string CategoryTr { get; set; } = string.Empty;
        public string CategoryEn { get; set; } = string.Empty;
        
        [Required]
        public string DescriptionTr { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        
        public string ImageUrl { get; set; } = string.Empty;
        
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        
        [NotMapped]
        public List<IFormFile> GalleryFiles { get; set; } = new();
        
        public ICollection<ProjectImage> Gallery { get; set; } = new List<ProjectImage>();
        
        public string ProjectUrl { get; set; } = string.Empty;
        
        public bool IsActive { get; set; } = true;
        
        public bool ShowOnHome { get; set; } = true;
        
        public int OrderIndex { get; set; } = 0;
    }
}
