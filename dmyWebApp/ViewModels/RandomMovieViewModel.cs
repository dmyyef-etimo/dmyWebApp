using System.Collections.Generic;
using dmyWebApp.Models;

namespace dmyWebApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}