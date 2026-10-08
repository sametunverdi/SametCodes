using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Platform adı zorunludur.")]
        [StringLength(50)]
        public string PlatformName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bağlantı (URL) zorunludur.")]
        public string Url { get; set; } = string.Empty;

        [Required(ErrorMessage = "İkon (SVG) zorunludur.")]
        public string IconSvg { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public int OrderIndex { get; set; } = 0;
    }
}
