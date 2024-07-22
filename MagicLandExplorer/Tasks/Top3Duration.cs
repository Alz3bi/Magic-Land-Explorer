using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        // Finds and displays the top 3 destinations with the longest duration
        public static void FindTop3Duration(List<Category> categories)
        {
            var top3Duration = categories.SelectMany(category => category.Destinations!)
                                         .OrderByDescending(dest => dest.DestinationDuration)
                                         .Take(3);

            foreach (var dest in top3Duration)
            {
                Console.WriteLine(dest.Name);
            }
        }
    }
}
