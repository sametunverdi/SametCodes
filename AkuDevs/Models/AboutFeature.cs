using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class AboutFeature
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string IconSvg { get; set; } = string.Empty;
        
        public string ColorClass { get; set; } = string.Empty; // e.g. "red", "amber", "blue"
        
        public int OrderIndex { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

