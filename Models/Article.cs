using System;
using System.ComponentModel.DataAnnotations;

namespace CMSMvc.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty; // Rich text (HTML)

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author? Author { get; set; }
    }
}
