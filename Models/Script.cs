using System.ComponentModel.DataAnnotations;

namespace EduScriptAI.Models
{
    public class Script
    {
        public int Id { get; set; }
        
        [Required]
        public required string Keywords { get; set; }
        
        [Required]
        public required string Level { get; set; }
        
        [Required]
        public required string Type { get; set; }
        
        [Required]
        public required string Content { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? UpdatedAt { get; set; }
    }
}
