using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string TitleTr { get; set; } = string.Empty;
        
        public string TitleEn { get; set; } = string.Empty;
        
        [Required]
        public string IconText { get; set; } = string.Empty;
        
        public string DescriptionTr { get; set; } = string.Empty;
        
        public string DescriptionEn { get; set; } = string.Empty;
        
        public string ColorHex { get; set; } = "#4f46e5";
        
        public bool IsActive { get; set; } = true;
        
        public int OrderIndex { get; set; } = 0;
    }
}
