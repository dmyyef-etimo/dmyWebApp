using System.Collections.Generic;
using dmyWebApp.Models;

namespace dmyWebApp.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public string ActionName { get; set; }
    }
}