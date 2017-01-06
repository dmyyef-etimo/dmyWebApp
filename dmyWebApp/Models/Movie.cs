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

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? AddedDate { get; set; }

        [Display(Name = "In Stock")]
        public int? InStock { get; set; }
    }
}