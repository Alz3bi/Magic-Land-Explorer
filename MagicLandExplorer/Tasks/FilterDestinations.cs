using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static void FilterByDestination(List<Category> categories)
        {
            // Filters and displays the destinations with duration less than 100
            var filteredDestinations = categories.SelectMany(category => category.Destinations!)
                                                 .Where(dest => dest.DestinationDuration < 100)
                                                 .Select(dest => dest.Name);

            foreach (var dest in filteredDestinations)
            {
                Console.WriteLine(dest);
            }

        }
    }
}
