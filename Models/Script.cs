using System.ComponentModel.DataAnnotations;

namespace EduScriptAI.Models
{
    public class Script
    {
        public int Id { get; set; }
        
        [Required]
        public string Keywords { get; set; }
        
        [Required]
        public string Level { get; set; }
        
        [Required]
        public string Type { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? UpdatedAt { get; set; }
    }
}
