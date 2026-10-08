using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class TechStack
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Teknoloji Adı (TR) zorunludur.")]
        [Display(Name = "Teknoloji Adı (TR)")]
        public string NameTr { get; set; } = string.Empty;
        
        [Display(Name = "Teknoloji Adı (EN)")]
        public string NameEn { get; set; } = string.Empty;
        
        public bool IsActive { get; set; } = true;
        
        public int OrderIndex { get; set; } = 0;
    }
}
