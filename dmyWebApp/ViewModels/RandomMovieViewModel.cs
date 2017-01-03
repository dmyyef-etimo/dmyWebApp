using System.Collections.Generic;
using dmyWebApp.Models;

namespace dmyWebApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}