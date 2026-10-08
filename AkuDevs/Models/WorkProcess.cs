using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class WorkProcess
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adım Numarası zorunludur.")]
        [StringLength(2)]
        [Display(Name = "Adım Numarası (Örn: 01)")]
        public string StepNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Başlık (TR) zorunludur.")]
        [StringLength(100)]
        [Display(Name = "Başlık (TR)")]
        public string TitleTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Başlık (EN) zorunludur.")]
        [StringLength(100)]
        [Display(Name = "Başlık (EN)")]
        public string TitleEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Açıklama (TR) zorunludur.")]
        [StringLength(500)]
        [Display(Name = "Açıklama (TR)")]
        public string DescriptionTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Açıklama (EN) zorunludur.")]
        [StringLength(500)]
        [Display(Name = "Açıklama (EN)")]
        public string DescriptionEn { get; set; } = string.Empty;

        [Display(Name = "Gecikme Süresi (Saniye - Örn: 0.1)")]
        public double AnimationDelay { get; set; } = 0.0;

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Sıralama")]
        public int OrderIndex { get; set; } = 0;
    }
}
