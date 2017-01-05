using System;

namespace dmyWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int InStock { get; set; }
    }
}