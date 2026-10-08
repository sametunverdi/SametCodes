using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class HeroSection
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Rozet (TR) zorunludur.")]
        [StringLength(100)]
        public string BadgeTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rozet (EN) zorunludur.")]
        [StringLength(100)]
        public string BadgeEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Beyaz Başlık (TR) zorunludur.")]
        [StringLength(200)]
        public string TitleWhiteTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Beyaz Başlık (EN) zorunludur.")]
        [StringLength(200)]
        public string TitleWhiteEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kırmızı Başlık (TR) zorunludur.")]
        [StringLength(200)]
        public string TitleRedTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kırmızı Başlık (EN) zorunludur.")]
        [StringLength(200)]
        public string TitleRedEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Açıklama (TR) zorunludur.")]
        public string DescriptionTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Açıklama (EN) zorunludur.")]
        public string DescriptionEn { get; set; } = string.Empty;
    }
}
