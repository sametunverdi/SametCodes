using System.ComponentModel.DataAnnotations;

namespace AkuDevs.Models
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Değer zorunludur.")]
        [StringLength(20)]
        [Display(Name = "Değer (Örn: 45+, %100)")]
        public string Value { get; set; } = string.Empty;

        [Required(ErrorMessage = "Başlık (TR) zorunludur.")]
        [StringLength(100)]
        [Display(Name = "Başlık (TR) - Alt satıra geçmek için <br> kullanabilirsiniz.")]
        public string TitleTr { get; set; } = string.Empty;

        [Required(ErrorMessage = "Başlık (EN) zorunludur.")]
        [StringLength(100)]
        [Display(Name = "Başlık (EN) - Alt satıra geçmek için <br> kullanabilirsiniz.")]
        public string TitleEn { get; set; } = string.Empty;

        [Display(Name = "Sıralama")]
        public int OrderIndex { get; set; } = 0;

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; } = true;
    }
}
