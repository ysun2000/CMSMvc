using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMSMvc.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UsernameEmail { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        public virtual ICollection<Article> Articles { get; set; } = [];
    }
}
