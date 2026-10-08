using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string TitleTr { get; set; } = string.Empty;
        public string TitleEn { get; set; } = string.Empty;
        
        [Required]
        public string DescriptionTr { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        
        public string ImageUrl { get; set; } = string.Empty;
        
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile? ImageFile { get; set; }
        
        public string IconSvg { get; set; } = string.Empty;
        
        public bool IsLargeCard { get; set; } = false;
        
        public bool IsActive { get; set; } = true;
        
        public int OrderIndex { get; set; } = 0;
    }
}
