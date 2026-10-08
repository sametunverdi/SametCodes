using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunludur.")]
        [StringLength(100)]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; } = string.Empty;

        [StringLength(100)]
        [Display(Name = "Ünvan / Şirket")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mesaj zorunludur.")]
        [StringLength(1000)]
        [Display(Name = "Yorum")]
        public string Message { get; set; } = string.Empty;

        [Required]
        [Range(1, 5)]
        [Display(Name = "Puan")]
        public int Rating { get; set; } = 5;

        [StringLength(255)]
        [Display(Name = "Avatar URL")]
        public string? AvatarUrl { get; set; }

        [Display(Name = "Onaylandı Mı?")]
        public bool IsApproved { get; set; } = false;

        [Display(Name = "Gönderilme Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
