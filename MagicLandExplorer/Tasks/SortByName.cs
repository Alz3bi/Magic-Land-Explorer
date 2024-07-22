using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        // Sorts and displays the destinations by name
        public static void SortDestinationsByName(List<Category> categories)
        {
            var sortedDestinations = categories.SelectMany(category => category.Destinations!)
                                               .OrderBy(dest => dest.Name)
                                               .Select(dest => dest.Name);

            foreach (var dest in sortedDestinations)
            {
                Console.WriteLine(dest);
            }
        }
    }
}
