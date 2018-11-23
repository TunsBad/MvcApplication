using OdeToFood.Entities;
using System.Collections.Generic;

namespace MvcApplication.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
