using System;
using System.ComponentModel.DataAnnotations;

namespace dmyWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? InStock { get; set; }
    }
}