using System.ComponentModel.DataAnnotations;

namespace dmyWebApp.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string Name { get; set; }
    }
}