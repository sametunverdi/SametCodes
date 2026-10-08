using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkuDevs.Models
{
    public class ProjectImage
    {
        [Key]
        public int Id { get; set; }
        
        public int ProjectId { get; set; }
        
        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }
        
        public string ImageUrl { get; set; } = string.Empty;
    }
}
