using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public static void FindLongestDuration(List<Category> categories)
        {
            // Finds and displays the destination with the longest duration
            var longestDuration = categories.SelectMany(category => category.Destinations!)
                                             .OrderByDescending(dest => dest.DestinationDuration)
                                             .Select(dest => dest.Name)
                                             .First();
            Console.WriteLine(longestDuration);
        }
    }
}
